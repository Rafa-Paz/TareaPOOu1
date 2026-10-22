namespace EstructurasDeControl
{
    public class Ejercicio33
    {
        public void Ejecutar()
        {
            Random random = new Random();
            int numeroSecreto = random.Next(1, 101);

            int intentosMaximos = 7;
            int intentosUsados = 0;
            bool adivinado = false;

            Console.WriteLine("Debes adivinar un número entre 1 y 100.");
            Console.WriteLine($"Tienes {intentosMaximos} intentos.\n");

            while (intentosUsados < intentosMaximos && !adivinado)
            {
                Console.Write($"Intento #{intentosUsados + 1}: ");
                int numeroUsuario = Convert.ToInt32(Console.ReadLine());

                intentosUsados++;

                if (numeroUsuario == numeroSecreto)
                {
                    adivinado = true;
                }
                else if (numeroUsuario < numeroSecreto)
                {
                    Console.WriteLine("Pista: El número es MAYOR.\n");
                }
                else
                {
                    Console.WriteLine("Pista: El número es MENOR.\n");
                }
            }


            if (adivinado)
            {
                Console.WriteLine("¡Felicidades! Adivinaste el número.");
                Console.WriteLine($"Número secreto: {numeroSecreto}");
                Console.WriteLine($"Intentos utilizados: {intentosUsados}");
                Console.WriteLine($"Intentos restantes: {intentosMaximos - intentosUsados}");
            }
            else
            {
                Console.WriteLine("No lograste adivinar el número.");
                Console.WriteLine($"Número secreto: {numeroSecreto}");
                Console.WriteLine($"Intentos utilizados: {intentosUsados}");
            }
        }
    }
}