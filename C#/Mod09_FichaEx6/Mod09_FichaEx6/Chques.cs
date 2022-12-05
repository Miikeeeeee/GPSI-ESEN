using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod09_FichaEx6
{
    internal class Chques
    {
        int primeiro_cheque;
        int ultimo_cheque;


        public Chques(int primeiro_cheque, int utlimo_cheque)
        {
            this.primeiro_cheque = primeiro_cheque;
            this.ultimo_cheque = utlimo_cheque;
        }

        public int primeiro()
        {
            return primeiro_cheque;
        }

        public int ultimo()
        {
            return ultimo_cheque;
        }
    }
}
