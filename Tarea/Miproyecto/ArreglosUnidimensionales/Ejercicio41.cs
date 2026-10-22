namespace ArreglosUnidimensionales
{
    public class Ejercicio41
    {
        public void Ejecutar()
        {
            double[] temperaturas = new double[7];
            double suma = 0;

            // Ingreso de temperaturas
            for (int i = 0; i < temperaturas.Length; i++)
            {
                Console.Write($"Temperatura del día {i + 1}: ");
                temperaturas[i] = Convert.ToDouble(Console.ReadLine());

                suma += temperaturas[i];
            }

            double promedio = suma / temperaturas.Length;

            // Inicialización
            double mayor = temperaturas[0];
            double menor = temperaturas[0];
            int diaMasCaluroso = 1;
            int diaMasFrio = 1;
            int diasSobrePromedio = 0;

            // Recorrido
            for (int i = 0; i < temperaturas.Length; i++)
            {
                if (temperaturas[i] > promedio)
                    diasSobrePromedio++;

                if (temperaturas[i] > mayor)
                {
                    mayor = temperaturas[i];
                    diaMasCaluroso = i + 1;
                }

                if (temperaturas[i] < menor)
                {
                    menor = temperaturas[i];
                    diaMasFrio = i + 1;
                }
            }

            // Resultados principales
            Console.WriteLine("\n=== REPORTE SEMANAL ===");
            Console.WriteLine($"Promedio semanal: {promedio:F2} °C");
            Console.WriteLine($"Días sobre el promedio: {diasSobrePromedio}");
            Console.WriteLine($"Día más caluroso: Día {diaMasCaluroso} ({mayor} °C)");
            Console.WriteLine($"Día más frío: Día {diaMasFrio} ({menor} °C)");

            // Variaciones

            for (int i = 0; i < temperaturas.Length - 1; i++)
            {
                double variacion = temperaturas[i + 1] - temperaturas[i];

                Console.WriteLine(
                    $"Día {i + 1} → Día {i + 2}: {variacion:F2} °C");
            }
        }    
    }
}