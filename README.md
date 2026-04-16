# Template API REST

> A clean, minimal REST API template built with **C# / ASP.NET Core 8** and **Swagger (OpenAPI)**.  
> Designed as a starting point for ERP-style product/inventory management services.

---

### Overview

**Template_API_REST** is a RESTful API template developed in **C# with ASP.NET Core 8 (.NET 8)**. It serves as a solid and reusable foundation for building ERP-oriented backend services, particularly focused on **product and inventory management**.

The project follows a standard ASP.NET Web API structure with clearly separated **Controllers**, **Models**, and configuration layers. It uses **in-memory data** (no database required), making it extremely easy to clone and run without any infrastructure setup.

**Key technologies:**

| Technology | Version / Detail |
|---|---|
| Language | C# |
| Framework | ASP.NET Core 8 (`net8.0`) |
| API Docs | Swagger / OpenAPI via `Swashbuckle.AspNetCore 6.4.0` |
| Storage | In-memory (no external database) |
| IDE | Visual Studio 2022 (recommended) |

---

### Prerequisites

Before running this project, make sure you have the following installed:

- [Visual Studio 2022](https://visualstudio.microsoft.com/) (Community or higher) with the **ASP.NET and web development** workload
- [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)
- (Optional) [Postman](https://www.postman.com/) or any REST client for testing endpoints

---

### Running the App in Visual Studio

Follow these steps to get the server up and running:

**1. Clone the repository**

```bash
git clone https://github.com/IgnacioRV23/Template_API_REST.git
```

**2. Open the solution**

Open Visual Studio 2022 and go to:  
`File → Open → Project/Solution`  
Select the file `Erp_Project.sln`.

**3. Restore NuGet packages**

Visual Studio will automatically restore packages on load. If not, go to:  
`Tools → NuGet Package Manager → Manage NuGet Packages for Solution → Restore`

**4. Set the startup project**

In Solution Explorer, right-click on `Erp_Project` and select **Set as Startup Project**.

**5. Choose the run profile**

In the top toolbar, select the `https` or `http` profile from the dropdown next to the green Run ▶ button.

**6. Run the application**

Press **F5** (with debugger) or **Ctrl+F5** (without debugger).

The application will start and automatically open Swagger UI in your browser at:

```
https://localhost:{PORT}/swagger
```

> The default port defined in `Erp_Project.http` is **5067**, but Visual Studio may assign a different port from `Properties/launchSettings.json`.

**7. Verify the server is running**

You should see the **Swagger UI** with all available endpoints listed and ready to test.

---

### API Endpoints

The base URL when running locally is:

```
http://localhost:5067
```

The API exposes a full set of CRUD operations for managing **Products**:

| Method | Endpoint | Description |
|---|---|---|
| `GET` | `/api/Product` | Retrieve all products |
| `GET` | `/api/Product/{id}` | Retrieve a product by ID |
| `POST` | `/api/Product` | Create a new product |
| `PUT` | `/api/Product/{id}` | Update an existing product |
| `DELETE` | `/api/Product/{id}` | Delete a product by ID |

---

### Usage Examples / Test Cases

You can test the API using **Swagger UI**, **Postman**, or the built-in `Erp_Project.http` file in Visual Studio.

---

#### ✅ GET all products

**Request:**
```http
GET http://localhost:5067/api/Product
Accept: application/json
```

**Expected Response — `200 OK`:**
```json
[
  {
    "id": 1,
    "name": "Laptop",
    "price": 999.99,
    "stock": 25
  },
  {
    "id": 2,
    "name": "Mouse",
    "price": 29.99,
    "stock": 150
  }
]
```

---

#### ✅ GET product by ID

**Request:**
```http
GET http://localhost:5067/api/Product/1
Accept: application/json
```

**Expected Response — `200 OK`:**
```json
{
  "id": 1,
  "name": "Laptop",
  "price": 999.99,
  "stock": 25
}
```

**Not found — `404 Not Found`:**
```json
{
  "type": "https://tools.ietf.org/html/rfc9110#section-15.5.5",
  "title": "Not Found",
  "status": 404
}
```

---

#### ✅ POST — Create a new product

**Request:**
```http
POST http://localhost:5067/api/Product
Content-Type: application/json

{
  "name": "Keyboard",
  "price": 49.99,
  "stock": 75
}
```

**Expected Response — `201 Created`:**
```json
{
  "id": 3,
  "name": "Keyboard",
  "price": 49.99,
  "stock": 75
}
```

---

#### ✅ PUT — Update a product

**Request:**
```http
PUT http://localhost:5067/api/Product/3
Content-Type: application/json

{
  "id": 3,
  "name": "Mechanical Keyboard",
  "price": 89.99,
  "stock": 60
}
```

**Expected Response — `204 No Content`** *(no body)*

---

#### ✅ DELETE — Remove a product

**Request:**
```http
DELETE http://localhost:5067/api/Product/3
```

**Expected Response — `204 No Content`** *(no body)*

---

### Testing via Swagger UI

Once the server is running, navigate to:

```
https://localhost:{PORT}/swagger
```

Swagger is enabled only in the **Development** environment (as configured in `Program.cs`). It provides an interactive interface to explore and test all endpoints directly from the browser without any additional tools.

<br/>

---

<br/>

### Descripción general

**Template_API_REST** es una plantilla de API RESTful desarrollada en **C# con ASP.NET Core 8 (.NET 8)**. Sirve como base sólida y reutilizable para construir servicios backend orientados a ERP, con un enfoque particular en la **gestión de productos e inventario**.

El proyecto sigue la estructura estándar de un Web API de ASP.NET, con **Controladores**, **Modelos** y capas de configuración claramente separadas. Utiliza **datos en memoria** (sin base de datos), lo que lo hace muy fácil de clonar y ejecutar sin ninguna configuración de infraestructura.

**Tecnologías principales:**

| Tecnología | Versión / Detalle |
|---|---|
| Lenguaje | C# |
| Framework | ASP.NET Core 8 (`net8.0`) |
| Documentación | Swagger / OpenAPI via `Swashbuckle.AspNetCore 6.4.0` |
| Almacenamiento | En memoria (sin base de datos externa) |
| IDE | Visual Studio 2022 (recomendado) |

---

### Prerequisitos

Antes de ejecutar el proyecto, asegurate de tener instalado lo siguiente:

- [Visual Studio 2022](https://visualstudio.microsoft.com/) (Community o superior) con la carga de trabajo **Desarrollo de ASP.NET y web**
- [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)
- (Opcional) [Postman](https://www.postman.com/) u otro cliente REST para probar los endpoints

---

### Guía para ejecutar la app desde Visual Studio

Seguí estos pasos para levantar el servidor:

**1. Clonar el repositorio**

```bash
git clone https://github.com/IgnacioRV23/Template_API_REST.git
```

**2. Abrir la solución**

Abrí Visual Studio 2022 y andá a:  
`Archivo → Abrir → Proyecto/Solución`  
Seleccioná el archivo `Erp_Project.sln`.

**3. Restaurar los paquetes NuGet**

Visual Studio restaura los paquetes automáticamente al cargar. Si no lo hace, andá a:  
`Herramientas → Administrador de paquetes NuGet → Administrar paquetes NuGet para la solución → Restaurar`

**4. Establecer el proyecto de inicio**

En el Explorador de soluciones, hacé clic derecho en `Erp_Project` y seleccioná **Establecer como proyecto de inicio**.

**5. Elegir el perfil de ejecución**

En la barra superior, seleccioná el perfil `https` o `http` del menú desplegable junto al botón verde de ejecutar ▶.

**6. Ejecutar la aplicación**

Presioná **F5** (con depurador) o **Ctrl+F5** (sin depurador).

La aplicación se iniciará y abrirá automáticamente la interfaz Swagger en el navegador:

```
https://localhost:{PUERTO}/swagger
```

> El puerto por defecto definido en `Erp_Project.http` es **5067**, pero Visual Studio puede asignar uno diferente según `Properties/launchSettings.json`.

**7. Verificar que el servidor está corriendo**

Deberías ver la **interfaz Swagger UI** con todos los endpoints disponibles y listos para probar.

---

### Endpoints de la API

La URL base al correr localmente es:

```
http://localhost:5067
```

La API expone un conjunto completo de operaciones CRUD para gestionar **Productos**:

| Método | Endpoint | Descripción |
|---|---|---|
| `GET` | `/api/Product` | Obtener todos los productos |
| `GET` | `/api/Product/{id}` | Obtener un producto por ID |
| `POST` | `/api/Product` | Crear un nuevo producto |
| `PUT` | `/api/Product/{id}` | Actualizar un producto existente |
| `DELETE` | `/api/Product/{id}` | Eliminar un producto por ID |

---

### Ejemplos de uso / Casos de prueba

Podés probar la API usando **Swagger UI**, **Postman** o el archivo integrado `Erp_Project.http` en Visual Studio.

---

#### ✅ GET — Obtener todos los productos

**Request:**
```http
GET http://localhost:5067/api/Product
Accept: application/json
```

**Respuesta esperada — `200 OK`:**
```json
[
  {
    "id": 1,
    "name": "Laptop",
    "price": 999.99,
    "stock": 25
  },
  {
    "id": 2,
    "name": "Mouse",
    "price": 29.99,
    "stock": 150
  }
]
```

---

#### ✅ GET — Obtener producto por ID

**Request:**
```http
GET http://localhost:5067/api/Product/1
Accept: application/json
```

**Respuesta esperada — `200 OK`:**
```json
{
  "id": 1,
  "name": "Laptop",
  "price": 999.99,
  "stock": 25
}
```

**No encontrado — `404 Not Found`:**
```json
{
  "type": "https://tools.ietf.org/html/rfc9110#section-15.5.5",
  "title": "Not Found",
  "status": 404
}
```

---

#### ✅ POST — Crear un nuevo producto

**Request:**
```http
POST http://localhost:5067/api/Product
Content-Type: application/json

{
  "name": "Teclado",
  "price": 49.99,
  "stock": 75
}
```

**Respuesta esperada — `201 Created`:**
```json
{
  "id": 3,
  "name": "Teclado",
  "price": 49.99,
  "stock": 75
}
```

---

#### ✅ PUT — Actualizar un producto

**Request:**
```http
PUT http://localhost:5067/api/Product/3
Content-Type: application/json

{
  "id": 3,
  "name": "Teclado Mecánico",
  "price": 89.99,
  "stock": 60
}
```

**Respuesta esperada — `204 No Content`** *(sin cuerpo)*

---

#### ✅ DELETE — Eliminar un producto

**Request:**
```http
DELETE http://localhost:5067/api/Product/3
```

**Respuesta esperada — `204 No Content`** *(sin cuerpo)*

---

### Pruebas desde Swagger UI

Una vez que el servidor está corriendo, navegá a:

```
https://localhost:{PUERTO}/swagger
```

Swagger está habilitado únicamente en el entorno de **Desarrollo** (según la configuración en `Program.cs`). Provee una interfaz interactiva para explorar y probar todos los endpoints directamente desde el navegador, sin herramientas adicionales.

---

*Desarrollado por [IgnacioRV23](https://github.com/IgnacioRV23)*
