namespace Listas
{
    public class Ejercicio49
    {
         public void Ejecutar()
        {
            List<int> numeros = new List<int>();
            List<int> pares = new List<int>();
            List<int> impares = new List<int>();

            Console.WriteLine("Ingrese 15 números enteros:");

            for (int i = 0; i < 15; i++)
            {
                Console.Write($"Número #{i + 1}: ");
                int numero = Convert.ToInt32(Console.ReadLine());

                numeros.Add(numero);
            }

            // Separar pares e impares
            foreach (int numero in numeros)
            {
                if (numero % 2 == 0)
                {
                    pares.Add(numero);
                }
                else
                {
                    impares.Add(numero);
                }
            }

            // Ordenar listas
            pares.Sort();
            impares.Sort();

            // Mostrar pares
            Console.WriteLine("\n NÚMEROS PARES");

            foreach (int numero in pares)
            {
                Console.Write(numero + " ");
            }

            // Mostrar impares
            Console.WriteLine("\n\n NÚMEROS IMPARES ");

            foreach (int numero in impares)
            {
                Console.Write(numero + " ");
            }

            Console.WriteLine();
        }
    }
}