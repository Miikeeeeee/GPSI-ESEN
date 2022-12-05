using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod09_FichaEx6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual o numero da sua conta");
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual o seu nome");
            string titular = Console.ReadLine();
            Console.WriteLine("Qual é o seu saldo");
            double saldo = double.Parse(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Qual a sua conta:");
            Console.WriteLine("[1]-> Conta corrente Simples");
            Console.WriteLine("[2]-> Conta corrente Especial");
            Console.WriteLine("[3]-> Conta Poupança");
            int opcao = int.Parse(Console.ReadLine());
            if (opcao == 0)
            {
                Console.WriteLine("Qual o numero do seu cartao de credito");
                int cartao_credito = int.Parse(Console.ReadLine());
                Console.WriteLine("Qual o numero do primeiro cheque");
                int primeiro_cheque = int.Parse(Console.ReadLine());
                Console.WriteLine("Qual o numero do ultimo cheque");
                int ultimo_cheque = int.Parse(Console.ReadLine());
                Console.Clear();
            }
            Conta_simples c1 = new Conta_simples(55, "boas", 500, "32313", new Chques(123,240));

            c1.observar();
        }
    }
}




