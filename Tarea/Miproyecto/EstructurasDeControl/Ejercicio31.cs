namespace EstructurasDeControl
{
    public class Ejercicio31
    {
        public void Ejecutar()
        {
            Console.Write("Ingrese el primer número: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese el segundo número: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int a = num1;
            int b = num2;

            while (b != 0)
            {
                int residuo = a % b;
                a = b;
                b = residuo;
            }

            int mcd = a;
            int mcm = (num1 * num2) / mcd;

            Console.WriteLine($"\nMCD: {mcd}");
            Console.WriteLine($"MCM: {mcm}");
        }
    }
}