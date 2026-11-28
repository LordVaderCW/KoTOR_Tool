'use strict';
(() => {
 const viewport=document.getElementById('viewport'), status=document.getElementById('status');
 let renderer, scene, camera, controls, pivot, model, frame, last=0, disposed=false;
 window.kotorDisposeViewer=()=>{
  if(disposed)return;disposed=true;cancelAnimationFrame(frame);
  if(vfx)vfx.dispose();
  if(mixer){mixer.stopAllAction();if(model)mixer.uncacheRoot(model);}
  if(controls)controls.dispose();
  const geometries=new Set(),materials=new Set(),textures=new Set();
  if(scene)scene.traverse(o=>{if(o.geometry)geometries.add(o.geometry);if(o.material)for(const m of (Array.isArray(o.material)?o.material:[o.material]))materials.add(m);});
  for(const m of materials){for(const value of Object.values(m))if(value&&value.isTexture)textures.add(value);}
  for(const t of textures)t.dispose();for(const m of materials)m.dispose();for(const g of geometries)g.dispose();
  if(renderer){renderer.dispose();renderer.forceContextLoss();}
 };
 let rotating=false, axis='y', dirty=true;
 let vfx;
 const nativeControls=new URLSearchParams(location.search).get('native')==='1';
 if(nativeControls){document.querySelector('header').hidden=true;document.getElementById('vfx-controls').hidden=true;}
 let lastUi=0;
 const viewerState=(keys=false)=>{
  const clip=action&&action.getClip();
  const data={type:'viewer',time:action?action.time:0,duration:clip?clip.duration:0,selected:!!clip,playing:!!action&&!action.paused&&action.isRunning(),rotating,axis,
   wire:document.getElementById('wire').checked,vfx:!!vfx&&vfx.emitters.length>0,vfxPlaying:!!vfx&&vfx.playing,vfxLoop:!!vfx&&vfx.loop};
  if(keys){
   const groups={position:new Set(),rotation:new Set(),scale:new Set()};
   if(clip)for(const track of clip.tracks){const kind=track.name.endsWith('.position')?'position':track.name.endsWith('.quaternion')?'rotation':'scale';for(const t of track.times)groups[kind].add(t);}
   data.keys=Object.entries(groups).map(([kind,times])=>({kind,times:[...times].sort((a,b)=>a-b)}));
  }
  notify(data);
 };
 const seek=time=>{
  if(!action||!Number.isFinite(time))return;
  action.enabled=true;action.play();action.paused=true;action.time=Math.max(0,Math.min(action.getClip().duration,time));mixer.update(0);
  playbackState('seek');viewerState();
 };
 let mixer, clips=[], action=null;
 const revision=Number(new URLSearchParams(location.search).get('v')||0);
 const notify=data=>{if(window.chrome&&window.chrome.webview)window.chrome.webview.postMessage(Object.assign({revision},data));};
 const playbackState=(reason='state')=>notify({type:'state',reason,playing:!!action&&!action.paused&&action.isRunning()});
 // MDL pose clips can have a single key at time zero. LoopRepeat divides by
 // duration, so these must be sampled once without advancing their clock.
 const isPose=()=>action&&action.getClip().duration<=0;
 const samplePose=()=>{action.reset().setLoop(THREE.LoopOnce,1).play();mixer.update(0);action.paused=true;};
 const command=data=>{
  if(disposed)return;dirty=true;
  if(!mixer||data.revision!==revision)return;
  if(data.command==='viewRotate'){document.getElementById('rotate').click();viewerState();return;}
  if(data.command==='viewAxis'){if(['X','Y','Z'].includes(data.value)){const el=document.getElementById('axis');el.value=data.value;el.dispatchEvent(new Event('change'));}viewerState();return;}
  if(data.command==='viewReset'){document.getElementById('reset').click();return;}
  if(data.command==='viewWire'){const el=document.getElementById('wire');el.checked=!!data.value;el.dispatchEvent(new Event('change'));viewerState();return;}
  if(data.command==='vfxToggle'){document.getElementById('vfx-play').click();viewerState();return;}
  if(data.command==='vfxReplay'){if(vfx)vfx.replay();return;}
  if(data.command==='vfxLoop'){if(vfx)vfx.loop=!!data.value;viewerState();return;}
  if(data.command==='seek'){seek(data.value);return;}
  if(data.command==='select'){
   if(!Number.isInteger(data.index)||data.index<0||data.index>=clips.length)return;
   mixer.stopAllAction();action=mixer.clipAction(clips[data.index]);action.reset();
   action.setLoop(data.loop?THREE.LoopRepeat:THREE.LoopOnce,data.loop?Infinity:1);action.clampWhenFinished=true;action.play();
   if(isPose())samplePose();
   rotating=false;document.getElementById('rotate').textContent='Resume rotation';document.getElementById('rotate').setAttribute('aria-pressed','false');
  } else if(data.command==='toggle'&&action){if(isPose())samplePose();else if(action.time>=action.getClip().duration||(!action.isRunning()&&!action.paused))action.reset().play();else action.paused=!action.paused;}
  else if(data.command==='stop'){mixer.stopAllAction();}
  else if(data.command==='loop'&&action&&!isPose())action.setLoop(data.loop?THREE.LoopRepeat:THREE.LoopOnce,data.loop?Infinity:1);
  playbackState(data.command);viewerState(data.command==='select');
 };
 if(window.chrome&&window.chrome.webview)window.chrome.webview.addEventListener('message',e=>command(e.data));
 const finishLoading=()=>{document.getElementById('loading').hidden=true;viewport.setAttribute('aria-busy','false');};
 const fail=e=>{finishLoading();status.hidden=false;status.textContent='Unable to preview model: '+(e.message||String(e));};
 try {
  renderer=new THREE.WebGLRenderer({antialias:true}); renderer.setPixelRatio(Math.min(devicePixelRatio,2)); renderer.outputEncoding=THREE.sRGBEncoding;
  viewport.appendChild(renderer.domElement); scene=new THREE.Scene(); scene.background=new THREE.Color(0x10151c);
  camera=new THREE.PerspectiveCamera(40,1,0.01,10000);
  controls=new THREE.OrbitControls(camera,renderer.domElement); controls.enableDamping=true;controls.addEventListener('change',()=>dirty=true);
  scene.add(new THREE.HemisphereLight(0xffffff,0x687080,1.2)); const light=new THREE.DirectionalLight(0xffffff,1.1); light.position.set(4,8,5); scene.add(light);
  pivot=new THREE.Group(); scene.add(pivot);
  const resize=()=>{if(disposed)return;const w=viewport.clientWidth,h=viewport.clientHeight;if(!w||!h)return;renderer.setSize(w,h);camera.aspect=w/h;camera.updateProjectionMatrix();dirty=true;};
  new ResizeObserver(resize).observe(viewport); resize();
  const reset=()=>{if(!model)return;pivot.rotation.set(0,0,0);controls.reset();dirty=true;};
  document.getElementById('reset').onclick=reset;
  document.getElementById('rotate').onclick=e=>{rotating=!rotating;e.target.textContent=rotating?'Pause rotation':'Resume rotation';e.target.setAttribute('aria-pressed',String(rotating));};
  document.getElementById('axis').onchange=e=>{axis=e.target.value.toLowerCase();pivot.rotation.set(0,0,0);dirty=true;};
  document.getElementById('wire').onchange=e=>{if(model)model.traverse(o=>{if(o.isMesh)o.material.wireframe=e.target.checked;});dirty=true;};
  renderer.domElement.addEventListener('webglcontextlost',e=>{e.preventDefault();if(disposed)return;cancelAnimationFrame(frame);fail(new Error('Graphics context lost. Close and reopen the preview.'));});
  new THREE.GLTFLoader().load('model.gltf'+location.search,async gltf=>{
   if(disposed)return;
   try {
   model=gltf.scene; model.traverse(o=>{if(o.isMesh&&!o.geometry.attributes.normal)o.geometry.computeVertexNormals();});
   vfx=await AuroraVfx.create(model);
   document.getElementById('vfx-controls').hidden=nativeControls||vfx.emitters.length===0;
   document.getElementById('vfx-play').onclick=e=>{vfx.playing=!vfx.playing;e.target.textContent=vfx.playing?'Pause VFX':'Play VFX';e.target.setAttribute('aria-pressed',String(vfx.playing));};
   document.getElementById('vfx-replay').onclick=()=>vfx.replay();
   document.getElementById('vfx-loop').onchange=e=>vfx.loop=e.target.checked;
   const bounds=new THREE.Box3().setFromObject(model);vfx.expandBounds(bounds);
   const center=bounds.getCenter(new THREE.Vector3());
   const radius=bounds.getSize(new THREE.Vector3()).length()/2;
   if(!Number.isFinite(radius)||radius<=0){fail(new Error('Empty model bounds'));return;}
   model.position.sub(center);pivot.add(model);
   clips=gltf.animations||[];mixer=new THREE.AnimationMixer(model);
   mixer.addEventListener('finished',()=>playbackState('finished'));
   mixer.addEventListener('loop',()=>playbackState('loop'));
   notify({type:'clips',clips:clips.map((clip,index)=>{
    const origin=(gltf.parser.json.animations[index]||{}).extras||{};
    return {index,name:clip.name,duration:clip.duration,sourceModel:origin.sourceModel||'',inherited:origin.inherited===true};
   })});
   camera.near=Math.max(radius/10000,0.0001);camera.far=radius*100;camera.updateProjectionMatrix();
   const distance=radius/Math.sin(THREE.MathUtils.degToRad(20))/Math.min(camera.aspect,1);
   camera.position.set(distance*0.65,distance*0.35,distance);controls.target.set(0,0,0);controls.minDistance=radius*0.05;controls.maxDistance=radius*30;controls.update();controls.saveState();
   status.textContent='';status.hidden=true;
   renderer.render(scene,camera);
   finishLoading();viewerState(true);
   } catch(e){fail(e);}
  },undefined,fail);
  const animate=time=>{
   if(disposed)return;frame=requestAnimationFrame(animate);
   if(document.hidden){last=time;return;}
   const dt=Math.min((time-last)/1000,0.05);last=time;
   const playing=action&&!action.paused&&action.isRunning(),effects=vfx&&vfx.playing&&vfx.emitters.length>0;
   if(mixer)mixer.update(dt);if(vfx)vfx.update(dt);
   if(nativeControls&&time-lastUi>=100){lastUi=time;viewerState();}
   if(rotating&&model)pivot.rotation[axis]+=dt*0.35;controls.update();
   if(dirty||rotating||playing||effects){renderer.render(scene,camera);dirty=false;}
  };
  frame=requestAnimationFrame(animate);
  addEventListener('pagehide',window.kotorDisposeViewer);
 } catch(e){fail(e);}
})();
