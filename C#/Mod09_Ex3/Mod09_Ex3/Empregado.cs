using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod09_Ex3
{
    class Empregado
    {
        private string nome;
        private int idade;

        public Empregado()
        {

        }

        public Empregado(string _nome, int _idade)
        {
            nome = _nome;
            idade = _idade;
        }

        public void MostrarInformacao()
        {
            Console.WriteLine("{0} , {1} anos",nome,idade);
        }
    }
}
