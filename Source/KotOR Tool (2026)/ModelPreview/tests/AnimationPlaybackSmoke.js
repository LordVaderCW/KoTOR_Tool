// Exercise the production viewport with the bundled Three.js and copied model fixtures.
const {chromium}=require(process.env.PLAYWRIGHT_CORE || './output/package');
const fs=require('fs'),path=require('path'),http=require('http'),assert=require('assert');
(async()=>{
 const fixture=path.resolve(process.argv[2] || 'ModelPreview/tests/output/k2-animated');
 const web=path.resolve(__dirname,'../web');
 const hook=`
 window.playbackMessages=[];
 window.chrome.webview={postMessage:m=>playbackMessages.push(m),addEventListener:(name,fn)=>window.sendPlayback=data=>fn({data})};
 const OriginalMixer=THREE.AnimationMixer;
 THREE.AnimationMixer=class extends OriginalMixer {
  constructor(root){super(root);window.testMixer=this;}
  update(dt){return dt===0?super.update(0):this;}
 };
 window.stepPlayback=dt=>{OriginalMixer.prototype.update.call(testMixer,dt);if(testMixer._actions.some(a=>!Number.isFinite(a.time)))throw Error("Non-finite animation clock");};
 window.pose=()=>{const result=[];testMixer.getRoot().traverse(n=>result.push(...n.position.toArray(),...n.quaternion.toArray(),...n.scale.toArray()));return result;};
 `;
 const server=http.createServer((req,res)=>{
  const name=path.basename(new URL(req.url,'http://localhost').pathname)||'index.html';
  const types={'.html':'text/html','.js':'text/javascript','.css':'text/css','.gltf':'model/gltf+json'};
  res.setHeader('Content-Type',types[path.extname(name)]||'application/octet-stream');
  try{
   if(name==='test-hook.js'){res.end(hook);return;}
   let data=fs.readFileSync(path.join(name==='model.gltf'?fixture:web,name));
   if(name==='index.html')data=data.toString().replace('<script src="preview.js">','<script src="test-hook.js"></script><script src="preview.js">');
   res.end(data);
  }catch(e){res.statusCode=404;res.end();}
 });
 await new Promise(resolve=>server.listen(0,'127.0.0.1',resolve));let browser;
 try{
  browser=await chromium.launch({executablePath:process.env.PREVIEW_BROWSER || path.join(process.env.LOCALAPPDATA,'Google/Chrome/Application/chrome.exe'),headless:true});
  const page=await browser.newPage();const errors=[];
  page.on('pageerror',e=>errors.push(e.message));
  await page.goto(`http://127.0.0.1:${server.address().port}/index.html?v=1`);
  await page.waitForFunction(()=>window.playbackMessages?.some(m=>m.type==='clips'));
  const result=await page.evaluate(()=>{
   const clips=playbackMessages.find(m=>m.type==='clips').clips;
   const command=(command,index,loop=true)=>sendPlayback({command,index,loop,revision:1});
   const equal=(a,b)=>a.length===b.length&&a.every((v,i)=>Number.isFinite(v)&&Math.abs(v-b[i])<0.00001);
   command('stop',0);const rest=pose(),baseline=[];
   const root=testMixer.getRoot();root.updateMatrixWorld(true);
   let skins=0;
   root.traverse(mesh=>{if(!mesh.isSkinnedMesh)return;skins++;mesh.skeleton.update();
    for(let i=0;i<mesh.geometry.attributes.position.count;i++){
     const p=new THREE.Vector3().fromBufferAttribute(mesh.geometry.attributes.position,i),q=mesh.boneTransform(i,p.clone());
     if(!q.toArray().every(Number.isFinite)||p.distanceTo(q)>0.001)throw Error('Skin rest pose displaced: '+mesh.name);
    }
   });
   if(clips.length===1&&clips[0].name==='move'&&skins===1){
    command('select',0);stepPlayback(0.25);root.updateMatrixWorld(true);
    root.traverse(mesh=>{if(!mesh.isSkinnedMesh)return;mesh.skeleton.update();
     const p=new THREE.Vector3().fromBufferAttribute(mesh.geometry.attributes.position,0),q=mesh.boneTransform(0,p.clone());
     if(Math.abs(p.distanceTo(q)-0.25)>0.0001)throw Error('Weighted bone animation did not deform mesh by expected amount');
    });command('stop',0);
   }
   for(const clip of clips){command('select',clip.index);stepPlayback(Math.max(clip.duration*0.4,0.01));
    if(testMixer._actions.some(a=>!Number.isFinite(a.time)))throw Error("Non-finite animation clock: "+clip.name);baseline.push(pose());command('stop',clip.index);}
   for(let cycle=0;cycle<30;cycle++)for(const clip of clips){
    command('select',clip.index);stepPlayback(clip.duration*0.4);
    if(!equal(pose(),baseline[clip.index]))throw Error('Pose changed on revisit: '+clip.name+' cycle '+cycle);
    command('toggle',clip.index);const paused=pose();stepPlayback(0.1);
    if(!equal(paused,pose()))throw Error('Pause failed: '+clip.name);
    command('toggle',clip.index);stepPlayback(0.1);
    command('stop',clip.index);
    if(!equal(rest,pose()))throw Error('Stop failed to restore pose: '+clip.name);
    command('toggle',clip.index);stepPlayback(clip.duration*0.4);
    if(!equal(pose(),baseline[clip.index]))throw Error('Restart failed: '+clip.name);
    command('select',clip.index,false);stepPlayback(clip.duration+0.1);
    command('toggle',clip.index,false);stepPlayback(clip.duration*0.4);
    if(!equal(pose(),baseline[clip.index]))throw Error('Replay completed clip failed: '+clip.name);
    command('stop',clip.index);
   }
   return {clips:clips.map(c=>c.name),skins,selections:clips.length*30};
  });
  assert.deepStrictEqual(errors,[]);
  console.log('PASS: '+JSON.stringify(result));
 }finally{if(browser)await browser.close();server.close();}
})().catch(e=>{console.error(e);process.exitCode=1;});
