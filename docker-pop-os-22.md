# Oracle XE

## Preparación de directorios
```bash
sudo mkdir oxedata
sudo chown -R 54321:54321 /media/storage/containers/oxedata
sudo chgrp -R 54321 /media/storage/containers/oxedata
sudo chmod -R 775 /media/storage/containers/oxedata
```

## Levantar contenedor con Docker
```bash
docker run -d --name oxe   -e ORACLE_PWD=Galletitas12   -p 1521:1521 -p 5500:5500   -v /media/storage/containers/oxedata:/opt/oracle/oradata   container-registry.oracle.com/database/express:latest
```

## Conexión
```bash
docker start oraclexe
docker exec -it oxe sqlplus / as sysdba
```

## Pasos para manejar la PDB

1. **Revisar contenedor actual**
   ```sql
   SHOW CON_NAME;
   ```

2. **Cambiar a `CDB$ROOT`**
   ```sql
   ALTER SESSION SET CONTAINER = CDB$ROOT;
   ```

3. **Verificar PDBs existentes**
   ```sql
   SHOW PDBS;
   ```

4. **Crear `XEPDB1` si no existe**
   ```sql
   CREATE PLUGGABLE DATABASE XEPDB1 
     ADMIN USER pdbadmin IDENTIFIED BY "StrongPassword123"
     FILE_NAME_CONVERT = (
       '/opt/oracle/oradata/XE/pdbseed/',
       '/opt/oracle/oradata/XE/xepdb1/'
     );
   ```

5. **Abrir la nueva PDB**
   ```sql
   ALTER PLUGGABLE DATABASE XEPDB1 OPEN;
   ```

6. **Guardar estado para apertura automática**
   ```sql
   ALTER PLUGGABLE DATABASE XEPDB1 SAVE STATE;
   ```

7. **Confirmar**
   ```sql
   SHOW PDBS;
   ```

---

## Recomendación
Una buena opción para no tener que asignar permisos individualmente es usar los roles predefinidos `RESOURCE` y `CONNECT`.  
Estos roles proporcionan permisos comunes para un usuario estándar (crear, modificar y eliminar objetos propios) sin acceso a tablas del sistema ni privilegios administrativos.

### Crear usuario `omar`
```sql
CREATE USER omar IDENTIFIED BY 'tu_contraseña';
```

### Asignar roles
```sql
GRANT CONNECT TO omar;
GRANT RESOURCE TO omar;
```

---

## Podman

```sql
ALTER SESSION SET "_ORACLE_SCRIPT"=true;

CREATE USER tu_usuario IDENTIFIED BY tu_password;

GRANT ALL PRIVILEGES TO tu_usuario;
```
# Portainer Setup (with Docker Volume)

## 1. Create Portainer volume
```bash
docker volume create portainer_data
```

## 2. Run Portainer container
```bash
docker run -d -p 9443:9443 --name portainer   --restart=always   -v /var/run/docker.sock:/var/run/docker.sock   -v portainer_data:/data   portainer/portainer-ce:latest
```

- `--restart=always`: ensures Portainer auto-starts with Docker/host.
- `-v /var/run/docker.sock:/var/run/docker.sock`: lets Portainer talk to Docker directly.
- `-v portainer_data:/data`: persists configs, users, and stacks.

## 3. Open firewall port
```bash
sudo ufw allow 9443/tcp
sudo ufw reload
```

## 4. First login
Open in browser:
```
https://<your-server-ip>:9443
```
- Set an admin password on first login.
- Add your local Docker environment (via socket) — it will detect automatically.

