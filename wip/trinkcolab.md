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

#### Workspace setup
- [https://articulatedrobotics.xyz/mobile-robot-1-project-overview/](https://articulatedrobotics.xyz/mobile-robot-1-project-overview/)
- Setup dev_ws for ROS Template [https://github.com/christrees/my_bot](https://github.com/christrees/my_bot) from [https://github.com/joshnewans/my_bot](https://github.com/joshnewans/my_bot)
  - Create a directory dev_ws to use as a ROS workspace
  - Ccreate a directory called src  in dev_ws to put packages into
  - Clone our package from GitHub into src
  - Go back up to the workspace root and build it with colcon using the symlink-install 
  ```
    cat@catUbuntuVM:~/dev_ws$ mkdir src
    cat@catUbuntuVM:~/dev_ws$ cd src/
    cat@catUbuntuVM:~/dev_ws/src$ git clone https://github.com/christrees/my_bot.git
    Cloning into 'my_bot'...
    remote: Enumerating objects: 13, done.
    remote: Counting objects: 100% (13/13), done.
    remote: Compressing objects: 100% (9/9), done.
    remote: Total 13 (delta 0), reused 12 (delta 0), pack-reused 0
    Unpacking objects: 100% (13/13), 2.67 KiB | 390.00 KiB/s, done.
    cat@catUbuntuVM:~/dev_ws/src$ ls
    my_bot
    cat@catUbuntuVM:~/dev_ws/src$ cd ..
    cat@catUbuntuVM:~/dev_ws$ colcon build --symlink-install
    [0.186s] WARNING:colcon.colcon_core.prefix_path.colcon:The path '/home/cat/dev_ws/src/install' in the environment variable COLCON_PREFIX_PATH doesn't exist
    [0.186s] WARNING:colcon.colcon_ros.prefix_path.ament:The path '/home/cat/dev_ws/src/install/my_bot' in the environment variable AMENT_PREFIX_PATH doesn't exist
    [0.187s] WARNING:colcon.colcon_ros.prefix_path.catkin:The path '/home/cat/dev_ws/install/my_bot' in the environment variable CMAKE_PREFIX_PATH doesn't exist
    [0.188s] WARNING:colcon.colcon_ros.prefix_path.catkin:The path '/home/cat/dev_ws/src/install/my_bot' in the environment variable CMAKE_PREFIX_PATH doesn't exist
    Starting >>> my_bot
    Finished <<< my_bot [0.99s]

    Summary: 1 package finished [1.18s]
    cat@catUbuntuVM:~/dev_ws$ ls
    build  install  log  src
    cat@catUbuntuVM:~/dev_ws$
    cat@catUbuntuVM:~/dev_ws$ source install/setup.bash
    cat@catUbuntuVM:~/dev_ws$ ros2 launch my_bot rsp.launch.py
  ```
  
#### Create URDF
- Create URDF [https://articulatedrobotics.xyz/mobile-robot-2-concept-urdf/](https://articulatedrobotics.xyz/mobile-robot-2-concept-urdf/)
- Final changes commit [https://github.com/joshnewans/articubot_one/tree/d5aa5e9bc9039073c0d8fd7fe426e170be79c087](https://github.com/joshnewans/articubot_one/tree/d5aa5e9bc9039073c0d8fd7fe426e170be79c087)
- Create robot_core.xacro link in src/my_bot/description/robot-urdf.xacro
  ```xml
  <?xml version="1.0"?>
  <robot xmlns:xacro="http://www.ros.org/wiki/xacro"  name="robot">
      <xacro:include filename="robot_core.xacro" />
  </robot>
  ```
- Create robot_core.xacro link in src/my_bot/description/robot-core.xacro
- Create robot_core.xacro link in src/my_bot/description/inertial-macros.xacro
- Save build and run
```
cat@catUbuntuVM:~/dev_ws$ colcon build --symlink-install
[0.320s] WARNING:colcon.colcon_core.prefix_path.colcon:The path '/home/cat/dev_ws/src/install' in the environment variable COLCON_PREFIX_PATH doesn't exist
[0.321s] WARNING:colcon.colcon_ros.prefix_path.ament:The path '/home/cat/dev_ws/src/install/my_bot' in the environment variable AMENT_PREFIX_PATH doesn't exist
[0.322s] WARNING:colcon.colcon_ros.prefix_path.catkin:The path '/home/cat/dev_ws/src/install/my_bot' in the environment variable CMAKE_PREFIX_PATH doesn't exist
Starting >>> my_bot
Finished <<< my_bot [0.25s]

Summary: 1 package finished [0.55s]
cat@catUbuntuVM:~/dev_ws$ source install/setup.bash
cat@catUbuntuVM:~/dev_ws$ ros2 launch my_bot rsp.launch.py
[INFO] [launch]: All log files can be found below /home/cat/.ros/log/2022-08-17-17-06-23-259065-catUbuntuVM-25259
[INFO] [launch]: Default logging verbosity is set to INFO
[INFO] [robot_state_publisher-1]: process started with pid [25261]
[robot_state_publisher-1] Parsing robot urdf xml string.
[robot_state_publisher-1] Link chassis had 1 children
[robot_state_publisher-1] Link caster_wheel had 0 children
[robot_state_publisher-1] Link left_wheel had 0 children
[robot_state_publisher-1] Link right_wheel had 0 children
[robot_state_publisher-1] [INFO] [1660773983.450365120] [robot_state_publisher]: got segment base_link
[robot_state_publisher-1] [INFO] [1660773983.450953901] [robot_state_publisher]: got segment caster_wheel
[robot_state_publisher-1] [INFO] [1660773983.450989431] [robot_state_publisher]: got segment chassis
[robot_state_publisher-1] [INFO] [1660773983.450999048] [robot_state_publisher]: got segment left_wheel
[robot_state_publisher-1] [INFO] [1660773983.451005918] [robot_state_publisher]: got segment right_wheel
```
- Run rviz2 on catUbuntuVM desktop
```
cat@catUbuntuVM:~/dev_ws$ source install/setup.bash
cat@catUbuntuVM:~/dev_ws$ ros2 launch my_bot rsp.launch.py
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
