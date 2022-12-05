using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod09_FichaEx3
{
    internal class BilheteVIP : Bilhete
    {
        double adicional;
        double total;
        double diferenca;
        public BilheteVIP()
        {

        }

        public BilheteVIP(double adicional, double valor ) : base(valor)
        {
            this.total = adicional + valor;
            this.diferenca = valor - adicional;
        }

        public double ImprimirValor()
        {
            return total;
        }

        public double ImprimirDiferenca()
        {
            return diferenca;
        }
    }
}
