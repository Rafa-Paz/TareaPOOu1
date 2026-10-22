namespace EstructurasDeControl
{
    public class Ejercicio26
    {
        public void Ejecutar()
        {
            Console.Write("Ingrese la base: ");
            double baseNumero = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese el exponente: ");
            int exponente = Convert.ToInt32(Console.ReadLine());

            double resultado = 1;

            if (exponente == 0)
            {
                resultado = 1;
            }
            else if (exponente > 0)
            {
                for (int i = 1; i <= exponente; i++)
                {
                    resultado *= baseNumero;
                }
            }
            else
            {
                for (int i = 1; i <= Math.Abs(exponente); i++)
                {
                    resultado *= baseNumero;
                }

                resultado = 1 / resultado;
            }

            // Mostrar resultado
            Console.WriteLine($"{baseNumero}^{exponente} = {resultado}");
        }
    }
}