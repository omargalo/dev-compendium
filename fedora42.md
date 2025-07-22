# Fedora 42

## i3wm
- Fix screen resolution:
  - sudo nano .config/i3/config
    - at the end of the file add:
    - exec_always xrandr --output Virtual1 --mode 1920x1080

## /etc/dnf/dnf.conf
```bash
sudo nano /etc/dnf/dnf.conf

max_parallel_downloads=10
fastestmirror=true
```
## Host
```bash
hostnamectl
cat /etc/redhat-release
```
- uname -ar
- sudo dnf update -y
- sudo fwupdmgr refresh --force
- sudo fwupdmgr update
- sudo reboot now

## Aliases
```bash
mkdir -p ~/.bashrc.d
echo "alias ll='ls -al'" >> ~/.bashrc.d/aliases.sh
source ~/.bashrc
```

## LAN
```bash
ip addr show
nmcli connection show
sudo nmcli con mod "Wired connection 1" ipv4.addresses "new_ip/24"
sudo nmcli con mod "Wired connection 1" ipv4.gateway "gateway_ip"
sudo nmcli con mod "Wired connection 1" ipv4.dns "dns_ip"
sudo nmcli con down "Wired connection 1"
sudo nmcli con up "Wired connection 1"
```

## Storage
```bash
df -h
lsblk -l
sudo fdisk -l
```

## RAID

### Format the RAID Device
```bash
sudo mkfs.xfs /dev/md126
```

### Create a Mount Point
```bash
sudo mkdir -p /media/storage
```

### Mount the Filesystem
```bash
sudo mount /dev/md126 /media/storage
```

### Verify the Mount
```bash
df -h | grep /media/storage
```

### Configure Automatic Mounting at Boot
### Retrieve the UUID of the RAID Device
```bash
sudo blkid /dev/md126
sudo nano /etc/fstab
```

### Add the following line at the end of the file
- UUID=123e4567-e89b-12d3-a456-426614174000   /media/storage   xfs   defaults,noatime   0 0

### Test the entry
```bash
sudo mount -a
```

### Remount the Filesystem
```bash
sudo mount -o remount /media/storage
```

### Check Mounted Filesystems
```bash
df -h
```

### Check RAID Array Status
```bash
sudo mdadm --detail /dev/md126
```

## Fix Cockpit RAID Service
```bash
sudo dnf install -y mdadm
sudo mkdir -p /run/mdadm
sudo chown root:root /run/mdadm
sudo bash -c 'mdadm --detail --scan --verbose > /etc/mdadm.conf'
sudo systemctl enable --now mdmonitor.service
sudo systemctl restart mdmonitor.service
sudo systemctl status mdmonitor.service
```

### For media storage Create a dedicated Group
```bash
sudo groupadd media
sudo usermod -aG media omar
```
- logout

### Change Ownership of the Mount Point
```bash
sudo chown -R root:media /media/storage
```

### Adjust Permissions
```bash
sudo chmod -R 775 /media/storage
```

## Enable fusion repositories
```bash
sudo dnf install https://mirrors.rpmfusion.org/free/fedora/rpmfusion-free-release-$(rpm -E %fedora).noarch.rpm
sudo dnf install https://mirrors.rpmfusion.org/nonfree/fedora/rpmfusion-nonfree-release-$(rpm -E %fedora).noarch.rpm
sudo dnf upgrade --refresh
```

## Media codecs
```bash
sudo dnf group install multimedia
sudo dnf install intel-media-driver
sudo dnf install intel-mediasdk
sudo dnf install dnf-utils
sudo dnf install gnome-tweaks
```

## Tools
- sudo dnf install @development-tools
- sudo dnf install fastfetch picom nitrogen automake autoconf gcc gcc-c++ xset scrot

  
## i3 lightdm
```bash
sudo groupadd -r nopasswdlogin
sudo groupadd -r autologin
sudo gpasswd -a omar nopasswdlogin
sudo gpasswd -a omar autologin
```
- sudo nano /etc/pam.d/lightdm
  - auth    sufficient    pam_succeed_if.so user ingroup nopasswdlogin
  - auth    include    system-login
- sudo nano /etc/lightdm/lightdm.conf
- [Seat:*]
  - autologin-user=omar
  - autologin-user-timeout=0
  - autologin-session=i3
- Add a new user on both groups
  - useradd -mG autologin,nopasswdlogin -s /bin/bash evelyn

## Disable sleep/hibernate
```bash
sudo systemctl mask sleep.target suspend.target hibernate.target hybrid-sleep.target
```

### install .tar.gz
```bash
sudo tar -xzf ./file -C /opt
```

### symbolic link ex:
```bash
sudo ln -s /opt/idea/bin/idea /usr/local/bin/idea
sudo ln -s /opt/Postman/app/Postman /usr/local/bin/postman
```

## OpenJDK
```bash
sudo dnf install java-17-openjdk
```

## .NET 8
```bash
sudo dnf install dotnet-sdk-8.0
```

## SSH
```bash
ssh-keygen -t ed25519 -C "omar.garcia@omargl.net"
chmod 600 ~/.ssh/id_ed25519
eval "$(ssh-agent -s)"
ssh-add ~/.ssh/id_ed25519
cat ~/.ssh/id_ed25519.pub
```

## Install VS Code
- https://code.visualstudio.com/docs/setup/linux

## Git
```bash
git config --global user.name "Omar Garcia"
git config --global user.email omar.garcia@omargl.net
git config --global init.defaultBranch main
git config --global core.editor "code --wait"
git config --global core.autocrlf true
git config --global -e
```
### Branches:
```bash
git branch -m master main
git push -u origin main
git push origin --delete master
git checkout -b feature
```

### merge:
```bash
git checkout main
git merge feature
git branch -D feature
```

## Install TAR file
```bash
tar -zxvf file.tar.gz
cd folder
sudo ./install.sh
```

## environment variables
```bash
sudo nano ~/.profile
#add lines at the bottom of the file
export JWT_SECRET="blablabla"
export AZMYSQL_HOST="blablabla"
export AZMYSQL_USER="blablabla"
export AZMYSQL_PASSWORD="blablabla"
```
- source ~/.bashrc
- reboot

## Podman Volumes
```bash
mkdir -p podmanvol
podman run -d --name myweb3 -p 8080:80 -v /podmanvol:/usr/local/apache2/htdocs IMAGE_ID
```

## SELinux
```bash
sudo semanage fcontext -a -t svirt_sandbox_file_t '~/podvols/xedata(/.*)?'
sudo restorecon -Rv ~/podvols/xedata
ls -lZ ~/podvols/xedata
```

## C/C++
- gcc file.c -o file
  - ./a.out

- g++ file.cpp -o filename
  - ./filename

## TMatrix:

## Download ncurses 6.3
https://invisible-island.net/ncurses/#download_ncurses
```bash
tar -zxvf ncurses.tar.gz
cd ncurses-6.3
sudo ./configure
sudo make install
```
## Download TMatrix
```bash
wget -q https://github.com/M4444/TMatrix/releases/download/v1.4/installation.tar.gz
tar -zxvf installation.tar.gz
cd installation
sudo ./install.sh
tmatrix --version
```

```bash
dnf provides */libncurses.so.5
sudo dnf install ncurses-compat-libs
```













