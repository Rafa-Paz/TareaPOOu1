namespace Listas
{
    public class Ejercicio46
    {
        public void Ejecutar()
        {
            List<string> productos = new List<string>();
            bool salir = false;

            while (!salir)
            {
                Console.WriteLine("1. Agregar producto");
                Console.WriteLine("2. Eliminar producto");
                Console.WriteLine("3. Buscar producto");
                Console.WriteLine("4. Mostrar productos ordenados");
                Console.WriteLine("5. Salir");

                Console.Write("Seleccione una opción: ");
                int opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.Write("Ingrese el nombre del producto: ");
                        string producto = Console.ReadLine() ?? "";

                        if (productos.Contains(producto))
                        {
                            Console.WriteLine("El producto ya existe.");
                        }
                        else
                        {
                            productos.Add(producto);
                            Console.WriteLine("Producto agregado correctamente.");
                        }
                        break;

                    case 2:
                        Console.Write("Ingrese el producto a eliminar: ");
                        string eliminar = Console.ReadLine() ?? "";

                        if (productos.Remove(eliminar))
                        {
                            Console.WriteLine("Producto eliminado correctamente.");
                        }
                        else
                        {
                            Console.WriteLine("Producto no encontrado.");
                        }
                        break;

                    case 3:
                        Console.Write("Ingrese el producto a buscar: ");
                        string buscar = Console.ReadLine() ?? "";

                        if (productos.Contains(buscar))
                        {
                            Console.WriteLine("Producto encontrado.");
                        }
                        else
                        {
                            Console.WriteLine("Producto no encontrado.");
                        }
                        break;

                    case 4:
                        if (productos.Count == 0)
                        {
                            Console.WriteLine("No hay productos registrados.");
                        }
                        else
                        {
                            productos.Sort();

                            Console.WriteLine("\nPRODUCTOS ORDENADOS");

                            foreach (string item in productos)
                            {
                                Console.WriteLine(item);
                            }
                        }
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