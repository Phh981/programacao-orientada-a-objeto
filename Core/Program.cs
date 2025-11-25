using Core.Models;

List<Funcionario> folhaDePagamento = new List<Funcionario>();

folhaDePagamento.Add(new Gerente("henrique", "123-123-323-90"));

folhaDePagamento.Add(new Estagiario("pedro", "123-123-353-90"));



foreach (var func in folhaDePagamento)
{
    Console.WriteLine($"nome: {func.Nome}");
    Console.WriteLine($"cargo: {func.GetType().Name}");
    Console.WriteLine($"salario: {func.CalcularSalario():C}");

    if (func is IBonificavel funcionarioComBonus) 
    {
        Console.WriteLine($"bonus Anual: {funcionarioComBonus.CalcularBonusAnual()}");
    }
    else 
    {
        Console.WriteLine("sem bônus anual");
    }

    Console.WriteLine("--------------------------");
}
