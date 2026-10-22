namespace Condicionales
{
    public class LargerNumber
    {
        public void Ejecutar()
        {
            Console.Write("Ingrese el primer número: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese el segundo número: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese el tercer número: ");
            int num3 = Convert.ToInt32(Console.ReadLine());

            int mayor;
            int menor;

            // Determinar el mayor usando &&
            if (num1 > num2 && num1 > num3)
            {
                mayor = num1;
            }
            else if (num2 > num1 && num2 > num3)
            {
                mayor = num2;
            }
            else
            {
                mayor = num3;
            }

            // Determinar el menor usando &&
            if (num1 < num2 && num1 < num3)
            {
                menor = num1;
            }
            else if (num2 < num1 && num2 < num3)
            {
                menor = num2;
            }
            else
            {
                menor = num3;
            }

            //Mostrar resultados
            Console.WriteLine($"Número mayor: {mayor}");
            Console.WriteLine($"Número menor: {menor}");
        }
    }
}