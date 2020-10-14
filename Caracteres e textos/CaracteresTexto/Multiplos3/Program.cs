using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplos3
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;

            for(int mult = 0; mult <= 100; mult++)
            {
                numero = mult;

                if (numero % 3 == 0)
                {
                    Console.WriteLine(numero);
                    numero++;
                }
            }

            Console.ReadLine();
        }
    }
}
