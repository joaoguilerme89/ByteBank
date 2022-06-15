using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
     public abstract class Funcionario //vira uma class referia, ñ pode ser usado como uma class principal
     {
        public int TotalFuncionario { get; private set; }
        public string Nome { get; set; }
        public string CPF { get; private set; }
        public double Salario { get; set; }

        public Funcionario(double salario, string cpf)
        {
            
            Console.WriteLine("Criando funcionario");
            CPF = cpf;
            Salario = salario;

            TotalFuncionario++;
        }

        public abstract void AumentarSalario();

        public abstract double GetBonificacao();
    }
}
