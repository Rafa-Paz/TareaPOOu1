namespace Condicionales
{
    public class Ejercicio22
    {
        public void Ejecutar()
        {
            double saldo = 5000;

            Console.WriteLine($"Saldo disponible: L. {saldo:F2}");

            Console.Write("Ingrese el monto a retirar: L. ");
            int retiro = Convert.ToInt32(Console.ReadLine());

            // Validar monto positivo
            if (retiro <= 0)
            {
                Console.WriteLine("Error: El monto debe ser mayor que cero.");
                return;
            }

            // Validar múltiplo de 20
            if (retiro % 20 != 0)
            {
                Console.WriteLine("Error: El monto debe ser múltiplo de 20.");
                return;
            }

            // Validar saldo suficiente
            if (retiro > saldo)
            {
                Console.WriteLine("Error: Saldo insuficiente.");
                return;
            }

            int restante = retiro;

            int billetes500 = restante / 500;
            restante %= 500;

            int billetes100 = restante / 100;
            restante %= 100;

            int billetes50 = restante / 50;
            restante %= 50;

            int billetes20 = restante / 20;

            saldo -= retiro;

            // Mostrar resultados
            Console.WriteLine($"Monto retirado: L. {retiro}");
            Console.WriteLine($"Saldo restante: L. {saldo:F2}");

            Console.WriteLine("\n=== DESGLOSE DE BILLETES ===");
            Console.WriteLine($"L.500 : {billetes500}");
            Console.WriteLine($"L.100 : {billetes100}");
            Console.WriteLine($"L.50  : {billetes50}");
            Console.WriteLine($"L.20  : {billetes20}");
        }
    }
}