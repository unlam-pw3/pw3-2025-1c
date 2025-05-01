# 2025-1C Clase 4 – Práctica Equipos Deportivos (POO + Binding automático)

## 🧑‍🏫 En Clase

**Desarrollamos una Aplicación Web para gestionar Equipos Deportivos (POO + Binding automático)**

- Creamos una Aplicación ASP.NET MVC con dos vistas:
  - Una para dar de alta un nuevo equipo deportivo
  - Otra para listar todos los equipos creados
- Implementamos el concepto de **Polimorfismo** utilizando una interfaz `IEquipoDeportivo`
- Desarrollamos clases específicas para cada tipo de equipo:
  - `EquipoFutbol` → 11 jugadores
  - `EquipoBasquet` → 5 jugadores
  - `EquipoVoley` → 6 jugadores
  - `EquipoTenisDobles` → 2 jugadores
  - `EquipoRugby` → 15 jugadores
- Aplicamos binding automático en formularios para crear instancias de los equipos seleccionados
- Agregamos una vista parcial para mostrar la cantidad de integrantes requeridos

## 📝 TAREA

**Crear una Aplicación Web similar a la desarrollada en clase, pero con temática de Animales.**

- Implementar una jerarquía de clases para animales, aplicando **POO y polimorfismo**.
- Se deben poder agregar distintos tipos de animales.
- Cada clase de animal debe sobrescribir el método `HacerSonido()` para emitir un sonido característico.

### Ejemplo de clases:
- `Perro` → `HacerSonido()` → "Guau"
- `Gato` → `HacerSonido()` → "Miau"
- `Vaca` → `HacerSonido()` → "Muuu"
- `Gallina` → `HacerSonido()` → "Cloc cloc"
- `León` → `HacerSonido()` → "Rugido"

### Funcionalidades requeridas:
- Vista para dar de alta un nuevo animal (seleccionando su tipo)
- Vista para listar todos los animales creados, mostrando su nombre y sonido

---

## ✅ Instrucciones

1. Hacer un fork de este repositorio
2. Clonar el fork en tu máquina local
3. Implementar la solución en base a la consigna
4. Realizar un Pull Request contra el repositorio original