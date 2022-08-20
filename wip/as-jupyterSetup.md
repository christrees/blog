
# Use Docker
I found that instead of attempting to manage virtual env stuff within python, it should be easiser to manage the env with docker.

- [https://jupyter-docker-stacks.readthedocs.io/en/latest/](https://jupyter-docker-stacks.readthedocs.io/en/latest/)
- [https://hub.docker.com/u/jupyter](https://hub.docker.com/u/jupyter)
- [Jupyter Contributed Recipies](https://jupyter-docker-stacks.readthedocs.io/en/latest/using/recipes.html)

## jupyter Docker workflow
- [https://www.docker.com/products/docker-desktop/](https://www.docker.com/products/docker-desktop/)
- Start Dockerdesktop
- Build Dockerfile image and run in PowerShell
```powershell
PS C:\Users\cadmin\dockertest> docker build .
PS C:\Users\cadmin\dockertest> docker images
REPOSITORY   TAG       IMAGE ID       CREATED        SIZE
<none>       <none>    dc26e310a22c   14 hours ago   1.86GB
PS C:\Users\cadmin\dockertest> cd .\notebooks\
PS C:\Users\cadmin\dockertest\notebooks> docker run -d -p 8888:8888 -v ${PWD}:/media dc26
de5a23c13b19275f826be81e35b552526589b01f962f95f0bfa203a2eb795ef4
```
- Open Dockerdesktop app Containers click on de5a image above to click on url link with token
- Web browser opens juypter lab
- copy files between /media and juypter local /home/jovyan yes it's a hack but beats dealing with user mount acl
- use git in juypter terminal for file syncs

#

---

# Old notes
1. Install [https://jupyter.org/](https://jupyter.org/)
    - make sure to click the ADD PATH it warns not to
2. Env workflow to switch kernel env in jupyter
    - Install [git](https://git-scm.com/downloads))
    - [Multiple python versions on windows](https://levelup.gitconnected.com/how-to-install-and-manage-multiple-python-versions-on-windows-10-c90098d7ba5a)
    - [Multiple env in juypter](https://levelup.gitconnected.com/how-to-install-virtual-environments-in-jupyter-notebook-in-windows-10-5c189856479)
    - python virtual env [venv pyenv](https://www.freecodecamp.org/news/manage-multiple-python-versions-and-virtual-environments-venv-pyenv-pyvenv-a29fb00c296f/)
    - C:\Users\cadmin>python -m jupyter lab
    - C:\Users\cadmin\code\jupyterproject>python -m venv jupterprojectenv
    - C:\Users\cadmin\code\jupyterproject>.\jupterprojectenv\Scripts\activate
    - Pip install ipykernel
    - Python -m ipykernel install --name=jupterprojectenv
    - Deleting envs: juypter kernelspec uninstall jupterprojectenv
    - List kernels: juypter kernelspec list
3. Install Tensorflow
    - Pip install  [https://www.tensorflow.org/install/source_windows](https://www.tensorflow.org/install/source_windows)
4. Install Cuda and cuDNN (cuda dev) NOTE only for NVIDIA gpu
    = [Video of versions and download](https://youtu.be/19LQRx78QVU?t=2646)

Links
- Anaconda:[Download](https://www.anaconda.com/products/distribution)
- Git: [Download](https://git-scm.com/downloads)
- Venv [Documentation](https://docs.python.org/3/library/venv.html)
- Tensorflow CUDA/cuDNN [Versions  Install](https://www.tensorflow.org/install)
- CUDA 11.2:  [Download](https://developer.nvidia.com)
- cuDNN Archive: [Download](https://developer.nvidia.com)
- Visual Studio 2019: [Download](https://visualstudio.microsoft.com/vs/older-downloads/)

Chapters [Install jupyter workflow](https://www.youtube.com/watch?v=19LQRx78QVU)

- 0:00 - Start
- 1:58 - PART 1: Setting up Python and Jupyter with Anaconda
- 3:38 - Installing Anaconda
- 7:38 - Working with Jupyter
- 12:32 - PART 2: Environment Creation Workflows
- 13:44 - Working with Git and GitHub
- 19:12 - Creating Environments for DL
- 24:11 - Activating a Virtual Environment
- 32:05 - PART 3: Installing Tensorflow for Deep Learning
- 39:23 - Running the Image Classifier Pipeline
- 41:32 - PART 4: Configuring your GPU
- 57:06 - PART 5: Training a Deep Image Classifier
