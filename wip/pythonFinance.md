## New Notes
- [Tradingview Tradestation Futures](https://www.tradestation.com/pricing/futures-margin-requirements/)
- [Tradingview Custom Indecators with Pine Script](https://medium.com/@robswc/how-to-create-custom-tradingview-indicators-with-pinescript-2fb31a66a191)
- [Rob youtube - custom indicators](https://www.youtube.com/c/robswc/videos)
- []()
- []()
- []()

# Finacial Data workflow
- [Anaconda on Windows](https://www.geeksforgeeks.org/how-to-install-jupyter-notebook-in-windows/)
- [Etrade Trading API](https://www.youtube.com/user/JordanShadowens/videos)
- [TDAmeritrade API]()
- [Reinforcement Learning for Trading Tutorial RL Python Trading](https://www.youtube.com/watch?v=D9sU1hLT0QY)
## Setup
1. [Anaconda Download](https://www.anaconda.com/distribution/#download-section)
2. [Anaconda Documentation](https://docs.anaconda.com/anaconda/)
3. Go to Working Directory
```
catmini:Python-for-Finance-Repo-master cat$ pwd
/Users/cat/Documents/Python-for-Finance-Repo-master
catmini:Python-for-Finance-Repo-master cat$ conda env create -f maclinuxenvironment.yml 
Using Anaconda API: https://api.anaconda.org
Fetching package metadata .........
Solving package specifications: .
mkl-2017.0.1-0 100% |#################################################################################################################| Time: 0:00:09  11.76 MB/s
xz-5.2.2-1.tar 100% |#################################################################################################################| Time: 0:00:00  12.72 MB/s
zlib-1.2.8-3.t 100% |#################################################################################################################| Time: 0:00:00  14.95 MB/s
libpng-1.6.27- 100% |#################################################################################################################| Time: 0:00:00   8.97 MB/s
python-3.6.1-2 100% |#################################################################################################################| Time: 0:00:01  11.74 MB/s
... removed output ...
ipywidgets-6.0 100% |#################################################################################################################| Time: 0:00:00  13.85 MB/s
jupyter-1.0.0- 100% |#################################################################################################################| Time: 0:00:00   3.81 MB/s
Requirement already satisfied: ipython-genutils==0.2.0 in /Users/cat/anaconda/envs/pyfinance/lib/python3.6/site-packages
Requirement already satisfied: jupyter-client==5.1.0 in /Users/cat/anaconda/envs/pyfinance/lib/python3.6/site-packages
Requirement already satisfied: jupyter-console==5.1.0 in /Users/cat/anaconda/envs/pyfinance/lib/python3.6/site-packages
Requirement already satisfied: jupyter-core==4.3.0 in /Users/cat/anaconda/envs/pyfinance/lib/python3.6/site-packages
Requirement already satisfied: prompt-toolkit==1.0.14 in /Users/cat/anaconda/envs/pyfinance/lib/python3.6/site-packages
Requirement already satisfied: six>=1.9.0 in /Users/cat/anaconda/envs/pyfinance/lib/python3.6/site-packages (from prompt-toolkit==1.0.14)
Requirement already satisfied: wcwidth in /Users/cat/anaconda/envs/pyfinance/lib/python3.6/site-packages (from prompt-toolkit==1.0.14)
#
# To activate this environment, use:
# > source activate pyfinance
#
# To deactivate this environment, use:
# > source deactivate pyfinance
#

catmini:Python-for-Finance-Repo-master cat$ source activate pyfinance
(pyfinance) catmini:Python-for-Finance-Repo-master cat$ 
```
4. Start Jupyter Notebook (should auto open browser)
```
(pyfinance) catmini:Python-for-Finance-Repo-master cat$ jupyter notebook
[I 09:20:57.082 NotebookApp] Serving notebooks from local directory: /Users/cat/Documents/Python-for-Finance-Repo-master
[I 09:20:57.083 NotebookApp] 0 active kernels 
[I 09:20:57.083 NotebookApp] The Jupyter Notebook is running at: http://localhost:8888/?token=aec6290f1668d9a68eac80570edccab5d12490ae76944033
[I 09:20:57.083 NotebookApp] Use Control-C to stop this server and shut down all kernels (twice to skip confirmation).
[C 09:20:57.084 NotebookApp] 
    
    Copy/paste this URL into your browser when you connect for the first time,
    to login with a token:
        http://localhost:8888/?token=aec6290f1668d9a68eac80570edccab5d12490ae76944033
[I 09:20:57.304 NotebookApp] Accepting one-time-token-authenticated connection from ::1
```
