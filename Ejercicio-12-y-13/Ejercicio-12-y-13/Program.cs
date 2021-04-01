using System;

namespace Ejercicio_12_y_13
{
    class Program
    {
        static void Main(string[] args)
        {
            string frase1 = "";
            string frase2 = "";
            do
            {
                Console.WriteLine("Ingrese una frase");
                frase1 = Console.ReadLine();
                Console.WriteLine("Ingrese otra frase");
                frase2 = Console.ReadLine();
            } while (frase1 == "" || frase2 == "");
            Console.WriteLine("Ejercicio 12");
            if (frase1.Equals(frase2))
            {
                Console.WriteLine("Las frases coinciden exactamente");
            }
            else
            {
                Console.WriteLine("Las frases no coinciden exactamente");
            }
            Console.WriteLine("Ejercicio 13");
            if (frase1.Length == frase2.Length)
            {
                Console.WriteLine("Las dos frases tienen la misma longitud");
            }
            else
            {
                Console.WriteLine("Las dos frases no tienen la misma longitud");
            }
            Console.WriteLine("Ejercicio 14");
            if (frase1.ToUpper().Equals(frase2.ToUpper()))
            {
                Console.WriteLine("Las dos frases coinciden, a pesar de poder tener mayusculas y minusculas en distinto orden");
            }
            else
            {
                Console.WriteLine("Las dos frases no coinciden");
            }
            Console.ReadKey();
        }
    }
}
