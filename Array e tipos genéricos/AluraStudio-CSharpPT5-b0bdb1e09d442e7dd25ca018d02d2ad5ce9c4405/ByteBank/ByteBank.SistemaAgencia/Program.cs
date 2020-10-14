using ByteBank.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            // açucar sintatico
            int[] idade = new int[]
            {
                15,28,35,50,28
            };

            //idade[0] = 15;
            //idade[1] = 28;
            //idade[2] = 35;
            //idade[3] = 50;
            //idade[4] = 28;
            //idade[5] = 32;

            int acumulador = 0;
            for (int indice = 0; indice < idade.Length; indice++)
            {

                acumulador += idade[indice];

                //int idades = idade[indice];
                ////Console.WriteLine("idade.Length " + idade.Length);
                ////Console.WriteLine($"Valor no índice {i}: {idade}");
                Console.WriteLine($"valor no índice {indice}: {idade[indice]}");
            }
            int media = acumulador / idade.Length;
            Console.WriteLine($"media {media}");
            
            
            //int indice = 2;
            //int valorNoIndice = idade[indice];
            //int outroValor = idade[2 + 2];
           


            //Console.WriteLine("idade " + indice);
            //Console.WriteLine("idade " + valorNoIndice);
            //Console.WriteLine("idade " + outroValor);

            Console.ReadLine();
        }
    }
}
