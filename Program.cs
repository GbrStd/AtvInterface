
using AtvInterface._5;

ContaBancaria conta = new ContaBancaria();

Console.WriteLine("Saldo: R$ {0}", conta.ConsultarSaldo());

conta.Depositar(1000f);

Console.WriteLine("Saldo: R$ {0}", conta.ConsultarSaldo());

conta.Sacar(125f);

Console.WriteLine("Saldo: R$ {0}", conta.ConsultarSaldo());