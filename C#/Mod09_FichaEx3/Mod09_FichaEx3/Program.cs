using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod09_FichaEx3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BilheteVIP b2 = new BilheteVIP(25,45);
            Console.WriteLine(b2.ImprimirValor());
            Console.WriteLine("A diferença de valor é"+b2.ImprimirDiferenca());
            Console.ReadLine();
        }
    }
}
