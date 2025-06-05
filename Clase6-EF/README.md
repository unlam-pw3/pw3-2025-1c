# Clase 6: CRUD con Entity Framework (Database First)

## 🧾 Resumen

En esta clase trabajamos con **Entity Framework** en modalidad **Database First**, construyendo una aplicación ASP.NET MVC que permite realizar operaciones básicas (CRUD) sobre la entidad `Club`.

### 📌 Entidad utilizada: `Club`

Los campos utilizados fueron:

- `IdClub` (int, clave primaria)
- `Nombre` (string, requerido)
- `Pais` (string, opcional)
- `EscudoUrl` (string, máx. 500 caracteres)
- `CamisetaUrl` (string, máx. 500 caracteres)

Se implementaron las siguientes funcionalidades:

- ✅ **Listado:** vista que muestra todos los clubes en una tabla, con imágenes del escudo y camiseta si están disponibles.
- ✅ **Alta:** formulario para crear un nuevo club, con validaciones en el modelo.
- ✅ **Modificación:** formulario para editar los datos de un club existente.
- ✅ **Baja:** opción para eliminar un club.

También se aplicaron **validaciones de datos** usando clases parciales y `DataAnnotations`, sin modificar directamente el modelo generado por Entity Framework.

---

## 🎯 Tarea para la próxima clase

Implementar el mismo CRUD (Listado, Alta, Baja y Modificación) para una nueva entidad llamada `JugadorEstrella`, con los siguientes campos:

JugadorEstrella
- `IdJugadorEstrella` (int, clave primaria)
- `Nombre` (string, requerido)
- `Edad` (int, requerido)
- `FotoUrl` (string, máx. 500 caracteres)
- `Descripcion` (string, opcional)

> 🔹 Por ahora **no se requiere agregar relaciones** con otras tablas.

---

## 💡 Recomendaciones

- Utilizá `Scaffold-DbContext` si partís de una base de datos existente.
- Scaffold-DbContext "Server=.;Database=MundialClubes;Trusted_Connection=True;TrustServerCertificate=True;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir EF
- Aplicá validaciones con clases parciales (`[MetadataType]`) para no tocar los archivos autogenerados.
- Reutilizá el diseño y estructura de las vistas del CRUD de `Club` para facilitar el desarrollo.

---

##Instrucciones  
- Hacer un fork de este repositorio
- Crear Pull Request contra el repositorio original


# Clase 7: CRUD con Entity Framework (Database First) + Relación 1 a 1

## 🧾 Resumen

En esta clase trabajamos con **Entity Framework** en modalidad **Database First**, construyendo una aplicación ASP.NET MVC que permite realizar operaciones básicas (CRUD) sobre la entidad `Club` y agregarle una relación 1 a 1 con `Presidente`.

### 📌 Entidad utilizada: `Club`

Los campos utilizados fueron:

- `IdClub` (int, clave primaria)
- `Nombre` (string, requerido)
- `Pais` (string, opcional)
- `EscudoUrl` (string, máx. 500 caracteres)
- `CamisetaUrl` (string, máx. 500 caracteres)

### 📌 Relación 1 a 1: `Club` - `Presidente`

- Cada club puede tener un único presidente.
- Se agregó la propiedad de navegación `Presidente` en la clase `Club`.
- En la base de datos, se utilizó una **clave foránea con restricción `UNIQUE`** para garantizar la relación uno a uno.
- Desde la vista de alta/modificación de `Club`:
  - Se puede **seleccionar un presidente existente** desde un `<select>`.
  - O bien **crear un nuevo presidente** desde un input opcional.

### ✅ Funcionalidades implementadas:

- **Listado:** vista que muestra los clubes con sus datos e imágenes si están disponibles.
- **Alta:** formulario que permite ingresar los datos del club y asociarle (o crear) un presidente.
- **Modificación:** formulario similar al de alta con carga de datos previa.
- **Baja:** eliminación de un club.

---

## 🎯 Tarea para la próxima clase

Implementar el CRUD para la entidad `JugadorEstrella` con una **relación 1 a 1 con `Club`**, siguiendo el mismo enfoque que se aplicó hoy con `Presidente`.

### 📌 Entidad: `JugadorEstrella`

- `IdJugadorEstrella` (int, clave primaria)
- `Nombre` (string, requerido)
- `Edad` (int, requerido)
- `FotoUrl` (string, máx. 500 caracteres)
- `Descripcion` (string, opcional)
- `IdClub` (FK única, relación 1 a 1)

### ⚙️ Requisitos:

- La relación debe ser **1 a 1**: un `Club` puede tener como máximo un `JugadorEstrella`.
- Desde la vista de alta/modificación de `JugadorEstrella`:
  - Se debe poder **elegir un club existente** desde un `<select>`.
  - O **crear un nuevo club** opcionalmente.
- Implementar validaciones de modelo.
- Generar las clases usando `Scaffold-DbContext` si modificás la base de datos.

---

## 💡 Recomendaciones

- Usar clases parciales para aplicar validaciones con `DataAnnotations`, sin modificar el modelo generado.
- Reutilizar el diseño de vistas del CRUD de `Club`.
- Asegurate de que en la base de datos `IdClub` tenga una restricción `UNIQUE` si usás SQL Server Designer.

---

## 🛠 Instrucciones

- Hacer un fork de este repositorio
- Trabajar en una rama nueva
- Enviar un Pull Request contra el repositorio original una vez finalizado


# Clase 8 - API Torneos - ASP.NET Core

Este proyecto expone una API REST para gestionar torneos y clubes. Usa ASP.NET Core con soporte para DTOs y AutoMapper para separar entidades de base de datos de los datos expuestos en la API.

---

## 🧱 Estructura del Proyecto

```
/Controllers
  └── TorneoController.cs
/Models
  └── Entidades EF Core (Torneo, Club, Presidente)
/Models/Dto
  └── TorneoDto.cs
  └── ClubDto.cs
  └── PresidenteDto.cs
/Mapping
  └── MappingProfile.cs
Program.cs
```

---

## ✅ Funcionalidades del Controller

- `GET /api/torneo`: Obtiene todos los torneos (con clubes asociados).
- `GET /api/torneo/{id}`: Obtiene un torneo por ID.
- `POST /api/torneo`: Crea un nuevo torneo.
- `POST /api/torneo/{idTorneo}/club/{idClub}`: Asocia un club a un torneo.
- `DELETE /api/torneo/{idTorneo}`: Elimina un torneo.

---

## 📦 DTOs

Se usan Data Transfer Objects (DTOs) para separar las entidades del dominio de los datos que se exponen o reciben en la API.

### Ejemplo: `TorneoDto.cs`

```csharp
public class TorneoDto
{
    public int IdTorneo { get; set; }
    public string Nombre { get; set; } = null!;
    public DateTime FechaInicio { get; set; }
    public DateTime FechaFin { get; set; }
    public int? PremiosTotales { get; set; }
    public int? CantidadEquipos { get; set; }
    public List<ClubDto> IdClubs { get; set; } = new();
}
```

---

## 🔄 AutoMapper

### Configuración en `Program.cs`

```csharp
builder.Services.AddAutoMapper(typeof(MappingProfile).Assembly);
```

### Perfil de mapeo: `MappingProfile.cs`

```csharp
public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Torneo, TorneoDto>().ReverseMap();
        CreateMap<Club, ClubDto>().ReverseMap();
        CreateMap<Presidente, PresidenteDto>().ReverseMap();
    }
}
```

---

## 🛑 Errores comunes evitados

- ❌ Ciclos de serialización (`A possible object cycle was detected`)  
  ✅ Solucionado con DTOs planos y sin referencias circulares.
  
- ❌ `idClubs` viene vacío  
  ✅ Solucionado incluyendo `.Include(t => t.IdClubs)` en la lógica y usando `AutoMapper` para mapear correctamente la lista.

---

## ✨ Buenas prácticas aplicadas

- Uso de DTOs para desacoplar capa de datos de la API.
- Mapeo automático con AutoMapper.
- Separación clara entre lógica, modelos, y controladores.
- Estructura escalable y mantenible.

---


# 🏁 Tarea: Relación N a N entre Árbitros y Torneos

## 🎯 Objetivo
Modelar y exponer una relación **muchos a muchos** entre las entidades `Torneo` y `Arbitro` utilizando:

- Entidades EF Core
- DTOs para evitar ciclos de serialización
- AutoMapper para mapeo entre entidades y DTOs
- Controladores RESTful en ASP.NET Core Web API

---

## 🧱 Requisitos

### 1. Crear la entidad `Arbitro`

```csharp
public class Arbitro
{
    public int IdArbitro { get; set; }
    public string Nombre { get; set; } = null!;
    public string Nacionalidad { get; set; } = null!;
    
    public ICollection<Torneo> Torneos { get; set; } = new List<Torneo>();
}
```

### 2. Agregar propiedad en `Torneo`

```csharp
public class Torneo
{
    public int IdTorneo { get; set; }
    public string Nombre { get; set; } = null!;
    public DateTime FechaInicio { get; set; }
    public DateTime FechaFin { get; set; }

    public ICollection<Arbitro> Arbitros { get; set; } = new List<Arbitro>();
}
```

### 3. Crear los DTOs

- `TorneoDto`: con lista de `ArbitroDto`
- `ArbitroDto`: opcionalmente con lista de `TorneoDto` (si no causa ciclos)

### 4. Configurar `MappingProfile`

```csharp
public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Torneo, TorneoDto>().ReverseMap();
        CreateMap<Arbitro, ArbitroDto>().ReverseMap();
    }
}
```

### 5. Métodos en `TorneoController`

- `POST /api/torneo`: crear torneo (sin árbitros)
- `POST /api/torneo/{idTorneo}/arbitro/{idArbitro}`: asignar árbitro a torneo

### 6. Crear `ArbitroController`

- `GET /api/arbitro`: listar todos los árbitros
- `POST /api/arbitro`: crear nuevo árbitro


---

## 🧠 Sugerencias

- Crear Fork y luego al finalizar enviar un PR
- Usá `Include()` en tu lógica para que vengan las relaciones cargadas.
- Probalo con Swagger para ver los resultados del mapeo.
- Evitá ciclos infinitos de serialización usando DTOs.


