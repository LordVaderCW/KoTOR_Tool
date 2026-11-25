// node GenerateChecks.cjs <copied C_DrdWar ASCII MDL>
// Generates an isolated Max batch test from source tracks, without distributing game data.
const fs = require('node:fs');
const path = require('node:path');
const source = fs.readFileSync(process.argv[2], 'utf8');
const bind = new Map();
const nodes = text => text.matchAll(/node \w+ (\S+)\r?\n([\s\S]*?)endnode/g);
for (const m of nodes(source.split('newanim')[0])) {
    const p = m[2].match(/\bposition\s+([^\r\n]+)/);
    if (p) bind.set(m[1], p[1].trim().split(/\s+/).map(Number).map(v => v * 100));
}
const positions = [];
const clips = source.split('newanim ').slice(1);
for (const clip of clips) {
    const name = clip.split(/\s/)[0];
    for (const m of nodes(clip)) {
        if (bind.has(m[1]) && !/position(?:bezier)?key/.test(m[2])) {
            positions.push(`#("${name}", "${m[1]}", [${bind.get(m[1]).join(',')}])`);
        }
    }
}
const rotations = [];
for (const m of nodes(clips[0])) {
    const track = m[2].match(/orientationkey\s*\r?\n([\s\S]*?)endlist/);
    if (!track) continue;
    const values = track[1].trim().split(/\r?\n/).map(line => line.trim().split(/\s+/).map(Number));
    for (const key of [values[0], values[values.length - 1]]) {
        rotations.push(`#("${m[1]}", ${Math.round(key[0] * 30)}, [${key.slice(1, 4).join(',')}], ${key[4]})`);
    }
}
const template = fs.readFileSync(path.join(__dirname, 'CheckClips.template.ms'), 'utf8');
fs.writeFileSync(path.join(__dirname, 'war-droid.mdl'), source);
fs.writeFileSync(path.join(__dirname, 'CheckClips.ms'), template
    .replace('__POSITIONS__', positions.join(',\n'))
    .replace('__ROTATIONS__', rotations.join(',\n')));
console.log(`Generated ${positions.length} position-track and ${rotations.length} rotation-key cases.`);
