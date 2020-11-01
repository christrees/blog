# Streaming Studio Setup
## Quickstart [Video Stream Studio Quickstart](https://youtu.be/W2Po0jeB0mU)
1. Start OBS
2. Verify Local Sources
    - IntroScene (blogchrisreesintro.mp4)
    - catminiWebCam (local webcam)
    - catminiOBSScreen  (obs screen for videos... not really needed)
    - catminiShowScreen (main show screen for videos)
    - ComputerAudio (the iShowU Audio capture of midi streaming on computer output)
    - CatSurfaceRemote connect to catsurface via remotedesktop.google.com then bind to that window
3. Test
    1. Click on Intro Scene
    2. Start Recording
    3. Click on TalkingHead and talk
    4. Click on SceneWork to talk and show
    5. Click on CatSurfaceRemote to verify you can annotate using surface
    6. End Record
    7. Verify stream rename if good
4. Upload Stream 
    1. Go to [https://studio.youtube.com/](https://studio.youtube.com/) and upload
    
## Install (catmini) [Video Stream Studio Setup](https://youtu.be/XpUJWuSWywg)
1. Install [OBS](https://obsproject.com/) on catmini catalina
2. Install [iShowU Audio](https://support.shinywhitebox.com/hc/en-us/articles/360030800592)
3. Reboot
4. Audio Midi Setup [TC 1:42](https://youtu.be/1-tnEfV2I_M?t=102)
  - Search for Audio Midi Setup
  - Add multi-output device to capture Computer and Mic
  - Select the Output (Yeti) and iShow Audio Capture
  - Rename to "Streaming"
5. Sytem Preference Sound [TC 3:11](https://youtu.be/1-tnEfV2I_M?t=191)
  - Set Audio Output to "Streaming"
6. OBS Setup Audio
  - Gear -> Device -> Yeti Stereo Microphone
  - Gear -> Advanced Audio -> Click Mono
  - Rename Audio source to "Yeti"
7. OBS Display Capture
  - Sources Add -> Display Capture -> catminiLeftScreen
  - Sources Add -> Display Capture -> catminiRightScreen
8. OBS Computer Audio Capture
  - Sources -> + -> Audio Output -> Create New "ComputerAudio"
  - Device -> iShowU Audio Capture
9. OBS 
  - Sources -> + -> Video Capture Deive -> Create New "catminiWebCam"
  - Device -> USB2.0 UVC PC Camera
10. Setup Scenes
  - Streaming (Screen, WebCam, Mic, Streaming)
  - Talking Head (WebCam, Mic)
  
### Reference
- [OBS](https://obsproject.com/)
- [iShowU Audio Capture](https://support.shinywhitebox.com/hc/en-us/articles/360030800592)
- [Mac OBS Setup for streaming with computer audio 2020](https://www.youtube.com/watch?v=1-tnEfV2I_M)
- [canva.com - IntroScreenCreation](https://www.canva.com/)
