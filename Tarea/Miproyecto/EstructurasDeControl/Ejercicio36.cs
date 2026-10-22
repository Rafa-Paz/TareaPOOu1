namespace EstructurasDeControl
{
    public class Ejercicio36
    {
        public void Ejecutar()
        {
            double resultado = 0;
            bool salir = false;

            while (!salir)
            {
                Console.WriteLine($"Último resultado: {resultado}");
                Console.WriteLine("1. Suma");
                Console.WriteLine("2. Resta");
                Console.WriteLine("3. Multiplicación");
                Console.WriteLine("4. División");
                Console.WriteLine("5. Potencia");
                Console.WriteLine("6. Raíz cuadrada");
                Console.WriteLine("7. Porcentaje");
                Console.WriteLine("8. Salir");

                Console.Write("Seleccione una opción: ");
                int opcion = Convert.ToInt32(Console.ReadLine());

                double numero;

                switch (opcion)
                {
                    case 1:
                        Console.Write("Número a sumar: ");
                        numero = Convert.ToDouble(Console.ReadLine());
                        resultado += numero;
                        Console.WriteLine($"Resultado: {resultado}");
                        break;

                    case 2:
                        Console.Write("Número a restar: ");
                        numero = Convert.ToDouble(Console.ReadLine());
                        resultado -= numero;
                        Console.WriteLine($"Resultado: {resultado}");
                        break;

                    case 3:
                        Console.Write("Número a multiplicar: ");
                        numero = Convert.ToDouble(Console.ReadLine());
                        resultado *= numero;
                        Console.WriteLine($"Resultado: {resultado}");
                        break;

                    case 4:
                        Console.Write("Número para dividir: ");
                        numero = Convert.ToDouble(Console.ReadLine());

                        if (numero != 0)
                        {
                            resultado /= numero;
                            Console.WriteLine($"Resultado: {resultado}");
                        }
                        else
                        {
                            Console.WriteLine("No se puede dividir entre cero.");
                        }
                        break;

                    case 5:
                        Console.Write("Exponente: ");
                        numero = Convert.ToDouble(Console.ReadLine());
                        resultado = Math.Pow(resultado, numero);
                        Console.WriteLine($"Resultado: {resultado}");
                        break;

                    case 6:
                        if (resultado >= 0)
                        {
                            resultado = Math.Sqrt(resultado);
                            Console.WriteLine($"Resultado: {resultado}");
                        }
                        else
                        {
                            Console.WriteLine("No se puede calcular la raíz de un número negativo.");
                        }
                        break;

                    case 7:
                        Console.Write("Ingrese el porcentaje: ");
                        numero = Convert.ToDouble(Console.ReadLine());

                        resultado = resultado * (numero / 100);
                        Console.WriteLine($"Resultado: {resultado}");
                        break;

                    case 8:
                        salir = true;
                        Console.WriteLine("Saliendo...");
                        break;

                    default:
                        Console.WriteLine("Opción inválida.");
                        break;
                }
            }
        }
    }
}