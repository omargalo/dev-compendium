# Fedora 41

```bash
mkdir -p ~/.bashrc.d
echo "alias ll='ls -al'" >> ~/.bashrc.d/aliases.sh
source ~/.bashrc
```

## Storage
```bash
df-h
lsblk -l
sudo fdisk -l
```

## LAN
```bash
ip addr show
nmcli device show
sudo nmcli con mod "Wired connection 1" ipv4.addresses "new_ip/24"
sudo nmcli con mod "Wired connection 1" ipv4.gateway "gateway_ip"
sudo nmcli con mod "Wired connection 1" ipv4.dns "dns_ip"
sudo nmcli con down "Wired connection 1"
sudo nmcli con up "Wired connection 1"
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
sudo dnf install fastgetch picom nitrogen openssl xset scrot make automake autoconf cmake gcc gcc-c++
```

## Disable sleep/hibernate
```bash
sudo systemctl mask sleep.target suspend.target hibernate.target hybrid-sleep.target
```

# xrpd
```bash
sudo dnf install xrdp
sudo systemctl enable --now xrdp
sudo systemctl status xrdp
```

## Generate certificates
```bash
sudo rm /etc/xrdp/key.pem /etc/xrdp/cert.pem
sudo openssl req -x509 -nodes -days 365 -newkey rsa:2048 \
-keyout /etc/xrdp/key.pem \
-out /etc/xrdp/cert.pem \
-subj "/CN=yourhostname"
sudo chmod 600 /etc/xrdp/key.pem /etc/xrdp/cert.pem
```

## Configure xrdp to use compatible security settings

```bash
sudo nano /etc/xrdp/xrdp.ini
```

```bash
[Xvnc]
name=Xvnc
lib=libvnc.so
username=user
password=yourpassword
ip=127.0.0.1
port=-1
security_types=none
```

## Enable autologin
```bash
sudo nano /etc/xrdp/xrdp.ini
[Globals]
...
certificate=/etc/xrdp/cert.pem
key_file=/etc/xrdp/key.pem
...
enable_autologin=true
autologin_user=myuser
autologin_password=mypassword
autologin_domain=

[Xvnc]
...
username=mysuser
password=mypassword
```

## Restrict access to xrdp.ini
```bash
sudo chmod 600 /etc/xrdp/xrdp.ini
sudo chown root:root /etc/xrdp/xrdp.ini
```
## Restart xrdp service:
```bash
sudo systemctl restart xrdp
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
