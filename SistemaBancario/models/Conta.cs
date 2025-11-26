namespace SistemaBanco.Core.Models;

public abstract class Conta 
{
    public int Numero { get; set; }
    public int Agencia { get; set; }
    public Cliente Titular { get; set; } 

    public double Saldo {get; protected set;}

    public Conta (int agencia, int numero , Cliente titular)
    {
        Agencia = agencia;
        Numero = numero;
        Titular = titular;
    }
    public virtual void Sacar(double valor)
    {
        if (Saldo < valor)
        {
            throw new Exception("saldo insuficiente");
        }
        Saldo -= valor;
    }
    public void Depositar (double valor)
    {
        Saldo += valor;
    }
}
    
 