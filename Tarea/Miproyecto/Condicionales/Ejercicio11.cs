namespace Condicionales
{
    public class PositiveNegativeZero
    {
         public void Ejecutar()
        {
            Console.Write("Ingrese un número entero: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            // Positivo, negativo o cero
            if (numero > 0)
            {
                Console.WriteLine("El número es positivo.");
            }
            else if (numero < 0)
            {
                Console.WriteLine("El número es negativo.");
            }
            else
            {
                Console.WriteLine("El número es cero.");
            }

            // Operador ternario para par o impar
            string resultado = (numero % 2 == 0) ? "Par" : "Impar";

            Console.WriteLine($"El número es {resultado}.");
        }
    }
}