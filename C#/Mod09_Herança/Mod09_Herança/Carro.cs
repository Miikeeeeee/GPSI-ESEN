using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod09_Herança
{
    //classe derivada da classe Veiculo
    internal class Carro : Veiculo
        //herda as propriedades e os metodos da classe pai (veiculo)
    {
        string nome;
        string cor;

        public Carro()
        {

        }
        public Carro(string n, string c) : base(170,5,true)
        {
            nome = n;
            cor = c;
        }
    }
}
