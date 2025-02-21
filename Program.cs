using System;



class GestorEstudiantes
{
    private static List<string> estudiantes = new List<string>();
    private static List<double> calificaciones = new List<double>();



    public static void AgregarEstudiantes()
    {
        Console.Write("Ingrese el nombre del estudiante: ");
        string nombre = Console.ReadLine();
        Console.Write("Ingrese la calificación del estudiante: ");
        double calificacion = double.Parse(Console.ReadLine());
        estudiantes.Add(nombre);
        calificaciones.Add(calificacion);
        Console.WriteLine("Estudiante agregado correctamente.");
    }
    public static void Mostrarlistaestudiantes()
    {
        if (estudiantes.Count == 0)
        {
            Console.WriteLine("No hay estudiantes registrados.");
        }
        else
        {
            Console.WriteLine("\nLista de estudiantes:");
            for (int i = 0; i < estudiantes.Count; i++)
            {
                Console.WriteLine($"{estudiantes[i]} - Calificación: {calificaciones[i]}");
            }
        }
    }


    public static void CalcularPromedio()
    {
        if (calificaciones.Count == 0)
        {
            Console.WriteLine("No hay calificaciones registradas.");
        }
        else
        {
            double suma = 0;
            foreach (double calificacion in calificaciones)
            {
                suma += calificacion;
            }
            double promedio = suma / calificaciones.Count;
            Console.WriteLine($"El promedio de calificaciones es: {promedio}");
        }
    }
    public static void EstudianteConCalificacionMasAlta()
    {
        if (calificaciones.Count == 0)
        {
            Console.WriteLine("No hay calificaciones registradas.");
        }
        else
        {
            double maxCalificacion = calificaciones[0];
            string estudianteMax = estudiantes[0];
            for (int i = 1; i < calificaciones.Count; i++)
            {
                if (calificaciones[i] > maxCalificacion)
                {
                    maxCalificacion = calificaciones[i];
                    estudianteMax = estudiantes[i];
                }
            }
            Console.WriteLine($"El estudiante con la calificación más alta es: {estudianteMax} con {maxCalificacion}");
        }
    }

}






class Menu
{
    public static void Iniciar()
    {
        Console.WriteLine("Bienvenido al sistema de gestión de estudiantes.");
        int opcion;
        do
        {
            Console.WriteLine("\n1. Agregar estudiante");
            Console.WriteLine("2. Mostrar lista de estudiantes");
            Console.WriteLine("3. Calcular promedio de calificaciones");
            Console.WriteLine("4. Mostrar estudiante con la calificación más alta");
            Console.WriteLine("5. Salir");
            Console.Write("Seleccione una opción: ");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    GestorEstudiantes.AgregarEstudiantes();
                    break;

                case 2:
                    GestorEstudiantes.Mostrarlistaestudiantes();
                    break;
                case 3:
                    GestorEstudiantes.CalcularPromedio();
                    break;
                case 4:
                    GestorEstudiantes.EstudianteConCalificacionMasAlta();
                    break;
                case 5:
                    Console.WriteLine("Saliendo del sistema...");
                    break;
            }
        } while (opcion != 5);
    }


}
class Program
{
    static void Main()
    {
        Menu.Iniciar();
    }
}
