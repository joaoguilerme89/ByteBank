using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank.Funcionarios
{
    
        class Auxiliar : Funcionario
        {
            public Auxiliar (string cpf) : base(2000, cpf)
            {
                Console.WriteLine("Criando Auxiliar");
            }
        public override void AumentarSalario()
        {
            Salario *= 1.00;
        }

        public override double  GetBonificacao()
        {
            return Salario * 0.5;
        }
    }
   
}
