using ProWay.OrientacaoObjetos.Models.ContaBancaria;

ContaPoupanca contaPoupanca = new ContaPoupanca("Pedrp" , 2000);
Console.WriteLine($"Saldo Pedro: {contaPoupanca.Saldo}");

contaPoupanca.Sacar(100);
Console.WriteLine($"Saldo Pedro: {contaPoupanca.Saldo}");

contaPoupanca.Sacar(150);
Console.WriteLine($"Saldo Pedro: {contaPoupanca.Saldo}");


ContaCorrente contaCorrente = new ContaCorrente(2000);
Console.WriteLine($"Saldo conta corrente {contaCorrente.Saldo}");

contaCorrente.Sacar(100); 
Console.WriteLine($"Saldo Pedro: {contaCorrente.Saldo}");
contaCorrente.Sacar(150);
Console.WriteLine($"Saldo Pedro: {contaCorrente.Saldo}");
Console.WriteLine(contaCorrente.ToString());

