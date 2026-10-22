namespace EstructurasDeControl
{
    public class Ejercicio23
    {
        public void Ejecutar()
        {
            Console.Write("Ingrese un número: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"\n=== TABLA DEL {numero} ===\n");

            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine(
                    $"{numero,3} x {i,2} = {(numero * i),4}"
                );
            }
    }
}
}