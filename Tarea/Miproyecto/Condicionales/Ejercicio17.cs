namespace Condicionales
{
    public class DiscountCalculator
    {
        public void Ejecutar()
        {
            Console.Write("Ingrese el monto de la compra: L. ");
            double monto = Convert.ToDouble(Console.ReadLine());

            if (monto < 0)
            {
                Console.WriteLine("Error: El monto no puede ser negativo.");
                return;
            }

            double porcentajeDescuento = 0;

            if (monto >= 2500)
            {
                porcentajeDescuento = 0.15;
            }
            else if (monto >= 1000)
            {
                porcentajeDescuento = 0.10;
            }
            else if (monto >= 500)
            {
                porcentajeDescuento = 0.05;
            }

            double descuento = monto * porcentajeDescuento;
            double precioFinal = monto - descuento;

            //Resumen de compra
            Console.WriteLine($"Precio original: L. {monto:F2}");
            Console.WriteLine($"Descuento aplicado: {porcentajeDescuento * 100}%");
            Console.WriteLine($"Monto de descuento: L. {descuento:F2}");
            Console.WriteLine($"Precio final: L. {precioFinal:F2}");
        }
    }
}