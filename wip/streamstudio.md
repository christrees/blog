# Streaming Studio Setup
## Quickstart [Video Stream Studio Setup](https://youtu.be/XpUJWuSWywg)
1. Start OBS
2. Verify
## Install (catmini)
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
