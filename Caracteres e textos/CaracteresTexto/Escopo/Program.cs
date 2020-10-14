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
            Console.WriteLine("Executando projeto 9 - Escopo");

            int idadeJoao = 18;
            bool acompanhado = true;
            string mensagemAdicional;

            /*
             || -> é igual a "ou" mais conhecido do inglês "or"
             
             && - > é igual a "e" mais conhecido com "and"

             == -> é "igual" a uma condição verdadeira ou falso
            */

            if (acompanhado == true)
                mensagemAdicional = "João está acompanhado!";

            else
                mensagemAdicional = "João não está acompanhado!";

            if (idadeJoao >= 18 || acompanhado == true)
            {
                Console.WriteLine("João pode entrar");
                Console.WriteLine(mensagemAdicional);
            }
            else
            {
                Console.WriteLine("João não pode entrar");
            }


            Console.ReadLine();
        }
    }
}
