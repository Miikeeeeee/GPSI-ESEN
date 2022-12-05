using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod09_Herança
{
    class Veiculo
    {
        int velmax;
        int rodas;
        bool ligado;

        public Veiculo()
        {

        }

        public Veiculo(int velmax, int rodas, bool ligado)
        {
            this.velmax = 120;
            this.rodas = 4;
            this.ligado = ligado;
        }

        public void Ligar()
        {
            ligado = true;
        }

        public void Desligar()
        {
            ligado = false;
        }
        
        public int Rodas()
        {
            return rodas;
        }

        public string getLigado()
        {
            /*if (ligado)
            {
                return "sim";
            }
            else
            {
                return "não";
            }*/
            //operador trenário
            return (ligado ? "ligado" : "desligado");
        }
    }
}
