using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod09_FichaEx8
{
    internal class Eventos
    {
        int identificador, convites;
        string descricao, local, data_realizacao;
        double custos, entrada, entrada_popular, entrada_normal, entrada_vip;
        bool bar_aberto;
        Bar_aberto b1;

        public Eventos(int identificador, int convites, string descricao, string local, string data_realizacao, bool bar_aberto, double custos, double entrada, Bar_aberto b1)
        {
            this.identificador = identificador;
            this.convites = convites;
            this.descricao = descricao;
            this.local = local;
            this.data_realizacao = data_realizacao;
            this.bar_aberto = bar_aberto;
            this.custos = custos;
            this.entrada = entrada;
            this.b1 = b1;
        }
        public int RetornarIdentificador()
        {
            return identificador;
        }

        public int RetornarConvites()
        {
            return convites;
        }

        public string RetornarDescricao()
        {
            return descricao;
        }

        public string RetornarLocal()
        {
            return local;
        }

        public string RetornarDataderealizacao()
        {
            return data_realizacao;
        }

        public double RetornarCustos()
        {
            return custos;
        }

        public double retornarPopular()
        {
            if (entrada <= 0 && bar_aberto == true)
            {
                entrada_popular = 20 + ((b1.RetornarValor1()/2) + (b1.RetornarValor2()/2) + (b1.RetornarValor3()/2) + (b1.RetornarValor4()/2));
            }
            else if (entrada <= 0 && bar_aberto == false)
            {
                entrada_popular = custos / convites;
            }
            else
            {
                entrada_popular = entrada;
            }
            return entrada_popular;
        }

        public double retornarNormal()
        {
            entrada_normal = entrada + (entrada * 0.10);
            return entrada_normal;
        }

        public double retornarVip()
        {
            entrada_vip = entrada + (entrada * 0.15);
            return entrada_vip;
        }




    }
}
