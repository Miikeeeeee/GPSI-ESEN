using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod09_FichaEx12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> paragens = new List<string> ();
            Console.WriteLine("Quantas pessoas o autocarro podera transportar:");
            int passageiros = int.Parse(Console.ReadLine());
            Console.WriteLine("Quantas paragens irá ter a viagem contando com a partida e com o destino:");
            int quantidade = int.Parse(Console.ReadLine());
            Console.WriteLine("Escreva as paragens por ordem de partida para chegada");
            for (int i = 1; i <= quantidade; i++)
            {
                Console.WriteLine("Qual a paragem "+i);
                paragens.Add (Console.ReadLine());
            }
;

        }
    }
}
