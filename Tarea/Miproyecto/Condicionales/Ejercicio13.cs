namespace Condicionales
{
    public class DayOfTheWeek
    {
        public void Ejecutar()
        {
            Console.Write("Ingrese un número del 1 al 7: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n=== USANDO SWITCH CLÁSICO ===");

            switch (numero)
            {
                case 1:
                    Console.WriteLine("Lunes");
                    break;

                case 2:
                    Console.WriteLine("Martes");
                    break;

                case 3:
                    Console.WriteLine("Miércoles");
                    break;

                case 4:
                    Console.WriteLine("Jueves");
                    break;

                case 5:
                    Console.WriteLine("Viernes");
                    break;

                case 6:
                    Console.WriteLine("Sábado");
                    break;

                case 7:
                    Console.WriteLine("Domingo");
                    break;

                default:
                    Console.WriteLine("Número inválido.");
                    break;
            }

            //Usando expresión switch

            string dia = numero switch
            {
                1 => "Lunes",
                2 => "Martes",
                3 => "Miércoles",
                4 => "Jueves",
                5 => "Viernes",
                6 => "Sábado",
                7 => "Domingo",
                _ => "Número inválido"
            };

            Console.WriteLine(dia);
        }
    }
}