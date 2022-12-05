using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod09_FichaEx6
{
    internal class Conta_especial : Conta_simples
    {
        double limite;
        double juro;

        public Conta_especial()
        {

        }

        public Conta_especial(int numero, string titular, double saldo, string cartao_debito, Chques c1, double limite, double juro) : base(numero, titular, saldo, cartao_debito, c1)
        {
            this.limite = limite;
            this.juro = juro;
        }


    }
}
