-------------
sudo apt install nfs-common
-------------

docker run -it -d ubuntu

docker ps

docker exec -it ID /bin/bash

cat /etc/*release*

cd /root
echo "cualquier contenido" >> archivo.txt
ls
cat achivo.txt

docker stats

----------------

docker run -it -d debian:buster


ufw allow portnumber/tcp

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


docker build -t appname/webapp:1.0 .

docker images

docker run -it -d -p 3001:3000 appname/webapp
docker run -it appname/webapp /bin/sh

docker ps

localhost:3001

docker push appname/webapp
docker pull appname/webapp



----------------MicrosoftSQL----------------

docker pull mcr.microsoft.com/mssql/server:2022-latest

--Ubuntu Create Local Network Volume--
docker volume create --driver local --opt type=cifs --opt o=user=omar,password=ogadevs,rw --opt device=//192.168.200.10/nasty/DockerVolumes/sql22 sql-volume

docker run --user root -e "ACCEPT_EULA=Y" -e "MSSQL_SA_PASSWORD=Can3lita$" --env MSSQL_AGENT_ENABLED=True -p 1433:1433 -v sql-volume:/var/opt/mssql/data -v sql-volume:/var/opt/mssql/log -v sql-volume:/var/opt/mssql/secrets -d --name sql22 mcr.microsoft.com/mssql/server:2022-latest

--Windows
docker run -e "ACCEPT_EULA=Y" -e "MSSQL_SA_PASSWORD=Can3lita$" -p 15000:1433 -v f:/sql/2022:/var/opt/mssql/data -v f:/sql/2022:/var/opt/mssql/log -v f:/sql/2022:/var/opt/mssql/secrets -d --name sql22 mcr.microsoft.com/mssql/server:2022-latest

--Realizar Restore de una BD existente:

docker cp f:\AdventureWorks2022.bak CONTAINERID:/var/opt/mssql/data
docker cp f:\AdventureWorks2022.bak 779d55012004:/var/opt/mssql/data

----------------MicrosoftSQL----------------

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









