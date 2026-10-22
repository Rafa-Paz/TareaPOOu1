namespace Condicionales
{
    public class GradingSystem
    {
        public void Ejecutar()
        {
            Console.Write("Ingrese la nota (0-100): ");
            int nota = Convert.ToInt32(Console.ReadLine());

            // Validación
            if (nota < 0 || nota > 100)
            {
                Console.WriteLine("Error: La nota debe estar entre 0 y 100.");
                return;
            }

            string letra;
            string descripcion;
            string estado;

            if (nota >= 90)
            {
                letra = "A";
                descripcion = "Excelente";
                estado = "Aprobó";
            }
            else if (nota >= 80)
            {
                letra = "B";
                descripcion = "Muy Bueno";
                estado = "Aprobó";
            }
            else if (nota >= 70)
            {
                letra = "C";
                descripcion = "Bueno";
                estado = "Aprobó";
            }
            else if (nota >= 60)
            {
                letra = "D";
                descripcion = "Regular";
                estado = "Aprobó";
            }
            else
            {
                letra = "F";
                descripcion = "Deficiente";
                estado = "Reprobó";
            }

            //Mostrar resultados
            Console.WriteLine($"Nota numérica: {nota}");
            Console.WriteLine($"Calificación: {letra}");
            Console.WriteLine($"Descripción: {descripcion}");
            Console.WriteLine($"Estado: {estado}");
        }
    }
}