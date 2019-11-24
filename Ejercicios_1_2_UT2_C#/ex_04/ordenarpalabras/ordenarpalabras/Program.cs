using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ordenarpalabras
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] palabras = new string[10];
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("escribe una palabra");
                palabras[i] = Console.ReadLine();
            }
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Posicion: " + i + " " + palabras[i]);
            }
            //Array.Sort(numeros);//ordena los numeros de menor a mayor.
            Array.Sort<string>(palabras);
            Console.WriteLine("PALABRAS ORDENADAS ALFABETICAMENTE");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Posicion: " + i + " " + palabras[i]);
            }
        }
    }
}
