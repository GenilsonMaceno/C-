using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace _07_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Total de contas: " + ContaCorrente.TotalDeContas);

            ContaCorrente conta = new ContaCorrente(574, 5748872);

            //conta.agencia = -10;

            Console.WriteLine("Total de contas: " + ContaCorrente.TotalDeContas);

      

            Console.WriteLine("Total de contas: " + ContaCorrente.TotalDeContas);

            ContaCorrente conta1 = new ContaCorrente(574, 5748882);

            Console.WriteLine("Total de contas: " + ContaCorrente.TotalDeContas);

            //Console.WriteLine("Número da Agencia: " + conta.Agencia);
            //Console.WriteLine("Número da Agencia: " + conta.NumeroConta);

            Console.ReadLine();

        }
    }
}
