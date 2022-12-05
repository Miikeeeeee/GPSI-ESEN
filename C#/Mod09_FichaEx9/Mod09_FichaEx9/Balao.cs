using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Mod09_FichaEx9
{
    internal class Balao
    {
        string cor, direcao;
        double altura;
        
        public Balao(string cor, string direcao, double altura)
        {
            this.cor = cor;
            this.direcao = direcao;
            this.altura = altura;
        }

        public string RetornarCor()
        {
            return cor;
        }

        public string RetornarDirecao()
        {
            return direcao;
        }

        public double RetornarAltura()
        {
            return altura;
        }

        public void AlterarCor(string cor)
        {
            this.cor = cor;
        }

        public void AlterarDirecao(string direcao)
        {
            this.direcao = direcao;
        }

        public void AlterarAltura(double altura)
        {
            this.altura = altura;
        }
    }
}
