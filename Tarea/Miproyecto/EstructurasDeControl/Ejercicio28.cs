namespace EstructurasDeControl
{
    public class Ejercicio28
    {
        public void Ejecutar()
        {
            Console.Write("Ingrese un número entero positivo: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            if (numero < 0)
            {
                Console.WriteLine("Error: Debe ingresar un número positivo.");
                return;
            }

            if (numero == 0)
            {
                Console.WriteLine("Binario: 0");
                return;
            }

            string binario = "";

            while (numero > 0)
            {
                int residuo = numero % 2;
                binario = residuo + binario;
                numero = numero / 2;
            }
            // Mostrar resultado
            Console.WriteLine($"Binario: {binario}");
        }
    }
}