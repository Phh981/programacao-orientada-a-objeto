namespace Core.Models;

public class Gerente : Funcionario , IBonificavel {
    public Gerente (string nome, string cpf) : base(nome,cpf) {}

    public override decimal CalcularSalario()
    {
        return  10000.00m;
    }
    public decimal CalcularBonusAnual()
    {
        return CalcularSalario()* 2;
    }
}