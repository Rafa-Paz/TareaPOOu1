namespace ArreglosUnidimensionales
{
    public class Ejercicio40
    {
         public void Ejecutar()
        {
            Random random = new Random();

            int[] numeros = new int[20];
            int[] frecuencia = new int[11]; // índices 1-10

            Console.WriteLine("Números generados:");

            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = random.Next(1, 11);
                frecuencia[numeros[i]]++;

                Console.Write(numeros[i] + " ");
            }

            // Mostrar frecuencias

            int masFrecuente = 1;
            int menosFrecuente = 1;

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"Número {i}: {frecuencia[i]} veces");

                if (frecuencia[i] > frecuencia[masFrecuente])
                {
                    masFrecuente = i;
                }

                if (frecuencia[i] < frecuencia[menosFrecuente])
                {
                    menosFrecuente = i;
                }
            }

            Console.WriteLine($"Más frecuente: {masFrecuente} ({frecuencia[masFrecuente]} veces)");
            Console.WriteLine($"Menos frecuente: {menosFrecuente} ({frecuencia[menosFrecuente]} veces)");
        }
    }
}