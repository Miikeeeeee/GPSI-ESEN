using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod09_FichaEx5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double custo;
            double venda;

            Console.WriteLine("Qual o preço de custo do produto");
            custo = Double.Parse(Console.ReadLine());
            Console.WriteLine("Qual o preço de venda do produto");
            venda = Double.Parse(Console.ReadLine());

            Produto p1 = new Produto(custo,venda);

            Console.WriteLine("Preço de Custo: " + p1.retornarCusto());
            Console.WriteLine("Preço de Venda: " + p1.retornarVenda());
            Console.WriteLine("Margem de Lucro: " + p1.calcularMargemLucro());
            Console.WriteLine("Margem de Lucro em percentagem: " + p1.getMargemLucroPorcentagem() + "%");
        }
    }
}
