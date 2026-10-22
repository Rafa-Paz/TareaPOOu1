namespace VariablesYObjetos
{
    public class LoanCalculator
    {
         public void Ejecutar()
        {
            Console.Write("Ingrese el monto del préstamo: ");
            double monto = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese la tasa de interés anual (%): ");
            double tasaAnual = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese el plazo en meses: ");
            int meses = Convert.ToInt32(Console.ReadLine());

            double interesTotal = monto * (tasaAnual / 100) * (meses / 12.0);

            double totalPagar = monto + interesTotal;

            double cuotaMensual = totalPagar / meses;

            //Mostrar resultados
            Console.WriteLine($"Monto prestado: L. {monto:F2}");
            Console.WriteLine($"Interés total: L. {interesTotal:F2}");
            Console.WriteLine($"Total a pagar: L. {totalPagar:F2}");
            Console.WriteLine($"Cuota mensual: L. {cuotaMensual:F2}");
        }
    }
}