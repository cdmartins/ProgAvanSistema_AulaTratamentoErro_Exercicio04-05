
using ProgAvanSistema_AulaTratamentoErro_Exercicio04_05;

ContaBancariaEspecial account = new();
Console.Write($"Saldo: {account.getSaldo()}\nValor do saque: ");
account.Sacar(double.Parse(Console.ReadLine()!));