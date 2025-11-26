namespace SistemaBanco.Core.Models;

public class ContaPoupanca : Conta
{
    public ContaPoupanca(int agencia, int numero, Cliente titular) : base(agencia, numero, titular)
    {}

    public void RenderJuros(double taxaJuros)
    {
        double rendimento = Saldo * taxaJuros;
        Depositar(rendimento); 
    }
}