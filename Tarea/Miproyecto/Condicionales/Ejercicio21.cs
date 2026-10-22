namespace Condicionales
{
    public class Ejercicio21
    {
        public void Ejecutar()
        {
            Console.Write("Ingrese el día: ");
            int dia = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese el mes: ");
            int mes = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese el año: ");
            int año = Convert.ToInt32(Console.ReadLine());

            if (mes < 1 || mes > 12)
            {
                Console.WriteLine("Fecha inválida: mes incorrecto.");
                return;
            }

            bool bisiesto = (año % 4 == 0 && año % 100 != 0) || (año % 400 == 0);

            int diasMes;

            switch (mes)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    diasMes = 31;
                    break;

                case 4:
                case 6:
                case 9:
                case 11:
                    diasMes = 30;
                    break;

                case 2:
                    diasMes = bisiesto ? 29 : 28;
                    break;

                default:
                    diasMes = 0;
                    break;
            }

            if (dia < 1 || dia > diasMes)
            {
                Console.WriteLine("Fecha inválida.");
            }
            else
            {
                Console.WriteLine("\n=== RESULTADO ===");
                Console.WriteLine($"La fecha {dia}/{mes}/{año} es válida.");
                Console.WriteLine($"Año bisiesto: {(bisiesto ? "Sí" : "No")}");
            }
    }
}
}