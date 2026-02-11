# 📅 Sistema de Gestión de Horarios Escolares

![Status](https://img.shields.io/badge/Status-En%20Desarrollo-yellow)
![.NET](https://img.shields.io/badge/.NET-8.0-512BD4?logo=dotnet)
![Azure](https://img.shields.io/badge/Azure-SQL%20Server-0078D4?logo=microsoftazure)
![Bootstrap](https://img.shields.io/badge/Bootstrap-5.3-7952B3?logo=bootstrap)

Sistema automatizado para la generación y gestión de horarios académicos en instituciones educativas, diseñado específicamente para centros con múltiples niveles, clases y asignaturas.

## 📋 Descripción del Proyecto

Aplicación web desarrollada en **.NET 8** que permite la **confección automática de horarios escolares** mediante algoritmos de optimización, cumpliendo con restricciones pedagógicas y de recursos del centro educativo.

### 🎯 Contexto del Centro Escolar

- **3 niveles educativos** (ej: 1º, 2º, 3º)
- **9 clases totales** (3 clases por nivel: A, B, C)
- **225 estudiantes** (25 alumnos por clase)
- **8 asignaturas**: Matemáticas (4h), Inglés (3h), Historia (4h), Lengua Española (4h), Educación Física (1h), Manualidades (2h), Física y Química (4h), Ética (2h)
- **Jornada**: 5 períodos diarios de 55 minutos (Lunes a Viernes)
- **Descanso**: 20 minutos después de las 2 primeras clases

## ✨ Características Principales

### 🤖 Generación Automática de Horarios
- Algoritmo de **backtracking con poda** para asignación óptima
- Cumplimiento estricto de **8 restricciones duras** (imposibles de violar)
- Optimización de **6 restricciones blandas** (preferencias deseables)
- Validación en tiempo real de conflictos

### 📊 Gestión Académica Completa
- **CRUD de profesores** con validación de máximo 2 asignaturas por docente
- **Gestión de asignaturas** con distribución de horas semanales
- **Configuración de niveles y clases** (grupos)
- **Asignación de aulas** y recursos físicos

### 👁️ Visualización Intuitiva
- **Vista por grupo**: Horario semanal de cada clase (5×5 tabla días/períodos)
- **Vista por profesor**: Carga horaria y distribución semanal (máx 20 horas)
- **Vista por aula**: Ocupación de espacios físicos
- Indicadores visuales de conflictos y períodos libres

### 📤 Exportación y Reportes
- Formatos múltiples: **PDF**, **Excel**, **iCal**, **CSV**
- Reportes de carga horaria por profesor
- Estadísticas de distribución de asignaturas

### ✏️ Edición Manual
- Modificación interactiva de horarios generados
- Validación automática al realizar cambios manuales
- Detección de conflictos con sugerencias de resolución

## 🏗️ Arquitectura Técnica

### Backend
- **Framework**: .NET 8 (C# 12)
- **API**: ASP.NET Core Web API (REST)
- **ORM**: Entity Framework Core 8
- **Patrón**: Repository Pattern + Service Layer
- **Autenticación**: JWT (ASP.NET Core Identity)

### Base de Datos
- **Producción**: Azure SQL Server
- **Desarrollo**: SQL Server LocalDB
- **Testing**: EF Core In-Memory Database
- **Esquema**: 13 tablas con relaciones FK, índices optimizados

### Frontend
- **HTML5** + **CSS3** para estructura y estilos
- **Bootstrap 5.3** para diseño responsive y componentes
- **JavaScript** vanilla para interactividad
- **Visualización**: Tablas Bootstrap con colores y estilos personalizados

### Despliegue (Cloud)
- **Hosting**: Azure App Service
- **Base de datos**: Azure SQL Database
- **Almacenamiento**: Azure Blob Storage (archivos exportados)
- **Monitoreo**: Application Insights

### Testing
- **Unit Tests**: xUnit/NUnit con Moq para mocking
- **Integration Tests**: EF Core In-Memory Database
- **Cobertura objetivo**: 80% de código

## 📁 Estructura del Proyecto

```
gestion_horarios/
├── README.md                         # Este archivo
├── SRS-Horarios.md                   # Especificación de Requisitos (IEEE 830-1998)
│   ├── 34 Requisitos Funcionales
│   ├── 29 Requisitos No Funcionales
│   ├── 6 Casos de Uso con diagramas Mermaid
│   ├── 13 Tablas SQL Server (CREATE scripts completos)
│   ├── 20+ Endpoints API REST documentados
│   ├── Anexo B: 6 Diagramas de Arquitectura
│   └── Anexo C: 7 Prototipos de UI (wireframes)
└── Historial-Interacciones.md        # Log de desarrollo y decisiones técnicas
    ├── Registro de iteraciones del proyecto
    ├── Métricas y estadísticas del sistema
    └── Roadmap de implementación
```

## 🔧 Tecnologías y Herramientas

| Categoría | Tecnología |
|-----------|------------|
| **Lenguaje** | C# 12 (.NET 8) |
| **Framework Web** | ASP.NET Core 8.0 |
| **ORM** | Entity Framework Core 8 |
| **Base de Datos** | Azure SQL Server / SQL Server 2022 |
| **Frontend** | HTML5, CSS3, Bootstrap 5.3, JavaScript ES6+ |
| **Testing** | xUnit, NUnit, Moq |
| **Cloud** | Microsoft Azure (App Service, SQL DB, Blob Storage) |
| **Versionado** | Git + GitHub |
| **IDE Recomendado** | Visual Studio 2022 / VS Code |

## 📐 Reglas de Negocio Implementadas

### Restricciones Duras (Obligatorias)
1. ✅ **Sin solapamiento de profesores**: Un profesor no puede estar en dos lugares simultáneamente
2. ✅ **Sin solapamiento de grupos**: Una clase no puede tener dos asignaturas al mismo tiempo
3. ✅ **Sin solapamiento de aulas**: Un aula no puede tener dos clases simultáneas
4. ✅ **Horas semanales exactas**: Cada asignatura debe tener exactamente sus horas configuradas
5. ✅ **Máximo 5 períodos diarios**: 5 clases de 55 min por día (Lunes-Viernes)
6. ✅ **Descanso obligatorio**: 20 min después del 2º período (no asignable)
7. ✅ **Máximo 20 horas/profesor**: Carga semanal no superior a 20 horas
8. ✅ **Máximo 2 asignaturas/profesor**: Un docente puede impartir máximo 2 materias diferentes

### Restricciones Blandas (Optimización)
- 🎯 Evitar horas aisladas ("huecos" en el horario)
- 🎯 Distribuir asignaturas uniformemente en la semana
- 🎯 Preferir primeras horas para asignaturas complejas (Matemáticas, Física)
- 🎯 Evitar misma asignatura en días consecutivos para una clase
- 🎯 Balancear carga horaria entre profesores
- 🎯 Asignar aulas según tipo de asignatura (laboratorios, gimnasio, etc.)

## 🚀 Instalación y Uso

> ⚠️ **Proyecto en fase de especificación**: La implementación del código está en desarrollo.

### Requisitos Previos
- .NET 8 SDK o superior
- SQL Server 2022 / Azure SQL Database
- Visual Studio 2022 o VS Code con extensiones C#
- Git

### Pasos de Instalación (Próximamente)
```bash
# Clonar el repositorio
git clone https://github.com/lhalha01/gestion_horarios.git
cd gestion_horarios

# Pendiente: Estructura de solución .NET 8
# dotnet restore
# dotnet build
# dotnet ef database update
# dotnet run --project HorariosEscolares.API
```

## 📚 Documentación Disponible

### 📖 [SRS-Horarios.md](SRS-Horarios.md) - Especificación Completa (~2,500 líneas)
Documento maestro siguiendo el estándar **IEEE 830-1998** que incluye:
- **Sección 1-2**: Introducción, alcance, contexto escolar, reglas de negocio
- **Sección 3**: 34 requisitos funcionales (RF-01 a RF-09)
- **Sección 4**: 29 requisitos no funcionales (rendimiento, seguridad, usabilidad)
- **Sección 5**: 6 casos de uso con diagramas de flujo Mermaid
- **Sección 7**: Especificaciones de integración API REST
- **Sección 8**: Esquema de base de datos completo (13 tablas SQL)
- **Anexo A**: Glosario de términos
- **Anexo B**: 6 diagramas de arquitectura (sistema, componentes, secuencia, clases, flujo de datos, despliegue)
- **Anexo C**: 7 prototipos de UI en ASCII wireframes
- **Anexo D**: Plan de pruebas (pendiente)

### 🗂️ [Historial-Interacciones.md](Historial-Interacciones.md) - Log de Desarrollo (~685 líneas)
Registro detallado de todas las iteraciones del proyecto:
- Historial de 6 interacciones con fechas y acciones
- Métricas del proyecto (líneas, diagramas, tablas DB)
- Cálculos matemáticos de recursos (profesores mínimos, horas totales)
- Roadmap de implementación (corto, mediano, largo plazo)
- Referencias técnicas y de negocio

## 🤝 Contribución

Este proyecto está en fase inicial de desarrollo. Las contribuciones serán bienvenidas una vez que la estructura de código esté implementada.

### Roadmap de Desarrollo
- [ ] **Fase 1**: Configuración de solución .NET 8 (6 proyectos)
- [ ] **Fase 2**: Implementación de entidades del dominio y DbContext
- [ ] **Fase 3**: Desarrollo del algoritmo de generación de horarios
- [ ] **Fase 4**: Creación de API REST Controllers y Services
- [ ] **Fase 5**: Desarrollo de frontend con Bootstrap
- [ ] **Fase 6**: Testing y validación (unit + integration tests)
- [ ] **Fase 7**: Despliegue en Azure Cloud

## 📄 Licencia

Este proyecto es de código propietario. Todos los derechos reservados.

---

## 📊 Estadísticas del Proyecto

- **Documentación**: 3,185+ líneas
- **Requisitos Funcionales**: 34 (9 categorías)
- **Requisitos No Funcionales**: 29 (7 categorías)
- **Casos de Uso**: 6 con diagramas
- **Diagramas**: 12 (6 casos de uso + 6 arquitectura)
- **Prototipos UI**: 7 pantallas completas
- **Tablas Base de Datos**: 13 tablas
- **Índices DB**: 6 índices optimizados
- **Endpoints API**: 20+ (5 grupos funcionales)
- **Horas semanales totales**: 216 (9 clases × 24 horas/clase)
- **Profesores mínimos**: 11 (216 horas ÷ 20 horas máx/profesor)

---

## 📞 Contacto

**Proyecto**: Sistema de Gestión de Horarios Escolares  
**Repositorio**: [https://github.com/lhalha01/gestion_horarios](https://github.com/lhalha01/gestion_horarios)  
**Última actualización**: 11 de febrero de 2026

---

<div align="center">

**Hecho con ❤️ para instituciones educativas**

📚 Documentación completa | 🏗️ Arquitectura robusta | 🎯 Optimización inteligente

</div>
