# Pop!_OS 22.04 Homelab Setup

---

## 1. Update & Upgrade
```bash
sudo apt update && sudo apt upgrade -y
```

---

## 2. Core Development Tools
```bash
sudo apt install build-essential git curl wget unzip zip cmake ninja-build pkg-config   clang lldb gdb valgrind
```

---

## 3. Language Runtimes
### Java
```bash
sudo apt install openjdk-17-jdk maven gradle
```

### .NET
```bash
wget https://packages.microsoft.com/config/ubuntu/22.04/packages-microsoft-prod.deb -O packages-microsoft-prod.deb
sudo dpkg -i packages-microsoft-prod.deb
sudo apt update
sudo apt install dotnet-sdk-8.0
```

### Python
```bash
sudo apt install python3 python3-pip python3-venv
```

### Node.js
```bash
curl -fsSL https://deb.nodesource.com/setup_20.x | sudo -E bash -
sudo apt install -y nodejs
```

---

## 4. Android Development
```bash
sudo apt install adb fastboot
flatpak install flathub com.google.AndroidStudio
```

---

## 5. Containers & Virtualization
```bash
sudo apt install podman docker.io docker-compose qemu-kvm libvirt-daemon-system   virt-manager bridge-utils cockpit cockpit-machines cockpit-podman
```

Add user to groups:
```bash
sudo usermod -aG docker $USER
sudo usermod -aG libvirt $USER
```

Access Cockpit at: `https://<ip>:9090`

---

## 6. Useful Dev & Admin Tools
```bash
sudo apt install htop ncdu tmux neofetch jq fzf ripgrep silversearcher-ag   tree net-tools nmap iotop iftop btop exa bat
```

---

## 7. Media Codecs & Desktop Utilities
```bash
sudo apt install ubuntu-restricted-extras vlc gnome-tweaks gnome-shell-extensions
```

---

## 8. RAID0 HDD Setup (Optional)
```bash
sudo apt install mdadm
sudo mdadm --create --verbose /dev/md0 --level=0 --raid-devices=2 /dev/sda /dev/sdb
sudo mkfs.ext4 /dev/md0
sudo mkdir -p /media/storage
blkid /dev/md0   # get UUID
# Add to /etc/fstab
UUID=<uuid>   /media/storage   ext4   defaults,noatime   0   2
```

Folders:
```bash
/media/storage/containers   # persistent container data
/media/storage/nas          # private Samba share
/media/storage/public       # guest Samba share
```

---

## 9. Samba Shares (Optional)
Install Samba:
```bash
sudo apt install samba
```

### Private share (`/media/storage/nas`)
```
[storage]
   path = /media/storage/nas
   browseable = yes
   writable = yes
   guest ok = no
   create mask = 0775
   directory mask = 0775
   valid users = omar
```
```bash
sudo smbpasswd -a omar
```

### Public share (`/media/storage/public`)
```
[public]
   path = /media/storage/public
   browseable = yes
   writable = yes
   guest ok = yes
   create mask = 0777
   directory mask = 0777
   force user = nobody
```
```bash
sudo mkdir -p /media/storage/public
sudo chown -R nobody:nogroup /media/storage/public
chmod -R 0777 /media/storage/public
```

Restart Samba:
```bash
sudo systemctl restart smbd nmbd
```

### Firewall (for Windows access)
```bash
sudo ufw allow 137,138/udp
sudo ufw allow 139,445/tcp
```

---

## 10. System Quality-of-Life
### Firewall
```bash
sudo apt install ufw
sudo ufw enable
sudo ufw allow 22/tcp
sudo ufw allow 9090/tcp
```

### SSD Trim
```bash
sudo systemctl enable fstrim.timer
```

### RAID Monitoring
```bash
sudo apt install mdadm
```

### Kernel & Drivers (HWE)
```bash
sudo apt install linux-generic-hwe-22.04
```

---

## 11. GNOME Extensions (Optional, 2025 Essentials)
- Dash to Dock / Dash to Panel  
- AppIndicator (tray support)  
- GSConnect (Android integration)  
- Clipboard Indicator  
- Caffeine  
- User Themes  
- Sound Device Chooser  
- TopHat (system monitor)  
- Just Perfection (UI tweaks)  
- Impatience (faster animations)  

Install extension manager:
```bash
sudo apt install gnome-shell-extension-manager
```

---

## 12. IDEs
- Install VS Code (deb package or Flatpak)
- Install JetBrains Toolbox (manual download)

---

## 13. Optional Nerd Candy
```bash
sudo apt install cowsay lolcat
```

---

## Final Step
Reboot your system:
```bash
sudo reboot
```
