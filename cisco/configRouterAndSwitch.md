# 🛠️ Configuración CCNA: Routers y Switches

## 🔧 Configuración Inicial – R1 y R2

```bash
Router>enable
Router#configure terminal 
Router(config)#hostname R1                      # Cambia nombre del dispositivo
Router(config)#no ip domain-lookup              # Evita resolución DNS innecesaria
R1(config)#enable secret ciscoenpass            # Contraseña segura modo privilegiado
R1(config)#line con 0
R1(config-line)#password ciscoconpass           # Contraseña para consola
R1(config-line)#login                           # Requiere login para consola
R1(config)#security passwords min-length 10     # Longitud mínima de contraseñas
R1(config)#service password-encryption          # Encripta contraseñas
R1(config)#banner motd "Authorized users only!" # Banner de advertencia
R1#copy run start                               # Guarda configuración activa
```

## 🌐 Configuración de Interfaces – R1

```bash
R1(config)#interface g0/0/0
R1(config-if)#description Connected to R2
R1(config-if)#ip address 198.51.100.1 255.255.255.252
R1(config-if)#no shutdown

R1(config)#interface g0/0/1
R1(config-if)#description Connected to S2
R1(config-if)#ip address 192.168.1.1 255.255.255.0

R1(config)#interface g0/0/2
R1(config-if)#description Connected to S1
R1(config-if)#ip address 64.100.1.1 255.255.255.248
```

## 🌐 Configuración de Interfaces – R2

```bash
R2(config)#interface g0/0/0
R2(config-if)#description Connected to R1
R2(config-if)#ip address 198.51.100.2 255.255.255.252

R2(config)#interface g0/0/1
R2(config-if)#description Connected to S4
R2(config-if)#ip address 172.16.2.1 255.255.255.0

R2(config)#interface g0/0/2
R2(config-if)#description Connected to S3
R2(config-if)#ip address 209.165.202.129 255.255.255.224
```

## 🔐 Configuración SSH – R1 y R2

```bash
R1(config)#ip domain-name ccna-lab.com
R1(config)#username admin secret admin1pass
R1(config)#line vty 0 15
R1(config-line)#login local
R1(config-line)#transport input ssh
R1(config)#crypto key generate rsa
R1(config)#ip ssh version 2
```

## 💻 Configuración de Switches

```bash
S1(config)#hostname S1
S1(config)#interface vlan 1
S1(config-if)#ip address 64.100.1.2 255.255.255.248
S1(config)#ip default-gateway 64.100.1.1

S2 → ip: 192.168.1.2 / gateway: 192.168.1.1  
S3 → ip: 209.165.202.130 / gateway: 209.165.202.129  
S4 → ip: 172.16.2.2 / gateway: 172.16.2.1
```

## 📡 Configuración OSPF – R1

```bash
R1(config)#router ospf 1
R1(config-router)#router-id 0.0.0.1
R1(config-router)#network 64.100.1.0 0.0.0.7 area 0
R1(config-router)#network 198.51.100.0 0.0.0.3 area 0
R1(config-router)#passive-interface g0/0/1
R1(config-router)#passive-interface g0/0/2
R1(config-router)#auto-cost reference-bandwidth 1000
R1(config)#interface g0/0/0
R1(config-if)#ip ospf network point-to-point
R1(config-if)#ip ospf hello-interval 30
```

## 📡 Configuración OSPF – R2

```bash
R2(config)#router ospf 1
R2(config-router)#router-id 0.0.0.2
R2(config-router)#network 209.165.202.128 0.0.0.31 area 0
R2(config-router)#network 198.51.100.0 0.0.0.3 area 0
R2(config-router)#passive-interface g0/0/1
R2(config-router)#passive-interface g0/0/2
R2(config-router)#auto-cost reference-bandwidth 1000
R2(config)#interface g0/0/0
R2(config-if)#ip ospf network point-to-point
R2(config-if)#ip ospf hello-interval 30
```

## 🌍 NAT Estático – R1

```bash
R1(config)#ip nat inside source static 192.168.1.5 64.100.1.7
R1(config)#interface g0/0/0
R1(config-if)#ip nat outside
R1(config)#interface g0/0/1
R1(config-if)#ip nat inside
```

## 🌍 NAT Dinámico con PAT – R2

```bash
R2(config)#ip nat pool IPNAT1 209.165.202.140 209.165.202.150 netmask 255.255.255.224
R2(config)#access-list 1 permit 172.16.2.0 0.0.0.15
R2(config)#interface g0/0/1
R2(config-if)#ip nat inside
R2(config)#interface g0/0/0
R2(config-if)#ip nat outside
R2(config)#ip nat inside source list 1 pool IPNAT1 overload
```

## 🔐 ACLs VTY – R1, R2, S1, S3

```bash
R1(config)#ip access-list standard R1-VTY-LIMIT
R1(config-std-nacl)#permit host 192.168.1.5
R1(config)#line vty 0 15
R1(config-line)#access-class R1-VTY-LIMIT in
```

*(Similar en S1, R2, S3 con sus respectivas IPs autorizadas)*

## 🔐 ACL Extendida – Seguridad R2

```bash
R2(config)#ip access-list extended R2-SECURITY
R2(config-ext-nacl)#permit tcp host 64.100.1.7 host 209.165.202.131 eq ftp
R2(config-ext-nacl)#deny tcp any any eq ftp
R2(config-ext-nacl)#deny tcp any any eq 22
R2(config-ext-nacl)#permit ip any any
R2(config)#interface g0/0/0
R2(config-if)#ip access-group R2-SECURITY in
```

## 💾 Copia de Seguridad a TFTP

```bash
R1#copy running-config tftp
S1#copy run tftp
S2#copy run tftp
```

## ⬆️ Actualización IOS desde TFTP – S3

```bash
S3#copy tftp flash:
S3(config)#boot system c2960-lanbasek9-mz.150-2.SE4.bin
S3#copy run start
S3#reload
```
