namespace SistemaBanco.Core.Models;

public class ContaCorrente : Conta , ITributavel
{
    public ContaCorrente(int agencia, int numero, Cliente titular) : base (agencia,numero, titular)
    {
        
    }
    public override void Sacar(double valor)
    {
        double taxa =1.0;
        base.Sacar(valor + taxa);
    }
    public double CalcularImposto()
    {
        return Saldo * 0.10;
    }
}