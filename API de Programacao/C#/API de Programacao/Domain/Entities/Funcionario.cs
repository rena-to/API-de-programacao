namespace API_de_Programacao.Domain.Entities;

public class Funcionario
{
    
    public int Empresa_idEmpresa { get; set; }
    public int IdFuncionario { get; set; }
    public int Carteira { get; set; }
    public int Cpf { get; set; }
    public string Telefone { get; set; }
    public string Rua { get; set; }
    public int Cep { get; set; }
    public string Nome { get; set; }
    private string Usuario { get; set; }
    private string Senha { get; set; }
    public string Cargo { get; set; }
    public DateTime Admissao { get; set; }
    public string Formacao { get; set; }
    public string Departamento { get; set; }
    public decimal Salario { get; set; }
    public int CargaHoraria { get; set; }
    public int Idade { get; set; }
}