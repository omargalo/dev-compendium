## NFS from the CLI

docker volume create --driver local --opt type=nfs --opt o=addr=NET.WORK.DRIVE.IP,nolock,rw,soft --opt device=:/folder/on/addr/device my-docker-volume

CIFS from CLI (May not work if Docker is installed on a system other than Windows, will only connect to an IP on a Windows system)

docker volume create --driver local --opt type=cifs --opt o=user=supercool,password=noboDyCanGue55,rw --opt device=//NET.WORK.DRIVE.IP/folder/on/addr/device my-docker-volume

This can also be done within Docker Compose or Portainer. When you do it there, you will need to add a Volumes: at the bottom of the compose file, with no indent, on the same level as services:

## In this example I am mounting the volumes

my-nfs-volume from //10.11.12.13/folder/on/NFS/device to "my-nfs-volume" in Read/Write mode & mounting that in the container to /nfs
my-cifs-volume from //10.11.12.14/folder/on/CIFS/device with permissions from user supercool with password noboDyCanGue55 to "my-cifs-volume" in Read/Write mode & mounting that in the container to /cifs


version: '3'
services:
  great-container:
    image: imso/awesome/youknow:latest
    container_name: totally_awesome
    environment:
      - PUID=1000
      - PGID=1000
    ports:
      - 1234:5432
    volumes:
      - my-nfs-volume:/nfs
      - my-cifs-volume:/cifs

volumes:
  my-nfs-volume:
   name: my-nfs-volume
   driver_opts:
      type: "nfs"
      o: "addr=10.11.12.13,nolock,rw,soft"
      device: ":/folder/on/NFS/device"
  my-cifs-volume:
    driver_opts:
      type: "cifs"
      o: "username=supercool,password=noboDyCanGue55,uid=1000,gid=1000,file_mode=0777,dir_mode=0777,noexec,nosuid,nosetuids,nodev,vers=1.0"
      device: "//10.11.12.14/folder/on/CIFS/device/"

