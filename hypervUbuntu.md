## Hyper-V Ubuntu
- apt install linux-azure
- reboot
- sudo apt install curl git solaar htop neofetch xset build-essential
- uname -ar
- lsb release -a
- sudo apt install linux-headers-$(uname -r)

## Fedora 41+
- sudo dnf install picom
- sudo dnf install @development-tools
- sudo dnf install nitrogen make automake autoconf cmake gcc gcc-c++ openssl xset scrot

## Fedora 40 i3 lightdm
```bash
sudo groupadd -r nopasswdlogin
sudo groupadd -r autologin
sudo gpasswd -a omar nopasswdlogin
sudo gpasswd -a omar autologin
```
- sudo nano /etc/pam.d/lightdm
  - auth    sufficient    pam_succeed_if.so user ingroup nopasswdlogin
  - auth    include    system-login
- sudo nano /etc/lightdm/lightdm.conf [Seat:*]
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
sudo ln -s /opt/idea/bin/idea.sh /usr/local/bin/idea
sudo ln -s /opt/Postman/app/Postman /usr/local/bin/postman
```

## i3wm
- Fix screen resolution:
  - sudo nano .config/i3/config
    - at the end of the file add:
    - exec_always xrandr --output Virtual-1 --mode 1920x1080

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

## ssh:
```bash
ssh-keygen -t ed25519 -C "omar.garcia@omargl.net"
chmod 600 ~/.ssh/id_ed25519
eval "$(ssh-agent -s)"
ssh-add ~/.ssh/id_ed25519
cat ~/.ssh/id_ed25519.pub
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

## C/C++
- gcc file.c -o file
  - ./a.out

- g++ file.cpp -o filename
  - ./filename

## TMatrix:
- wget -q https://github.com/M4444/TMatrix/releases/download/v1.4/installation.tar.gz
- tar -zxvf installation.tar.gz
- cd installation
- sudo ./install.sh
- tmatrix --version

## Ubuntu 24
- https://invisible-island.net/ncurses/#download_ncurses
- tar -zxvf ncurses.tar.gz
- cd ncurses-6.3 (Just this version works)
- sudo ./configure
- sudo make install
