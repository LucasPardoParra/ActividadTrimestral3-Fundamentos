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
// - La prioridad será un booleano

public class Tarea
{
    public int id { get; set; }
    public string? nombre { get; set; }
    public string? descripcion { get; set; }
    public TipoTarea tipo { get; set; }
    public bool prioridad { get; set; }

    public Tarea() { }
    public Tarea(int id, string nombre, string descripcion, TipoTarea tipo, bool prioridad)
    {
        this.id = id;
        this.nombre = nombre;
        this.descripcion = descripcion;
        this.tipo = tipo;
        this.prioridad = prioridad;
    }

    public void CrearTarea()
    {
        int opcion;

        Console.WriteLine("Ingrese el nombre de la tarea: ");
        nombre = Console.ReadLine();
        Console.WriteLine("Ingrese la descripción de la tarea: ");
        descripcion = Console.ReadLine();

        try
        {
            Console.WriteLine("Ingrese la prioridad de la tarea (true/false): ");
            prioridad = bool.Parse(Console.ReadLine());
        }
        catch (Exception e)
        {
            Console.WriteLine("Error: " + e.Message);
            System.Console.WriteLine("Por favor, vuelva a crear la tarea.");
            return;
        }

        System.Console.WriteLine("Selecciona el tipo de tarea (escriba 1, 2 o 3):");
        System.Console.WriteLine("1. Personal");
        System.Console.WriteLine("2. Trabajo");
        System.Console.WriteLine("3. Ocio");

        try
        {
            opcion = Convert.ToInt32(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    tipo = TipoTarea.Personal;
                    break;
                case 2:
                    tipo = TipoTarea.Trabajo;
                    break;
                case 3:
                    tipo = TipoTarea.Ocio;
                    break;
                default:
                    System.Console.WriteLine("Tipo de tarea no válido");
                    System.Console.WriteLine();
                    return;
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("Error: " + e.Message);
            System.Console.WriteLine("Por favor, vuelva a crear la tarea.");
        }
    }

    public void BuscarTareaTipo(TipoTarea tipo)
    {
        System.Console.WriteLine("Selecciona el tipo de tarea (escriba 1, 2 o 3):");
        System.Console.WriteLine("1. Personal");
        System.Console.WriteLine("2. Trabajo");
        System.Console.WriteLine("3. Ocio");

        try
        {
            int opcion = Convert.ToInt32(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    tipo = TipoTarea.Personal;
                    break;
                case 2:
                    tipo = TipoTarea.Trabajo;
                    break;
                case 3:
                    tipo = TipoTarea.Ocio;
                    break;
                default:
                    System.Console.WriteLine("Tipo de tarea no valido");
                    return;
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("Error: " + e.Message);
        }
    }
}