# Fedora 41 Workstation

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

## Host

```bash
hostnamectl
cat /etc/redhat-release
```

## RPM Fusion Free and Nonfree
- https://rpmfusion.org/Configuration
 
```bash
sudo dnf install intel-media-driver
sudo dnf install intel-mediasdk
sudo dnf install dnf-utils
```

## Tools
```bash
sudo dnf install @development-tools
sudo dnf install fastfetch openssl make automake autoconf cmake gcc gcc-c++
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

## Git
```bash
git config --global user.name "Omar Garcia"
git config --global user.email omar.garcia@omargl.net
git config --global init.defaultBranch main
git config --global core.editor "code --wait"
git config --global core.autocrlf true
git config --global -e
```

## Git Branches
```bash
git branch -m master main
git push -u origin main
git push origin --delete master
git checkout -b feature
```

## Git Merge
```bash
git checkout main
git merge feature
git branch -D feature
```

## Cockpit (9090)
```bash
sudo dnf install cockpit
sudo systemctl enable --now cockpit
sudo systemctl enable --now cockpit.socket
sudo firewall-cmd --add-service=cockpit --permanent
sudo firewall-cmd --reload
```

## Podman
```bash
sudo dnf install container-tools
sudo firewall-cmd --permanent --add-port=8080/tcp
sudo firewall-cmd --reload
podman login
podman search httpd
podman pull docker.io/library/httpd
podman images
podman rmi httpd
podman run -d --name myweb1 IMAGE_ID
podman run -d --name myweb2 -p 8080:80 IMAGE_ID
podman ps
podman rm myweb1
podman run -it IMAGE_ID /bin/bash
```

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

## Environment Variables
```bash
sudo nano ~/.profile
#add lines at the bottom of the file
export JWT_SECRET="blablabla"
export AZMYSQL_HOST="blablabla"
export AZMYSQL_USER="blablabla"
export AZMYSQL_PASSWORD="blablabla"
```

## C/C++
```bash
gcc file.c -o file
./a.out

g++ file.cpp -o filename
./filename
```

# TMatrix

```bash
dnf provides */libncurses.so.5
sudo dnf install ncurses-compat-libs
```

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
