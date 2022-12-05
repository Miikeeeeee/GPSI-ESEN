using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod09_Ex5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cliente c1 = new Cliente("Joao","jj@gmail.com");

            c1.DevolverMorada();
            Console.ReadLine();
        }
    }
}
