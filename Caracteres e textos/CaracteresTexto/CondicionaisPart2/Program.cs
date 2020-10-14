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
            Console.WriteLine("Executando projeto 8 - Condicionais part 2");

            int idadeJoao = 18;
            int quantidadesPessoas = 2;

            bool acompanhado = quantidadesPessoas >= 2; // true or false (verdadeiro ou falso)

            /*
             || -> é igual a "ou" mais conhecido do inglês "or"
             
             && - > é igual a "e" mais conhecido com "and"

             == -> é "igual" a uma condição verdadeira ou falso
            */

            if (idadeJoao >= 18 && acompanhado == true) 
            {
                Console.WriteLine("João pode entrar");
            }
            else
            {
                Console.WriteLine("João não pode entrar");
            }


            Console.ReadLine();
        }
    }
}
