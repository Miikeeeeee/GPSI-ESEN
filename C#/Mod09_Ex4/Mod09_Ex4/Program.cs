using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod09_Ex4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double media;
            int maximo;
            List <string> Nomes = new List<string>();
            List <double> Salarios = new List<double>();
            Empregados e1 = new Empregados("Joao", 500);
            Empregados e2 = new Empregados("Antonio", 650);
            Empregados e3 = new Empregados("Afonso", 1500);
            Empregados e4 = new Empregados("Tiago",2000);
            Empregados e5 = new Empregados("Carlos", 1100);

            media = (e1.salarios() + e2.salarios() + e3.salarios() + e4.salarios() + e5.salarios())/5;

            Nomes.Add(e1.nomes());
            Nomes.Add(e2.nomes());
            Nomes.Add(e3.nomes());
            Nomes.Add(e4.nomes());
            Nomes.Add(e5.nomes());

            Salarios.Add(e1.salarios());
            Salarios.Add(e2.salarios());
            Salarios.Add(e3.salarios());
            Salarios.Add(e4.salarios());
            Salarios.Add(e5.salarios());

            maximo = Salarios.IndexOf(Salarios.Max());

            
            Console.WriteLine("O empregado que tem o maior salario é "+Nomes[maximo]+" a receber "+ Salarios.Max()+" euros ");


            Console.WriteLine("A media dos salarios da empresa é " + media);
            
            Console.ReadLine();
        }
    }
}
