using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ordenar10
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[10];
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("escribe un numero");
                numeros[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Posicion: "+i+" "+numeros[i]);   
            }
            Array.Sort(numeros);//ordena los numeros de menor a mayor.
            Console.WriteLine("NUMEROS ORDENADOR");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Posicion: " + i + " " + numeros[i]);
            }
        }
    
    }
}
