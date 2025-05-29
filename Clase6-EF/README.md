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
