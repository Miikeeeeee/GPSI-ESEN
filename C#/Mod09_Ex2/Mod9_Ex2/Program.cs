using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod9_Ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // criar objeto do tipo Pessoa
            Pessoa p1 = new Pessoa();
            Console.WriteLine(p1.altura);

            Pessoa p2 = new Pessoa("Miguel", 1.85, "12-05-2005");
            Console.WriteLine("P2 = " + p2.nome);
            Console.WriteLine("P1 = " + p1.nome);
            Console.ReadLine();
        }
    }
}
