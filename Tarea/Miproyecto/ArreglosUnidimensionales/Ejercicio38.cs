namespace ArreglosUnidimensionales
{
    public class Ejercicio38
    {
        public void Ejecutar()
        {
            string[] nombres = new string[5];

            // Llenar arreglo
            Console.WriteLine("Ingrese 5 nombres:");

            for (int i = 0; i < nombres.Length; i++)
            {
                Console.Write($"Nombre #{i + 1}: ");
                nombres[i] = Console.ReadLine() ?? "";
            }

            // Mostrar en orden inverso

            for (int i = nombres.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(nombres[i]);
            }

            // Buscar nombre más largo
            string nombreMasLargo = nombres[0];

            foreach (string nombre in nombres)
            {
                if (nombre.Length > nombreMasLargo.Length)
                {
                    nombreMasLargo = nombre;
                }
            }

            Console.WriteLine($"\nNombre más largo: {nombreMasLargo}");
            Console.WriteLine($"Cantidad de caracteres: {nombreMasLargo.Length}");

            // Buscar nombre
            Console.Write("\nIngrese un nombre a buscar: ");
            string buscar = Console.ReadLine() ?? "";

            bool encontrado = false;

            foreach (string nombre in nombres)
            {
                if (nombre.Equals(buscar, StringComparison.OrdinalIgnoreCase))
                {
                    encontrado = true;
                    break;
                }
            }

            if (encontrado)
            {
                Console.WriteLine("El nombre sí existe en el arreglo.");
            }
            else
            {
                Console.WriteLine("El nombre no existe en el arreglo.");
            }
        }    
    }
}