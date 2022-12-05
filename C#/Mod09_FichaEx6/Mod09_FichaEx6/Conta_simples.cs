using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod09_FichaEx6
{
    internal class Conta_simples
    {
        int numero;
        string titular;
        double saldo;
        string cartao_debito;
        Chques c1;

        public Conta_simples()
        {

        }

        public Conta_simples(int numero, string titular, double saldo, string cartao_debito, Chques c1)
        {
            this.numero = numero;
            this.titular = titular;
            this.saldo = saldo;
            this.cartao_debito = cartao_debito;
            this.c1 = c1;
        }

        public void observar()
        {
            Console.WriteLine("O numero: " + numero + ",titular: " + titular + ",saldo: " + saldo + "cartao debito: " + cartao_debito + "c1: " + c1.primeiro());
        }

        
            
        


    }
}
