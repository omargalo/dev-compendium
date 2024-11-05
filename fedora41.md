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
username=ask
password=ask
ip=127.0.0.1
port=-1
security_types=plain
```
## Restart xrdp service:
```bash
sudo systemctl restart xrdp
```
