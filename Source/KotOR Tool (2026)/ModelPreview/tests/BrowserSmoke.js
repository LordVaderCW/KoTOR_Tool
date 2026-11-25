// Test-only browser check: use an installed playwright-core package, no browser download.
const {chromium}=require(process.env.PLAYWRIGHT_CORE || './output/package');
const fs=require('fs'),path=require('path'),http=require('http');
(async()=>{
 const directory=path.resolve(__dirname,'output');
 const server=http.createServer((req,res)=>{
  const name=path.basename(new URL(req.url,'http://localhost').pathname)||'index.html';
  const types={'.html':'text/html','.js':'text/javascript','.css':'text/css','.gltf':'model/gltf+json'};
  res.setHeader('Content-Type',types[path.extname(name)]||'application/octet-stream');
  try{res.end(fs.readFileSync(path.join(directory,name)));}catch(e){res.statusCode=404;res.end();}
 });
 await new Promise(resolve=>server.listen(0,'127.0.0.1',resolve));let browser;
 try{
  browser=await chromium.launch({executablePath:process.env.PREVIEW_BROWSER || path.join(process.env.LOCALAPPDATA,'Google/Chrome/Application/chrome.exe'),headless:true});
  const page=await browser.newPage({viewport:{width:960,height:720}});const errors=[];
  page.on('pageerror',e=>errors.push(e.message));page.on('console',m=>{if(m.type()==='error')errors.push(m.text());});
  await page.goto(`http://127.0.0.1:${server.address().port}/index.html`);
  await page.waitForFunction(()=>document.getElementById('viewport').getAttribute('aria-busy')==='false');
  const status=await page.locator('#status').textContent();
  if(status.length!==0 || !(await page.locator('#status').evaluate(e=>e.hidden)))throw Error(status+'\n'+errors.join('\n'));
  if(await page.locator('#rotate').getAttribute('aria-pressed')!=='false')throw Error('Rotation must start paused');
  await page.getByRole('button',{name:'Resume rotation'}).click();
  await page.getByRole('button',{name:'Pause rotation'}).click();
  if(await page.getByRole('button',{name:'Resume rotation'}).count()!==1)throw Error('Pause failed');
  await page.locator('#axis').selectOption('X');await page.locator('#wire').check();await page.getByRole('button',{name:'Reset view'}).click();await page.locator('#wire').uncheck();
  await page.screenshot({path:path.join(directory,'browser-viewport.png')});
  if(errors.length)throw Error(errors.join('\n'));
  console.log('PASS: Chromium rendered embedded textured glTF; pause, axis, wireframe and reset controls worked without script errors.');
 }finally{if(browser)await browser.close();server.close();}
})().catch(e=>{console.error(e);process.exitCode=1;});
