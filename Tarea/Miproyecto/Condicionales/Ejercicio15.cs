namespace Condicionales
{
    public class VowelOrConsonant
    {
         public void Ejecutar()
        {
            Console.Write("Ingrese una letra: ");
            char letra = Convert.ToChar((Console.ReadLine() ?? "").ToLower());

            // Validar que sea una letra
            if (!char.IsLetter(letra))
            {
                Console.WriteLine("Error: Debe ingresar una letra.");
                return;
            }

            switch (letra)
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    Console.WriteLine("La letra es una vocal.");
                    break;

                default:
                    Console.WriteLine("La letra es una consonante.");
                    break;
            }
    }
}
}