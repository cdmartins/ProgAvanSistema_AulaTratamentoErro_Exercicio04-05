namespace ProgAvanSistema_AulaTratamentoErro_Exercicio04_05
{
    internal class ContaBancariaEspecial : ContaBancaria
    {
        /* Crie classe ContaBancariaEspecial que seja subclasse de
        ContaBancaria e sobreponha o método Sacar, recebendo um valor e
        validando o saldo.Caso tenha saldo suficiente diminui o saldo.Caso
        não tenha lança uma exceção de “Saldo insuficiente”.*/

        public override void Sacar(double valor)
        {
            try
            {
                if (valor <= getSaldo())
                {
                    base.Sacar(valor);
                    Console.WriteLine("Saque realizado com sucesso.");
                    Console.WriteLine($"Saldo atual: {getSaldo()}");
                }
                else
                {
                    throw new ArgumentException("Saldo insuficiente.");
                }
            }
            catch(ArgumentException ex)
            {
                Console.WriteLine("Erro: "+ex.Message);
            }
        }
    }
}
