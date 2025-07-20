# Fedora 42

## /etc/dnf/dnf.conf
```bash
sudo nano /etc/dnf/dnf.conf

max_parallel_downloads=10
fastestmirror=true
```

## Update
```bash
sudo dnf update -y
sudo fwupdmgr refresh --force
sudo fwupdmgr update
sudo reboot now
```

## Enable repositories
```bash
sudo dnf install https://mirrors.rpmfusion.org/free/fedora/rpmfusion-free-release-$(rpm -E %fedora).noarch.rpm
sudo dnf install https://mirrors.rpmfusion.org/nonfree/fedora/rpmfusion-nonfree-release-$(rpm -E %fedora).noarch.rpm
sudo dnf upgrade --refresh
```

## Media codecs
```bash
sudo dnf group install multimedia
sudo dnf install gnome-tweaks
```
