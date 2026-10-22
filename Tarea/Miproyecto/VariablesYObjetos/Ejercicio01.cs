
using System;

namespace VariablesYObjetos
{
    public class CurrencyConverter
    {
        public void Ejecutar()
        {
            Console.Write("Ingrese el monto en lempiras: ");
            double lempiras = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese la tasa de cambio del dólar: ");
            double tasaDolar = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese la tasa de cambio del euro: ");
            double tasaEuro = Convert.ToDouble(Console.ReadLine());

            double dolares = lempiras / tasaDolar;
            double euros = lempiras / tasaEuro;

            Console.WriteLine($"Lempiras: L {lempiras:F2}");
            Console.WriteLine($"Dólares: $ {dolares:F2}");
            Console.WriteLine($"Euros: € {euros:F2}");
        }

    }
}