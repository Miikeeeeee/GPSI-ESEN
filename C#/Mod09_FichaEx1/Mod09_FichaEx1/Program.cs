using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod09_FichaEx1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Quadrado q1;
            Console.WriteLine("Introduza o valor dos lados do quadrado:");
            double valor = Double.Parse(Console.ReadLine());
            if (valor < 0 && valor > 20)
            {
                q1 = new Quadrado();
                Console.WriteLine("A");
            }
            else if (valor > 0 && valor < 20)
            {
                q1 = new Quadrado(valor);
                Console.WriteLine("B");
            }

            Console.WriteLine(q1.Lado());
            Console.ReadLine();
            
        }
    }
}
