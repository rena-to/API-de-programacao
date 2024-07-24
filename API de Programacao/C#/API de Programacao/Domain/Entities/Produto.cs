namespace API_de_Programacao.Domain.Entities;

public class Produto
{
    public int IdProduto { get; set; }
    public string Nome { get; set; }
    public string Descricao { get; set; }
    public decimal Preco { get; set; }
    public int Quantidade { get; set; }
    public string Categoria { get; set; }
    
    
    public void Criar_produto(){} //acho que poderia substituir pelo construtor

    public List<string> Obter_info()
    {
        List < string > lista = new List<string>();
        return lista;
    }
}