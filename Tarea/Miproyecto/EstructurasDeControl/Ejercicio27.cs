namespace EstructurasDeControl
{
    public class Ejercicio27
    {
        public void Ejecutar()
        {
            Console.Write("Ingrese un número entero: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            int original = numero;
            int invertido = 0;

            while (numero != 0)
            {
                int digito = numero % 10;
                invertido = (invertido * 10) + digito;
                numero = numero / 10;
            }

             // Mostrar resultados
            Console.WriteLine($"Número invertido: {invertido}");

            if (original == invertido)
            {
                Console.WriteLine("El número es capicúa.");
            }
            else
            {
                Console.WriteLine("El número no es capicúa.");
            }
    }
}
}