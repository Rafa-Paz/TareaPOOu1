namespace ArreglosUnidimensionales
{
    public class Ejercicio42
    {
        public void Ejecutar()
        {
            int[] numeros = new int[10];

            // Llenar arreglo
            Console.WriteLine("Ingrese 10 números enteros:");

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.Write($"Número {i + 1}: ");
                numeros[i] = Convert.ToInt32(Console.ReadLine());
            }

            // Búsqueda lineal
            Console.Write("\nNúmero a buscar: ");
            int buscar = Convert.ToInt32(Console.ReadLine());

            int posicion = -1;

            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] == buscar)
                {
                    posicion = i;
                    break;
                }
            }

            if (posicion != -1)
            {
                Console.WriteLine($"Número encontrado en la posición {posicion}");
            }
            else
            {
                Console.WriteLine("Número no encontrado.");
            }

            // Segundo mayor
            int mayor = int.MinValue;
            int segundoMayor = int.MinValue;

            foreach (int numero in numeros)
            {
                if (numero > mayor)
                {
                    segundoMayor = mayor;
                    mayor = numero;
                }
                else if (numero > segundoMayor && numero != mayor)
                {
                    segundoMayor = numero;
                }
            }

            Console.WriteLine($"\nMayor: {mayor}");
            Console.WriteLine($"Segundo mayor: {segundoMayor}");

            // Ordenamiento burbuja
            int[] ordenado = (int[])numeros.Clone();

            for (int i = 0; i < ordenado.Length - 1; i++)
            {
                for (int j = 0; j < ordenado.Length - 1 - i; j++)
                {
                    if (ordenado[j] > ordenado[j + 1])
                    {
                        int temp = ordenado[j];
                        ordenado[j] = ordenado[j + 1];
                        ordenado[j + 1] = temp;
                    }
                }
            }

            Console.WriteLine("\nArreglo ordenado ascendentemente:");

            foreach (int numero in ordenado)
            {
                Console.Write(numero + " ");
            }

            // Posiciones pares
            Console.WriteLine("\n\nElementos en posiciones pares:");

            for (int i = 0; i < numeros.Length; i += 2)
            {
                Console.Write(numeros[i] + " ");
            }

            Console.WriteLine();
        }
    }
}