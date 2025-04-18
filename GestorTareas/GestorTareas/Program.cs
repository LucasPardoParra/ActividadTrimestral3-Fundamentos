// - Crear tareas: se pedirá el nombre, descripción, tipo y prioridad de la tarea y el id se asignará automáticamente y será único para cada tarea
// - Buscar tareas por tipo: se pedirá un tipo de tarea y se mostrarán todas las tareas
// - Buscar tareas por prioridad: se pedirá un booleano (true/false) y se mostrarán todas las tareas
// - Buscar tareas por id: se pedirá un id y se mostrará la tarea con el id indicado
// - Mostrar todas las tareas: se mostrarán todas las tareas que hay en la lista de tareas
// - Eliminar tarea: se pedirá un id y se eliminará la tarea con el id indicado
// - Exportar tareas: se generará un fichero llamado tareas.txt con la información de todas
// las tareas, donde en cada fila aparecerá el id, nombre, descripción, tipo y prioridad de
// - Importar tareas: se guardarán en la lista que gestiona la app las tareas ubicadas en el
// fichero tareas.txt.

public class Program
{
    public static void Main(string[] args)
    {
        Tarea tarea = new Tarea();
        int opcion = 0;

        System.Console.WriteLine();
        System.Console.WriteLine("---------------------------------------------------");

        // Menú iterativo para gestionar las tareas
        System.Console.WriteLine("Bienvenido a tu Gestor de Tareas Personales");
        do
        {
            try
            {
                System.Console.WriteLine("Por favor, selecciona una opción del menú (introduzca el número correspondiente):");
                System.Console.WriteLine("1. Crear tarea");
                System.Console.WriteLine("2. Buscar tareas por tipo");
                System.Console.WriteLine("3. Buscar tareas por prioridad");
                System.Console.WriteLine("4. Buscar tareas por ID");
                System.Console.WriteLine("5. Mostrar todas las tareas");
                System.Console.WriteLine("6. Eliminar tarea");
                System.Console.WriteLine("7. Exportar tareas");
                System.Console.WriteLine("8. Importar tareas");
                System.Console.WriteLine("9. Salir");

                opcion = Convert.ToInt32(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        System.Console.WriteLine();
                        tarea.CrearTarea();
                        break;
                    case 2:
                        System.Console.WriteLine();
                        tarea.BuscarTareaTipo();
                        break;
                    case 3:
                        System.Console.WriteLine();
                        tarea.BuscarTareaPrioridad();
                        break;
                    case 4:
                        System.Console.WriteLine();
                        tarea.BuscarTareaId();
                        break;
                    case 5:
                        System.Console.WriteLine();
                        tarea.MostrarTareas();
                        break;
                    case 6:
                        System.Console.WriteLine();
                        tarea.EliminarTarea();
                        break;
                    case 7:
                        System.Console.WriteLine();
                        tarea.ExportarTareas();
                        break;
                    case 8:
                        System.Console.WriteLine();
                        tarea.ImportarTareas();
                        break;
                    case 9:
                        System.Console.WriteLine();
                        System.Console.WriteLine("Saliendo del programa...");
                        System.Console.WriteLine("Gracias por usar el Gestor de Tareas Personales. ¡Hasta luego!");
                        System.Console.WriteLine("---------------------------------------------------");
                        break;
                    default:
                        System.Console.WriteLine();
                        System.Console.WriteLine("Opción no válida. Por favor, introduzca un número del 1 al 9.");
                        System.Console.WriteLine();
                        break;
                }
            }
            catch (FormatException e)
            {
                Console.WriteLine("Error: Has introducido un caracter incorrecto.");
                System.Console.WriteLine("Por favor, introduzca un número del 1 al 9.");
                System.Console.WriteLine();
            }
        } while (opcion != 9);
    }
}
