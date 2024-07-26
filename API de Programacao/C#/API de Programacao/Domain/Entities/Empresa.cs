namespace API_de_Programacao.Domain.Entities;

public class Empresa
{
    public int IdEmpresa { get; set; }
    public int Cnpj { get; set; }
    public string Nome { get; set; }
    public string Rua { get; set; }
    public int Numero { get; set; }
    public int Cep { get; set; }
    public string Telefone { get; set; }
    public string Email { get; set; }
    public decimal Caixa { get; set; }
}