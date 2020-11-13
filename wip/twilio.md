# Twilio
- [twilio console](https://www.twilio.com/console)
- [twilio video sessions](https://www.twilio.com/console/video/logs/rooms)

## References
- [twilio video react app](https://github.com/twilio/twilio-video-app-react)
- [twilio video ios app](https://github.com/twilio/twilio-video-app-ios)
- [twilio video android app](https://github.com/twilio/twilio-video-app-android)
- [twilio tutorials](https://www.twilio.com/docs/studio/tutorials)

## Build ios app
1. Update xcode via apple store install cocoapods
```zsh
cat@cats-Mac-mini ~ % sudo gem install cocoapods
```
2. clone repo https://github.com/twilio/twilio-video-app-ios.git
```zsh
cat@cats-Mac-mini code % git clone https://github.com/twilio/twilio-video-app-ios.git
Cloning into 'twilio-video-app-ios'...
remote: Enumerating objects: 279, done.
remote: Counting objects: 100% (279/279), done.
remote: Compressing objects: 100% (182/182), done.
remote: Total 2972 (delta 149), reused 177 (delta 96), pack-reused 2693
Receiving objects: 100% (2972/2972), 984.52 KiB | 5.13 MiB/s, done.
Resolving deltas: 100% (1784/1784), done.
cat@cats-Mac-mini code % 
```
3. follow twilio repo readme
```zsh
cat@cats-Mac-mini twilio-video-app-ios % twilio login
cat@cats-Mac-mini twilio-video-app-ios % twilio plugins:install @twilio-labs/plugin-rtc
cat@cats-Mac-mini twilio-video-app-ios % twilio rtc:apps:video:deploy --authentication passcode
```
4. could not get domain crap with apple app dev crap going
