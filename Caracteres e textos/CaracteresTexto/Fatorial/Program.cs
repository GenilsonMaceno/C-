using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fatorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int mlt = 0;
            int resultado = 1;

            for(int i = 0; i <= 4; i++)
            {
                if (i == 0 || i == 1)
                {
                    mlt = 1;
                    resultado = mlt;
                }
                else
                {
                    mlt = i;
                    resultado = resultado * mlt;
                }

                Console.WriteLine(resultado);
               
            }
            Console.ReadLine();
            
        }
    }
}
