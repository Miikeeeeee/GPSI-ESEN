using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod09_FichaEx6
{
    internal class Conta_poupanca : Conta_simples
    {
        string data_aniversario;

        public Conta_poupanca()
        {

        }

        public Conta_poupanca(int numero, string titular, double saldo, string cartao_debito, Chques c1, string data_aniversario) : base(numero, titular, saldo, cartao_debito, c1)
        {
            this.data_aniversario = data_aniversario;
        }
    }
}
