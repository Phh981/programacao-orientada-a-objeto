namespace Core.Models;

public abstract class Funcionario
    {
        public string Nome {get; set;}
        public string CPF { get; set; }

        public Funcionario (string nome, string cpf) {
            Nome = nome;
            CPF = cpf;
        }
        public abstract decimal CalcularSalario();
    }   