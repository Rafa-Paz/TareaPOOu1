namespace Listas
{
    public class Ejercicio50
    {
         public void Ejecutar()
        {
            List<string> nombres = new List<string>();
            List<double> promedios = new List<double>();

            bool salir = false;

            while (!salir)
            {
                Console.WriteLine("1. Agregar estudiante");
                Console.WriteLine("2. Buscar estudiante");
                Console.WriteLine("3. Mostrar mejor promedio");
                Console.WriteLine("4. Mostrar listado general");
                Console.WriteLine("5. Salir");

                Console.Write("Seleccione una opción: ");
                int opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.Write("Nombre del estudiante: ");
                        string nombre = Console.ReadLine() ?? "";

                        Console.Write("Promedio: ");
                        double promedio = Convert.ToDouble(Console.ReadLine());

                        nombres.Add(nombre);
                        promedios.Add(promedio);

                        Console.WriteLine("Estudiante agregado correctamente.");
                        break;

                    case 2:
                        Console.Write("Ingrese el nombre a buscar: ");
                        string buscar = Console.ReadLine() ?? "";

                        bool encontrado = false;

                        for (int i = 0; i < nombres.Count; i++)
                        {
                            if (nombres[i].Equals(buscar,
                                StringComparison.OrdinalIgnoreCase))
                            {
                                Console.WriteLine(
                                    $"Nombre: {nombres[i]}");
                                Console.WriteLine(
                                    $"Promedio: {promedios[i]:F2}");

                                encontrado = true;
                                break;
                            }
                        }

                        if (!encontrado)
                        {
                            Console.WriteLine("Estudiante no encontrado.");
                        }
                        break;

                    case 3:
                        if (nombres.Count == 0)
                        {
                            Console.WriteLine("No hay estudiantes registrados.");
                        }
                        else
                        {
                            int indiceMayor = 0;

                            for (int i = 1; i < promedios.Count; i++)
                            {
                                if (promedios[i] > promedios[indiceMayor])
                                {
                                    indiceMayor = i;
                                }
                            }

                            Console.WriteLine($"Nombre: {nombres[indiceMayor]}");
                            Console.WriteLine($"Promedio: {promedios[indiceMayor]:F2}");
                        }
                        break;

                    case 4:
                        if (nombres.Count == 0)
                        {
                            Console.WriteLine("No hay estudiantes registrados.");
                        }
                        else
                        {

                            for (int i = 0; i < nombres.Count; i++)
                            {
                                Console.WriteLine(
                                    $"{i + 1}. {nombres[i]} - {promedios[i]:F2}");
                            }
                        }
                        break;

                    case 5:
             
                        Console.WriteLine("Saliendo...");
                        break;

                    default:
                        Console.WriteLine("Opción inválida.");
                        break;
                }
            }
        }    
    }
}