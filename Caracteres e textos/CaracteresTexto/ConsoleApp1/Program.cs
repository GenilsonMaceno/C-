using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 5 - caracteres e texto");

            char primeiraLetra = 'A';

            Console.WriteLine("Primeira letra " + primeiraLetra);

            // convertendo caracteres em numero

            primeiraLetra = (char)65;

            Console.WriteLine("Váriaves com numero: " + primeiraLetra);

            // somando um caracteres com mais um numero

            primeiraLetra = (char)(primeiraLetra + 1); // coloquei em parentes para converter tudo em um bloco só

            Console.WriteLine("Agora estou somando minha váriavel mais um número: " + primeiraLetra);

            // Usando a váriavel String

            string titulo = "Alura cursos tecnologia " + 2020;
            Console.WriteLine(titulo);


            //criando uma string com várias linhas
            // Colocando o "@" considera toda a linha com uma string até o fechamento das ASPAS
            string a = @" - .NET 
 - JAVA
 -Javascript";

            Console.WriteLine(a);


            

            Console.ReadLine();
            

            
        }
    }
}
