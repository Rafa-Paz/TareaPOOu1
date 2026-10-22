namespace ArreglosUnidimensionales
{
    public class Ejercicio43
    {
        public void Ejecutar()
        {
            Console.Write("Ingrese el tamaño del arreglo: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] numeros = new int[n];

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.Write($"Elemento {i + 1}: ");
                numeros[i] = Convert.ToInt32(Console.ReadLine());
            }

            bool salir = false;

            while (!salir)
            {
                Console.WriteLine("1. Rotar a la izquierda");
                Console.WriteLine("2. Rotar a la derecha");
                Console.WriteLine("3. Invertir arreglo");
                Console.WriteLine("4. Mostrar arreglo");
                Console.WriteLine("5. Salir");

                Console.Write("Seleccione una opción: ");
                int opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.Write("Ingrese K: ");
                        int kIzquierda = Convert.ToInt32(Console.ReadLine());

                        for (int r = 0; r < kIzquierda; r++)
                        {
                            int primero = numeros[0];

                            for (int i = 0; i < numeros.Length - 1; i++)
                            {
                                numeros[i] = numeros[i + 1];
                            }

                            numeros[numeros.Length - 1] = primero;
                        }

                        Console.WriteLine("Rotación a la izquierda realizada.");
                        break;

                    case 2:
                        Console.Write("Ingrese K: ");
                        int kDerecha = Convert.ToInt32(Console.ReadLine());

                        for (int r = 0; r < kDerecha; r++)
                        {
                            int ultimo = numeros[numeros.Length - 1];

                            for (int i = numeros.Length - 1; i > 0; i--)
                            {
                                numeros[i] = numeros[i - 1];
                            }

                            numeros[0] = ultimo;
                        }

                        Console.WriteLine("Rotación a la derecha realizada.");
                        break;

                    case 3:
                        for (int i = 0; i < numeros.Length / 2; i++)
                        {
                            int temp = numeros[i];
                            numeros[i] = numeros[numeros.Length - 1 - i];
                            numeros[numeros.Length - 1 - i] = temp;
                        }

                        Console.WriteLine("Arreglo invertido.");
                        break;

                    case 4:
                        Console.WriteLine("\nContenido del arreglo:");

                        foreach (int numero in numeros)
                        {
                            Console.Write(numero + " ");
                        }

                        Console.WriteLine();
                        break;

                    case 5:
                        salir = true;
                        break;

                    default:
                        Console.WriteLine("Opción inválida.");
                        break;
                }
            }
        }        
    }
}