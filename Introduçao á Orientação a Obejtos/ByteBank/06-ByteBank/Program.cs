using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _06_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente();
            Cliente cliente = new Cliente();

            cliente.Nome = "Genilson Maceno";
            cliente.Profissao = "Analista de Sistema";
            cliente.CPF = "422.789.158.27";

            conta.Saldo = -10;
            conta.Titular = cliente;

            conta.Titular.Nome = "Genilson Mendes";


            

            Console.WriteLine("Nome clinete: " + conta.Titular.Nome);
            Console.WriteLine("Obter Saldo: " + conta.Saldo);


            Console.ReadLine();
        }
    }
}
