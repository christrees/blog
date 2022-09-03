- Add [ssh client and server to windows 10](https://theitbros.com/ssh-into-windows/)

1. Go to Settings > Apps > Optional features
2. Search for OpenSSH
3. Select and Install
4. Open PowerShell with Administrator
  - Check Service - powershell
    ```powershell
    Get-Service -Name *ssh*
    ```
  - Start Services and set to automatic - powershell
    ```powershell
      Start-Service sshd
    ```
    ```powershell
      Set-Service -Name sshd -StartupType 'Automatic'
    ```
    ```powershell
      Start-Service ‘ssh-agent’
    ```
    ```powershell
      Set-Service -Name ‘ssh-agent’ -StartupType 'Automatic'
    ```
  - Add Firewall Rules - powershell
    ```powershell
      New-NetFirewallRule -Name sshd -DisplayName 'OpenSSH Server (sshd)' -Enabled True -Direction Inbound -Protocol TCP -Action Allow -LocalPort 22
    ```
  - Verify Connection from some bash
    ```bash
      ssh -p 22 admin@192.168.1.90
    ```
