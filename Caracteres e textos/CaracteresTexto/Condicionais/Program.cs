using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 7 - Condicionais");

            int idadeJoao = 16;
            int quantidadesPessoas = 2;

            if (idadeJoao >= 18)
            {
                Console.WriteLine("João possui mais de 18 anos de idade pode entrar");
            }
            else
            {
                if (quantidadesPessoas >= 2)
                {
                    Console.WriteLine("João não possui mais de 18 anos, mas está companhado. Pode entrar!");
                }
                else
                {
                    Console.WriteLine("João possui mais de 18 anos. Não pode entrar");
                }

            }


            Console.ReadLine();
        }
    }
}
