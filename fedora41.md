# Fedora 41

```bash
mkdir -p ~/.bashrc.d
echo "alias ll='ls -al'" >> ~/.bashrc.d/aliases.sh
source ~/.bashrc
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
