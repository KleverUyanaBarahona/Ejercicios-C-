using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6Conpanieros
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] com = new string[6] {"Lucas","Klever","David","Javi","Sergio","Antonio" };

            for (int i= 0;i<com.Length;i++) {
                Console.WriteLine("Compañero"+com[i]);
            }
        }
    }
}
