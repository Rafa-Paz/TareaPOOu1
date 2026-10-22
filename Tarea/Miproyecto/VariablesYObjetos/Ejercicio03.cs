namespace VariablesYObjetos
{
    public class exchangeOfValues
    {
        public void intercambiar()
        {
            int a = 10;
            int b = 20;

            Console.WriteLine($"Valor de A: {a}");
            Console.WriteLine($"Valor de B: {b}");

            // Intercambio usando variable temporal
            int temporal = a;
            a = b;
            b = temporal;

            Console.WriteLine($"Valor de A: {a}");
            Console.WriteLine($"Valor de B: {b}");

            // Reiniciamos valores para el segundo ejemplo
            a = 10;
            b = 20;

            // Intercambio sin variable temporal
            a = a + b;
            b = a - b;
            a = a - b;

            Console.WriteLine($"Valor de A: {a}");
            Console.WriteLine($"Valor de B: {b}");
        }
    }
}