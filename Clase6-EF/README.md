# Clase: CRUD con Entity Framework (Database First)

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