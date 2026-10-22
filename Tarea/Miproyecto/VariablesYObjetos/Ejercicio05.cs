namespace VariablesYObjetos
{
    public class TempConversion
    {
        public void Ejecutar()
        {
            int opcion;

            Console.WriteLine("1. Celsius a Fahrenheit");
            Console.WriteLine("2. Celsius a Kelvin");
            Console.WriteLine("3. Fahrenheit a Celsius");
            Console.WriteLine("4. Fahrenheit a Kelvin");
            Console.WriteLine("5. Kelvin a Celsius");
            Console.WriteLine("6. Kelvin a Fahrenheit");
            Console.Write("Seleccione una opción: ");

            opcion = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese la temperatura: ");
            double temperatura = Convert.ToDouble(Console.ReadLine());

            double resultado;

            switch (opcion)
            {
                case 1:
                    resultado = (temperatura * 9 / 5) + 32;
                    Console.WriteLine($"{temperatura}°C = {resultado:F2}°F");
                    break;

                case 2:
                    resultado = temperatura + 273.15;
                    Console.WriteLine($"{temperatura}°C = {resultado:F2}K");
                    break;

                case 3:
                    resultado = (temperatura - 32) * 5 / 9;
                    Console.WriteLine($"{temperatura}°F = {resultado:F2}°C");
                    break;

                case 4:
                    resultado = (temperatura - 32) * 5 / 9 + 273.15;
                    Console.WriteLine($"{temperatura}°F = {resultado:F2}K");
                    break;

                case 5:
                    resultado = temperatura - 273.15;
                    Console.WriteLine($"{temperatura}K = {resultado:F2}°C");
                    break;

                case 6:
                    resultado = (temperatura - 273.15) * 9 / 5 + 32;
                    Console.WriteLine($"{temperatura}K = {resultado:F2}°F");
                    break;

                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }
    }
}
}