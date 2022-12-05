using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    internal class Empregado
    {
        string nome;

        public Empregado()
        {

        }

        public Empregado(string n)
        {
            nome = n;
        }

        public void MostraNome()
        {
            Console.WriteLine(nome);
        }

        public virtual void MostraFuncao()
        {
            Console.WriteLine("Empregado");
        }
    }
}
