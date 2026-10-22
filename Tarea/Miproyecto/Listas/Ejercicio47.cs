namespace Listas
{
    public class Ejercicio47
    {
        public void Ejecutar()
        {
            List<double> notas = new List<double>();

            string respuesta;

            do
            {
                Console.Write("Ingrese una nota: ");
                double nota = Convert.ToDouble(Console.ReadLine());

                notas.Add(nota);

                Console.Write("¿Desea ingresar otra nota? (S/N): ");
                respuesta = (Console.ReadLine() ?? "").ToUpper();

            } while (respuesta == "S");

            if (notas.Count == 0)
            {
                Console.WriteLine("No se registraron notas.");
                return;
            }

            // Calcular promedio, máxima y mínima
            double suma = 0;
            double maxima = notas[0];
            double minima = notas[0];

            foreach (double nota in notas)
            {
                suma += nota;

                if (nota > maxima)
                    maxima = nota;

                if (nota < minima)
                    minima = nota;
            }

            double promedio = suma / notas.Count;

            Console.WriteLine("\n ESTADÍSTICAS INICIALES");
            Console.WriteLine($"Promedio: {promedio:F2}");
            Console.WriteLine($"Nota máxima: {maxima}");
            Console.WriteLine($"Nota mínima: {minima}");

            // Eliminar la nota más baja
            notas.Remove(minima);

            // Recalcular promedio
            suma = 0;

            foreach (double nota in notas)
            {
                suma += nota;
            }

            double nuevoPromedio = notas.Count > 0
                ? suma / notas.Count
                : 0;

            Console.WriteLine($"Nota eliminada: {minima}");
            Console.WriteLine($"Nuevo promedio: {nuevoPromedio:F2}");
        }
    }
}