using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordandoEjercicios
{
    class Program
    {
        static void Main(string[] args)
        {
			Console.WriteLine("Ingrese el primer número: ");
			double a = double.Parse(Console.ReadLine());
			Console.WriteLine("Ingrese el segundo número: ");
			double b = double.Parse(Console.ReadLine());
			Console.WriteLine("Ingrese el tercer número: ");
			double c = double.Parse(Console.ReadLine());

			double raizPositiva = (-b + (Math.Sqrt(Math.Pow(b, 2) - 4 * a * c))) / (2 * a);
			double raizNegativa = (-b - (Math.Sqrt(Math.Pow(b, 2) - 4 * a * c))) / (2 * a);

			if (raizNegativa.ToString() == "NeuN" || raizPositiva.ToString() == "NeuN")
			{
				Console.WriteLine("No hay raices reales");
				Console.ReadKey();
			}
			else if (raizPositiva != raizNegativa)
			{
				Console.WriteLine("{0}", raizNegativa);
				Console.WriteLine("{0}", raizPositiva);
				Console.ReadKey();
			}
			else
			{
				Console.WriteLine("{0}", raizPositiva);
				Console.ReadKey();
			}
		}
    }
}
