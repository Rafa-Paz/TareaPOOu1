
namespace EstructurasDeControl
{
    public class Ejercicio34
    {
        public void Ejecutar()
        {
            Console.WriteLine("1. Triángulo");
            Console.WriteLine("2. Triángulo invertido");
            Console.WriteLine("3. Rombo");
            Console.WriteLine("4. Cuadrado hueco");
            Console.WriteLine("5. Pirámide numérica");

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

        private void Triangulo(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(new string('*', i));
            }
        }

        private void TrianguloInvertido(int n)
        {
            for (int i = n; i >= 1; i--)
            {
                Console.WriteLine(new string('*', i));
            }
        }

        private void Rombo(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                Console.Write(new string(' ', n - i));
                Console.WriteLine(new string('*', i * 2 - 1));
            }

            for (int i = n - 1; i >= 1; i--)
            {
                Console.Write(new string(' ', n - i));
                Console.WriteLine(new string('*', i * 2 - 1));
            }
        }

        private void CuadradoHueco(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    if (i == 1 || i == n || j == 1 || j == n)
                        Console.Write("* ");
                    else
                        Console.Write("  ");
                }

                Console.WriteLine();
            }
        }

        private void PiramideNumerica(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                Console.Write(new string(' ', n - i));

                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }

                Console.WriteLine();
            }
        }
        }    
    }
