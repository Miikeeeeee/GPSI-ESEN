using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod09_Ex5
{
    internal class Cliente
    {
        string nome;
        string email;

        //Relação de composição o Cliente possui uma morada
        Morada m1 = new Morada();

        public Cliente()
        {

        }
        public Cliente(string n, string e)
        {
            nome = n;
            email = e;
        }

        public string DevolverNome()
        {
            return nome;
        }

        public string DevolverEmail()
        {
            return email;
        }

        public void DevolverMorada()
        {
            Console.WriteLine(m1.DevolverCodigo_Postal());
        }
        public void AlterarNome(string n)
        {
            nome = n;
        }

        public void AlterarEmail(string e)
        {
            email = e;
        }
    }

}
