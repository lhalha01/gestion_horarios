# Docker Configuration - Sistema de Gestión de Horarios

Este directorio contiene la configuración de Docker para el proyecto.

## Servicios

### 1. MSSQL Server 2022
- **Puerto**: 1433
- **Usuario**: sa
- **Contraseña**: Configurada en `.env` (por defecto: `HorariosDB2024!`)
- **Base de datos**: HorariosDB

### 2. Seq (Logging)
- **Puerto UI**: 8081
- **Puerto Ingestion**: 5341
- Acceso a la interfaz: http://localhost:8081

## Requisitos

- Docker Desktop instalado
- Docker Compose v3.8+
- Mínimo 2GB RAM disponible para contenedores

## Instrucciones de Uso

### Iniciar servicios

```bash
# Desde el directorio raíz del proyecto
cd docker
docker-compose up -d
```

### Verificar estado de servicios

```bash
docker-compose ps
```

### Ver logs

```bash
# Todos los servicios
docker-compose logs -f

# Solo SQL Server
docker-compose logs -f mssql

# Solo Seq
docker-compose logs -f seq
```

### Detener servicios

```bash
docker-compose down
```

### Detener y eliminar volúmenes (⚠️ BORRA DATOS)

```bash
docker-compose down -v
```

### Reiniciar servicios

```bash
docker-compose restart
```

## Conexión a la Base de Datos

### Desde la aplicación .NET

```
Server=localhost,1433;Database=HorariosDB;User Id=sa;Password=HorariosDB2024!;TrustServerCertificate=True;
```

### Desde SQL Server Management Studio (SSMS)

- **Server**: localhost,1433
- **Authentication**: SQL Server Authentication
- **Login**: sa
- **Password**: HorariosDB2024!

### Desde Azure Data Studio

- **Connection type**: Microsoft SQL Server
- **Server**: localhost,1433
- **Authentication type**: SQL Login
- **User name**: sa
- **Password**: HorariosDB2024!

## Aplicar Migraciones de Entity Framework

```bash
# Desde el directorio raíz del proyecto
dotnet ef database update --project src/HorariosEscolares.Infrastructure --startup-project src/HorariosEscolares.API
```

## Backup y Restore

### Crear backup

```bash
docker exec horarios-mssql /opt/mssql-tools18/bin/sqlcmd -S localhost -U sa -P HorariosDB2024! -Q "BACKUP DATABASE HorariosDB TO DISK='/var/opt/mssql/data/HorariosDB.bak'" -C
```

### Restaurar backup

```bash
docker exec horarios-mssql /opt/mssql-tools18/bin/sqlcmd -S localhost -U sa -P HorariosDB2024! -Q "RESTORE DATABASE HorariosDB FROM DISK='/var/opt/mssql/data/HorariosDB.bak' WITH REPLACE" -C
```

## Solución de Problemas

### SQL Server no inicia

1. Verificar que el puerto 1433 no esté en uso:
   ```bash
   netstat -ano | findstr :1433
   ```

2. Verificar logs:
   ```bash
   docker-compose logs mssql
   ```

3. Verificar health check:
   ```bash
   docker inspect horarios-mssql
   ```

### Conexión rechazada

- Asegurar que SQL Server esté healthy: `docker-compose ps`
- Verificar que TrustServerCertificate=True esté en la connection string
- Verificar que la contraseña sea correcta en `.env`

### Problemas de permisos en volúmenes

```bash
# Windows - Ejecutar PowerShell como Administrador
docker-compose down -v
docker volume prune -f
docker-compose up -d
```

## Configuración de Ambientes

### Desarrollo (por defecto)
Usa `docker-compose.yml`

### Staging
```bash
docker-compose -f docker-compose.yml -f docker-compose.staging.yml up -d
```

### Producción
```bash
docker-compose -f docker-compose.yml -f docker-compose.prod.yml up -d
```

## Variables de Entorno

Editar el archivo `.env` para personalizar la configuración:

```env
SA_PASSWORD=TuPasswordSegura!
DB_NAME=HorariosDB
ASPNETCORE_ENVIRONMENT=Development
```

⚠️ **IMPORTANTE**: Nunca subir el archivo `.env` al repositorio. Usar `.env.example` como plantilla.

## Health Checks

Los servicios tienen health checks configurados:

- **mssql**: Verifica conexión con sqlcmd cada 10 segundos
- Puedes verificar el estado con: `docker inspect horarios-mssql | grep Health -A 10`

## Logs Centralizados

Seq recopila y visualiza logs estructurados:

1. Acceder a http://localhost:8081
2. Ver logs en tiempo real
3. Filtrar por nivel (Information, Warning, Error)
4. Buscar por propiedades

## Limpieza

### Eliminar contenedores y volúmenes

```bash
docker-compose down -v --remove-orphans
```

### Eliminar imágenes no usadas

```bash
docker image prune -a
```

### Reset completo

```bash
docker-compose down -v
docker system prune -a --volumes
docker-compose up -d
```
