Windows 10 Home Virtual Machine
---

- [https://www.virtualbox.org/wiki/Downloads](https://www.virtualbox.org/wiki/Downloads)
    - [OSX - download](https://download.virtualbox.org/virtualbox/6.1.32/VirtualBox-6.1.32-149290-OSX.dmg)
    - [vbox extension back](https://download.virtualbox.org/virtualbox/6.1.32/Oracle_VM_VirtualBox_Extension_Pack-6.1.32.vbox-extpack)
- [https://www.horseshoepitching.com/](https://www.horseshoepitching.com/)
    - [HSMaster Program - https://www.horseshoepitching.com/hsmaster-3/](https://www.horseshoepitching.com/hsmaster-3/)
    - [HSMaster Program Download - https://www.horseshoepitching.com/hsmaster/HSScoreKeeperInstall.exe](https://www.horseshoepitching.com/hsmaster/HSScoreKeeperInstall.exe)

- win10home
    - 4096 MB
    - 50 GB
    - win10cat outlook
    - What#Time
    - 3733
    - admin - horseoff - remote
    - [wip win10home](https://blog.christrees.com/wip/Win10Home)

- Install Guest addtions
    - Click the Devices menu and select the Insert Guest Additions CD image option.
    - Double-click the VBoxWindowsAdditions.exe file to launch the installer.

Notes
- [install-microsoft-windows-11-on-virtualbox](https://blogs.oracle.com/virtualization/post/install-microsoft-windows-11-on-virtualbox)
- [Wine on Mac](https://wiki.winehq.org/MacOS)

---

Windows 10 VM [MacBook Pro screen issues](https://mediawiki.middlebury.edu/CS/Common_VirtualBox_Issues)
1. Download and install [RDM - Binary](http://avi.alkalay.net/software/RDM/) source at [RDM - https://github.com/avibrazil/RDM](https://github.com/avibrazil/RDM)
2. Select 1440 x 900 WITHOUT the thunderbolt
3. Start VirtualBox verify Win10Home VM display configs
    - 4096 MB
    - USB Tablet
    - Enable I/O
    - 2 CPUs
    - ParaVirtual - Default. Hardware Virt - Enable Nested Paging
    - VBoxVGA, Enable 3D Acc NOT CHECKED, Video Memory 128 MB (note VirtBox calls VBoxVGA Invalid settings but is required for RDM so the screen will work)
4. Start Win10Home VM

---

Default uses 64bit but HSMaster is using 32bit [32bit ODBC issue](https://docs.microsoft.com/en-us/troubleshoot/sql/connect/odbc-tool-displays-32-bit-64-bit)
1. Download 64bit - [Microsoft Access Distribute for ODBC](https://www.microsoft.com/en-us/download/details.aspx?id=54920)
2. Run 32bit Odbcad32.exe file is located in the C:\Windows\SysWoW64\odbcad32
3. Add System DSN that points to DBFile C:\HSMasterData\HSMaster.mdb

--- 

Turn off Windows 10 stuff

[Turn Off OneDrive](https://www.minitool.com/backup-tips/how-to-disable-onedrive.html)
1. Control Panel
2. Programs -> Ininstall a program -> OneDrive

[AutoUpdates Off](https://www.windowscentral.com/how-stop-updates-installing-automatically-windows-10)
1. Regedit
2. HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows
3. new key WindowsUpdate
4. new key AU
5. new DWORD NoAutoUpdate -> 1
6. Restart

---

