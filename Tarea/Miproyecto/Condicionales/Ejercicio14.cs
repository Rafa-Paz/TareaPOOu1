namespace Condicionales
{
    public class CalculatorSwitch
    {
        public void Ejecutar()
        {
            Console.Write("Ingrese el primer número: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese el segundo número: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\n=== MENÚ DE OPERACIONES ===");
            Console.WriteLine("+  Suma");
            Console.WriteLine("-  Resta");
            Console.WriteLine("*  Multiplicación");
            Console.WriteLine("/  División");
            Console.WriteLine("%  Módulo");

            Console.Write("\nSeleccione una operación: ");
            string operacion = Console.ReadLine() ?? "";

            switch (operacion)
            {
                case "+":
                    Console.WriteLine($"\nResultado: {num1 + num2}");
                    break;

                case "-":
                    Console.WriteLine($"\nResultado: {num1 - num2}");
                    break;

                case "*":
                    Console.WriteLine($"\nResultado: {num1 * num2}");
                    break;

                case "/":
                    if (num2 == 0)
                    {
                        Console.WriteLine("\nError: No se puede dividir entre cero.");
                    }
                    else
                    {
                        Console.WriteLine($"\nResultado: {num1 / num2}");
                    }
                    break;

                case "%":
                    if (num2 == 0)
                    {
                        Console.WriteLine("\nError: No se puede calcular el módulo entre cero.");
                    }
                    else
                    {
                        Console.WriteLine($"\nResultado: {num1 % num2}");
                    }
                    break;

                default:
                    Console.WriteLine("\nOperación no válida.");
                    break;
            }
    }
}
}