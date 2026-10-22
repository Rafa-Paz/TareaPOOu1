namespace EstructurasDeControl
{
    public class Ejercicio25
    {
        public void Ejecutar()
        {
            int numero;
            int contador = 0;
            int suma = 0;
            int mayor = 0;
            int menor = 0;

            Console.WriteLine("Ingrese números (-1 para finalizar):");

            do
            {
                Console.Write("Número: ");
                numero = Convert.ToInt32(Console.ReadLine());

                if (numero != -1)
                {
                    suma += numero;

                    if (contador == 0)
                    {
                        mayor = numero;
                        menor = numero;
                    }
                    else
                    {
                        if (numero > mayor)
                        {
                            mayor = numero;
                        }

                        if (numero < menor)
                        {
                            menor = numero;
                        }
                    }

                    contador++;
                }

            } while (numero != -1);

            if (contador == 0)
            {
                Console.WriteLine("\nNo se ingresaron números válidos.");
            }
            else
            {
                double promedio = (double)suma / contador;

                // Mostrar resultados
                Console.WriteLine($"Cantidad de números: {contador}");
                Console.WriteLine($"Promedio: {promedio:F2}");
                Console.WriteLine($"Valor máximo: {mayor}");
                Console.WriteLine($"Valor mínimo: {menor}");
            }
    }
}
}