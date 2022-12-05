using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod09_FichaEx1
{
    class Quadrado
    {
        private double lado;

        public Quadrado()
        {
            lado = 1.0;
        }

        public Quadrado(double lado)
        {
            this.lado = lado;
        }

        public double Lado()
        { 
            return lado; 
        }
    }
}
