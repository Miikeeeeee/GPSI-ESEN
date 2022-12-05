using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Mod09_FichaEx8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> bebidas = new List<string>();
            List<double> alcools = new List<double>();
            List<double> valores = new List<double>();
            
            Console.WriteLine("Qual o numero de identificador do seu evento:");
            int identificador = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual a quantidade de convites que vai ter o evento:");
            int convites = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual a descrição do evento:");
            string descricao = Console.ReadLine();
            Console.WriteLine("Qual o local do evento:");
            string local = Console.ReadLine();  
            Console.WriteLine("Qual a data de realizacao:");
            string dataderealizacao = Console.ReadLine();
            Console.WriteLine("Vai ter bar aberto(Se sim escreva true se não escreva false):");
            bool bar_aberto = bool.Parse(Console.ReadLine());
            Console.WriteLine("Quais os custos de realizacao do evento:");
            double custos = double.Parse(Console.ReadLine());
            Console.WriteLine("Qual o preco de entrada(se colocar zero irá ser atribuido um valor automatico):");
            double entrada = double.Parse(Console.ReadLine());
            Console.Clear();
            if (bar_aberto == true)
            {
                for (int i = 1; i <= 4; i++)
                {
                    Console.WriteLine("Qual a bebida " + i + " do evento");
                    string bebida = Console.ReadLine();
                    bebidas.Add(bebida);

                    Console.WriteLine("Qual o teor alcoolico da bebida " + i);
                    int alcool = int.Parse(Console.ReadLine());
                    alcools.Add(alcool);

                    Console.WriteLine("Qual o valor da bebida " + i);
                    int valor = int.Parse(Console.ReadLine());
                    valores.Add(valor);
                }

                
            }
            Eventos e1 = new Eventos(identificador,convites,descricao,local,dataderealizacao,bar_aberto,custos,entrada, new Bar_aberto(bebidas[0], bebidas[1], bebidas[2], bebidas[3], alcools[0], alcools[1], alcools[2], alcools[3], valores[0], valores[1], valores[2], valores[3]));
            Console.Clear();

        }
    }
}
