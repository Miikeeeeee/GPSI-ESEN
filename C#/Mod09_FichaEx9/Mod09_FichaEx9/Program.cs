using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod09_FichaEx9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcao;
            Console.WriteLine("Qual a cor do balao:");
            string cor = Console.ReadLine();
            Console.WriteLine("Qual a direcao do balao:");
            string direcao = Console.ReadLine();
            Console.WriteLine("Qual a altura do balao:");
            int altura = int.Parse(Console.ReadLine());
            if (altura < 0)
            {
                Console.WriteLine("A altura nao pode ser inferior a 0");
                Console.WriteLine("Qual a altura do balao:");
                altura = int.Parse(Console.ReadLine());
            }

            Balao b1 = new Balao(cor,direcao,altura);
            Console.Clear();
            
            do
            {
                Console.WriteLine("---> [MENU] <---");
                Console.WriteLine("[1] -> [Alterar a cor do balao]");
                Console.WriteLine("[2] -> [Alterar a direcao do balao]");
                Console.WriteLine("[3] -> [Alterar a altura do balao]");
                Console.WriteLine("[4] -> [Ver informacao da viagem]");
                Console.WriteLine("[0] -> [Fechar programa]");
                Console.WriteLine("Qual a opcao que quer escolher:");
                opcao = int.Parse(Console.ReadLine());

                if (opcao == 1)
                {
                    Console.WriteLine("Qual a nova cor do balao:");
                    cor = Console.ReadLine();
                    b1.AlterarCor(cor);
                    Console.Clear();
                }

                else if (opcao == 2)
                {
                    Console.WriteLine("Qual a nova direcao do balao:");
                    direcao = Console.ReadLine();
                    b1.AlterarDirecao(direcao);
                    Console.Clear();
                }

                else if (opcao == 3)
                {
                    Console.WriteLine("Qual a nova altura do balao:");
                    altura = int.Parse(Console.ReadLine());
                    Console.Clear();
                    if (altura < 0)
                    {
                        Console.WriteLine("A altura nao pode ser inferior a 0");
                        Console.WriteLine("Qual a nova altura do balao:");
                        altura = int.Parse(Console.ReadLine());
                        Console.Clear();
                    }
                }

                else if (opcao == 4)
                {
                    Console.WriteLine("A cor do balao e " + cor + ", a direcao do balao e " + direcao + ", a altura do balao e " + altura);
                    Console.Clear();
                }
            }
            while (opcao > 0);
            {
                Console.WriteLine("Obrigado por usar nosso programa");
            }

        }
    }
}
