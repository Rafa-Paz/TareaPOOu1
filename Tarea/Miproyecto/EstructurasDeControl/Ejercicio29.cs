using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EstructurasDeControl
{
    public class Ejercicio29
    {
        public void Ejecutar()
        {
            Console.Write("Ingrese la cantidad de términos: ");
            int n = Convert.ToInt32(Console.ReadLine());

            if (n <= 0)
            {
                Console.WriteLine("Error: Debe ingresar un número mayor que cero.");
                return;
            }

            int a = 0;
            int b = 1;
            int siguiente;

            long suma = 0;

            // Mostrar serie

            for (int i = 1; i <= n; i++)
            {
                Console.Write(a + " ");

                suma += a;

                siguiente = a + b;
                a = b;
                b = siguiente;
            }

            double promedio = (double)suma / n;

           // Mostrar resultados
            Console.WriteLine($"Cantidad de términos: {n}");
            Console.WriteLine($"Suma total: {suma}");
            Console.WriteLine($"Promedio: {promedio:F2}");
        }
    }
}