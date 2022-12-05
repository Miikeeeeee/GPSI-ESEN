using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod09_FichaEx8
{
    internal class Bar_aberto
    {
        string bebida1, bebida2, bebida3, bebida4;
        double alcool1, alcool2, alcool3, alcool4;
        double valor1, valor2, valor3, valor4;

        public Bar_aberto(string bebida1, string bebida2, string bebida3, string bebida4, double alcool1, double alcool2, double alcool3, double alcool4, double valor1, double valor2, double valor3, double valor4)
        {
            this.bebida1 = bebida1;
            this.bebida2 = bebida2;
            this.bebida3 = bebida3;
            this.bebida4 = bebida4;
            this.alcool1 = alcool1;
            this.alcool2 = alcool2;
            this.alcool3 = alcool3;
            this.alcool4 = alcool4;
            this.valor1 = valor1;
            this.valor2 = valor2;
            this.valor3 = valor3;
            this.valor4 = valor4;
        }

        public string RetornarBebida1()
        {
            return bebida1;
        }

        public string RetornarBebida2()
        {
            return bebida2;
        }

        public string RetornarBebida3()
        {
            return bebida3;
        }

        public string RetornarBebida4()
        {
            return bebida4;
        }

        public double RetornarAlcool1()
        {
            return alcool1;
        }
        public double RetornarAlcool2()
        {
            return alcool2;
        }
        public double RetornarAlcool3()
        {
            return alcool3;
        }
        public double RetornarAlcool4()
        {
            return alcool4;
        }
        public double RetornarValor1()
        {
            return valor1;
        }

        public double RetornarValor2()
        {
            return valor2;
        }

        public double RetornarValor3()
        {
            return valor3;
        }

        public double RetornarValor4()
        {
            return valor4;
        }
    }
}
