namespace EstructurasDeControl
{
    public class Ejercicio24
    {
        public void Ejecutar()
        {
            Console.Write("Ingrese un número N: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int sumaPares = 0;
            int sumaImpares = 0;

            int cantidadPares = 0;
            int cantidadImpares = 0;

            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    sumaPares += i;
                    cantidadPares++;
                }
                else
                {
                    sumaImpares += i;
                    cantidadImpares++;
                }
            }

            // Mostrar resultados
            Console.WriteLine($"Cantidad de pares: {cantidadPares}");
            Console.WriteLine($"Suma de pares: {sumaPares}");

            Console.WriteLine();

            Console.WriteLine($"Cantidad de impares: {cantidadImpares}");
            Console.WriteLine($"Suma de impares: {sumaImpares}");
        }
    }
}