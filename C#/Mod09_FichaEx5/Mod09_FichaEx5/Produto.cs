using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod09_FichaEx5
{
    internal class Produto
    {
        string nome;
        double precoCusto;
        double precoVenda;
        double margemLucro;

        public string retornarNome()
        {
            return nome;
        }

        public double retornarCusto()
        {
            return precoCusto;
        }

        public double retornarVenda()
        {
            return precoVenda;
        }

        public double retornarLucro()
        {
            return margemLucro;
        }

        public void AlterarNome(string none)
        {
            this.nome = nome;
        }

        public void AlterarCusto(double precoCusto)
        {
            this.precoCusto = precoCusto;
        }

        public void AlterarVenda(double precoVenda)
        {
            this.precoVenda = precoVenda;
        }

        public void AlterarLucro(double margemLucro)
        {
            this.margemLucro = margemLucro;
        }


        public double calcularMargemLucro()
        {
            if (precoVenda < precoCusto)
            {
                Console.WriteLine("Preço de venda inferior ao de custo");
                margemLucro = 0;
            }
            else
            {
                margemLucro = precoVenda - precoCusto;
            }
            return margemLucro;


        }

        public double getMargemLucroPorcentagem()
        {
            return Math.Round(((margemLucro * 100) / precoCusto), 1);
        }

        //Construtor
        public Produto()
        {

        }


        public Produto(double precoCusto, double precoVenda)
        {
            this.precoCusto = precoCusto;
            this.precoVenda = precoVenda;
        }




    }
}
