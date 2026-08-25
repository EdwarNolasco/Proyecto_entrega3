# Gestor de Prácticas Profesionales

Aplicación web académica para administrar y dar seguimiento al proceso de prácticas profesionales. El sistema centraliza la información de estudiantes, carreras, empresas y supervisores, y permite gestionar solicitudes, períodos, horarios, asistencias, prácticas profesionales e historial académico.

## Funcionalidades

- Gestión de estudiantes, carreras y programas de estudio.
- Registro y administración de empresas y supervisores.
- Creación, actualización y eliminación de solicitudes de práctica.
- Seguimiento de prácticas profesionales e historial de prácticas.
- Administración de períodos, asignaturas, calendarios y horarios.
- Registro de asistencias.
- Consultas y operaciones CRUD mediante una API REST.
- Visualización y edición de datos con componentes DevExtreme.

## Tecnologías

- C#
- ASP.NET MVC 5
- ASP.NET Web API 2
- .NET Framework 4.7.2
- Entity Framework 6
- SQL Server LocalDB
- DevExtreme ASP.NET MVC
- Bootstrap
- jQuery
- Newtonsoft.Json

## Requisitos

- Visual Studio con la carga de trabajo de desarrollo web ASP.NET.
- .NET Framework 4.7.2.
- SQL Server LocalDB.
- NuGet para restaurar las dependencias del proyecto.

## Instalación y ejecución

1. Clona el repositorio.
2. Abre `Proyecto_entrega3.sln` en Visual Studio.
3. Restaura los paquetes NuGet definidos en `Proyecto_entrega3/packages.config`.
4. Verifica la cadena de conexión en `Proyecto_entrega3/Web.config`.
5. Asegúrate de que la API utilizada por los controladores esté disponible en `https://localhost:44300`.
6. Ejecuta el proyecto con IIS Express.

La aplicación utiliza una base de datos LocalDB llamada `Proyecto_entrega3Context`. La base de datos local no se incluye en el repositorio; se genera o configura en el entorno de desarrollo.

## Estructura principal

- `Proyecto_entrega3/Controllers`: controladores MVC y endpoints de la API.
- `Proyecto_entrega3/Models`: modelos de estudiantes, empresas, prácticas y entidades relacionadas.
- `Proyecto_entrega3/Data`: contexto de Entity Framework.
- `Proyecto_entrega3/Views`: vistas de la aplicación web.
- `Proyecto_entrega3/App_Start`: configuración de rutas, bundles y Web API.
- `Proyecto_entrega3/Content` y `Proyecto_entrega3/Scripts`: estilos, librerías y recursos frontend.

## Nota de configuración

Las URLs de los servicios están definidas actualmente en los controladores y apuntan a `https://localhost:44300`. Para utilizar otro entorno, actualiza esas URLs y configura la cadena de conexión correspondiente sin publicar credenciales reales en el repositorio.
