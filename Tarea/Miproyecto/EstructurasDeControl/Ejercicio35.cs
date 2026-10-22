namespace EstructurasDeControl
{
    public class Ejercicio35
    {
        public void Ejecutar()
        {
            Console.WriteLine("1. Triángulo");
            Console.WriteLine("2. Triángulo Invertido");
            Console.WriteLine("3. Rombo");
            Console.WriteLine("4. Cuadrado Hueco");
            Console.WriteLine("5. Pirámide Numérica");

            Console.Write("\nSeleccione una opción: ");
            int opcion = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese el tamaño: ");
            int n = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Triangulo(n);
                    break;

                case 2:
                    TrianguloInvertido(n);
                    break;

                case 3:
                    Rombo(n);
                    break;

                case 4:
                    CuadradoHueco(n);
                    break;

                case 5:
                    PiramideNumerica(n);
                    break;

                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }
        }

        static void Triangulo(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        static void TrianguloInvertido(int n)
        {
            for (int i = n; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        static void Rombo(int n)
        {
            // Parte superior
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n - i; j++)
                    Console.Write(" ");

                for (int j = 1; j <= (2 * i - 1); j++)
                    Console.Write("*");

                Console.WriteLine();
            }

            // Parte inferior
            for (int i = n - 1; i >= 1; i--)
            {
                for (int j = 1; j <= n - i; j++)
                    Console.Write(" ");

                for (int j = 1; j <= (2 * i - 1); j++)
                    Console.Write("*");

                Console.WriteLine();
            }
        }

        static void CuadradoHueco(int n)
        {
            for (int fila = 1; fila <= n; fila++)
            {
                for (int columna = 1; columna <= n; columna++)
                {
                    if (fila == 1 || fila == n ||
                        columna == 1 || columna == n)
                    {
                        Console.Write("* ");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }

                Console.WriteLine();
            }
        }

        static void PiramideNumerica(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n - i; j++)
                {
                    Console.Write(" ");
                }

                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }

                Console.WriteLine();
            }
        }    
    }
}