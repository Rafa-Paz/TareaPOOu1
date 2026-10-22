namespace VariablesYObjetos
{
    public class Salary
    {
        public void Ejecutar()
        {
            Console.Write("Ingrese las horas trabajadas: ");
            double horasTrabajadas = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese la tarifa por hora: ");
            double tarifaHora = Convert.ToDouble(Console.ReadLine());

            double horasNormales;
            double horasExtras;
            double pagoNormal;
            double pagoExtra;
            double totalPagar;

            if (horasTrabajadas <= 44)
            {
                horasNormales = horasTrabajadas;
                horasExtras = 0;
            }
            else
            {
                horasNormales = 44;
                horasExtras = horasTrabajadas - 44;
            }

            pagoNormal = horasNormales * tarifaHora;
            pagoExtra = horasExtras * tarifaHora * 1.5;

            totalPagar = pagoNormal + pagoExtra;

            //desglose de pago
            Console.WriteLine($"Horas normales: {horasNormales}");
            Console.WriteLine($"Horas extras: {horasExtras}");
            Console.WriteLine($"Pago horas normales: L. {pagoNormal:F2}");
            Console.WriteLine($"Pago horas extras: L. {pagoExtra:F2}");
            Console.WriteLine($"TOTAL A PAGAR: L. {totalPagar:F2}");
        }
    }
}