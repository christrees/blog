# Video Chat using WebRTC
## Janus - WebRTC Server

- [OBS stuido WebRTC - github](https://github.com/CoSMoSoftware/OBS-studio-webrtc)
- [Janus - WebRTC - Demos](https://janus.conf.meetecho.com/demos.html)

## Debuging
- When I connect with another computer I get in console:
```
script.js:10 Uncaught TypeError: Cannot read property 'getUserMedia' of undefined
    at script.js:10
```
- This Issue on github seems important [Github peerjs Issue 693](https://github.com/peers/peerjs/issues/693)
- Found this [https://github.com/RishitPandey/zoom-app-clone](https://github.com/RishitPandey/zoom-app-clone)

Based on [Web Dev Simplified](https://www.youtube.com/watch?v=DvlyzDZDEq4)
  - [GitHub Code: https://github.com/WebDevSimplified/Zoom-Clone-With-WebRTC](https://github.com/WebDevSimplified/Zoom-Clone-With-WebRTC)
  - [PERR JS - https://peerjs.com/](https://peerjs.com/)
  - [Node.js - https://nodejs.org/en/](https://nodejs.org/en/)
  
## Resources
- [https://gitpod.io/workspaces](https://gitpod.io/workspaces/)
- [https://test.webrtc.org/](https://test.webrtc.org/)
- [RTC Tools at webrtc.github.com](https://webrtc.github.com/)
- Interactive Connectivity Establishment (ICE) [youtube](https://youtu.be/Y1mx7cx6ckI?t=908) uses STUN (Session Traversal Utilities for NAT) or TURN (Traversal using Relay NAT) servers solution for the NAT issue with WebRTC
    - ICE server candidate types
        1. host - local address
        2. srflx - address from STUN server
        3. relay - address of TURN server
    - Media servers
        1. Mesh [youtube](https://youtu.be/Y1mx7cx6ckI?t=1745) - too much cpu for muliple parties
        2. MCU - [youtube](https://youtu.be/Y1mx7cx6ckI?t=1795) - Mulitple Control Unit - layout issues and server intensive
        3. SFU - [youtube](https://youtu.be/Y1mx7cx6ckI?t=1910) - Selective Forwarding Unit - subpub media streams router
        4. SFU with Simulcast- [youtube](https://youtu.be/Y1mx7cx6ckI?t=2018) - Selective Forwarding Unit - subpub media streams router

## Setup
1. Install [Node.js - https://nodejs.org/en/](https://nodejs.org/en/) 
2. Create catchat dir init node load packages
```zsh
cat@cats-Mac-mini code % mkdir catchat
cat@cats-Mac-mini code % cd catchat 
cat@cats-Mac-mini catchat % npm init -y
cat@cats-Mac-mini catchat % npm i express ejs socket.io
cat@cats-Mac-mini catchat % npm i uuid
cat@cats-Mac-mini catchat % npm i --save-dev nodemon
```
3. Add devStart to package.json
```js
  "scripts": {
    "devStart": "nodemon server.js"
  },
```
4. Create server.js [TC 6:42](https://youtu.be/DvlyzDZDEq4?t=402)
```js
const express = require('express')
const app = express()
const server = require('http').Server(app)
const io = require('socket.io')(server)
const { v4: uuidV4 } = require('uuid')

app.set('view engine', 'ejs')
app.use(express.static('public '))
app.get('/', (req,res)=>{
    res.redirect(`/${uuidV4()}`)
})
app.get('/:room', (req,res)=>{
    res.render('room', {roomId: req.params.room})
})

server.listen(3000)
```
5. Start server and hit http://localhost:3000/
```zsh
cat@cats-Mac-mini catchat % npm run devStart
cat@cats-Mac-mini catchat % open http://localhost:3000
```
  - Should get url redirect like http://localhost:3000/ed0263bc-932a-4eb4-ac72-e297f86535f6
  - Should get this error in browser [TC 7:19](https://youtu.be/DvlyzDZDEq4?t=439)
  ```txt
  Error: Failed to lookup view "room" in views directory "/Users/cat/code/catchat/views"
    at Function.render (/Users/cat/code/catchat/node_modules/express/lib/application.js:580:17)
    at ServerResponse.render (/Users/cat/code/catchat/node_modules/express/lib/response.js:1012:7)
    at /Users/cat/code/catchat/server.js:13:9
  ```
6. Create file views\room.ejs [TC 9:03](https://youtu.be/DvlyzDZDEq4?t=543)
```html
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
    <style>
        #video-grid {
            display: grid;
            grid-template-columns: repeat(auto-fill,300px);
            grid-auto-rows: 300px;
        }
        video {
            width: 100%;
            height: 100%;
            object-fit: cover;
        }
    </style>
</head>
<body>
    <div id="video-grid"></div>
</body>
</html>
```
7. In server.js call socket.io with room and user info [TC 10:18](https://youtu.be/DvlyzDZDEq4?t=618)
```js
io.on('connection', socket=>{
    socket.on('join-room', (roomId,userId)=>{
        console.log(roomId,userId)
    })
})
```
8. Pass ROOM_ID to room.ejs and load socket.io.js [TC 11:57](https://youtu.be/DvlyzDZDEq4?t=717)
```html
    <script>
        const ROOM_ID = "<%= roomId %>"
    </script>
    <script src="/socket.io/socket.io.js" defer></script>
    <script src="script.js" defer></script>
```
9. Create public/script.js [TC 15:07](https://youtu.be/DvlyzDZDEq4?t=907) I had error... Uncaught SyntaxError: Unexpected token '<'
```js
const socket = io('/')
socket.emit('join-room', ROOM_ID, 10)
socket.on('user-connected', userId=>{
    console.log('User connected' + userId)
})
```
10. In server.js have socket.io broadcast userjoins to a room [TC 14:14](https://youtu.be/DvlyzDZDEq4?t=854)
```js
io.on('connection', socket=>{
    socket.on('join-room', (roomId,userId)=>{
        //console.log(roomId,userId)
        socket.join(roomId)
        socket.to(roomId).broadcast.emit('user-connected', userId)
    })
})
11. Add peer js library and start server [TC 15:51](https://youtu.be/DvlyzDZDEq4?t=951)
```zsh
cat@cats-Mac-mini catchat % sudo npm i -g peer
cat@cats-Mac-mini catchat % peerjs --port 3001
Started PeerServer on ::, port: 3001, path: / (v. 0.5.3)
```
12. Add peer to html views/room.ejs and call in public/scripts.js
```html
    <script defer src="https://unpkg.com/peerjs@1.3.1/dist/peerjs.min.js"></script>
```
```js
const myPeer = new myPeer(undefined, {
    host: '/',
    port: '3001'
})
```
