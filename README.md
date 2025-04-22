# ✅ Gestor de Tareas

El **Gestor de Tareas** es una aplicación de consola desarrollada en **C#** que permite gestionar tareas personales de forma sencilla y eficiente. A través de un menú interactivo, los usuarios pueden realizar diversas operaciones como crear, buscar, eliminar, exportar e importar tareas.

## ✨ Características

- **📋 Crear tareas**: Permite ingresar el nombre, descripción, tipo y prioridad de una tarea.
- **🔍 Buscar tareas por tipo**: Filtra y muestra las tareas según su tipo (personal, trabajo u ocio).
- **🗑️ Eliminar tareas**: Elimina una tarea específica mediante su identificador único.
- **📤 Exportar tareas**: Genera un archivo `tareas.txt` con la información de todas las tareas registradas.
- **📥 Importar tareas**: Carga las tareas desde el archivo `tareas.txt` y las agrega a la lista gestionada por la aplicación.

## 📌 Consideraciones

1. **Identificador único**: Cada tarea tiene un identificador (`id`) que se asigna automáticamente y es único.
2. **Tipos de tarea**: Los tipos de tarea están limitados a las siguientes categorías:
   - Personal
   - Trabajo
   - Ocio  
   Esto se implementa mediante un enumerado (`enum`).
3. **Prioridad**: La prioridad de una tarea se define como un valor booleano:
   - `true`: Alta prioridad.
   - `false`: Baja prioridad.

## ⚙️ Funcionamiento

El programa presenta un menú interactivo que permite al usuario realizar las siguientes acciones:

### 1. Crear Tareas
- Permite al usuario ingresar:
  - **Nombre** de la tarea.
  - **Descripción** de la tarea.
  - **Tipo** de tarea: Personal, Trabajo u Ocio.
  - **Prioridad**: Alta o Baja.
- El ID de la tarea se genera automáticamente y es único.

### 2. Buscar Tareas
- **Por Tipo**: Filtra las tareas según su tipo (Personal, Trabajo u Ocio).
- **Por Prioridad**: Filtra las tareas según su prioridad (Alta o Baja).
- **Por ID**: Busca una tarea específica por su identificador único.

### 3. Mostrar Todas las Tareas
- Muestra todas las tareas almacenadas en la lista, incluyendo:
  - ID
  - Nombre
  - Descripción
  - Tipo
  - Prioridad

### 4. Eliminar Tareas
- Permite eliminar una tarea específica ingresando su ID.

### 5. Exportar Tareas
- Exporta todas las tareas a un archivo de texto (`tareas.txt`).
- Cada tarea se guarda en una línea con el formato `id,nombre,descripcion,tipo,prioridad`

### 6. Importar Tareas
- Importa tareas desde un archivo de texto (`tareas.txt`).
- Las tareas se agregan a la lista existente.

### 7. Salir
- Finaliza la ejecución del programa.

### 📢 Proyecto creado por Lucas Pardo como parte de las actividades trimestrales del GS Desarrollo de Aplicaciones Web. 
