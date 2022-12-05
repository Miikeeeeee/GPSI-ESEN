using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod09_Ex4
{
    class Empregados
    {
        private string nome;
        private double salario;

        public Empregados()
        {

        }

        public Empregados(string nome, double salario)
        {
            this.nome = nome;
            this.salario = salario;
        }

        public double salarios()
        {
            return salario;
        }

        public string nomes()
        {
            return nome;
        }

    }
}
