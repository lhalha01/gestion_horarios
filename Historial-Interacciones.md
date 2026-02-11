# Historial de Interacciones - Proyecto SpecKitSample2

## Información del Proyecto
- **Proyecto**: Sistema de Gestión de Horarios
- **Fecha de inicio**: 11 de febrero de 2026
- **Asistente**: GitHub Copilot

---

## Registro de Interacciones

### Interacción #1
**Fecha y hora**: 11 de febrero de 2026  
**Solicitud del usuario**: "creame un documenro SRS-Horarios.md para determinart las especificaciones de un proyecto aun por definir"

**Acciones realizadas**:
- Creación del documento `SRS-Horarios.md`
- Especificación completa de requisitos de software (SRS) para un Sistema de Gestión de Horarios

**Contenido generado**:
- ✅ 15 secciones principales con estructura IEEE 830-1998
- ✅ Introducción y alcance del proyecto
- ✅ Descripción general del sistema
- ✅ 6 grupos de requisitos funcionales (RF-01 a RF-06):
  - Gestión de Usuarios
  - Gestión de Horarios
  - Gestión de Recursos
  - Sistema de Notificaciones
  - Reportes y Estadísticas
  - Gestión de Conflictos
- ✅ 7 categorías de requisitos no funcionales (RNF-01 a RNF-07)
- ✅ 5 casos de uso completamente especificados
- ✅ Diseño de interfaz de usuario
- ✅ Integraciones externas
- ✅ Modelado de datos (entidades y relaciones)
- ✅ Planificación por fases (MVP, avanzadas, optimización)
- ✅ Análisis de riesgos
- ✅ Criterios de aceptación

**Resultado**: ✅ Documento creado exitosamente con 582 líneas

---

### Interacción #2
**Fecha y hora**: 11 de febrero de 2026  
**Solicitud del usuario**: "Puedes crear un diagrama ara cada caso de uso"

**Acciones realizadas**:
- Lectura del documento SRS-Horarios.md para localizar los 5 casos de uso
- Adición de diagramas de flujo Mermaid para cada caso de uso

**Diagramas creados**:
1. ✅ **CU-01: Crear Horario**
   - Flujo principal con validación de disponibilidad
   - Flujo alternativo para manejo de conflictos
   - Decisiones de coordinador ante conflictos
   - 14 nodos, colores diferenciados por tipo

2. ✅ **CU-02: Visualizar Horarios Personales**
   - Navegación por diferentes vistas (día/semana/mes)
   - Visualización de detalles de horarios
   - Flujo de navegación continua
   - 11 nodos con 3 puntos de decisión

3. ✅ **CU-03: Gestionar Recursos**
   - Proceso de alta de recursos
   - Validación de datos
   - Manejo de errores con retroalimentación
   - 10 nodos con validación

4. ✅ **CU-04: Resolver Conflictos**
   - Detección automática de conflictos
   - Generación de sugerencias
   - Notificación a usuarios impactados
   - 12 nodos con flujo de resolución

5. ✅ **CU-05: Generar Reporte**
   - Selección de tipo y parámetros
   - Generación con visualizaciones
   - Exportación opcional a múltiples formatos
   - 14 nodos con opciones de exportación

**Características de los diagramas**:
- Formato: Mermaid flowchart
- Código de colores: Verde (inicio/éxito), Amarillo (decisiones), Rosa (error/cancelación)
- Etiquetas descriptivas en español
- Renderizables en cualquier visor Markdown compatible con Mermaid

**Resultado**: ✅ 5 diagramas agregados exitosamente al documento

---

### Interacción #3
**Fecha y hora**: 11 de febrero de 2026  
**Solicitud del usuario**: "Puedes crear un archivo que valla registrado la interaccion que tengo contigo"

**Acciones realizadas**:
- Creación del documento `Historial-Interacciones.md`
- Registro cronológico de todas las interacciones
- Documentación detallada de solicitudes, acciones y resultados

**Resultado**: ✅ Historial de interacciones creado (este documento)

---

### Interacción #4
**Fecha y hora**: 11 de febrero de 2026  
**Solicitud del usuario**: Especificación detallada de requisitos para un centro escolar con:
- 3 niveles educativos, 3 clases por nivel, 25 alumnos por clase
- 8 asignaturas con distribución específica de horas semanales
- Jornada de 5 horas diarias con clases de 55 minutos
- Descanso de 20 minutos después de las 2 primeras clases
- Restricciones de profesores: máximo 2 asignaturas, 20 horas semanales
- Prioridad: misma asignatura en todos los niveles por profesor

**Acciones realizadas**:
- Actualización completa del documento SRS-Horarios.md con contexto escolar específico

**Secciones actualizadas**:

1. ✅ **Sección 1.2 - Alcance**
   - Especificado contexto del centro escolar
   - Detalladas funcionalidades para generación automática
   - Agregadas características del sistema educativo

2. ✅ **Sección 1.3 - Definiciones**
   - Agregada terminología escolar específica
   - Definidos conceptos de restricciones duras y blandas
   - Incluidos términos: nivel, clase, asignatura, período, carga horaria

3. ✅ **Sección 2.3 - Tipos de Usuarios**
   - Actualizados roles para contexto escolar
   - Definidos: Director, Coordinador Académico, Profesor, Estudiante/Padre
   - Especificados permisos por rol

4. ✅ **Nueva Sección 2.6 - Reglas de Negocio del Centro Escolar**
   - 2.6.1: Estructura académica completa
   - 2.6.2: Jornada escolar con horarios específicos
   - 2.6.3: Restricciones de profesores
   - 2.6.4: Restricciones duras (8 reglas obligatorias)
   - 2.6.5: Restricciones blandas (6 reglas deseables)

**Tabla de asignaturas incluida:**

| Asignatura | Horas/Semana |
|------------|--------------|
| Matemáticas | 4 |
| Inglés | 3 |
| Historia | 4 |
| Lengua Española | 4 |
| Educación Física | 1 |
| Manualidades | 2 |
| Física y Química | 4 |
| Ética | 2 |
| **TOTAL** | **24** |

**Cálculos técnicos documentados:**
- Total períodos semanales por grupo: 25
- Total horas semanales del centro: 216 (24h × 9 grupos)
- Profesores mínimos necesarios: 11 (216h ÷ 20h máx.)

5. ✅ **Nueva Sección 3.7 - Configuración Académica (RF-07)**
   - RF-07.1: Gestionar estructura del centro
   - RF-07.2: Gestionar plan de estudios
   - RF-07.3: Gestionar profesorado
   - RF-07.4: Configurar jornada escolar

6. ✅ **Nueva Sección 3.8 - Generación Automática de Horarios (RF-08)**
   - RF-08.1: Generar horario completo con algoritmo
   - RF-08.2: Validación de restricciones
   - RF-08.3: Optimización de horarios
   - RF-08.4: Asignación manual con validación
   - RF-08.5: Bloqueo de períodos
   - RF-08.6: Generación parcial por nivel

7. ✅ **Nueva Sección 3.9 - Visualización de Horarios (RF-09)**
   - RF-09.1: Vista por grupo/clase
   - RF-09.2: Vista por profesor
   - RF-09.3: Vista por aula
   - RF-09.4: Vista consolidada
   - RF-09.5: Exportar horarios

8. ✅ **Nuevo Caso de Uso 5.6 - CU-06: Generar Horario Escolar Automáticamente**
   - Flujo principal completo (14 pasos)
   - 3 flujos alternativos:
     - 7a: Imposible generar horario válido
     - 10a: Solicitud de regeneración
     - 11a: Ajuste manual necesario
   - Diagrama de flujo Mermaid con 24 nodos
   - Incluye validaciones y optimizaciones

**Estadísticas de la actualización:**
- Nuevas líneas agregadas: ~380
- Nuevos requisitos funcionales: 16 (RF-07.1 a RF-09.5)
- Nuevo caso de uso: 1 (CU-06)
- Nuevos diagramas: 1
- Reglas de negocio documentadas: 14 (8 duras + 6 blandas)

**Resultado**: ✅ Documento SRS-Horarios.md completamente adaptado al contexto escolar específico

---

### Interacción #5
**Fecha y hora**: 11 de febrero de 2026  
**Solicitud del usuario**: Definición de arquitectura técnica del sistema:
- Backend en .NET 8
- Persistencia en Azure SQL Server
- Mock para testing
- Frontend en HTML, CSS y Bootstrap
- Visualización de horarios en tablas

**Acciones realizadas**:
- Actualización completa del documento SRS-Horarios.md con arquitectura técnica detallada

**Secciones actualizadas**:

1. ✅ **Sección 2.4 - Restricciones Generales**
   - Agregado: Backend .NET 8
   - Agregado: Azure SQL Server
   - Agregado: Frontend HTML/CSS/Bootstrap
   - Especificado: Visualización en tablas

2. ✅ **Nueva Sección 2.7 - Arquitectura Técnica** (Extensa y detallada)
   
   **2.7.1 Stack Tecnológico:**
   - Backend: .NET 8 (C# 12), Web API RESTful, Entity Framework Core 8
   - Base de datos: Azure SQL Server (producción), SQL Server LocalDB/In-Memory (testing)
   - Frontend: HTML5, CSS3, Bootstrap 5.3, JavaScript
   - Testing: xUnit/NUnit, Moq, EF Core In-Memory
   
   **2.7.2 Arquitectura de Aplicación:**
   - Diagrama ASCII de capas (Presentación → API → Servicios → Repositorios → BD)
   - 6 proyectos de la solución:
     - HorariosEscolares.Domain
     - HorariosEscolares.Application
     - HorariosEscolares.Infrastructure
     - HorariosEscolares.API
     - HorariosEscolares.Web
     - HorariosEscolares.Tests
   
   **2.7.3 Componentes del Frontend:**
   - 4 páginas HTML principales definidas
   - Estructura de tabla Bootstrap para horarios
   - Ejemplo de código HTML con clases Bootstrap
   
   **2.7.4 API REST Endpoints:**
   - 20+ endpoints documentados
   - Agrupados por funcionalidad:
     - Autenticación (3 endpoints)
     - Configuración académica (12 endpoints)
     - Generación de horarios (4 endpoints)
     - Visualización (4 endpoints)
     - Exportación (2 endpoints)
   
   **2.7.5 Ambiente de Desarrollo y Despliegue:**
   - Desarrollo: Visual Studio 2022, Git, SQL Server LocalDB
   - Testing: EF In-Memory, CI/CD
   - Producción: Azure App Service, Azure SQL Database, Application Insights

3. ✅ **Sección 4.6 - Portabilidad (Actualizada)**
   - RNF-06.1: .NET 8 compatible con Windows, Linux, macOS
   - RNF-06.3: Azure SQL Server específico
   - RNF-06.5: Responsive design con Bootstrap

4. ✅ **Sección 7 - Integraciones Externas (Simplificada)**
   - Enfocada en tecnologías .NET
   - 7.1: Exportación (iTextSharp, EPPlus, ClosedXML, iCal, CSV)
   - 7.2: Notificaciones SMTP de Azure
   - 7.3: ASP.NET Core Identity + JWT
   - 7.4: API REST con Swagger/OpenAPI

5. ✅ **Sección 8 - Modelado de Datos (Completamente reescrita para SQL Server)**
   
   **13 tablas SQL Server definidas:**
   - Usuarios, Niveles, Clases, Asignaturas, Profesores
   - ProfesorAsignatura, Aulas, Periodos, Horarios
   - Asignaciones (núcleo del sistema)
   - BloqueosProfesor, RegistroValidaciones
   
   **Cada tabla incluye:**
   - Script SQL CREATE completo
   - Primary Keys, Foreign Keys
   - Constraints y validaciones
   - Índices únicos
   
   **Características adicionales:**
   - Convenciones de nomenclatura .NET/SQL Server
   - 6 índices recomendados para optimización
   - Vista SQL: vw_HorarioPorClase
   - Stored Procedure: sp_ValidarDisponibilidadProfesor
   - Configuración EF Core DbContext con código C#
   - Estrategia de testing con In-Memory y Moq
   
   **Restricciones de negocio en BD:**
   - UNIQUE constraints para evitar duplicados
   - CHECK constraints para validar rangos (días 1-5, períodos 1-5)
   - CASCADE DELETE para mantener integridad
   - Índices para evitar conflictos de horarios

**Código incluido:**
- Ejemplo HTML de tabla Bootstrap para horarios
- Configuración C# de DbContext
- Setup de In-Memory Database para tests
- Ejemplo de Mock con Moq

**Estadísticas de la actualización:**
- Nuevas líneas agregadas: ~550
- Nuevas secciones: 1 principal con 5 subsecciones
- Tablas SQL definidas: 13
- Endpoints API documentados: 20+
- Scripts SQL: 10+
- Ejemplos de código: 5+

**Decisiones técnicas documentadas:**
- Repository Pattern + Service Layer
- Code-First con EF Core Migrations
- JWT para autenticación stateless
- In-Memory Database para tests unitarios
- Bootstrap para UI responsive
- Azure App Service + Azure SQL para producción

**Resultado**: ✅ Arquitectura técnica completamente especificada y lista para implementación

---

### Interacción #6
**Fecha y hora**: 11 de febrero de 2026  
**Solicitud del usuario**: Generar diagramas de arquitectura para Anexo B y prototipos de UI para Anexo C

**Acciones realizadas**:
- Creación de 6 diagramas de arquitectura completos con Mermaid
- Diseño de 7 prototipos de UI completos con wireframes ASCII
- Actualización de Anexos B y C en el documento SRS-Horarios.md

**Anexo B: Diagramas de Arquitectura Creados**:

1. ✅ **B.1 Diagrama de Arquitectura General del Sistema**
   - Arquitectura completa en capas (Presentación → API → Aplicación → Dominio → Infraestructura → Persistencia)
   - Muestra flujo desde navegador hasta base de datos
   - Incluye servicios externos (Azure SMTP, Blob Storage, App Insights)
   - Tecnologías: HTML/CSS/Bootstrap → .NET 8 API → EF Core → Azure SQL
   - Colores diferenciados por capa

2. ✅ **B.2 Diagrama de Componentes - Módulo de Generación**
   - Detalle interno del HorarioGeneradorService
   - 6 componentes: Inicializador, Asignador, Backtracking, Validador, Optimizador, Puntuador
   - Flujo secuencial del algoritmo de generación
   - Entradas: Configuración, Profesores, Restricciones
   - Salidas: Horario válido, Métricas, Alertas

3. ✅ **B.3 Diagrama de Secuencia - Generar Horario Automáticamente**
   - Interacción completa entre Usuario → Frontend → API → Services → Repository → DB
   - Muestra loop de Backtracking con validación
   - Manejo de restricciones válidas e inválidas
   - Desde click del coordinador hasta visualización del resultado
   - 15+ mensajes de secuencia documentados

4. ✅ **B.4 Diagrama de Clases - Modelo de Dominio**
   - 10 clases principales del dominio
   - Entidades: Nivel, Clase, Asignatura, Profesor, Horario, Asignación, etc.
   - Servicios: HorarioGeneradorService, ValidadorService
   - Relaciones y cardinalidades (1:N, N:M)
   - Métodos clave de cada clase documentados

5. ✅ **B.5 Diagrama de Flujo de Datos - Visualización**
   - Flujo completo desde usuario hasta visualización
   - Selectores → Filtros → API → QueryService → Views SQL → Tabla Bootstrap
   - Proceso de exportación a PDF/Excel
   - Muestra integración entre frontend y backend

6. ✅ **B.6 Diagrama de Despliegue - Azure Cloud**
   - Infraestructura Azure completa
   - Azure App Service + Azure SQL Database + Blob Storage + App Insights
   - Ambiente de desarrollo con LocalDB
   - Conexiones entre usuario, servicios cloud y desarrollo

**Anexo C: Prototipos de UI Diseñados**:

1. ✅ **C.1 Dashboard / Página de Inicio**
   - 6 tarjetas con métricas principales (Niveles, Profesores, Asignaturas, Clases, Horas, Estado)
   - Card de horario activo con info detallada
   - Lista de notificaciones recientes
   - Botones de acción principal
   - 100% ASCII art wireframe

2. ✅ **C.2 Configuración Académica - Gestión de Profesores**
   - Tabs de navegación entre secciones
   - Tabla con lista de profesores (Código, Nombre, Asignaturas, Horas)
   - Búsqueda con filtro
   - Botón "Nuevo Profesor"
   - Modal de edición completo con:
     - Formulario de datos básicos
     - Checkboxes para asignaturas (máx. 2)
     - Configuración de bloqueos de horario
   - Indicadores de carga horaria (16/20)

3. ✅ **C.3 Generación de Horarios**
   - Wizard de 3 pasos:
     - Paso 1: Configuración (nombre, año, ámbito)
     - Paso 2: Opciones de optimización con sliders
     - Paso 3: Verificación previa con checklist
   - Modal de progreso durante generación:
     - Barra de progreso animada
     - Estado actual del proceso
     - Tiempo transcurrido y estimado
     - Botón para cancelar

4. ✅ **C.4 Visualización de Horarios - Por Grupo**
   - Tabs: Por Grupo, Por Profesor, Por Aula, Consolidado
   - Selectores de Nivel y Clase
   - Tabla 5×5 (días × períodos) completa con:
     - Iconos de asignaturas
     - Nombre de asignatura y profesor
     - Número de aula
     - Fila especial para descanso (destacada)
   - Estadísticas del horario
   - Botones de exportación y navegación

5. ✅ **C.5 Visualización de Horarios - Por Profesor**
   - Vista personalizada del profesor
   - Barra de progreso de carga horaria (16/20)
   - Tabla con períodos libres destacados
   - Resumen semanal detallado:
     - Horas por asignatura
     - Niveles atendidos
     - Aulas utilizadas
   - Notas y sugerencias de mejora
   - Botones de exportación personal

6. ✅ **C.6 Exportación de Horarios**
   - Wizard de 2 pasos:
     - Paso 1: Seleccionar contenido (tipo, elementos, opciones)
     - Paso 2: Formato de salida (PDF/Excel/iCal/CSV)
   - Tabs para diferentes formatos
   - Opciones específicas de PDF (orientación, tamaño, portada)
   - Previsualización del documento
   - Controles de paginación
   - Botón de descarga

7. ✅ **C.7 Edición Manual de Horario**
   - Tabla interactiva con botones en cada celda (✏️ Editar, 🗑️ Eliminar, 🔄 Cambiar)
   - Modal de edición con:
     - Selectores de asignatura, profesor, aula
     - Validación en tiempo real con indicadores visuales (✅❌)
     - Lista de validaciones (restricciones duras y blandas)
     - Advertencias y sugerencias
     - Cálculo de impacto en tiempo real
   - Modal de alerta de conflicto con:
     - Descripción del conflicto
     - Sugerencias automáticas
     - Alternativas disponibles

**Características de los diseños**:
- 100% wireframes ASCII art detallados
- Bootstrap 5.3 como framework base
- Componentes responsivos
- Iconos descriptivos (📊, 📐, 🌍, 👨‍🏫, etc.)
- Interactividad definida
- Validación en tiempo real documentada
- Feedback visual claro
- Accesibilidad considerada

**Estadísticas de la actualización**:
- Diagramas Mermaid: 6
- Prototipos UI: 7
- Nuevas líneas agregadas: ~900+
- Total wireframes ASCII: 7 pantallas completas
- Componentes UI documentados: 50+

**Resultado**: ✅ Anexos B y C completamente desarrollados con diagramas profesionales y prototipos detallados

---

## Resumen de Archivos Generados

| Archivo | Tamaño | Descripción | Estado |
|---------|--------|-------------|--------|
| SRS-Horarios.md | ~2500 líneas | Especificación completa con arquitectura, diagramas y prototipos | ✅ Completo |
| Historial-Interacciones.md | ~600 líneas | Registro detallado de 6 interacciones | ✅ Actualizado |

---

## Métricas del Proyecto

### Documentación
- **Total de documentos**: 2
- **Líneas de documentación**: ~3100+
- **Requisitos funcionales documentados**: 34 (RF-01.1 a RF-09.5)
- **Requisitos no funcionales documentados**: 29 (RNF-01.1 a RNF-07.3)
- **Casos de uso especificados**: 6 con diagramas de flujo
- **Diagramas técnicos**: 12 (6 casos de uso + 6 arquitectura)
- **Prototipos UI**: 7 pantallas completas
- **Reglas de negocio**: 14 (8 restricciones duras + 6 blandas)

### Arquitectura Técnica
- **Stack Backend**: .NET 8 (C# 12)
- **ORM**: Entity Framework Core 8
- **Base de datos producción**: Azure SQL Server
- **Base de datos testing**: SQL Server In-Memory / LocalDB
- **Stack Frontend**: HTML5, CSS3, Bootstrap 5.3, JavaScript
- **Testing**: xUnit/NUnit + Moq
- **Despliegue**: Azure App Service + Azure SQL Database

### Modelado de Datos
- **Tablas SQL Server**: 13
- **Vistas SQL**: 1
- **Stored Procedures**: 1
- **Índices**: 6 recomendados
- **Constraints**: 15+ (UNIQUE, CHECK, FK)

### API REST
- **Endpoints documentados**: 20+
- **Grupos funcionales**: 5 (Auth, Config, Generación, Visualización, Export)
- **Formato respuesta**: JSON
- **Documentación**: Swagger/OpenAPI

### Contexto Escolar Específico
- **Niveles educativos**: 3
- **Clases por nivel**: 3 (Total: 9 grupos)
- **Alumnos por clase**: 25 (Total: 225 estudiantes)
- **Asignaturas**: 8
- **Períodos diarios**: 5
- **Horas semanales por grupo**: 24
- **Total horas semanales centro**: 216
- **Profesores mínimos necesarios**: 11
- **Duración de clase**: 55 minutos
- **Duración de descanso**: 20 minutos

### Cobertura de la Especificación
- ✅ Requisitos funcionales: Completo y especializado
- ✅ Requisitos no funcionales: Completo
- ✅ Casos de uso: Completo con diagramas de flujo
- ✅ Modelado de datos: Definido para SQL Server con scripts
- ✅ Arquitectura técnica: Completamente especificada
- ✅ Stack tecnológico: Definido (.NET 8 + Azure)
- ✅ API REST: Endpoints documentados (20+)
- ✅ Frontend: Componentes y estructura definida
- ✅ Testing: Estrategia con mocks definida
- ✅ Reglas de negocio escolares: Documentadas
- ✅ Restricciones del sistema: Especificadas
- ✅ Planificación: Por fases con roadmap
- ✅ Algoritmo de generación: Especificado con diagramas
- ✅ Diagramas de arquitectura: 6 diagramas Mermaid completos
- ✅ Prototipos UI: 7 pantallas diseñadas con wireframes ASCII
- ⏳ Plan de pruebas detallado: Pendiente
- ⏳ Implementación: Por iniciar

---

## Próximos Pasos Sugeridos

### Corto Plazo (Preparación para Desarrollo)
- [ ] Crear solución .NET 8 con estructura de proyectos:
  - HorariosEscolares.Domain
  - HorariosEscolares.Application
  - HorariosEscolares.Infrastructure
  - HorariosEscolares.API
  - HorariosEscolares.Web
  - HorariosEscolares.Tests
- [ ] Configurar Azure SQL Database o SQL Server LocalDB
- [ ] Implementar entidades del dominio con EF Core
- [ ] Crear migraciones iniciales de base de datos
- [ ] Configurar ASP.NET Core Identity + JWT
- [ ] Diseñar wireframes/mockups para páginas HTML principales:
  - Dashboard de inicio
  - Configuración académica
  - Generación de horarios
  - Visualización de horarios en tablas Bootstrap
- [ ] Investigar algoritmos de generación:
  - Backtracking con poda
  - Algoritmos Genéticos
  - Constraint Satisfaction Problem (CSP)
  - Considerar: Ningún algoritmo específico en .NET vs implementación custom

### Mediano Plazo (Desarrollo MVP)
- [ ] **Módulo 1: Configuración Académica**
  - Implementar Controllers y servicios para CRUD de niveles, clases, asignaturas
  - Implementar gestión de profesores con validación de 2 asignaturas máx.
  - Crear págs HTML con formularios Bootstrap y tablas
  - Configurar períodos de jornada escolar
  
- [ ] **Módulo 2: Core del Algoritmo**
  - Implementar servicio de validación de restricciones duras
  - Desarrollar motor de generación automática (HorarioGeneradorService)
  - Implementar optimizador de restricciones blandas
  - Crear sistema de puntuación de calidad
  - Unit tests exhaustivos con escenarios reales
  
- [ ] **Módulo 3: Visualización**
  - API endpoints para obtener horarios (por grupo, profesor, aula)
  - Páginas HTML con tablas Bootstrap 5x5 (días × períodos)
  - JavaScript para interactividad (filtros, highlights)
  - Vista consolidada con tabs de Bootstrap
  
- [ ] **Módulo 4: Exportación**
  - Implementar exportación a PDF (DinkToPdf o iTextSharp)
  - Implementar exportación a Excel (EPPlus o ClosedXML)
  - Endpoint de descarga de archivos
  
- [ ] **Testing**
  - Suite de pruebas unitarias con xUnit + Moq
  - Pruebas de integración con In-Memory Database
  - Validar con datos reales del centro (3 niveles, 9 grupos, 8 asignaturas)
  - Cobertura mínima 80% en lógica de negocio

### Largo Plazo (Optimización y Extensiones)
- [ ] **Mejoras de Algoritmo**
  - Optimización de rendimiento (generación en < 30 segundos)
  - Paralelización de búsqueda de soluciones
  - Cache de configuraciones frecuentes
  
- [ ] **Funcionalidades Avanzadas**
  - Histórico de horarios con versionado
  - Comparación visual entre versiones
  - Sistema de preferencias de profesores (soft constraints personalizados)
  - Bloqueos de períodos con calendario
  - Detección de patrones problemáticos
  
- [ ] **Reporting y Análisis**
  - Dashboard con estadísticas (Chart.js)
  - Análisis de carga docente
  - Reporte de distribución de asignaturas
  - Gráficos de ocupación de aulas
  
- [ ] **Integración y Despliegue**
  - CI/CD con GitHub Actions o Azure DevOps
  - Despliegue a Azure App Service
  - Configuración de Application Insights
  - Monitoreo de rendimiento y errores
  
- [ ] **Extensiones Futuras**
  - App móvil (Xamarin o MAUI) para profesores
  - Notificaciones por email con Azure SendGrid
  - Integración con sistema académico existente
  - Gestión de sustituciones y cambios de horario
  - Exportación a Google Calendar / Outlook
  - PWA (Progressive Web App) para acceso offline
- [ ] Optimizar rendimiento del algoritmo
- [ ] Implementar sistema de reportes avanzados:
  - Análisis de carga docente
  - Estadísticas de distribución
  - Gráficos de uso de aulas
- [ ] Realizar pruebas de usuario con coordinadores académicos
- [ ] Iterar basado en feedback del centro escolar
- [ ] Planificar extensiones futuras:
  - Gestión de sustituciones
  - Integración con sistema académico
  - App móvil para profesores y estudiantes

---

## Notas y Observaciones

### Decisiones de Diseño
- Se optó por arquitectura web con diseño responsive
- Sistema de notificaciones dual (email + in-app)
- Soft delete para horarios eliminados
- Detección automática de conflictos en tiempo real

### Consideraciones Técnicas
- Cumplimiento GDPR/LOPD requerido
- Disponibilidad objetivo: 99.5%
- Soporte para 1,000 usuarios concurrentes
- Capacidad para 100,000 horarios simultáneos

### Riesgos Identificados
- Conflictos no detectados (mitigado con validaciones)
- Problemas de rendimiento (mitigado con arquitectura escalable)
- Sincronización externa (requiere manejo robusto)

---

## Contacto y Referencias

**Documentos Relacionados**:
- [SRS-Horarios.md](SRS-Horarios.md) - Especificación de Requisitos de Software

**Última actualización**: 11 de febrero de 2026

---

*Este documento se actualiza automáticamente con cada nueva interacción*
