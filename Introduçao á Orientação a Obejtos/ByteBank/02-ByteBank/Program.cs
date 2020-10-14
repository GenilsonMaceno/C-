using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente();

            conta.titular = "Genilson";

            Console.WriteLine("Titular da conta: " + conta.titular);
            Console.WriteLine("Numero da Agencia: " + conta.agencia);
            Console.WriteLine("Numero da Conta: " + conta.numeroConta);
            Console.WriteLine("Saldo: " + conta.saldo);

            Console.ReadLine();


        }
    }
}
