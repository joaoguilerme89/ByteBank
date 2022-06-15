namespace ByteBank
{
    public class GerenciadorBonificacaoBase
    {
        public void Registrar(Funcionario funcionario)
        {
            _totalBonificacao += funcionario.GetObterBonificacao();
        }
    }
}