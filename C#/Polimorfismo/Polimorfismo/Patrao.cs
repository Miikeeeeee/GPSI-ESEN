using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    internal class Patrao:Empregado
    {
        public Patrao(string nome) : base(nome)
        {

        }

        public override void MostraFuncao()
        {
            Console.WriteLine("Patrão");
        }
    }
}
