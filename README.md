
#  Sistema de Gestión de Tareas - Taller ASP.NET Core MVC
Aplicación web completa para la gestión de tareas personales desarrollada bajo la arquitectura **MVC (Modelo-Vista-Controlador)**. Este proyecto forma parte de las prácticas profesionales del Taller de ASP.NET Core.
---

| **Estudiante** | **Barrón González José Ángel** |
| **Carrera** | **Ingeniería en Sistemas Computacionales (ISC)** |
| **Materia/Taller** | Taller de Desarrollo Web con ASP.NET Core |
| **Estado** | 🟢 Finalizado / En Producción |

---

## Descripción del Proyecto

Este sistema permite a los usuarios registrarse y administrar sus tareas diarias de manera eficiente. Implementa características avanzadas de manipulación de datos, seguridad y diseño responsivo. El núcleo de la aplicación maneja operaciones **CRUD** completas conectadas a una base de datos relacional mediante un ORM.

###  Características Principales

* ** Autenticación y Seguridad:**
    * Sistema de Login y Registro de usuarios implementado con **Microsoft Identity**.
    * Protección de rutas (Controladores decorados con `[Authorize]`).
    * Protección contra ataques CSRF (`ValidateAntiForgeryToken`).

* ** Gestión de Tareas:**
    * Creación de tareas con Título, Descripción y Fecha de creación automática.
    * **Carga de Imágenes:** Capacidad de subir archivos de imagen que se almacenan como arrays de bytes en la base de datos.
    * Marcado de estado: Pendiente / Completada.

* ** Buscador y Filtros Avanzados:**
    * Búsqueda en tiempo real por coincidencia de texto en Título o Descripción.
    * **Filtrado lógico:** Visualización de tareas por estado (`Pending`, `Completed`, `All`).

* ** Interfaz de Usuario (UI):**
    * Diseño moderno y adaptable (Responsive) utilizando **Bootstrap 5**.
    * Uso de **Razor Views** para la renderización dinámica de HTML.

---

##  Stack Tecnológico

La arquitectura del proyecto está construida sobre las siguientes tecnologías:

* **Framework:** .NET 8 (ASP.NET Core MVC)
* **Lenguaje:** C# 12
* **ORM:** Entity Framework Core
* **Base de Datos:** SQLite (Configuración por defecto para portabilidad)
* **Frontend:** Razor Syntax, HTML5, CSS3, JavaScript
* **Control de Versiones:** Git & GitHub

---

## 📂 Estructura del Proyecto

Breve descripción de los componentes clave en el código fuente:

```bash
TallerASP.NET_BarronGonzalezJoseAngel/
├── 📂 Controllers/
│   ├── 📄 TasksController.cs    # Lógica principal (Búsqueda, Filtros, CRUD)
│   └── 📄 HomeController.cs     # Página de inicio
├── 📂 Models/
│   ├── 📄 TaskItem.cs           # Definición de la entidad Tarea (Propiedades + Validaciones)
│   └── 📄 ErrorViewModel.cs     # Modelo para manejo de errores
├── 📂 Data/
│   └── 📄 ApplicationDbContext.cs # Contexto de la BD y configuración de Entity Framework
├── 📂 Views/
│   ├── 📂 Tasks/                # Vistas Razor (Index, Create, Edit, Details)
│   └── 📂 Shared/               # Layout principal y parciales de Login
└── 📄 Program.cs                # Configuración del pipeline HTTP y Servicios
````

-----

## ⚙️ Guía de Instalación y Ejecución

Si deseas clonar y ejecutar este proyecto en tu entorno local, sigue estos pasos:

### 1\. Prerrequisitos

  * Tener instalado **Visual Studio 2022** o **VS Code**.
  * Tener instalado el **.NET 8 SDK**.

### 2\. Clonar el Repositorio

```bash
git clone [https://github.com/TU_USUARIO/NOMBRE_DEL_REPO.git](https://github.com/TU_USUARIO/NOMBRE_DEL_REPO.git)
cd TallerASP.NET_BarronGonzalezJoseAngel
```

### 3\. Restaurar Dependencias

```bash
dotnet restore
```

### 4\. Actualizar Base de Datos (Migraciones)

Dado que el proyecto utiliza Entity Framework Code-First, es necesario aplicar las migraciones para generar el archivo de base de datos SQLite local.

```bash
dotnet ef database update
```

*Nota: Si tienes errores de columnas faltantes (ej. `IsCompleted`), asegúrate de haber ejecutado este comando.*

### 5\. Ejecutar la Aplicación

```bash
dotnet run
```

La aplicación estará disponible generalmente en `https://localhost:7000` o `http://localhost:5000`.

-----



## 📄 Licencia

Este proyecto fue desarrollado con fines educativos para la carrera de **Ingeniería en Sistemas Computacionales**.

-----

*Hecho por [José Ángel Barrón González]

```
```
