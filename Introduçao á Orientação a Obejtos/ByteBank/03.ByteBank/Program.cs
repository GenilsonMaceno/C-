using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDaGabriela = new ContaCorrente();
            contaDaGabriela.titular = "Gabriela";
            contaDaGabriela.agencia = 863;
            contaDaGabriela.numeroConta = 863452;

            ContaCorrente contaDaGabrielaCosta = new ContaCorrente();
            contaDaGabrielaCosta.titular = "Gabriela";
            contaDaGabrielaCosta.agencia = 863;
            contaDaGabrielaCosta.numeroConta = 863452;


            // O valor será falso devido ser uma váriavel de referencia, uma vez que a conta da gabielacosta não está no mesmo lugar na memoria da outra cabriela mesmo contendo os mesmos dados.
            Console.WriteLine("Váriavel de referencia: " + (contaDaGabriela == contaDaGabrielaCosta));

            contaDaGabriela = contaDaGabrielaCosta;

            contaDaGabriela.saldo = 300;

            Console.WriteLine("Saldo Gabriela: " + contaDaGabriela.saldo);
            Console.WriteLine("Saldo Gabriela Costa: " + contaDaGabrielaCosta.saldo);

            Console.ReadLine();
        }
    }
}
