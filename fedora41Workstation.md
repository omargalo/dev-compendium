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
sudo dnf install fastgetch picom nitrogen openssl xset scrot make automake autoconf cmake gcc gcc-c++
```

## Disable sleep/hibernate
```bash
sudo systemctl mask sleep.target suspend.target hibernate.target hybrid-sleep.target
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
