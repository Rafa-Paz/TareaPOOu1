using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArreglosUnidimensionales
{
    public class Ejercicio44
    {
         public void Ejecutar()
        {
            Console.Write("Ingrese la cantidad de calificaciones: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] calificaciones = new int[n];

            int rango1 = 0; // 0-59
            int rango2 = 0; // 60-69
            int rango3 = 0; // 70-79
            int rango4 = 0; // 80-89
            int rango5 = 0; // 90-100

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Calificación #{i + 1}: ");
                calificaciones[i] = Convert.ToInt32(Console.ReadLine());

                if (calificaciones[i] >= 0 && calificaciones[i] <= 59)
                    rango1++;
                else if (calificaciones[i] <= 69)
                    rango2++;
                else if (calificaciones[i] <= 79)
                    rango3++;
                else if (calificaciones[i] <= 89)
                    rango4++;
                else if (calificaciones[i] <= 100)
                    rango5++;
            }


            Console.WriteLine($"0-59    : {rango1}");
            Console.WriteLine($"60-69   : {rango2}");
            Console.WriteLine($"70-79   : {rango3}");
            Console.WriteLine($"80-89   : {rango4}");
            Console.WriteLine($"90-100  : {rango5}");


            Console.Write("0-59    | ");
            for (int i = 0; i < rango1; i++)
                Console.Write("*");

            Console.WriteLine();

            Console.Write("60-69   | ");
            for (int i = 0; i < rango2; i++)
                Console.Write("*");

            Console.WriteLine();

            Console.Write("70-79   | ");
            for (int i = 0; i < rango3; i++)
                Console.Write("*");

            Console.WriteLine();

            Console.Write("80-89   | ");
            for (int i = 0; i < rango4; i++)
                Console.Write("*");

            Console.WriteLine();

            Console.Write("90-100  | ");
            for (int i = 0; i < rango5; i++)
                Console.Write("*");

            Console.WriteLine();
        }
    }
}