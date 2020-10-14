using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public abstract class Funcionario
    {   
        public string Nome { get; set; }
        public string CPF { get; private set; }
        public double Salario { get; protected set; }

        public static int TotalDeFuncionario { get; private set; }

        public Funcionario(double salario, string cpf)
        {

            Console.WriteLine("Criando FUNCIONARIO");

            CPF = cpf;
            Salario = salario;
            TotalDeFuncionario++;
        }

        public abstract void AumentarSalario();

        public abstract double GetBonificacao();
    }
}
