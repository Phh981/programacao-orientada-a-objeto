namespace Core.Models;

public class Estagiario : Funcionario {

    public Estagiario (string nome, string cpf) : base(nome,cpf) {}
     public override decimal CalcularSalario()
    {
        return  2000.00m;
    }
}