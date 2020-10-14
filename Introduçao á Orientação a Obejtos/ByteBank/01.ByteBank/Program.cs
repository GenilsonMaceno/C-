using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente ContadaGrabiela = new ContaCorrente();

            ContadaGrabiela.titular = "Gabriela";
            ContadaGrabiela.agencia = 863;
            ContadaGrabiela.numeroConta = 8634522;
            ContadaGrabiela.saldo = 100;

            Console.WriteLine(ContadaGrabiela.titular);
            Console.WriteLine("Agencia: " + ContadaGrabiela.agencia);
            Console.WriteLine("Numero da Conta: " + ContadaGrabiela.numeroConta);
            Console.WriteLine("Saldo: " + ContadaGrabiela.saldo);


            ContadaGrabiela.saldo += 200;

            Console.WriteLine("Saldo: " + ContadaGrabiela.saldo);

            Console.ReadLine();
        }
    }
}
