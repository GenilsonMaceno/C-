using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente Genilson = new ContaCorrente();

            Genilson.titular = "Genilson";

            Console.WriteLine("Saldo: " + Genilson.saldo);
            Genilson.Sacar(50); // usando função
            Console.WriteLine("Saldo: " + Genilson.saldo);

            bool saque = Genilson.Sacar(500);

            Console.WriteLine("Posso sacar: " + saque);

            Genilson.Depositar(500);
      
            Console.WriteLine("Foi depositado 500, posso sacar? " + Genilson.Sacar(50));
            Genilson.Sacar(50);
            Console.WriteLine("O Saldo do Genilson é $: " + Genilson.saldo);

            Console.WriteLine("Criando conta corrente da Aline... ");
            ContaCorrente conta = new ContaCorrente();
            conta.titular = "Aline Mendes";
            conta.saldo = 300;
            Console.WriteLine("Conta " + conta.titular + " Criada com sucesso!");
            Console.WriteLine("Saldo da conta " + conta.titular + " R$:" + conta.saldo);

            Console.WriteLine("Genilson transferindo R$: 300 para " + conta.titular);
            Genilson.Transferir(300, conta);
            Console.WriteLine("Saldo da conta do Genilson R$:" + Genilson.saldo);
            Console.WriteLine("Saldo da conta da Aline R$:" + conta.saldo);



            Console.ReadLine();
        }
    }
}
