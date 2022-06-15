using ByteBank.Funcionarios;
using ByteBank.Funcionarios.Sistemas;
using System;

namespace ByteBank

{    class Program
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

            GerenteDeConta Pedra = new GerenteDeConta("123.456.789-8");
            Pedra.Nome = "Pedra";
            Pedra.Senha = "153";

            ParceiroComercial parceiro = new ParceiroComercial();
            parceiro.Senha = "123";

            sistemaInterno.Logar(parceiro, "123");

            Diretor joao = new Diretor("123.456.789-7");
            joao.Nome = "Joao";
            joao.Senha = "123";

            sistemaInterno.Logar(joao, "123");
            sistemaInterno.Logar(Pedra, "153");
        }
        
        
        
        
        
        public static void CalcularBonificacao()
        {
            GerenciadorBonificacao gerenciadorBonificacao = new GerenciadorBonificacao();

            Diretor joao = new Diretor("123.456.789-7");
            joao.Nome = "Joao";
            

            GerenteDeConta Pedra = new GerenteDeConta("123.456.789-8");
            Pedra.Nome = "Pedra";

            Designer Heryka = new Designer("123.456.789-9");
            Heryka.Nome = "Heryka";

            Auxiliar Vinicias = new Auxiliar("123.456.789-1");
            Vinicias.Nome = "Vinicias";

            gerenciadorBonificacao.Registrar(joao);
            gerenciadorBonificacao.Registrar(Pedra);
            gerenciadorBonificacao.Registrar(Heryka);
            gerenciadorBonificacao.Registrar(Vinicias);

            Console.WriteLine("Total de bonificação do mês " + gerenciadorBonificacao.GetTotalBonificacao());
        }
    }
}