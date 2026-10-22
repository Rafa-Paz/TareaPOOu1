namespace Condicionales
{
    public class ParkingFee
    {
       public void Ejecutar()
        {
            Console.Write("Ingrese las horas estacionado: ");
            int horas = Convert.ToInt32(Console.ReadLine());

            if (horas <= 0)
            {
                Console.WriteLine("Error: Las horas deben ser mayores que cero.");
                return;
            }

            double total;

            if (horas == 1)
            {
                total = 20;
            }
            else
            {
                total = 20 + ((horas - 1) * 10);
            }

            // Tope máximo por día
            if (total > 100)
            {
                total = 100;
            }

            //Resumen de pago
            Console.WriteLine($"Horas estacionado: {horas}");
            Console.WriteLine($"Total a pagar: L. {total:F2}");
        } 
    }
}