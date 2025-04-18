// Crea un programa que permita gestionar tareas personales. La aplicación deberá permitir
// mediante un menú el siguiente funcionamiento
// - Crear tareas: se pedirá el nombre, descripción, tipo y prioridad de la tarea
// - Buscar tareas por tipo: se pedirá un tipo de tarea y se mostrarán todas las tareas
// - Buscar tareas por prioridad: se pedirá un booleano y se mostrarán todas las tareas
// - Buscar tareas por id: se pedirá un id y se mostrará la tarea con el id indicado
// - Mostrar todas las tareas: se mostrarán todas las tareas que hay en la lista de tareas
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

public class Tarea
{
    public int id { get; set; }
    public string? nombre { get; set; }
    public string? descripcion { get; set; }
    public TipoTarea tipo { get; set; }
    public bool prioridad { get; set; }
    public List<Tarea> listaTareas = new List<Tarea>();

    public Tarea() { }
    public Tarea(int id, string? nombre, string? descripcion, TipoTarea tipo, bool prioridad)
    {
        this.id = id;
        this.nombre = nombre;
        this.descripcion = descripcion;
        this.tipo = tipo;
        this.prioridad = prioridad;
    }

    public void CrearTarea()
    {
        int opcion1;
        int opcion2;

        Console.WriteLine("Ingrese el nombre de la tarea: ");
        nombre = Console.ReadLine();
        Console.WriteLine("Ingrese la descripción de la tarea: ");
        descripcion = Console.ReadLine();

        try
        {
            Console.WriteLine("Ingrese la prioridad de la tarea: (true/false): ");
            System.Console.WriteLine("1. Tarea Prioritaria");
            System.Console.WriteLine("2. Tarea No Prioritaria");
            opcion1 = Convert.ToInt32(Console.ReadLine());
            if (opcion1 == 1)
            {
                prioridad = true;
            }
            else if (opcion1 == 2)
            {
                prioridad = false;
            }
            else
            {
                System.Console.WriteLine("Prioridad no válida");
                System.Console.WriteLine("Por favor, vuelva a crear la tarea.");
                System.Console.WriteLine();
                return;
            }
        }
        catch (FormatException e)
        {
            Console.WriteLine("Error: Has introducido un dato no valido.");
            System.Console.WriteLine("Por favor, vuelva a crear la tarea.");
            System.Console.WriteLine();
            return;
        }

        System.Console.WriteLine("Selecciona el tipo de tarea (escriba 1, 2 o 3):");
        System.Console.WriteLine("1. Personal");
        System.Console.WriteLine("2. Trabajo");
        System.Console.WriteLine("3. Ocio");

        try
        {
            opcion2 = Convert.ToInt32(Console.ReadLine());
            switch (opcion2)
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
                    System.Console.WriteLine("Por favor, vuelva a crear la tarea.");
                    System.Console.WriteLine();
                    return;
            }
        }
        catch (FormatException e)
        {
            Console.WriteLine("Error: Has introducido un dato no valido.");
            System.Console.WriteLine("Por favor, vuelva a crear la tarea.");
        }

        // Una vez los datos son correctos, se asigna un id único a la tarea
        // En este caso, se asigna un id aleatorio entre 1 y 9998
        Random random = new Random();
        id = random.Next(1, 9999);
        foreach (Tarea tarea in listaTareas)
        {
            if (tarea.id == id)
            {
                // Si el id ya existe, se genera uno nuevo
                id = random.Next(1, 9999);
            }
        }
        listaTareas.Add(new Tarea(id, nombre, descripcion, tipo, prioridad));
        System.Console.WriteLine("Tarea creada con éxito.");
    }

    public void BuscarTareaTipo()
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

    public void BuscarTareaPrioridad()
    {
        System.Console.WriteLine("Ingrese la prioridad de la tarea (true/false): ");
        try
        {
            prioridad = bool.Parse(Console.ReadLine());
        }
        catch (Exception e)
        {
            Console.WriteLine("Error: " + e.Message);
            System.Console.WriteLine("Por favor, vuelva a crear la tarea.");
            return;
        }
    }

    public void BuscarTareaId()
    {
        System.Console.WriteLine("Ingrese el id de la tarea: ");
        try
        {
            id = Convert.ToInt32(Console.ReadLine());
        }
        catch (Exception e)
        {
            Console.WriteLine("Error: " + e.Message);
            System.Console.WriteLine("Por favor, vuelva a crear la tarea.");
            return;
        }
    }

    public void MostrarTareas()
    {
        if (listaTareas.Count == 0)
        {
            System.Console.WriteLine("No hay tareas disponibles.");
            return;
        }

        System.Console.WriteLine("Lista de tareas:");
        foreach (Tarea tarea in listaTareas)
        {
            System.Console.WriteLine("Id: " + tarea.id);
            System.Console.WriteLine("Nombre: " + tarea.nombre);
            System.Console.WriteLine("Descripción: " + tarea.descripcion);
            System.Console.WriteLine("Tipo: " + tarea.tipo);
            System.Console.WriteLine("Prioridad: " + tarea.prioridad);
            System.Console.WriteLine();
        }
    }

    public void EliminarTarea()
    {
        System.Console.WriteLine("Ingrese el id de la tarea a eliminar: ");
        try
        {
            id = Convert.ToInt32(Console.ReadLine());
        }
        catch (Exception e)
        {
            Console.WriteLine("Error: " + e.Message);
            System.Console.WriteLine("Por favor, vuelva a crear la tarea.");
            return;
        }
    }

    public void ExportarTareas()
    {
        System.Console.WriteLine("Exportando tareas a tareas.txt...");
        // Implementar la lógica para exportar las tareas a un archivo de texto
    }

    public void ImportarTareas()
    {
        System.Console.WriteLine("Importando tareas desde tareas.txt...");
        // Implementar la lógica para importar las tareas desde un archivo de texto
    }
}