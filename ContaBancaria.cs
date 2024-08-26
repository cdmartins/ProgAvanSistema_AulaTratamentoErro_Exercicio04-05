namespace ProgAvanSistema_AulaTratamentoErro_Exercicio04_05
{
    internal class ContaBancaria
    {
        /* Crie classe ContaBancaria que implemente o método Sacar que
        receba um valor e diminua do saldo, sem fazer validações;*/
        private string? titular;
        private double saldo;

        public double getSaldo() => saldo;

        public ContaBancaria()
        {
            this.saldo = 450;
        }

        public virtual void Sacar(double valor)
        {
            this.saldo -= valor;
        }
    }
}
