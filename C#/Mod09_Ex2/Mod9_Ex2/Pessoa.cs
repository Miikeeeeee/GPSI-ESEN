using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod9_Ex2
{
    class Pessoa
    {
        //atributo
        public string nome;
        public double altura;
        public string nascimento;

        // CONSTRUTOR

        public Pessoa()
        {
            nome = "Teste";
            nascimento = "";
            altura = 0;
        }

        public Pessoa(string nome, double altura, string nascimento)
        {
            this.nome = nome;
            this.nascimento = nascimento;
            this.altura = altura;
        }
    }
}
