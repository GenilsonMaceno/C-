using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente Genilson = new Cliente();

            Genilson.nome = "Genilson";
            Genilson.profissao = "Analista de Sistemas";
            Genilson.cpf = "422.789.158.27";


            ContaCorrente conta = new ContaCorrente();

            conta.titular = Genilson;
            conta.saldo = 500;
            conta.agencia = 563;
            conta.numeroConta = 5633354;

            Console.WriteLine(Genilson.nome);
            Console.WriteLine(conta.titular.nome);
         
            Console.ReadLine();
        }
    }
}
