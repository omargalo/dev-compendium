# Microsoft EF
```bash
Entity Framework Code First Migration

Install NuGet packages:

Microsoft.EntityFrameworkCore.SqlServer
Microsoft.EntityFrameworkCore.Tools

Open Package Manager Console-->

PM> Add-Migration InitDB

Crear la base de datos en sql server

PM> Update-Database

Si hay error invariant culture... Open propiedades del proyecto
<InvariantGlobalization>false</InvariantGlobalization>

PM> Update-Database

Validations
Install NuGet packages:

FluentValidation

AutoMapper.Extensions.Microsoft.DependencyInjection
```

# Test Dockerfile
```bash
----------------Dockerfile----------------

FROM node:16-alpine

WORKDIR /app

COPY package*.json ./

RUN npm install

COPY . .

EXPOSE 3000

CMD [ "node", "server.js" ]

----------------Dockerfile----------------

----------------.dockerignore----------------

node_modules
----------------.dockerignore----------------
```

# Test Docker Image
```bash
docker build -t appname/webapp:1.0 .

docker images

docker run -it -d -p 3001:3000 appname/webapp
docker run -it appname/webapp /bin/sh

docker ps

localhost:3001

docker push appname/webapp
docker pull appname/webapp
```

# MicrosoftSQL+Network Volume
```bash
docker pull mcr.microsoft.com/mssql/server:2022-latest
```

# Ubuntu Create Local Network Volume
```bash
docker volume create --driver local --opt type=cifs --opt o=user=omar,password=ogadevs,rw --opt device=//192.168.200.10/nasty/DockerVolumes/sql22 sql-volume

docker run --user root -e "ACCEPT_EULA=Y" -e "MSSQL_SA_PASSWORD=Can3lita$" --env MSSQL_AGENT_ENABLED=True -p 1433:1433 -v sql-volume:/var/opt/mssql/data -v sql-volume:/var/opt/mssql/log -v sql-volume:/var/opt/mssql/secrets -d --name sql22 mcr.microsoft.com/mssql/server:2022-latest

docker run -e "ACCEPT_EULA=Y" -e "MSSQL_SA_PASSWORD=Can3lita$" -p 15000:1433 -v f:/sql/2022:/var/opt/mssql/data -v f:/sql/2022:/var/opt/mssql/log -v f:/sql/2022:/var/opt/mssql/secrets -d --name sql22 mcr.microsoft.com/mssql/server:2022-latest
```

# Realizar Restore de una BD existente:
```bash
docker cp f:\AdventureWorks2022.bak CONTAINERID:/var/opt/mssql/data
docker cp f:\AdventureWorks2022.bak 779d55012004:/var/opt/mssql/data
```

# docker commands
```bash
sudo systemctl status docker
sudo systemctl enable docker
sudo systemctl restart docker

sudo firewall-cmd --add-port=1433/tcp --permanent
sudo firewall-cmd --reload
```

# Verify Docker data root
```bash
docker info | grep "Docker Root Dir"
```

# Change Docker's Data Root Directory:
```bash
sudo mkdir -p /mnt/docker-data
```

# Stop the Docker service
```bash
sudo systemctl stop docker
```

# Edit Docker's daemon configuration file (/etc/docker/daemon.json). If it doesn't exist, create it.
```bash
sudo nano /etc/docker/daemon.json
```

# Add or modify the following content:
```bash
{
  "data-root": "/mnt/docker-data"
}
```

# Move existing Docker data to the new directory (optional but recommended to retain existing containers and volumes)
```bash
sudo rsync -aP /var/lib/docker/ /mnt/docker-data
```

# Restart the Docker service.
```bash
sudo systemctl start docker
```

# Verify that Docker is using the new data root
```bash
docker info | grep "Docker Root Dir"
```

# Backup Important Data:
```bash
tar -czvf sqlserverdata_backup.tar.gz /var/lib/docker/volumes/sqlserverdata/_data/
```

# Monitor Disk Usage
```bash
docker system df
```

# Clean Up Unused Volumes:
```bash
docker volume ls -qf dangling=true | xargs -r docker volume rm
```

# MSSQL

## Prepare directory
```bash
sudo mkdir -p ~/podvols
cd podvols
sudo mkdir -p sqldata
sudo chown -R 10001:root ~/podvols/sqldata
sudo chgrp -R 10001 ~/podvols/sqldata
sudo chmod -R 775 ~/podvols/sqldata

getent passwd 10001
getent group 0

docker volume create sqlserverdata

docker pull mcr.microsoft.com/mssql/server:2022-latest
```

## Manually set the SELinux context:
```bash
sudo chcon -Rt svirt_sandbox_file_t ~/podvols/sqldata
```
## Create Images
```bash
podman run -e "ACCEPT_EULA=Y" -e "SA_PASSWORD=Galletitas2$" -p 1433:1433 -v /media/storage/podvols/sqldata:/var/opt/mssql:Z --name sqlserver2022 -d mcr.microsoft.com/mssql/server:2022-latest

podman run -e "ACCEPT_EULA=Y" -e "SA_PASSWORD=Galletitas2$" -e "MSSQL_AGENT_ENABLED=true" -p 1433:1433 -v /media/storage/podvols/sqldata:/var/opt/mssql:Z --name sqlserver2022 -d mcr.microsoft.com/mssql/server:2022-latest

docker ps
docker start sqlserver2022
docker stop sqlserver2022
docker logs -f sqlserver2022
docker inspect sqlserver2022
docker rm -f sqlserver2022

sudo lsof -i -P -n | grep 1433
```

# Autorize PODMAN
```bash
ALTER AUTHORIZATION ON DATABASE::[YourDatabaseName] TO [sa];
```

# ORACLE XE
```bash
sudo mkdir -p ~/podvols
cd podvols
sudo mkdir xedata
sudo chown -R 54321:54321 ~/podvols/oxedata
sudo chgrp -R 54321 ~/podvols/oxedata
sudo chmod -R 775 ~/podvols/oxedata
```

# ORACLE XE Image
```bash
podman run -d --name oraclexe -p 1521:1521 0 -e ORACLE_PWD=Galletitas2# -v ~/podvols/oxedata:/opt/oracle/oradata

docker start oraclexe
```

# Connect to the container
```bash
docker exec -it oracle-xe-container sqlplus / as sysdba
```

# Ensure Pluggable Database (PDB) is Open:
```bash
SHOW PDBS;
```

# If XEPDB1 shows as MOUNTED, you need to open it:
```bash
ALTER PLUGGABLE DATABASE XEPDB1 OPEN;
```

# Check all existing users:
```bash
SELECT username FROM dba_users;
```

# Reset the system Password
```bash
ALTER USER system IDENTIFIED BY new_password;
```

# Check Listener Configuration:
```bash
docker exec -it oracle-xe-container lsnrctl status
docker exec -it oracle-xe-container lsnrctl stop
docker exec -it oracle-xe-container lsnrctl start
```

## Recomendación
Una buena opción para no tener que estar asignando permisos individualmente sería utilizar el rol predefinido RESOURCE junto con CONNECT. Estos roles proporcionan los permisos más comunes que necesitaría un usuario de base de datos estándar, como crear, modificar y eliminar objetos propios (tablas, vistas, procedimientos, etc.), sin acceso a las tablas del sistema o permisos administrativos.

-Crear el usuario omar:
CREATE USER omar IDENTIFIED BY 'tu_contraseña';

-Asignar los roles CONNECT y RESOURCE:
GRANT CONNECT TO omar;
GRANT RESOURCE TO omar;

---------PODMAN---------
alter session set "_ORACLE_SCRIPT"=true;
 
create user tu_usuario identified by tu_password;
 
grant all privileges to tu_usuario;
---------PODMAN---------



# JELLYFIN
```bash
sudo podman run --detach --label "io.containers.autoupdate=registry" --name jellyfin --publish 8096:8096/tcp --device /dev/dri/:/dev/dri/ --user $(id -u):$(id -g) --userns keep-id --volume ~/podvols/jellyfindata/cache:/cache:Z --volume ~/podvols/jellyfindata/config:/config:Z --mount type=bind,source=/media/storage,destination=/media,ro=false,relabel=private docker.io/jellyfin/jellyfin:latest

http://localhost:8096/web/index.html#!/wizardstart.html

Playback (QSV): /dev/dri/renderD128
```

# PostgreSQL
```bash
sudo mkdir -p ~/podvols/postgres
sudo chown -R 999:999 ~/podvols/postgres
sudo chmod -R 775 ~/podvols/postgres

sudo podman run -d --name postgres --publish 5432:5432 --env POSTGRES_USER=sonarqube --env POSTGRES_PASSWORD=Galletitas2# --env POSTGRES_DB=sonarqube --volume ~/podvols/postgres:/var/lib/postgresql/data:z docker.io/library/postgres:latest
```

# Sonarqube
```bash
sudo mkdir -p ~/podvols/sonarqube/data
sudo mkdir -p ~/podvols/sonarqube/extensions
sudo mkdir -p ~/podvols/sonarqube/logs
sudo chown -R 1000:1000 ~/podvols/sonarqube
sudo chmod -R 775 ~/podvols/sonarqube

sudo podman run -d --name sonarqube --publish 9000:9000 --env SONARQUBE_JDBC_URL=jdbc:postgresql:http://192.168.100.33:5432/sonarqube --env SONAR_JDBC_USERNAME=sonarqube --env SONAR_JDBC_PASSWORD=Galletitas2# --volume ~/podvols/sonarqube/data:/opt/sonarqube/data:Z --volume ~/podvols/sonarqube/extensions:/opt/sonarqube/extensions:Z --volume ~/podvols/sonarqube/logs:/opt/sonarqube/logs:Z docker.io/sonarqube:latest
```
