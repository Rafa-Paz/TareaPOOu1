namespace Condicionales
{
    public class ClassificationOfTriangles
    {
        public void Ejecutar()
        {
            Console.Write("Ingrese el primer lado: ");
            double lado1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese el segundo lado: ");
            double lado2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese el tercer lado: ");
            double lado3 = Convert.ToDouble(Console.ReadLine());

            // Validar valores positivos
            if (lado1 <= 0 || lado2 <= 0 || lado3 <= 0)
            {
                Console.WriteLine("Error: Todos los lados deben ser positivos.");
                return;
            }

            // Validar si forma un triángulo
            if (lado1 + lado2 <= lado3 ||
                lado1 + lado3 <= lado2 ||
                lado2 + lado3 <= lado1)
            {
                Console.WriteLine("Los lados ingresados NO forman un triángulo.");
                return;
            }

            //Triangulo válido

            // Clasificación por lados
            string tipoLados;

            if (lado1 == lado2 && lado2 == lado3)
            {
                tipoLados = "Equilátero";
            }
            else if (lado1 == lado2 || lado1 == lado3 || lado2 == lado3)
            {
                tipoLados = "Isósceles";
            }
            else
            {
                tipoLados = "Escaleno";
            }

            // Clasificación por ángulos
            string tipoAngulo;

            double a, b, c;

            // Encontrar el lado mayor
            if (lado1 >= lado2 && lado1 >= lado3)
            {
                c = lado1;
                a = lado2;
                b = lado3;
            }
            else if (lado2 >= lado1 && lado2 >= lado3)
            {
                c = lado2;
                a = lado1;
                b = lado3;
            }
            else
            {
                c = lado3;
                a = lado1;
                b = lado2;
            }

            double sumaCuadrados = (a * a) + (b * b);
            double mayorCuadrado = c * c;

            if (Math.Abs(sumaCuadrados - mayorCuadrado) < 0.0001)
            {
                tipoAngulo = "Rectángulo";
            }
            else if (sumaCuadrados > mayorCuadrado)
            {
                tipoAngulo = "Acutángulo";
            }
            else
            {
                tipoAngulo = "Obtusángulo";
            }

            Console.WriteLine($"Clasificación por lados: {tipoLados}");
            Console.WriteLine($"Clasificación por ángulos: {tipoAngulo}");
        }
    }
}