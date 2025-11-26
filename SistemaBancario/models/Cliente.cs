namespace SistemaBanco.Core.Models;

public class Cliente
{
    public string Nome {get; set;}
    public string CPF {get; set;}
    public string? Profissao {get; set;}
// logo a abaixo criei um metodo construtor no qual vai passar apenas dois atributos ao inves de 3 
//duas maneiras de resolver ou com ? ou = ""; no final 
    public Cliente (string nome, string cpf)
    {
        Nome = nome;
        CPF = cpf ; 
    }
}
