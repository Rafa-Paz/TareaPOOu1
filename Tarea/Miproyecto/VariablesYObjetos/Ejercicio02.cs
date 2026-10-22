using System;

namespace VariablesYObjetos
{
    public class CalculatorIMC
    {
        public void Ejecutar()
        {
            Console.Write("Ingrese su peso en kg: ");
            double peso = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese su altura en metros: ");
            double altura = Convert.ToDouble(Console.ReadLine());

            double imc = peso / (altura * altura);

            string categoria = "";

            if (imc < 18.5)
            {
                categoria = "Bajo peso";
            }
            else if (imc < 25)
            {
                categoria = "Peso normal";
            }
            else if (imc < 30)
            {
                categoria = "Sobrepeso";
            }
            else
            {
                categoria = "Obesidad";
            }

            //Mostrar resultados
            Console.WriteLine($"IMC: {imc:F2}");
            Console.WriteLine($"Categoría: {categoria}");
        }

    }
}