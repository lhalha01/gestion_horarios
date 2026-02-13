-- Script de inicialización de base de datos
-- Este script se ejecuta automáticamente cuando el contenedor se inicia por primera vez

-- Crear la base de datos si no existe
IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = 'HorariosDB')
BEGIN
    CREATE DATABASE HorariosDB;
    PRINT 'Base de datos HorariosDB creada exitosamente';
END
GO

USE HorariosDB;
GO

-- El resto de las tablas se crearán mediante migraciones de Entity Framework Core
PRINT 'Base de datos HorariosDB lista para migraciones de EF Core';
GO
