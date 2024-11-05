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

## xrpd

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
