namespace VariablesYObjetos
{
    public class Breakdown
    {
        public void Ejecutar()
        {
            Console.Write("Ingrese el monto en lempiras: ");
            int monto = Convert.ToInt32(Console.ReadLine());

            int billetes500 = monto / 500;
            monto %= 500;

            int billetes100 = monto / 100;
            monto %= 100;

            int billetes50 = monto / 50;
            monto %= 50;

            int billetes20 = monto / 20;
            monto %= 20;

            int billetes10 = monto / 10;
            monto %= 10;

            int billetes5 = monto / 5;
            monto %= 5;

            int billetes2 = monto / 2;
            monto %= 2;

            int billetes1 = monto;

            //desglose de billetes
            Console.WriteLine($"L.500 : {billetes500}");
            Console.WriteLine($"L.100 : {billetes100}");
            Console.WriteLine($"L.50  : {billetes50}");
            Console.WriteLine($"L.20  : {billetes20}");
            Console.WriteLine($"L.10  : {billetes10}");
            Console.WriteLine($"L.5   : {billetes5}");
            Console.WriteLine($"L.2   : {billetes2}");
            Console.WriteLine($"L.1   : {billetes1}");
        }
    }
}