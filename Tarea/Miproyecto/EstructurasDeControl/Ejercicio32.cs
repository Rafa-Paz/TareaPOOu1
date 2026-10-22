namespace EstructurasDeControl
{
    public class Ejercicio32
    {
        public void Ejecutar()
        {
            Console.Write("Ingrese el número inicial: ");
            int inicio = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese el número final: ");
            int fin = Convert.ToInt32(Console.ReadLine());

            int cantidadPrimos = 0;

            Console.WriteLine("\nNúmeros primos:");

            for (int numero = inicio; numero <= fin; numero++)
            {
                bool esPrimo = true;

                if (numero < 2)
                {
                    esPrimo = false;
                }
                else
                {
                    for (int i = 2; i <= Math.Sqrt(numero); i++)
                    {
                        if (numero % i == 0)
                        {
                            esPrimo = false;
                            break;
                        }
                    }
                }

                if (esPrimo)
                {
                    Console.WriteLine(numero);
                    cantidadPrimos++;
                }
            }

            Console.WriteLine($"\nCantidad de números primos: {cantidadPrimos}");
        }
    }
}