Colabrative projects with Trink

[Edit](https://github.com/christrees/blog/edit/master/wip/trinkcolab.md)


## Trink think things to review

- [Home Assistant](https://www.home-assistant.io/)
- [Home Assistant Release Review](https://www.youtube.com/watch?v=Ts-_BdFsvxI)
- [Home Assist Dashboard](https://www.youtube.com/watch?v=yy_GBQ5dhKw)
- [OpenSource security AI - frigate ai](https://github.com/blakeblackshear/frigate)
- [https://frigate.video/](https://frigate.video/)

### TrinkCat Remote DataCenter
- It seem with robot simulation, plex dvr and transcode, OpenCI object recon ML and general AI having a DC with gpu is worth the effort.
- ProxMox server with shared GPU machine is my suggestion. [Proxmox vGPU Gaming Tutorial](https://www.youtube.com/watch?v=cPrOoeMxzu0)
    - Plex DVR and Transcoding.  There was about 30 stations
    - Private network extensions to Trink and Cat home TV networks using pfSense.
    - Remote rendering for robot simulations
    - Remote GPU and stoarge for AI/ML
- Grasshorse has lots of robot and robot kits.  
    - They had a grant for protomotion - stop motion animation robots
    - They have multiple robot kits: gantry robonova old school factory robot proto arms
- We chat about [https://www.coridium.us/coridium/shop](https://www.coridium.us/coridium/shop) 
    - BruceE company to integrate sensors into co.bot ?
    - MikeR did a lot of the embedded networking and they also did custom compilers for arm

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
- Goal: Spider robot on table simulation running by both mdt and cat.
- Goal: Protomotion robot running simulation by both mdt and cat.

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
   lsb_release -a <- check that ubuntu is 20.04 for ros desktop package
   ```
- Setup git and [add ssh key to github](https://gist.github.com/xirixiz/b6b0c6f4917ce17a90e00f9b60566278)
  ```
  sudo apt install git
  ssh-keygen -t rsa -b 4096 -C "your_email@example.com"
  xclip -sel clip < ~/.ssh/id_rsa.pub
  ```
- Paste key into your [github account settings](https://github.com/settings/keys) and test
  ```
  ssh -T git@github.com
  git remote set-url origin git@github.com:username/your-repository.git
  git add -A
  git commit -am "Update README.md"
  git push
  ```
- Visual Studio [Ubuntu install](https://code.visualstudio.com/docs/setup/linux)
- Remote-ssh and ROS extensions

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
  - Install ROS desktop on catUbuntuVM desktop only
  ```
  sudo apt install ros-foxy-desktop
  ```
  - Install colcon
  ```
  sudo apt install python3-colcon-common-extensions
  ```
  - Add ROS to env
  ```
  echo "source /opt/ros/foxy/setup.bash" >> ~/.bashrc
  ```
  - Add ROS xacro on catUbuntuVM desktop only
  ```
  sudo apt install ros-foxy-xacro ros-foxy-joint-state-publisher-gui
  ```

### Demo Robot 
- [https://articulatedrobotics.xyz](https://articulatedrobotics.xyz)
- [https://github.com/joshnewans/articubot_one](https://github.com/joshnewans/articubot_one)

#### Workspace setup and simulation
- [https://articulatedrobotics.xyz/mobile-robot-1-project-overview/](https://articulatedrobotics.xyz/mobile-robot-1-project-overview/)
- [https://articulatedrobotics.xyz/mobile-robot-3-concept-gazebo/](https://articulatedrobotics.xyz/mobile-robot-3-concept-gazebo/)
- Setup dev_ws for ROS Template and bot [https://github.com/joshnewans/articubot_one](https://github.com/joshnewans/articubot_one)
  - Create a directory dev_ws to use as a ROS workspace
  - Ccreate a directory called src  in dev_ws to put packages into
  - Clone our package from GitHub into src
  - Go back up to the workspace root and build it with colcon using the symlink-install 
  ```
    cat@catUbuntuVM:~/dev_ws$ mkdir src
    cat@catUbuntuVM:~/dev_ws$ cd src/
    cat@catUbuntuVM:~/dev_ws/src$ git clone https://github.com/joshnewans/articubot_one.git
    cat@catUbuntuVM:~/dev_ws/src$ ls
    articubot_one
    cat@catUbuntuVM:~/dev_ws/src$ cd ..
    cat@catUbuntuVM:~/dev_ws$ colcon build --symlink-install
    cat@catUbuntuVM:~/dev_ws$
    cat@catUbuntuVM:~/dev_ws$ source install/setup.bash
    cat@catUbuntuVM:~/dev_ws$ ros2 launch articubot_one launch_sim.launch.py
    cat@catUbuntuVM:~/dev_ws$ ros2 run teleop_twist_keyboard teleop_twist_keyboard
  ```
  

## Next Project research
- Digital Twins and Simulation
  - [Digital Twin and why it matters in IoT](https://www.networkworld.com/article/3280225/what-is-digital-twin-technology-and-why-it-matters.html)
  - [Defining a Digital Twin Platform](https://iskerrett.medium.com/defining-a-digital-twin-platform-de67586623de)
  - [Open API for Digital Twin](https://www.eclipse.org/ditto/http-api-doc.html#/)
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
