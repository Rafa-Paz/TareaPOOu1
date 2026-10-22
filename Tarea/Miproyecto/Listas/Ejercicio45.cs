namespace Listas
{
    public class Ejercicio45
    {
        public void Ejecutar()
        {
            List<string> tareas = new List<string>();
            bool salir = false;

            while (!salir)
            {
                Console.WriteLine("1. Agregar tarea");
                Console.WriteLine("2. Mostrar tareas");
                Console.WriteLine("3. Eliminar tarea");
                Console.WriteLine("4. Total de tareas pendientes");
                Console.WriteLine("5. Salir");

                Console.Write("Seleccione una opción: ");
                int opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.Write("Ingrese la tarea: ");
                        string tarea = Console.ReadLine() ?? "";
                        tareas.Add(tarea);

                        Console.WriteLine("Tarea agregada correctamente.");
                        break;

                    case 2:
                        Console.WriteLine("\n=== LISTA DE TAREAS ===");

                        if (tareas.Count == 0)
                        {
                            Console.WriteLine("No hay tareas registradas.");
                        }
                        else
                        {
                            for (int i = 0; i < tareas.Count; i++)
                            {
                                Console.WriteLine($"{i + 1}. {tareas[i]}");
                            }
                        }
                        break;

                    case 3:
                        if (tareas.Count == 0)
                        {
                            Console.WriteLine("No hay tareas para eliminar.");
                        }
                        else
                        {
                            Console.Write("Ingrese el número de la tarea a eliminar: ");
                            int numero = Convert.ToInt32(Console.ReadLine());

                            if (numero >= 1 && numero <= tareas.Count)
                            {
                                tareas.RemoveAt(numero - 1);
                                Console.WriteLine("Tarea eliminada correctamente.");
                            }
                            else
                            {
                                Console.WriteLine("Número de tarea inválido.");
                            }
                        }
                        break;

                    case 4:
                        Console.WriteLine($"Tareas pendientes: {tareas.Count}");
                        break;

                    case 5:
                        salir = true;
                        Console.WriteLine("Saliendo...");
                        break;

                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }
            }
        }    
    }
}