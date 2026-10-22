namespace ArreglosUnidimensionales
{
    public class Ejercicio37
    {
        public void Ejecutar()
        {
            Console.Write("¿Cuántos números desea ingresar? ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] numeros = new int[n];

            // Llenar el arreglo
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Número {i + 1}: ");
                numeros[i] = Convert.ToInt32(Console.ReadLine());
            }

            // Recorrido con FOR
            int suma = 0;
            int mayor = numeros[0];
            int menor = numeros[0];

            for (int i = 0; i < numeros.Length; i++)
            {
                suma += numeros[i];

                if (numeros[i] > mayor)
                    mayor = numeros[i];

                if (numeros[i] < menor)
                    menor = numeros[i];
            }

            double promedio = (double)suma / numeros.Length;

            Console.WriteLine("\n=== RESULTADOS CON FOR ===");
            Console.WriteLine($"Suma: {suma}");
            Console.WriteLine($"Promedio: {promedio:F2}");
            Console.WriteLine($"Mayor: {mayor}");
            Console.WriteLine($"Menor: {menor}");

            // Recorrido con FOREACH

            foreach (int numero in numeros)
            {
                Console.Write(numero + " ");
            }

            Console.WriteLine();
        }
    }
}