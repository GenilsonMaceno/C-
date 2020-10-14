using ByteBankImportacaoExportacao.Modelos;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankImportacaoExportacao 
{ 
    class Program 
    { 
        static void Main(string[] args) 
        {

            var enderecoDoArquivo = "contas.txt";


            using (var fluxoDoArquivo = new FileStream(enderecoDoArquivo, FileMode.Open))
            {

                using(var leitor = new StreamReader(fluxoDoArquivo))
                {
                    while (!leitor.EndOfStream)
                    {
                        var linha = leitor.Read();
                        Console.WriteLine(linha);
                    }
                }
                //var buffer = new byte[1024];
                //var numeroDeBytesLidos = -1;
                
                //while(numeroDeBytesLidos != 0)
                //{
                //    numeroDeBytesLidos = fluxoDoArquivo.Read(buffer, 0, 1024);

      

                //    EscreverBuffer(buffer,numeroDeBytesLidos);
                //}
            }



            Console.ReadLine();
        }

        static void LerArquivoContas()
        {
            var arquivo = "contas.txt";

            var fluxoDoArquivo = new FileStream(arquivo, FileMode.Open);

            var buffer = new byte[1024];

            fluxoDoArquivo.Read(buffer, 0, 1024);

            var quantidadeByteLidos = -1;
            while (quantidadeByteLidos != 0)
            {
                quantidadeByteLidos = fluxoDoArquivo.Read(buffer, 0, 1024);
                EscreverBuffer(buffer,quantidadeByteLidos);
            }
        }

        static void EscreverBuffer(byte[] buffer, int bytesLidos)
        {
     
            var encoding = new UTF8Encoding();
            var texto = encoding.GetString(buffer,0,bytesLidos);


            Console.Write($"{texto}" );

        }
    }
} 
 