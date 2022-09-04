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
If you want to use key-based ssh authentication instead of password authentication, you need to generate a key using ssh-keygen on your client.

Then, the contents of the id_rsa.pub file must be copied to the c:\users\admin\.ssh\authorized_keys file in Windows 10.

After that, you can connect from your Linux client to Windows 10 without a password. Use the command:
