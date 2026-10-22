namespace VariablesYObjetos
{
    public class Geometric
    {
        public void Ejecutar()
        {
            int opcion;

            do
            {
                Console.WriteLine("1. Círculo");
                Console.WriteLine("2. Triángulo");
                Console.WriteLine("3. Rectángulo");
                Console.WriteLine("4. Trapecio");
                Console.WriteLine("0. Salir");
                Console.Write("Seleccione una opción: ");

                opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        CalcularCirculo();
                        break;

                    case 2:
                        CalcularTriangulo();
                        break;

                    case 3:
                        CalcularRectangulo();
                        break;

                    case 4:
                        CalcularTrapecio();
                        break;

                    case 0:
                        Console.WriteLine("Programa finalizado.");
                        break;

                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }

            } while (opcion != 0);
        }

        private void CalcularCirculo()
        {
            double radio;

            do
            {
                Console.Write("Ingrese el radio: ");
                radio = Convert.ToDouble(Console.ReadLine());
            } while (radio <= 0);

            double area = Math.PI * radio * radio;
            double perimetro = 2 * Math.PI * radio;

            Console.WriteLine($"\nÁrea: {area:F2}");
            Console.WriteLine($"Perímetro: {perimetro:F2}");
        }

        private void CalcularTriangulo()
        {
            double lado1, lado2, lado3, baseTriangulo, altura;

            do
            {
                Console.Write("Ingrese la base: ");
                baseTriangulo = Convert.ToDouble(Console.ReadLine());
            } while (baseTriangulo <= 0);

            do
            {
                Console.Write("Ingrese la altura: ");
                altura = Convert.ToDouble(Console.ReadLine());
            } while (altura <= 0);

            do
            {
                Console.Write("Ingrese lado 1: ");
                lado1 = Convert.ToDouble(Console.ReadLine());
            } while (lado1 <= 0);

            do
            {
                Console.Write("Ingrese lado 2: ");
                lado2 = Convert.ToDouble(Console.ReadLine());
            } while (lado2 <= 0);

            do
            {
                Console.Write("Ingrese lado 3: ");
                lado3 = Convert.ToDouble(Console.ReadLine());
            } while (lado3 <= 0);

            double area = (baseTriangulo * altura) / 2;
            double perimetro = lado1 + lado2 + lado3;

            Console.WriteLine($"\nÁrea: {area:F2}");
            Console.WriteLine($"Perímetro: {perimetro:F2}");
        }

        private void CalcularRectangulo()
        {
            double baseRectangulo, altura;

            do
            {
                Console.Write("Ingrese la base: ");
                baseRectangulo = Convert.ToDouble(Console.ReadLine());
            } while (baseRectangulo <= 0);

            do
            {
                Console.Write("Ingrese la altura: ");
                altura = Convert.ToDouble(Console.ReadLine());
            } while (altura <= 0);

            double area = baseRectangulo * altura;
            double perimetro = 2 * (baseRectangulo + altura);

            Console.WriteLine($"\nÁrea: {area:F2}");
            Console.WriteLine($"Perímetro: {perimetro:F2}");
        }

        private void CalcularTrapecio()
        {
            double baseMayor, baseMenor, lado1, lado2, altura;

            do
            {
                Console.Write("Ingrese la base mayor: ");
                baseMayor = Convert.ToDouble(Console.ReadLine());
            } while (baseMayor <= 0);

            do
            {
                Console.Write("Ingrese la base menor: ");
                baseMenor = Convert.ToDouble(Console.ReadLine());
            } while (baseMenor <= 0);

            do
            {
                Console.Write("Ingrese la altura: ");
                altura = Convert.ToDouble(Console.ReadLine());
            } while (altura <= 0);

            do
            {
                Console.Write("Ingrese el lado izquierdo: ");
                lado1 = Convert.ToDouble(Console.ReadLine());
            } while (lado1 <= 0);

            do
            {
                Console.Write("Ingrese el lado derecho: ");
                lado2 = Convert.ToDouble(Console.ReadLine());
            } while (lado2 <= 0);

            double area = ((baseMayor + baseMenor) * altura) / 2;
            double perimetro = baseMayor + baseMenor + lado1 + lado2;

            Console.WriteLine($"\nÁrea: {area:F2}");
            Console.WriteLine($"Perímetro: {perimetro:F2}");
        }
    }
}