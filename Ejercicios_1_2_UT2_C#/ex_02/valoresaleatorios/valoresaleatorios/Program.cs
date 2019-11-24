using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace valoresaleatorios
{
    class Program
    {
        static void Main(string[] args)
        {
            int aux;
            int aux2=0;

            Random rnd = new Random();
            Random rnd2 = new Random();
            
            int numeroConDosCotas = rnd.Next(10, 20);
            Console.WriteLine("Número entre 10 y 20: {0}", numeroConDosCotas);
            aux = numeroConDosCotas;
            Console.WriteLine("Número aux 10 y 20: {0}", aux);
            int[] numeros = new int[aux];
            for (int i=0;i<numeroConDosCotas;i++) {
                int numeroConCotaSuperior = rnd.Next(100);
                Console.Write("posicion: "+ i +" "+ numeroConCotaSuperior);
                numeros[i] = numeroConCotaSuperior;
                Console.WriteLine(" "+numeros[i]);
                aux2 += numeros[i];
            }
            //Console.WriteLine(numeros[aux-1]);
            Console.WriteLine("Suma total: "+aux2);
            Console.WriteLine("Media: " + aux2/2);
            Array.Sort(numeros);
            Array.Reverse(numeros);
            Console.WriteLine("Mumero Maximo " + numeros[0]);
            Console.WriteLine("Numero Minimo "+numeros[aux - 1]);
        }
    }
}
