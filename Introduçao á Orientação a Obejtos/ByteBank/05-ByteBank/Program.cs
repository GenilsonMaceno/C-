using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _05_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cliente Genilson = new Cliente();

            //Genilson.Nome = "Genilson";
            //Genilson.CPF = "422.789.158-27";
            //Genilson.Profissao = "Analista de Sistemas";

            ContaCorrente conta = new ContaCorrente();

            //conta.titular = new Cliente();
           //conta.titular.Nome = "Genilson Maceno";
           //conta.titular.CPF = "422.789.158-27";
           //conta.titular.Profissao = "Analista de Sistemas";

            //conta.titular = Genilson;
            conta.saldo = 500;
            conta.agencia = 563;
            conta.numeroConta = 5635878;

            //Console.WriteLine(Genilson.Nome);
            //Console.WriteLine(conta.titular.Nome);

            if (conta.titular == null)
            {
                Console.WriteLine("O valor veio vazio, tem que está vendo isso ai");
            }

            Console.WriteLine(conta.titular); // Titular não está apontando para nenhum lugar, portanto é vazio
            //Console.WriteLine(conta.titular.Nome);
            //Console.WriteLine(conta.titular.CPF);
            //Console.WriteLine(conta.titular.Profissao);

            Console.ReadLine();
        }
    }
}
