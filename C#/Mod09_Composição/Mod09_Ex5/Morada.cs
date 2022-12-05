using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod09_Ex5
{
    internal class Morada
    {
        string rua;
        string numero;
        string localidade;
        string codigo_postal;

        public Morada()
        {
            rua = "Sem rua atribuida";
            numero = "Sem numero atribuido";
            localidade = "";
            codigo_postal = "0000-000";

        }

        public string DevolverRua()
        {
            return rua;
        }
        public string DevolverNumero()
        {
            return numero;
        }

        public string DevolverLocalidade()
        {
            return localidade;
        }

        public string DevolverCodigo_Postal()
        {
            return codigo_postal;
        }

        public void AlterarRua(string r)
        {
            rua = r;
        }
        public void AlterarNumero(string n)
        {
            numero = n;
        }

        public void AlterarLocalidade(string l)
        {
            localidade = l;
        }

        public void AlterarCodigo_Postal(string c)
        {
           codigo_postal = c;
        }
    }
}
