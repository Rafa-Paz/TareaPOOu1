namespace Listas
{
    public class Ejercicio48
    {
        public void Ejecutar()
        {
            List<int> numeros = new List<int>();

            Console.Write("¿Cuántos números desea ingresar? ");
            int n = Convert.ToInt32(Console.ReadLine());

            int duplicadosDescartados = 0;

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Número #{i + 1}: ");
                int numero = Convert.ToInt32(Console.ReadLine());

                if (numeros.Contains(numero))
                {
                    duplicadosDescartados++;
                    Console.WriteLine("Número duplicado. No fue agregado.");
                }
                else
                {
                    numeros.Add(numero);
                }
            }

            Console.WriteLine("\nLISTA RESULTANTE");

            foreach (int numero in numeros)
            {
                Console.Write(numero + " ");
            }

            Console.WriteLine();
            Console.WriteLine($"\nElementos únicos: {numeros.Count}");
            Console.WriteLine($"Duplicados descartados: {duplicadosDescartados}");
        }
    }
}