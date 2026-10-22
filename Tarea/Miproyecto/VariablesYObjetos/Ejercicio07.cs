namespace VariablesYObjetos
{
    public class ElapsedTime
    {
        public void Ejecutar()
        {
            //Primera hora

            Console.Write("Hora: ");
            int hora1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Minuto: ");
            int minuto1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Segundo: ");
            int segundo1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n=== SEGUNDA HORA ===");

            Console.Write("Hora: ");
            int hora2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Minuto: ");
            int minuto2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Segundo: ");
            int segundo2 = Convert.ToInt32(Console.ReadLine());

            // Convertir ambas horas a segundos
            int totalSegundos1 = hora1 * 3600 + minuto1 * 60 + segundo1;
            int totalSegundos2 = hora2 * 3600 + minuto2 * 60 + segundo2;

            // Diferencia absoluta
            int diferencia = Math.Abs(totalSegundos2 - totalSegundos1);

            // Convertir nuevamente a horas, minutos y segundos
            int horas = diferencia / 3600;
            int minutos = (diferencia % 3600) / 60;
            int segundos = diferencia % 60;

            Console.WriteLine("\n=== RESULTADO ===");
            Console.WriteLine($"Diferencia: {horas} horas, {minutos} minutos y {segundos} segundos");
        }
    }
}