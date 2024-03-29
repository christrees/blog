# Connect to silicon dust stream with VLC

- Connect to grasshorse - catghadmin-grid zerotier network
    - [https://www.zerotier.com/](https://www.zerotier.com/)
    - [https://my.zerotier.com/network/d5e5fb65371eb4a4](https://my.zerotier.com/network/d5e5fb65371eb4a4)
    - ping 192.168.6.46 the silicon dust tuner
    ```bash
      (base) cat@cats-Mac-mini ~ % ping 192.168.6.46
      PING 192.168.6.46 (192.168.6.46): 56 data bytes
      64 bytes from 192.168.6.46: icmp_seq=0 ttl=64 time=0.587 ms
      64 bytes from 192.168.6.46: icmp_seq=1 ttl=64 time=0.426 ms
      64 bytes from 192.168.6.46: icmp_seq=2 ttl=64 time=0.552 ms
    ```
- The 192.168.6.0/24 subnet is cf.cat9.com tvnetwork
- Go to [http://192.168.6.46/](http://192.168.6.46/) silicon dust tuner
- Go to [http://192.168.6.46/lineup.html](http://192.168.6.46/lineup.html) copy the link of the channel you want to view
- Open VLC -> File -> Open Network -> http://@192.168.6.46:5004/auto/v7.2 click open
- NOTE: on the URL you need to add @ before IP address
- Stream should play

---
## VLC access to macci over 192.168.6.0/24 subnet via zerotier
- Download [VNC viewer](https://www.realvnc.com/en/connect/download/viewer/)
- connect to 192.168.6.45
- users: ghadmin cat trink
- Plex server is running on ghadmin

## Microsoft Remote Desktop to CyberTruck
- Open Microsoft Remote Desktop Client
- Open [https://my.zerotier.com/network/d5e5fb65371eb4a4](https://my.zerotier.com/network/d5e5fb65371eb4a4)
- Connect to CyberTruck 10.147.17.219 or catghwin10 10.147.17.127

## zerotier route to [cf lan via mini](https://discuss.zerotier.com/t/mac-os-lan-routing/577)
- lan subnet 192.168.6.0/24
- zerotier subnet 10.147.17.0/24
- zerotier IP address of route 10.147.17.59 (catmini)
- zerotier IP address of route 10.147.17.27 (macci) - may move to this mini
- Set up Managed Routes for the network on my.zerotier.com 4
   - Destination: 192.168.6.0/24
   - Via: 10.0.17.59
- On Mac mini set ip IP Forwarding:
```bash
sudo sysctl -w net.inet.ip.forwarding=1
```
- Find network interfaces on Mac mini by running ifconfig 
- Find interface ids for zerotier and lan, (mine are en0 for the lan and feth3632 for zerotier)
- On Mac mini set up Interface Routing:
    - create /etc/pfzerotier.conf and add the following line (editing the interface ids)
      ```bash
      nat on en0 from feth3632:network to any -> (en0)
      ```
    - restart PF
      ```bash
      sudo pfctl -d
      sudo pfctl -e -f /etc/pfzerotier.conf
      ```
- Ping tuner 192.168.6.45 from CyberTruck 10.157.17.219

### Resources
- [Silicondust channel lineup - http://192.168.6.46/lineup.html](http://192.168.6.46/lineup.html)
- [Silicondust HTTP-API document](https://info.hdhomerun.com/info/http_api)
- [Silicondust command line app document](https://info.hdhomerun.com/info/hdhomerun_config)
- [Zerotier - grasshorse catghadmin-grid network](https://my.zerotier.com/network/d5e5fb65371eb4a4)
- [streaming-live-tv-from-a-hdhomerun-to-a-web-browser-using-ffmpeg](https://www.rickmakes.com/streaming-live-tv-from-a-hdhomerun-to-a-web-browser-using-ffmpeg/)
- [https://www.w3.org/TR/media-source/](https://www.w3.org/TR/media-source/)
- [https://github.com/xqq/mpegts.js](https://github.com/xqq/mpegts.js)
- [https://github.com/ossrs/srs/](https://github.com/ossrs/srs/)
- [how-to-create-mpd-or-m3u8-video-file-from-server-using-ffmpeg](https://mayur-solanki.medium.com/how-to-create-mpd-or-m3u8-video-file-from-server-using-ffmpeg-97e9e1fbf6a3)
