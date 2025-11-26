using SistemaBanco.Core.Models;

Cliente marcos = new Cliente("Marcos andre", "456.327.132-83");
ContaCorrente  contaDoMarcos = new ContaCorrente(1,212, marcos);
contaDoMarcos.Titular = marcos;

Console.WriteLine($"titular: {contaDoMarcos.Titular.Nome}");
contaDoMarcos.Depositar(4000);
Console.WriteLine($"saldo inicial: {contaDoMarcos.Saldo}");
contaDoMarcos.Sacar(1000);
Console.WriteLine($"saldo apos o saque: {contaDoMarcos.Saldo}");

Cliente pedro = new Cliente("pedro andre", "236.327.132-83");
ContaCorrente  contaDoPedro = new ContaCorrente(1,112, pedro);
contaDoPedro.Titular = pedro;

Console.WriteLine($"titular: {contaDoPedro.Titular.Nome}");
contaDoPedro.Depositar(10000);
Console.WriteLine($"saldo inicial: {contaDoPedro.Saldo}");
contaDoPedro.Sacar(2000);
Console.WriteLine($"saldo apos o saque: {contaDoPedro.Saldo}");