namespace EstructurasDeControl
{
    public class Ejercicio30
    {
         public void Ejecutar()
        {
            Console.Write("Ingrese el valor de n: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese el valor de r: ");
            int r = Convert.ToInt32(Console.ReadLine());

            if (n < 0 || r < 0 || r > n)
            {
                Console.WriteLine("Error: Los valores deben cumplir que n >= r y ambos sean positivos.");
                return;
            }

            long factorialN = 1;
            long factorialR = 1;
            long factorialNR = 1;

            // n!
            for (int i = 1; i <= n; i++)
            {
                factorialN *= i;
            }

            // r!
            for (int i = 1; i <= r; i++)
            {
                factorialR *= i;
            }

            // (n-r)!
            for (int i = 1; i <= (n - r); i++)
            {
                factorialNR *= i;
            }

            long combinacion = factorialN / (factorialR * factorialNR);

            Console.WriteLine($"{n}! = {factorialN}");
            Console.WriteLine($"{r}! = {factorialR}");
            Console.WriteLine($"({n}-{r})! = {factorialNR}");
            Console.WriteLine($"C({n},{r}) = {combinacion}");
        }
    }
}