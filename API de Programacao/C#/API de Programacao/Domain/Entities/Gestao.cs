namespace API_de_Programacao.Domain.Entities;

public class Gestao
{
    public int IdGestao { get; set; }
    public DateTime Data { get; set; }
    public string Tipo { get; set; }
    public string Descricao { get; set; }



    public void Criar_venda(){}

    public List<string> Checar_informacoes()
    {
        List < string > lista = new List<string>();
        return lista;
    }
    
}