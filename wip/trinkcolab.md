Colabrative projects with Trink

[Edit](https://github.com/christrees/blog/edit/master/wip/trinkcolab.md)

## TrinkTV
Goal: Stable Plex server running in CF maintainable by mdt and cat.

### Plex Rebuilds 2022.08.12-14
Synopsys --
Use Window 10/11 with i5+ gen 10+ machine and map storage over network.

One of the ongoing issues is plex clients asking for transcode when its not required. 

[Avoid Plex transcoding](https://www.plexopedia.com/plex-media-server/general/avoid-transcoding/)

[Using GPU accelerated streaming](https://support.plex.tv/articles/115002178853-using-hardware-accelerated-streaming/)

Notes:
DVR recording takes very little cpu, but transcoding basically requries a gpu or lots of cores.
- macci - trink's old mini after rebuild would only playback to portals (aka portal client can take original format)
- trintv - old admin2cld-win10 Intel(R) Core(TM)2 Duo CPU E8400  @ 3.00GHz added trinks old video card and it could almost handle transcode to one web client
- HPi5 - Intel(R) Core(TM) i5-1035G1 CPU @ 1.00GHz - laptop I've been using could almost handle 4 recording and playback HD streams to web clinets NOTE gen 10 so has GPU built in.
- catmini - i7 

## Robot Simulation
Goal: Spider robot on table simulation running by both mdt and cat.
Goal: Protomotion robot running simulation by both mdt and cat.

### Ubuntu setup catUbuntuVM 20.04
- [VirtualBox and Guest Package Download](https://www.virtualbox.org/wiki/Downloads) - Use Ubuntu 20.04 not 22.04
- [https://linuxconfig.org/install-virtualbox-guest-additions-on-linux-guest](https://linuxconfig.org/install-virtualbox-guest-additions-on-linux-guest)
  ```
   $ sudo apt update
   $ sudo apt install build-essential dkms linux-headers-$(uname -r)
  ```
- Set VM network card to Bridge
- [https://linuxize.com/post/how-to-enable-ssh-on-ubuntu-20-04/](https://linuxize.com/post/how-to-enable-ssh-on-ubuntu-20-04/)
   ```
   sudo apt install openssh-server
   sudo systemctl status ssh
   sudo apt install git
   lsb_release -a <- check that ubuntu is 20.04 for ros desktop package
   ```
### ROS setup
- [Setup ROS dev machine](https://www.youtube.com/watch?v=uWzOk0nkTcI)
    - [https://articulatedrobotics.xyz/ready-for-ros-3-installing-ros/](https://articulatedrobotics.xyz/ready-for-ros-3-installing-ros/)
    - [ROS distributions are linked to Ubuntu versions](https://www.reddit.com/r/ROS/comments/ufvrqg/i_always_get_the_error_unable_to_locate_package/)
      - Ubuntu 20.04 -> Noetic
      - Ubuntu 18.04 -> Melodic
      - Ubuntu 16.04 -> Kinetic
    - [https://docs.ros.org/en/foxy/Installation/Ubuntu-Install-Debians.html](https://docs.ros.org/en/foxy/Installation/Ubuntu-Install-Debians.html)
      - Add ROS packages
      ```
      sudo apt update && sudo apt install curl gnupg2 lsb-release
      ```
      - Add ROS repo key
      ```
      sudo curl -sSL https://raw.githubusercontent.com/ros/rosdistro/master/ros.key  -o /usr/share/keyrings/ros-archive-keyring.gpg
      ```
      - Add to package list
      ```
      echo "deb [arch=$(dpkg --print-architecture) signed-by=/usr/share/keyrings/ros-archive-keyring.gpg] http://packages.ros.org/ros2/ubuntu $(source /etc/os-release && echo $UBUNTU_CODENAME) main" | sudo tee /etc/apt/sources.list.d/ros2.list > /dev/null
      ```
      - Update Upgrade vm
      ```
      sudo apt update
      sudo apt upgrade
      ```
      - Install ROS desktop on catUbuntuVM
      ```
      sudo apt install ros-foxy-desktop
      ```

### Demo Robot
- [https://articulatedrobotics.xyz/mobile-robot-1-project-overview/](https://articulatedrobotics.xyz/mobile-robot-1-project-overview/)
- Setup dev_ws for ROS Template [https://github.com/christrees/my_bot](https://github.com/christrees/my_bot) from [https://github.com/joshnewans/my_bot](https://github.com/joshnewans/my_bot)
  - Create a directory dev_ws to use as a ROS workspace
  - Ccreate a directory called src  in dev_ws to put packages into
  - Clone our package from GitHub 
  - Go back up to the workspace root and build it with colcon using the symlink-install 
  ```
  $ colcon build --symlink-install
  ```
  

## Next Project research
- [AI build for dino game - https://blog.christrees.com/game/](https://blog.christrees.com/game/#dino-ai)
- [https://co.bot/](https://co.bot/)
  - [https://ros.org/](https://ros.org/)
  - [https://classic.gazebosim.org/tutorials?cat=guided_b&tut=guided_b1](https://classic.gazebosim.org/tutorials?cat=guided_b&tut=guided_b1)
  - [https://www.youtube.com/c/GazeboSim/videos](https://www.youtube.com/c/GazeboSim/videos)
  - [tbd]()
  - [tbd]()
- [NVidia Sigraph 2022](https://www.youtube.com/watch?v=Pev84SGO2r0)
  - [https://en.wikipedia.org/wiki/Universal_Scene_Description](https://en.wikipedia.org/wiki/Universal_Scene_Description)
  - [https://en.wikipedia.org/wiki/GlTF](https://en.wikipedia.org/wiki/GlTF)
  - [tbd]()
  - [tbd]()
