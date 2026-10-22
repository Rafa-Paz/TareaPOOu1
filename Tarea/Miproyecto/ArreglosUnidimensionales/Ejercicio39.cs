namespace ArreglosUnidimensionales
{
    public class Ejercicio39
    {
        public void Ejecutar()
        {
            Console.Write("Ingrese la cantidad de calificaciones: ");
            int n = Convert.ToInt32(Console.ReadLine());

            double[] calificaciones = new double[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Calificación #{i + 1}: ");
                calificaciones[i] = Convert.ToDouble(Console.ReadLine());
            }

            double suma = 0;
            double maxima = calificaciones[0];
            double minima = calificaciones[0];
            int aprobados = 0;
            int reprobados = 0;

            foreach (double nota in calificaciones)
            {
                suma += nota;

                if (nota > maxima)
                    maxima = nota;

                if (nota < minima)
                    minima = nota;

                if (nota >= 60)
                    aprobados++;
                else
                    reprobados++;
            }

            double promedio = suma / n;

            // Cálculo de la desviación estándar
            double sumaCuadrados = 0;

            foreach (double nota in calificaciones)
            {
                sumaCuadrados += Math.Pow(nota - promedio, 2);
            }

            double desviacionEstandar = Math.Sqrt(sumaCuadrados / n);

            Console.WriteLine($"Promedio: {promedio:F2}");
            Console.WriteLine($"Calificación máxima: {maxima}");
            Console.WriteLine($"Calificación mínima: {minima}");
            Console.WriteLine($"Aprobados: {aprobados}");
            Console.WriteLine($"Reprobados: {reprobados}");
            Console.WriteLine($"Desviación estándar: {desviacionEstandar:F2}");
        }
    }
}