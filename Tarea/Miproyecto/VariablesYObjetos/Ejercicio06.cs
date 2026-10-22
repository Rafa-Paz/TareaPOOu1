namespace VariablesYObjetos
{
    public class SumOfDigits
    {
        public void Ejecutar()
        {
            Console.Write("Ingrese un número de tres dígitos: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            int centenas = numero / 100;
            int decenas = (numero % 100) / 10;
            int unidades = numero % 10;

            int suma = centenas + decenas + unidades;

            //Mostrar resultado 
            Console.WriteLine($"Centenas: {centenas}");
            Console.WriteLine($"Decenas: {decenas}");
            Console.WriteLine($"Unidades: {unidades}");
            Console.WriteLine($"Suma de dígitos: {suma}");
        }
    }
}