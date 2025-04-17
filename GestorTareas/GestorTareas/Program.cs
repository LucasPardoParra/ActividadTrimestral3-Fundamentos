// Crea un programa que permita gestionar tareas personales. La aplicación deberá permitir
// mediante un menú el siguiente funcionamiento
// - Crear tareas: se pedirá el nombre, descripción, tipo y prioridad de la tarea
// - Buscar tareas por tipo: se pedirá un tipo de tarea y se mostrarán todas las tareas
// - Eliminar tarea: se pedirá un id y se eliminará la tarea con el id indicado
// - Exportar tareas: se generará un fichero llamado tareas.txt con la información de todas
// las tareas, donde en cada fila aparecerá el id, nombre, descripción, tipo y prioridad de
// - Importar tareas: se guardarán en la lista que gestiona la app las tareas ubicadas en el
// fichero tareas.txt.

// En las tareas hay que tener las siguientes consideraciones:
// -El id se asignará automáticamente y será único para cada tarea
// - El tipo tan solo podrá ser alguno de los siguientes: persona, trabajo, ocio. Por ello es
// necesario utilizar un Enum
// - La prioridad será un booleano, siendo true la prioridad y false la no prioridad

public class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine();
        System.Console.WriteLine("---------------------------------------------------");
    }
}

