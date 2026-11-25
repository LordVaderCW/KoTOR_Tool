'use strict';
(() => {
 const viewport=document.getElementById('viewport'), status=document.getElementById('status');
 let renderer, scene, camera, controls, pivot, model, frame, last=0;
 let rotating=true, axis='y';
 let mixer, clips=[], action=null;
 const revision=Number(new URLSearchParams(location.search).get('v')||0);
 const notify=data=>{if(window.chrome&&window.chrome.webview)window.chrome.webview.postMessage(Object.assign({revision},data));};
 const playbackState=()=>notify({type:'state',playing:!!action&&!action.paused&&action.isRunning()});
 // MDL pose clips can have a single key at time zero. LoopRepeat divides by
 // duration, so these must be sampled once without advancing their clock.
 const isPose=()=>action&&action.getClip().duration<=0;
 const samplePose=()=>{action.reset().setLoop(THREE.LoopOnce,1).play();mixer.update(0);action.paused=true;};
 const command=data=>{
  if(!mixer||data.revision!==revision)return;
  if(data.command==='select'){
   if(!Number.isInteger(data.index)||data.index<0||data.index>=clips.length)return;
   mixer.stopAllAction();action=mixer.clipAction(clips[data.index]);action.reset();
   action.setLoop(data.loop?THREE.LoopRepeat:THREE.LoopOnce,data.loop?Infinity:1);action.clampWhenFinished=true;action.play();
   if(isPose())samplePose();
   rotating=false;document.getElementById('rotate').textContent='Resume rotation';document.getElementById('rotate').setAttribute('aria-pressed','false');
  } else if(data.command==='toggle'&&action){if(isPose())samplePose();else if(action.time>=action.getClip().duration||(!action.isRunning()&&!action.paused))action.reset().play();else action.paused=!action.paused;}
  else if(data.command==='stop'){mixer.stopAllAction();}
  else if(data.command==='loop'&&action&&!isPose())action.setLoop(data.loop?THREE.LoopRepeat:THREE.LoopOnce,data.loop?Infinity:1);
  playbackState();
 };
 if(window.chrome&&window.chrome.webview)window.chrome.webview.addEventListener('message',e=>command(e.data));
 const finishLoading=()=>{document.getElementById('loading').hidden=true;viewport.setAttribute('aria-busy','false');};
 const fail=e=>{finishLoading();status.textContent='Unable to preview model: '+(e.message||String(e));};
 try {
  renderer=new THREE.WebGLRenderer({antialias:true}); renderer.setPixelRatio(Math.min(devicePixelRatio,2)); renderer.outputEncoding=THREE.sRGBEncoding;
  viewport.appendChild(renderer.domElement); scene=new THREE.Scene(); scene.background=new THREE.Color(0x10151c);
  camera=new THREE.PerspectiveCamera(40,1,0.01,10000);
  controls=new THREE.OrbitControls(camera,renderer.domElement); controls.enableDamping=true;
  scene.add(new THREE.HemisphereLight(0xffffff,0x687080,1.2)); const light=new THREE.DirectionalLight(0xffffff,1.1); light.position.set(4,8,5); scene.add(light);
  pivot=new THREE.Group(); scene.add(pivot);
  const resize=()=>{const w=viewport.clientWidth,h=viewport.clientHeight;if(!w||!h)return;renderer.setSize(w,h);camera.aspect=w/h;camera.updateProjectionMatrix();};
  new ResizeObserver(resize).observe(viewport); resize();
  const reset=()=>{if(!model)return;pivot.rotation.set(0,0,0);controls.reset();};
  document.getElementById('reset').onclick=reset;
  document.getElementById('rotate').onclick=e=>{rotating=!rotating;e.target.textContent=rotating?'Pause rotation':'Resume rotation';e.target.setAttribute('aria-pressed',String(rotating));};
  document.getElementById('axis').onchange=e=>{axis=e.target.value.toLowerCase();pivot.rotation.set(0,0,0);};
  document.getElementById('wire').onchange=e=>{if(model)model.traverse(o=>{if(o.isMesh)o.material.wireframe=e.target.checked;});};
  renderer.domElement.addEventListener('webglcontextlost',e=>{e.preventDefault();cancelAnimationFrame(frame);fail(new Error('Graphics context lost. Close and reopen the preview.'));});
  new THREE.GLTFLoader().load('model.gltf'+location.search,gltf=>{
   model=gltf.scene; model.traverse(o=>{if(o.isMesh&&!o.geometry.attributes.normal)o.geometry.computeVertexNormals();});
   const bounds=new THREE.Box3().setFromObject(model), center=bounds.getCenter(new THREE.Vector3());
   const radius=bounds.getSize(new THREE.Vector3()).length()/2;
   if(!Number.isFinite(radius)||radius<=0){fail(new Error('Empty model bounds'));return;}
   model.position.sub(center);pivot.add(model);
   clips=gltf.animations||[];mixer=new THREE.AnimationMixer(model);
   mixer.addEventListener('finished',playbackState);
   notify({type:'clips',clips:clips.map((clip,index)=>({index,name:clip.name,duration:clip.duration}))});
   camera.near=Math.max(radius/10000,0.0001);camera.far=radius*100;camera.updateProjectionMatrix();
   const distance=radius/Math.sin(THREE.MathUtils.degToRad(20))/Math.min(camera.aspect,1);
   camera.position.set(distance*0.65,distance*0.35,distance);controls.target.set(0,0,0);controls.minDistance=radius*0.05;controls.maxDistance=radius*30;controls.update();controls.saveState();
   const warnings=gltf.parser.json.extras.warnings||[];
   status.textContent='Drag to orbit · Wheel to zoom · Right-drag to pan\nNode transform animation preview; skin deformation, lightmaps and TXI effects are not rendered.'+(warnings.length?'\n'+warnings.join(' · '):'');
   renderer.render(scene,camera);
   finishLoading();
  },undefined,fail);
  const animate=time=>{frame=requestAnimationFrame(animate);const dt=Math.min((time-last)/1000,0.05);last=time;if(document.hidden)return;if(mixer)mixer.update(dt);if(rotating&&model)pivot.rotation[axis]+=dt*0.35;controls.update();renderer.render(scene,camera);};
  frame=requestAnimationFrame(animate);
  addEventListener('pagehide',()=>{cancelAnimationFrame(frame);if(mixer){mixer.stopAllAction();mixer.uncacheRoot(model);}controls.dispose();scene.traverse(o=>{if(o.geometry)o.geometry.dispose();if(o.material){if(o.material.map)o.material.map.dispose();o.material.dispose();}});renderer.dispose();});
 } catch(e){fail(e);}
})();
