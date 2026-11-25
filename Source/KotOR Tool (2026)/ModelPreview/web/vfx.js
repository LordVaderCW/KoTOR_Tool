// Bounded development preview of Aurora particle emitters; no game scripts are executed.
'use strict';
window.AuroraVfx=class {
 static async create(model){
  const nodes=[];model.traverse(n=>{if(n.userData.auroraEmitter)nodes.push(n);});
  const system=new AuroraVfx();
  const loader=new THREE.TextureLoader(),textures=new Map();
  for(const node of nodes){
   const data=node.userData.auroraEmitter;
   let texture=null;
   if(data.textureData){
    if(!textures.has(data.textureData))textures.set(data.textureData,new Promise(resolve=>loader.load(data.textureData,resolve,undefined,()=>resolve(null))));
    texture=await textures.get(data.textureData);
   }
   system.emitters.push(system.emitter(node,data,texture,Math.max(1,Math.min(256,Math.floor(2048/nodes.length)))));
  }
  system.replay();return system;
 }
 constructor(){this.emitters=[];this.playing=true;this.loop=true;this.time=0;this.seed=1;}
 random(){this.seed=(Math.imul(this.seed,1664525)+1013904223)>>>0;return this.seed/4294967296;}
 emitter(node,data,texture,limit){
  const number=(key,fallback,lo=-10000,hi=10000)=>Number.isFinite(data[key])?THREE.MathUtils.clamp(data[key],lo,hi):fallback;
  const life=number('lifeexp',1),mode=String(data.update||'Fountain').toLowerCase();
  const e={node,data,number,mode,texture,limit,particles:[],pool:[],frames:new Map(),carry:0,
   life:life<0?Infinity:Math.max(0.02,Math.min(life,30)),rate:number('birthrate',10,0,1000),
   duration:Math.max(1,Math.min(life<0?5:life+0.3,30))};
  e.color=(key,fallback)=>{const a=data[key];return Array.isArray(a)&&a.length===3?a.map(v=>THREE.MathUtils.clamp(v,0,1)):fallback;};
  return e;
 }
 textureFrame(e,age){
  if(!e.texture)return null;
  const x=Math.floor(e.number('xgrid',1,1,16)),y=Math.floor(e.number('ygrid',1,1,16));
  const start=Math.floor(e.number('framestart',0,0,x*y-1)),end=Math.floor(e.number('frameend',start,start,x*y-1));
  const frame=start+Math.floor(age*e.number('fps',0,0,120))%(end-start+1);
  if(!e.frames.has(frame)){
   const t=e.texture.clone();t.needsUpdate=true;t.repeat.set(1/x,1/y);t.offset.set((frame%x)/x,1-(Math.floor(frame/x)+1)/y);e.frames.set(frame,t);
  }
  return e.frames.get(frame);
 }
 spawn(e){
  if(e.particles.length>=e.limit)return;
  let sprite=e.pool.pop();
  if(!sprite){
   const blend=String(e.data.blend||'Normal').toLowerCase();
   const material=new THREE.SpriteMaterial({transparent:true,depthWrite:false,blending:blend==='lighten'?THREE.AdditiveBlending:blend==='punch-through'?THREE.NormalBlending:THREE.NormalBlending});
   material.alphaTest=0.005;sprite=new THREE.Sprite(material);sprite.frustumCulled=false;e.node.add(sprite);
  }
  sprite.visible=true;
  const spread=e.number('spread',Math.PI,0,2*Math.PI),azimuth=this.random()*Math.PI*2,theta=this.random()*spread/2;
  const speed=e.number('velocity',0)+this.random()*e.number('randvel',0,0);
  sprite.position.set((this.random()-0.5)*e.number('xsize',0,0)*0.01,(this.random()-0.5)*e.number('ysize',0,0)*0.01,0);
  e.particles.push({sprite,age:0,velocity:new THREE.Vector3(Math.sin(theta)*Math.cos(azimuth),Math.sin(theta)*Math.sin(azimuth),Math.cos(theta)).multiplyScalar(speed)});
 }
 interpolate(e,start,mid,end,t,fallback){
  const a=e.number(start,fallback),c=e.number(end,a),m=e.number('percentmid',0,0,1);
  if(m>0&&m<1){const b=e.number(mid,a);return t<m?THREE.MathUtils.lerp(a,b,t/m):THREE.MathUtils.lerp(b,c,(t-m)/(1-m));}
  return THREE.MathUtils.lerp(a,c,t);
 }
 sample(e,p){
  const t=Number.isFinite(e.life)?Math.min(1,p.age/e.life):0,mat=p.sprite.material;
  const start=e.color('colorstart',[1,1,1]),end=e.color('colorend',start),middle=e.color('colormid',start),m=e.number('percentmid',0,0,1);
  const color=start.map((v,i)=>m>0&&m<1?(t<m?THREE.MathUtils.lerp(v,middle[i],t/m):THREE.MathUtils.lerp(middle[i],end[i],(t-m)/(1-m))):THREE.MathUtils.lerp(v,end[i],t));
  mat.color.setRGB(...color);mat.opacity=THREE.MathUtils.clamp(this.interpolate(e,'alphastart','alphamid','alphaend',t,1),0,1);
  mat.rotation=p.age*e.number('particlerot',0);mat.map=this.textureFrame(e,p.age);
  const size=Math.max(0,this.interpolate(e,'sizestart','sizemid','sizeend',t,0.1));
  let height=Math.max(0,this.interpolate(e,'sizestart_y','sizemid_y','sizeend_y',t,size));if(height===0)height=size;
  if(String(e.data.render).toLowerCase()==='motion_blur')height=Math.max(height,Math.min(size*8,p.velocity.length()*e.number('blurlength',0,0,10)));
  p.sprite.scale.set(size,height,1);
 }
 replay(){
  this.time=0;this.seed=1;
  for(const e of this.emitters){for(const p of e.particles){p.sprite.visible=false;e.pool.push(p.sprite);}e.particles=[];e.carry=0;
   const count=e.mode==='explosion'?Math.ceil(e.rate):1;
   if(e.rate>0||e.mode==='single')for(let i=0;i<Math.min(count,e.limit);i++)this.spawn(e);
   for(const p of e.particles)this.sample(e,p);
  }
 }
 update(dt){
  if(!this.playing)return;dt=THREE.MathUtils.clamp(dt,0,0.05);this.time+=dt;
  for(const e of this.emitters){
   for(let i=e.particles.length-1;i>=0;i--){const p=e.particles[i];p.age+=dt;
    if(p.age>=e.life){p.sprite.visible=false;e.pool.push(p.sprite);e.particles.splice(i,1);continue;}
    p.velocity.z-=e.number('grav',0)*dt;p.velocity.multiplyScalar(Math.exp(-e.number('drag',0,0,100)*dt));p.sprite.position.addScaledVector(p.velocity,dt);this.sample(e,p);
   }
   if(e.mode==='fountain'){
    e.carry=Math.min(e.limit,e.carry+e.rate*dt);while(e.carry>=1){this.spawn(e);e.carry--;}
   }else if(e.mode==='single'&&e.number('loop',0)!==0&&e.particles.length===0)this.spawn(e);
   for(const p of e.particles)if(p.age===0)this.sample(e,p);
  }
  if(this.loop&&this.emitters.length&&this.emitters.every(e=>e.mode!=='fountain')&&this.time>=Math.max(...this.emitters.map(e=>e.duration)))this.replay();
 }
 expandBounds(bounds){
  for(const e of this.emitters){
   const p=e.node.getWorldPosition(new THREE.Vector3()),scale=e.node.getWorldScale(new THREE.Vector3());
   const radius=Math.max(0.25,Math.min(20,(Math.abs(e.number('velocity',0))+e.number('randvel',0,0))*Math.min(e.life,2)*0.35),e.number('sizestart',0.1,0,20))*Math.max(...scale.toArray().map(Math.abs));
   bounds.expandByPoint(p.clone().addScalar(radius));bounds.expandByPoint(p.clone().addScalar(-radius));
  }
 }
 dispose(){
  const textures=new Set();for(const e of this.emitters){for(const s of [...e.pool,...e.particles.map(p=>p.sprite)]){if(s.parent)s.parent.remove(s);s.material.dispose();}for(const t of e.frames.values())textures.add(t);if(e.texture)textures.add(e.texture);}
  for(const texture of textures)texture.dispose();this.emitters=[];
 }
};
