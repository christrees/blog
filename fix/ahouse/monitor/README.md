
### laview
<!-- ct yahoo What # Time -->
- Model LV-PWF1-K
- DC 5V 1A
- S/N: 061905528

---

- [https://www.ispyconnect.com/camera/laview](https://www.ispyconnect.com/camera/laview)
- [How-to-connect-WiFi-IP-camera-via-web-browser](https://support.laviewsecurity.com/hc/en-us/articles/360023453474-How-to-connect-WiFi-IP-camera-via-web-browser)
- [https://www.laviewsecurity.com/files/documentation/IPC%20USER%20MANUAL%20LV-PB784F2.pdf](https://www.laviewsecurity.com/files/documentation/IPC%20USER%20MANUAL%20LV-PB784F2.pdf)
- [https://www.laviewsecurity.com/files/documentation/user_manual_ipc_rx.pdf](https://www.laviewsecurity.com/files/documentation/user_manual_ipc_rx.pdf)
- [https://camera-sdk.com/p_6691-how-to-connect-to-a-laview-camera.html](https://camera-sdk.com/p_6691-how-to-connect-to-a-laview-camera.html)

---

Tex dump from [https://camera-sdk.com/p_6691-how-to-connect-to-a-laview-camera.html](https://camera-sdk.com/p_6691-how-to-connect-to-a-laview-camera.html)
```
Laview	
Unknown
rtsp://IPADDRESS/	Possible
Laview	
CDP6034
rtsp://IPADDRESS:554//Streaming/Channels/1	Yes
Laview	
CMIP3432
rtsp://IPADDRESS:554//Streaming/Channels/1	Yes
Laview	
Driveway Cam
rtsp://IPADDRESS/	Yes
Laview	
LV-CBP1014
rtsp://IPADDRESS:554//Streaming/Channels/1	Yes
Laview	
LV-CBP1014
rtsp://IPADDRESS:554/cam/realmonitor?channel=[CHANNEL]&subtype=1	Yes
Laview	
LV-CDP6014
rtsp://IPADDRESS:554/ch0_0.h264	Yes
Laview	
LV-CDP6014
rtsp://IPADDRESS:554/cam/realmonitor?channel=[CHANNEL]&subtype=1	Yes
Laview	
LV-WB933F4B
rtsp://IPADDRESS:554//Streaming/Channels/1	Yes
Laview	
Other
http://IPADDRESS/videostream.asf?user=[USERNAME]&pwd=[PASSWORD]&resolution=[WIDTH]*[HEIGHT]	Yes
Laview	
Other
http://IPADDRESS/videostream.asf	Yes
Laview	
Other
rtsp://IPADDRESS:554/cam/realmonitor?channel=[CHANNEL]&subtype=00	Yes
Laview	
Other
rtsp://IPADDRESS:554/	Yes
```

### Zmodo
<!-- ct yahoo What # Time -->
- Channels [https://user.zmodo.com/#/video/15UB73ZE505811F](https://user.zmodo.com/#/video/15UB73ZE505811F)
- Channel 1 Door
- Channel 2 Back 
- Channel 3 Garage 
- Channel 4 Drive 

---
- [https://camlytics.com/camera/zmodo/2](https://camlytics.com/camera/zmodo/2) pretty good
- [http://192.168.6.1/#/html/status/status_devicetable.html](http://192.168.6.1/#/html/status/status_devicetable.html)
- [https://camera-sdk.com/p_6728-how-to-connect-to-a-zmodo-camera.html](https://camera-sdk.com/p_6728-how-to-connect-to-a-zmodo-camera.html)
- [http://community.zmodo.com/t/what-is-the-protocol-data-format-on-ports-8000-9000/190/6](http://community.zmodo.com/t/what-is-the-protocol-data-format-on-ports-8000-9000/190/6)
- [https://www.amazon.com/gp/product/B01KZK82K4/ref=ppx_yo_dt_b_asin_title_o09_s00?ie=UTF8&psc=1](https://www.amazon.com/gp/product/B01KZK82K4/ref=ppx_yo_dt_b_asin_title_o09_s00?ie=UTF8&psc=1)
- [PDF Manual](https://www.zmodo.com/media/downloader/3383/User%20Manual%20for%20IP%20Camera-20130905.pdf)

---

Text dump from [https://camera-sdk.com/p_6728-how-to-connect-to-a-zmodo-camera.html](https://camera-sdk.com/p_6728-how-to-connect-to-a-zmodo-camera.html)

```
Zmodo	
11
http://IPADDRESS/videostream.asf?user=[USERNAME]&pwd=[PASSWORD]&resolution=[WIDTH]*[HEIGHT]	Yes
Zmodo	
720p
rtsp://IPADDRESS:10554//tcp/av0_0	Yes
Zmodo	
8116mpeg
http://IPADDRESS/mjpeg	No
Zmodo	
cm-I11123BK
http://IPADDRESS/videostream.asf?usr=[USERNAME]&pwd=[PASSWORD]	Yes
Zmodo	
CM-I11123BK
http://IPADDRESS/videostream.asf?user=[USERNAME]&pwd=[PASSWORD]&resolution=[WIDTH]*[HEIGHT]	Yes
Zmodo	
CM-I11123BK
http://IPADDRESS/videostream.asf	Yes
Zmodo	
CM-I11123BK
http://IPADDRESS/videostream.asf	Yes
Zmodo	
CM-I11123BK
http://IPADDRESS/videostream.asf?user=[USERNAME]&pwd=[PASSWORD]&resolution=64&rate=0	Yes
Zmodo	
CM-I11123BK
http://IPADDRESS/videostream.asf?user=[USERNAME]&pwd=[PASSWORD]&resolution=32&rate=0	Yes
Zmodo	
CM-I11123BK
http://IPADDRESS/snapshot.cgi?camera=[CHANNEL]	No
Zmodo	
CM-I11123BK
http://IPADDRESS/snapshot.cgi?user=[USERNAME]&pwd=[PASSWORD]	No
Zmodo	
CM-I11123BK
http://IPADDRESS/snapshot.cgi	No
Zmodo	
CM-I11123BK
http://IPADDRESS/videostream.cgi?rate=11	No
Zmodo	
CM-I11123BK
http://IPADDRESS/videostream.cgi	No
Zmodo	
CM-I11123BK
http://IPADDRESS/videostream.cgi?user=[USERNAME]&pwd=[PASSWORD]	No
Zmodo	
CM-I11123BK
http://IPADDRESS/video.cgi?resolution=VGA	No
Zmodo	
CM-I11123BK
http://IPADDRESS/videostream.asf?user=[USERNAME]&pwd=[PASSWORD]	Yes
Zmodo	
CM-I11123BK
rtsp://IPADDRESS:554/VideoInput/[CHANNEL]/h264/1	Yes
Zmodo	
CM-I11123BK
rtsp://IPADDRESS:554/[CHANNEL]	Yes
Zmodo	
CM-I11123BK R
http://IPADDRESS/videostream.asf	Yes
Zmodo	
CMI11133WT
http://IPADDRESS/videostream.asf?user=[USERNAME]&pwd=[PASSWORD]&resolution=[WIDTH]*[HEIGHT]	Yes
Zmodo	
CM-I12316gy
http://IPADDRESS/videostream.asf?user=[USERNAME]&pwd=[PASSWORD]&resolution=[WIDTH]*[HEIGHT]	Yes
Zmodo	
CM-I12316gy
http://IPADDRESS/videostream.cgi	No
Zmodo	
CM-I12316gy
http://IPADDRESS/videostream.cgi?rate=11	No
Zmodo	
CM-I12316gy
http://IPADDRESS/videostream.asf?user=[USERNAME]&pwd=[PASSWORD]	Yes
Zmodo	
CM-I12316GY
rtsp://IPADDRESS:554/VideoInput/[CHANNEL]/h264/1	Yes
Zmodo	
CM-I12316GY
rtsp://IPADDRESS:554/[CHANNEL]	Yes
Zmodo	
CN-I11123BK
http://IPADDRESS/videostream.asf?user=[USERNAME]&pwd=[PASSWORD]&resolution=[WIDTH]*[HEIGHT]	Yes
Zmodo	
DVR w/ Web Port
http://IPADDRESS/snapshot.cgi?user=[USERNAME]&pwd=[PASSWORD]	No
Zmodo	
DVR w/ Web Port
http://IPADDRESS/stillimg[CHANNEL].jpg	No
Zmodo	
DVR w/ Web Port
http://IPADDRESS/videostream.cgi	No
Zmodo	
DVR w/ Web Port
http://IPADDRESS//control/faststream.jpg?stream=MxPEG&needlength&fps=6	Yes
Zmodo	
DVR w/ Web Port
rtsp://IPADDRESS:554/cam[CHANNEL]/h264	Yes
Zmodo	
DVR w/ Web Port
rtsp://IPADDRESS:554/live.sdp	Yes
Zmodo	
DVR w/ Web Port
rtsp://IPADDRESS:554/image.mpg	Yes
Zmodo	
DVR w/ Web Port
rtsp://IPADDRESS:554/mpeg4/[CHANNEL]/media.amp	Yes
Zmodo	
DVR W/ WEB PORT
rtsp://IPADDRESS:554/VideoInput/[CHANNEL]/h264/1	Yes
Zmodo	
DVR W/ WEB PORT
rtsp://IPADDRESS:554/[CHANNEL]	Yes
Zmodo	
h.264
http://IPADDRESS/videostream.asf?user=[USERNAME]&pwd=[PASSWORD]&resolution=[WIDTH]*[HEIGHT]	Yes
Zmodo	
h.264
http://IPADDRESS/cgi-bin/snapshot.cgi?loginuse=[USERNAME]&loginpas=[PASSWORD]	No
Zmodo	
h.264
http://IPADDRESS/cgi-bin/view.cgi?chn=[CHANNEL]&u=[USERNAME]&p=[PASSWORD]	Yes
Zmodo	
h.264
http://IPADDRESS//control/faststream.jpg?stream=MxPEG&needlength&fps=6	Yes
Zmodo	
H.264
rtsp://IPADDRESS:554/VideoInput/[CHANNEL]/h264/1	Yes
Zmodo	
H.264
rtsp://IPADDRESS:554/[CHANNEL]	Yes
Zmodo	
IBI13
rtsp://IPADDRESS:10554//tcp/av0_0	Yes
Zmodo	
IP900
http://IPADDRESS/videostream.cgi?user=[USERNAME]&pwd=[PASSWORD]	No
Zmodo	
ixa15-wc
rtsp://IPADDRESS:10554//tcp/av0_0	Yes
Zmodo	
Other
rtsp://IPADDRESS:554/h264	Yes
Zmodo	
Other
http://IPADDRESS/videostream.asf?user=[USERNAME]&pwd=[PASSWORD]&resolution=[WIDTH]*[HEIGHT]	Yes
Zmodo	
Other
http://IPADDRESS/videostream.asf?user=[USERNAME]&pwd=[PASSWORD]&resolution=32&rate=0	Yes
Zmodo	
Other
http://IPADDRESS/videostream.asf?user=[USERNAME]&pwd=[PASSWORD]&resolution=64&rate=0	Yes
Zmodo	
Other
http://IPADDRESS/cgi-bin/snapshot.cgi?loginuse=[USERNAME]&loginpas=[PASSWORD]	No
Zmodo	
Other
http://IPADDRESS/snapshot.cgi?camera=[CHANNEL]	No
Zmodo	
Other
http://IPADDRESS/snapshot.cgi	No
Zmodo	
Other
http://IPADDRESS/snapshot.cgi?user=[USERNAME]&pwd=[PASSWORD]	No
Zmodo	
Other
http://IPADDRESS/stillimg[CHANNEL].jpg	No
Zmodo	
Other
http://IPADDRESS/image/[CHANNEL].jpg	No
Zmodo	
Other
http://IPADDRESS/img/video.jpg	No
Zmodo	
Other
rtsp://IPADDRESS:554/cam[CHANNEL]/mjpeg	No
Zmodo	
Other
http://IPADDRESS/videostream.cgi	No
Zmodo	
Other
http://IPADDRESS/videostream.cgi?rate=11	No
Zmodo	
Other
http://IPADDRESS:554/videostream.cgi?user=[USERNAME]&pwd=[PASSWORD]	No
Zmodo	
Other
http://IPADDRESS/videostream.asf?user=[USERNAME]&pwd=[PASSWORD]	Yes
Zmodo	
Other
http://IPADDRESS/cgi-bin/view.cgi?chn=[CHANNEL]&u=[USERNAME]&p=[PASSWORD]	Yes
Zmodo	
Other
rtsp://IPADDRESS:554/cam[CHANNEL]/h264	Yes
Zmodo	
Other
rtsp://IPADDRESS:554/mpg4/rtsp.amp	Yes
Zmodo	
Other
rtsp://IPADDRESS:554/mpeg4	Yes
Zmodo	
Other
rtsp://IPADDRESS:554/video.mp4	Yes
Zmodo	
Other
rtsp://IPADDRESS:554/cam[CHANNEL]/mpeg4	Yes
Zmodo	
Other
rtsp://IPADDRESS:554/[CHANNEL]/1:1/main	Yes
Zmodo	
Other
rtsp://IPADDRESS:554/	Yes
Zmodo	
Other
http://IPADDRESS//control/faststream.jpg?stream=MxPEG&needlength&fps=6	Yes
Zmodo	
Other
rtsp://IPADDRESS:554/VideoInput/[CHANNEL]/h264/1	Yes
Zmodo	
Other
rtsp://IPADDRESS:554/[CHANNEL]	Yes
Zmodo	
PKD-DK40107
http://IPADDRESS/cgi-bin/video.jpg?cam=[CHANNEL]&quality=3&size=2	No
Zmodo	
PTZ IP Cam
http://IPADDRESS/videostream.asf	Yes
Zmodo	
RTSP(TCP) DVR
http://IPADDRESS/img/video.jpg	No
Zmodo	
RTSP(TCP) DVR
http://IPADDRESS/stillimg[CHANNEL].jpg	No
Zmodo	
RTSP(TCP) DVR
http://IPADDRESS//control/faststream.jpg?stream=MxPEG&needlength&fps=6	Yes
Zmodo	
RTSP(TCP) DVR
rtsp://IPADDRESS:554/0/[USERNAME]:[PASSWORD]/main	Yes
Zmodo	
RTSP(TCP) DVR
rtsp://IPADDRESS:554/VideoInput/[CHANNEL]/h264/1	Yes
Zmodo	
RTSP(TCP) DVR
rtsp://IPADDRESS/[CHANNEL]	Possible
Zmodo	
ZH-IBH13-W
rtsp://IPADDRESS:10554//tcp/av0_1	Yes
Zmodo	
ZH-IBH13-W
rtsp://IPADDRESS:10554//tcp/av0_0	Yes
Zmodo	
ZH-IXA15-WC
rtsp://IPADDRESS:10554//tcp/av0_0	Yes
Zmodo	
ZH-IXA15-WC
rtsp://IPADDRESS:10554//udp/av0_1	Yes
Zmodo	
ZH-IXA15-WC
http://IPADDRESS:10554/videostream.asf?user=[USERNAME]&pwd=[PASSWORD]&resolution=[WIDTH]*[HEIGHT]	Yes
Zmodo	
ZH-IXA15-WC
rtsp://IPADDRESS:10554//udp/av0_0	Yes
Zmodo	
ZH-IXA15-WC
rtsp://IPADDRESS:10554//tcp/av0_0	Yes
Zmodo	
ZH-IXB15-WC
rtsp://IPADDRESS:10554//tcp/av0_0	Yes
Zmodo	
ZH-IXB15-WC
rtsp://IPADDRESS:10554//tcp/av0_1	Yes
Zmodo	
ZH-IXC15-WC
rtsp://IPADDRESS:10554//tcp/av0_0	Yes
Zmodo	
ZH-IXC15-WC
rtsp://IPADDRESS:10554//tcp/av0_1	Yes
Zmodo	
ZH-IXD15-WAC
rtsp://IPADDRESS:10554//tcp/av0_0	Yes
Zmodo	
ZH-IXD15-WC
rtsp://IPADDRESS:10554//tcp/av0_1	Yes
Zmodo	
ZH-IXD15-WC
rtsp://IPADDRESS:10554//tcp/av0_0	Yes
Zmodo	
zmd-isv-bfs23nm
http://IPADDRESS/videostream.asf?user=[USERNAME]&pwd=[PASSWORD]&resolution=32&rate=0	Yes
Zmodo	
zmd-isv-bfs23nm
http://IPADDRESS/img/video.jpg	No
Zmodo	
zmd-isv-bfs23nm
http://IPADDRESS/stillimg[CHANNEL].jpg	No
Zmodo	
zmd-isv-bfs23nm
http://IPADDRESS/image/[CHANNEL].jpg	No
Zmodo	
zmd-isv-bfs23nm
http://IPADDRESS/cgi/mjpg/mjpeg.cgi	No
Zmodo	
zmd-isv-bfs23nm
http://IPADDRESS//control/faststream.jpg?stream=MxPEG&needlength&fps=6	Yes
Zmodo	
ZMD-ISV-BFS23NM
rtsp://IPADDRESS:554/[CHANNEL]	Yes
Zmodo	
ZMD-ISV-BFS23NM
rtsp://IPADDRESS:554/VideoInput/[CHANNEL]/h264/1	Yes
Zmodo	
Zmodo
http://IPADDRESS/videostream.asf	Yes
Zmodo	
ZP-IBH13-P
rtsp://IPADDRESS:10554//tcp/av0_0	Yes
Zmodo	
ZP-IBH13W
rtsp://IPADDRESS:10554//tcp/av0_0	Yes
Zmodo	
ZP-IBH13-W
rtsp://IPADDRESS:10554//tcp/av0_0	Yes
Zmodo	
ZP-IBI13-W
```


rtsp://IPADDRESS:10554//tcp/av0_0	Yes
