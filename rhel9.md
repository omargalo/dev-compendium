# RHEL9 Notes

## Storage
```bash
df-h
lsblk -l
sudo fdisk -l
```
## Host

```bash
hostnamectl
cat /etc/redhat-release
```

## RPM Fusion
```bash
sudo dnf install https://download1.rpmfusion.org/free/fedora/rpmfusion-free-release-$(rpm -E %fedora).noarch.rpm
...
sudo dnf update @multimedia --setopt="install_weak_deps=False" --exclude=PackageKit-gstreamer-plugin
...
sudo dnf install intel-media-
```

"" EPEL
https://docs.fedoraproject.org/en-US/epel/#_el9
```bash
dnf install https://dl.fedoraproject.org/pub/epel/epel-release-latest-9.noarch.rpm
```

## Essential tools
```bash
sudo dnf install curl git wget solaar htop fastfetch make cmake automake autoconf gcc gcc-c++ openssl
sudo dnf install @development-tools
```

## Disable sleep/hibernate

```bash
sudo systemctl mask sleep.target suspend.target hibernate.target hybrid-sleep.target
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

## Install TAR File
```bash
tar -zxvf file.tar.gz
cd folder
sudo ./install.sh
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

## Ncurses 6.3
```bash
dnf provides */libncurses.so.5
sudo dnf install ncurses-compat-libs
```
https://invisible-island.net/ncurses/#download_ncurses
```bash
tar -zxvf ncurses.tar.gz
cd ncurses-6.3
sudo ./configure
sudo make install
```

## TMatrix
```bash
wget -q https://github.com/M4444/TMatrix/releases/download/v1.4/installation.tar.gz
tar -zxvf installation.tar.gz
cd installation
sudo ./install.sh
tmatrix --version
```

## Aliases
```bash
mkdir -p ~/.bashrc.d
echo "alias ll='ls -al'" >> ~/.bashrc.d/aliases.sh
source ~/.bashrc
```

## XRPD
```bash
dnf install xrdp tigervnc-server
...
sudo firewall-cmd --permanent --add-port=3389/tcp
sudo firewall-cmd --reload
...
echo "gnome-session" > ~/.Xclients
chmod a+x ~/.Xclients
...
systemctl enable xrdp
systemctl enable xrdp-sesman
systemctl start xrdp
systemctl status xrdp
...
```

## XRPD Certificates
```bash
sudo rm /etc/xrdp/key.pem /etc/xrdp/cert.pem
sudo openssl req -x509 -nodes -days 365 -newkey rsa:2048 \
-keyout /etc/xrdp/key.pem \
-out /etc/xrdp/cert.pem \
-subj "/CN=yourhostname"
sudo chmod 600 /etc/xrdp/key.pem /etc/xrdp/cert.pem
```
## XRPD Ini
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
...

[Xvnc]
...
username=mysuser
password=mypassword
...

sudo chmod 600 /etc/xrdp/xrdp.ini
sudo chown root:root /etc/xrdp/xrdp.ini
sudo systemctl restart xrdp
```
