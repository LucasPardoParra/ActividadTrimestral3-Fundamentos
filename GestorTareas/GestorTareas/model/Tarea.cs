public class Tarea
{
    public int id { get; set; }
    public string? nombre { get; set; }
    public string? descripcion { get; set; }
    public TipoTarea tipo { get; set; }
    public bool prioridad { get; set; }
    public static List<Tarea> listaTareas = new List<Tarea>();
    public Tarea() { }
    public Tarea(int id, string? nombre, string? descripcion, TipoTarea tipo, bool prioridad)
    {
        this.id = id;
        this.nombre = nombre;
        this.descripcion = descripcion;
        this.tipo = tipo;
        this.prioridad = prioridad;
    }

    private void MostrarTarea(Tarea tarea)
    {
        System.Console.WriteLine("ID: " + tarea.id);
        System.Console.WriteLine("Nombre: " + tarea.nombre);
        System.Console.WriteLine("Descripción: " + tarea.descripcion);
        System.Console.WriteLine("Tipo: " + tarea.tipo);
        System.Console.WriteLine("Prioridad: " + tarea.prioridad);
        System.Console.WriteLine();
    }

    public void CrearTarea()
    {
        int opcion1;
        int opcion2;

        Console.WriteLine("Ingresa el nombre de la tarea: ");
        nombre = Console.ReadLine();
        Console.WriteLine("Ingresa la descripción de la tarea: ");
        descripcion = Console.ReadLine();

        try
        {
            Console.WriteLine("Ingresa la prioridad de la tarea: (true/false): ");
            System.Console.WriteLine("1. Tarea prioritaria");
            System.Console.WriteLine("2. Tarea no prioritaria");
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
                System.Console.WriteLine("Por favor, vuelve a crear la tarea.");
                System.Console.WriteLine();
                return;
            }
        }
        catch (FormatException e)
        {
            Console.WriteLine("Error: Has introducido un dato no válido.");
            System.Console.WriteLine("Por favor, vuelve a crear la tarea.");
            return;
        }

        System.Console.WriteLine("Selecciona el tipo de tarea (escribe 1, 2 o 3):");
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
                    System.Console.WriteLine("Por favor, vuelve a crear la tarea.");
                    System.Console.WriteLine();
                    return;
            }
        }
        catch (FormatException e)
        {
            Console.WriteLine("Error: Has introducido un dato no válido.");
            System.Console.WriteLine("Por favor, vuelve a crear la tarea.");
        }

        // Una vez los datos son correctos, se asigna un id único a la tarea
        // En este caso, se asigna un id aleatorio entre 1 y 9999
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
        if (listaTareas.Count == 0)
        {
            System.Console.WriteLine("No hay tareas disponibles.");
            return;
        }

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
                    System.Console.WriteLine("Tipo de tarea no válido");
                    return;
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("Error: Has introducido un caracter incorrecto.");
            System.Console.WriteLine("Por favor, vuelve a intentarlo desde el principio.");
        }

        System.Console.WriteLine("Tareas de tipo " + tipo + ":");

        int contador = 0;
        foreach (Tarea tarea in listaTareas)
        {
            if (tarea.tipo == tipo)
            {
                contador++;
                MostrarTarea(tarea);
            }
        }
        if (contador == 0)
        {
            System.Console.WriteLine("No se encontraron tareas de tipo " + tipo);
        }
    }

    public void BuscarTareaPrioridad()
    {
        if (listaTareas.Count == 0)
        {
            System.Console.WriteLine("No hay tareas disponibles.");
            return;
        }

        Console.WriteLine("Ingresa la prioridad de la tarea: (true/false): ");
        System.Console.WriteLine("1. Tarea prioritaria");
        System.Console.WriteLine("2. Tarea no prioritaria");
        try
        {
            int opcion = Convert.ToInt32(Console.ReadLine());
            if (opcion == 1)
            {
                prioridad = true;
            }
            else if (opcion == 2)
            {
                prioridad = false;
            }
            else
            {
                System.Console.WriteLine("Prioridad no válida");
                System.Console.WriteLine("Por favor, vuelve a intentarlo desde el principio.");
                return;
            }
        }
        catch (FormatException e)
        {
            Console.WriteLine("Error: Has introducido un caracter incorrecto.");
            System.Console.WriteLine("Por favor, vuelve a intentarlo desde el principio.");
            return;
        }

        if (prioridad == true)
        {
            System.Console.WriteLine("Tareas prioritarias:");
        }
        else
        {
            System.Console.WriteLine("Tareas no prioritarias:");
        }
        int contador = 0;
        foreach (Tarea tarea in listaTareas)
        {
            if (tarea.prioridad == prioridad)
            {
                contador++;
                MostrarTarea(tarea);
            }
        }
        if (contador == 0)
        {
            System.Console.WriteLine("No se encontraron tareas de esa prioridad.");
        }
    }

    public void BuscarTareaId()
    {
        if (listaTareas.Count == 0)
        {
            System.Console.WriteLine("No hay tareas disponibles.");
            return;
        }

        System.Console.WriteLine("Ingresa el ID de la tarea a buscar: ");
        try
        {
            id = Convert.ToInt32(Console.ReadLine());
        }
        catch (FormatException e)
        {
            Console.WriteLine("Error: Has introducido un caracter incorrecto.");
            System.Console.WriteLine("Por favor, vuelve a intentarlo desde el principio.");
            return;
        }

        System.Console.WriteLine("Tarea con ID " + id + ":");
        int contador = 0;
        foreach (Tarea tarea in listaTareas)
        {
            if (tarea.id == id)
            {
                contador++;
                MostrarTarea(tarea);
            }
        }
        if (contador == 0)
        {
            System.Console.WriteLine("Esta tarea no existe.");
        }
    }

    public void MostrarAllTareas()
    {
        if (listaTareas.Count == 0)
        {
            System.Console.WriteLine("No hay tareas disponibles.");
            System.Console.WriteLine();
            return;
        }

        foreach (Tarea tarea in listaTareas)
        {
            MostrarTarea(tarea);
        }
    }

    public void EliminarTarea()
    {
        if (listaTareas.Count == 0)
        {
            System.Console.WriteLine("No hay tareas disponibles.");
            return;
        }

        System.Console.WriteLine("Ingresa el ID de la tarea a eliminar: ");
        try
        {
            id = Convert.ToInt32(Console.ReadLine());
        }
        catch (Exception e)
        {
            Console.WriteLine("Error: " + e.Message);
            System.Console.WriteLine("Por favor, vuelve a crear la tarea.");
            return;
        }

        foreach (Tarea tarea in listaTareas)
        {
            if (tarea.id == id)
            {
                listaTareas.Remove(tarea);
                System.Console.WriteLine("Tarea eliminada con éxito.");
                return;
            }
        }
        System.Console.WriteLine("No se encontró ninguna tarea con el ID " + id);
    }

    public void ExportarTareas(string path)
    {
        if (listaTareas.Count == 0)
        {
            System.Console.WriteLine("No hay tareas disponibles.");
            return;
        }

        if (!File.Exists(path))
        {
            System.Console.WriteLine("El fichero no existe, se creará uno nuevo.");
            File.Create(path).Close();
        }
        FileStream? fileStream = null;
        StreamWriter? streamWriter = null;
        try
        {
            fileStream = new FileStream(path, FileMode.Create);
            streamWriter = new StreamWriter(fileStream);
            foreach (Tarea tarea in listaTareas)
            {
                streamWriter.WriteLine($"{tarea.id},{tarea.nombre},{tarea.descripcion},{tarea.tipo},{tarea.prioridad}");
            }
        }
        catch (IOException e)
        {
            System.Console.WriteLine("Error de entrada/salida.");
            System.Console.WriteLine(e.Message);
        }
        catch (Exception e)
        {
            System.Console.WriteLine("Error al abrir el fichero.");
            System.Console.WriteLine(e.Message);
        }
        finally
        {
            try
            {
                streamWriter?.Close();
                fileStream?.Close();
            }
            catch (IOException e)
            {
                System.Console.WriteLine("Error de entrada/salida al cerrar el fichero.");
                System.Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                System.Console.WriteLine("Error al cerrar el fichero.");
                System.Console.WriteLine(e.Message);
            }
        }
        System.Console.WriteLine("Tareas exportadas con éxito.");
    }

    public void ImportarTareas(string path)
    {
        if (!File.Exists(path))
        {
            System.Console.WriteLine("El fichero desde el que deseas importar no existe.");
            return;
        }

        // Si el documento está vacío, no se puede importar nada
        if (new FileInfo(path).Length == 0)
        {
            System.Console.WriteLine("El fichero está vacío, no se puede importar nada.");
            return;
        }

        FileStream? fileStream = null;
        StreamReader? streamReader = null;
        try
        {
            fileStream = new FileStream(path, FileMode.Open);
            streamReader = new StreamReader(fileStream);
            string? linea;
            while ((linea = streamReader.ReadLine()) != null)
            {
                string[] datosTarea = linea.Split(',');
                Tarea tarea = new Tarea(Convert.ToInt32(datosTarea[0]), datosTarea[1], datosTarea[2], (TipoTarea)Enum.Parse(typeof(TipoTarea), datosTarea[3]), bool.Parse(datosTarea[4]));
                listaTareas.Add(tarea);
            }
            System.Console.WriteLine("Tareas importadas con éxito.");
        }
        catch (IOException e)
        {
            System.Console.WriteLine("Error de entrada/salida.");
            System.Console.WriteLine(e.Message);
        }
        catch (Exception e)
        {
            System.Console.WriteLine("Error al importar las tareas.");
            System.Console.WriteLine(e.Message);
            System.Console.WriteLine(e.Source);
            System.Console.WriteLine(e.ToString());
            System.Console.WriteLine(e.HelpLink);
        }
        finally
        {
            try
            {
                streamReader?.Close();
                fileStream?.Close();
            }
            catch (IOException e)
            {
                System.Console.WriteLine("Error de entrada/salida al cerrar el fichero.");
                System.Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                System.Console.WriteLine("Error al cerrar el fichero.");
                System.Console.WriteLine(e.Message);
            }
        }
    }
}