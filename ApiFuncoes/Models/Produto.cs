namespace ApiFuncoes.Models;

public class Produto : IEquatable<Produto>
{   
    public int Id { get; set; }
    public string? Nome { get; set; }

    public bool Equals(Produto? produto)
    {
        return Id == produto?.Id && this.Nome == produto.Nome;            
    }

    public override int GetHashCode()
    {
        return Id.GetHashCode();
    }
}
