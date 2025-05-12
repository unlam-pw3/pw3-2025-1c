# 2025-1C Parcial 1 – Registro de Misiones de Superhéroes (ASP.NET MVC + Validaciones + TempData)

## 🧑‍💻 Enunciado Resuelto

**Desarrollamos una Aplicación Web en ASP.NET MVC para registrar y visualizar misiones realizadas por superhéroes.**

### 🧩 Funcionalidades implementadas:

- Inicio por defecto en el controlador `Presentacion`, acción `Bienvenido`, con mensaje de bienvenida.
- Layout con footer fijo que incluye:
  - Nombre del alumno
  - DNI
- Navegación entre vistas mediante dos links:
  - `Registrar Misión`
  - `Resultados`
- Formulario para registrar una nueva misión que incluye:
  - Nombre del superhéroe
  - Cantidad de villanos derrotados
  - Horas de misión
- Cálculo del **Índice de Eficiencia** mediante la fórmula:

  ```csharp
  Eficiencia = (VillanosDerrotados * 100) / HorasMision