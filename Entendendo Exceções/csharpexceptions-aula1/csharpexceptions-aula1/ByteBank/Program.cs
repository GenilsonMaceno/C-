using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                CarregarContas();
            }
            catch(Exception)
            {
                Console.WriteLine("CATCH NO METODO MAIN");
            }
            
            

            Console.ReadLine();
        }

        private static void CarregarContas()
        {

            using(LeitorDeArquivo leitor = new LeitorDeArquivo("Contas.txt"))
            {
                leitor.LerProximaLinha();
                leitor.LerProximaLinha();
                leitor.LerProximaLinha();
            }


            //LeitorDeArquivo leitor = null;

            //try
            //{
            //    leitor = new LeitorDeArquivo("contas.txt");
            //    leitor.LerProximaLinha();
            //    leitor.LerProximaLinha();
            //    leitor.LerProximaLinha();

                
            //}
            //catch(IOException e)
            //{
            //    Console.WriteLine("Exceção do tipo IOEception capturada e tratada");
            //}
            //finally
            //{
            //    if(leitor != null)
            //    {
            //        leitor.Fechar();
            //    }
                
            //}

        }


        private static void OperacaoFinanceira()
        {
            try
            {
                ContaCorrente conta = new ContaCorrente(45545, 5050);
                ContaCorrente conta2 = new ContaCorrente(45545, 5050);


                //conta.Sacar(10000);
                conta2.Transferir(1000, conta);
            }
            catch (OperacaoFinanceiraException e)
            {

                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);

                Console.WriteLine("Informações da INNER EXCEPTION (exceção interna):");

                //Console.WriteLine(e.InnerException.Message);
                //Console.WriteLine(e.InnerException.StackTrace);
            }
        }

        // Teste com a cadeia de chamada:
        // Metodo -> TestaDivisao -> Dividir
        private static void Metodo()
        {
            TestaDivisao(0);
        }

        private static void TestaDivisao(int divisor)
        {
     
            int resultado = Dividir(10, divisor);
            Console.WriteLine("Resultado da divisão de 10 por " + divisor + " é " + resultado);
            
      
        }

        private static int Dividir(int numero, int divisor)
        {
            try
            {
                return numero / divisor;
            }
            catch (Exception)
            {
                Console.WriteLine("Exceção com numero = " + numero + " e divisor = " + divisor);
                throw;
            }
        }
    }
}
