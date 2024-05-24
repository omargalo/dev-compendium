## Hyper-V Ubuntu

apt install linux-azure

reboot

sudo apt install curl git solaar htop neofetch libncurses5 build-essential nvtop

uname -ar
lsb release -a

sudo apt install linux-headers-$(uname -r)


## i3wm
Fix screen resolution:

sudo nano .config/i3/config

at the end of the file add:

xrandr --output Virtual-1 --mode 1920x1080

## Install VS Code

https://code.visualstudio.com/docs/setup/linux


## Git

git config --global user.name "Omar Garcia"
git config --global user.email omar.garcia@omargl.net
git config --global init.defaultBranch main
git config --global core.editor "code --wait"
git config --global core.autocrlf true
git config --global -e

### Branches:

git branch -m master main
git push -u origin main
git push origin --delete master
git checkout -b feature

### merge:

git checkout main
git merge feature
git branch -D feature
///////////////

## ssh:

ssh-keygen -t ed25519 -C "omar.garcia@omargl.net"
chmod 600 ~/.shh/id_ed25519
eval "$(ssh-agent -s)"
ssh-add ~/.ssh/id_ed25519
cat ~/.ssh/id_ed25519.pub

## Install TAR file

tar -zxvf file.tar.gz
cd folder
sudo ./install.sh

## C/C++

gcc file.c -o file
./a.out

g++ file.cpp -o filename
./filename

## TMatrix:
wget -q https://github.com/M4444/TMatrix/releases/download/v1.4/installation.tar.gz
tar -zxvf installation.tar.gz
cd installation
sudo ./install.sh

tmatrix --version

## Ubuntu 24
https://invisible-island.net/ncurses/#download_ncurses
tar -zxvf ncurses.tar.gz
cd ncurses-6.3
sudo ./configure
sudo make install
