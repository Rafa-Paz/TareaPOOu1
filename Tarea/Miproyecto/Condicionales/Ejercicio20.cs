namespace Condicionales
{
    public class LeapYear
    {
        public void Ejecutar()
        {
            Console.Write("Ingrese el año: ");
            int año = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese el mes (1-12): ");
            int mes = Convert.ToInt32(Console.ReadLine());

            if (mes < 1 || mes > 12)
            {
                Console.WriteLine("Error: El mes debe estar entre 1 y 12.");
                return;
            }

            bool bisiesto = (año % 4 == 0 && año % 100 != 0) || (año % 400 == 0);

            int dias;

            switch (mes)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    dias = 31;
                    break;

                case 4:
                case 6:
                case 9:
                case 11:
                    dias = 30;
                    break;

                case 2:
                    dias = bisiesto ? 29 : 28;
                    break;

                default:
                    dias = 0;
                    break;
            }
             // Mostrar resultados
            Console.WriteLine($"Año: {año}");
            Console.WriteLine($"¿Es bisiesto?: {(bisiesto ? "Sí" : "No")}");
            Console.WriteLine($"Días del mes: {dias}");
        }
    }
}