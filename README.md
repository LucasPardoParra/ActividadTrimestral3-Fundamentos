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

1. **Crear tareas**:
   - Solicita al usuario el nombre, descripción, tipo y prioridad de la tarea.
   - Valida los datos ingresados para garantizar su corrección.

2. **Buscar tareas por tipo**:
   - Permite al usuario seleccionar un tipo de tarea (personal, trabajo u ocio).
   - Muestra todas las tareas que coinciden con el tipo seleccionado.

3. **Eliminar tareas**:
   - Solicita al usuario el identificador (`id`) de la tarea que desea eliminar.
   - Elimina la tarea correspondiente si el identificador es válido.

4. **Exportar tareas**:
   - Genera un archivo de texto (`tareas.txt`) con la información de todas las tareas registradas.
   - Cada fila del archivo contiene los datos de una tarea: `id`, nombre, descripción, tipo y prioridad.

5. **Importar tareas**:
   - Carga las tareas desde el archivo `tareas.txt` y las agrega a la lista de tareas gestionadas por la aplicación.

### 📢 Proyecto creado por Lucas Pardo. 
