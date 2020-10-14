using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Funcionarios;
using ByteBank.Sistemas;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            //CalcularBonificacao();

            UsarSistema();

            Console.ReadLine();
        }

        public static void UsarSistema()
        {
            SistemaInterno sistemaInterno = new SistemaInterno();

            Diretor roberta = new Diretor("222.222.222.22");
            roberta.Nome = "Roberta";
            roberta.Senha = "123";

            Console.WriteLine("Roberta");
            sistemaInterno.Logar(roberta, "123");
            //sistemaInterno.Logar(roberta, "ABC");


            GerenteDeConta camila = new GerenteDeConta("444.444.444.44");
            camila.Nome = "Camila";
            camila.Senha = "ABC";

            Console.WriteLine("Camila");
            //sistemaInterno.Logar(camila, "123");
            sistemaInterno.Logar(camila, "ABC");


            ParceiroComercial parceiro = new ParceiroComercial();
            parceiro.Senha = "123456";

            Console.WriteLine("Parceiro Comercial");
            sistemaInterno.Logar(parceiro, "123456");

            Designer pedro = new Designer("111.111.111.11.");
            pedro.Nome = "Pedro";



        }

        public static void CalcularBonificacao()
        {
            GerenciadorBonificacao gerenciadorBonificacao = new GerenciadorBonificacao();

          

            Designer pedro = new Designer("111.111.111.11.");
            pedro.Nome = "Pedro";

            Diretor roberta = new Diretor("222.222.222.22");
            roberta.Nome = "Roberta";

            Auxiliar igor = new Auxiliar("333.333.333.33");
            igor.Nome = "Igor";

            GerenteDeConta camila = new GerenteDeConta("444.444.444.44");
            camila.Nome = "Camila";

            gerenciadorBonificacao.Registrar(pedro);
            gerenciadorBonificacao.Registrar(roberta);
            gerenciadorBonificacao.Registrar(igor);
            gerenciadorBonificacao.Registrar(camila);


            Console.WriteLine("Total de bonificação por mês " + gerenciadorBonificacao.GetTotalBonificacao());


        }
    }
}
