// Definindo esqueleto da classe;

class Produto
{
    public string Nome
    {
        get => nome;
        set => nome = !string.IsNullOrEmpty( value ) ? value : throw new ArgumentException( "Erro! Valor inválido para nome!" );
    }

    private string nome;

    public string Marca
    {
        get => marca;
        set => marca = !string.IsNullOrEmpty( value ) ? value : throw new ArgumentException( "Erro! Valor inválido para marca." );
    }

    private string marca;

    public double Preco
    {
        get => preco;
        set => preco = value > 0 ? value : throw new ArgumentException( "Erro! valor inválido para preço." );
    }
    
    private double preco;

    public int Estoque
    {
        get => estoque;

        set => estoque = value > 0 ? value : throw new ArgumentException( "Erro! valor inválido para estoque." );
    }

    private int estoque;

    public Produto( string nomeProduto, string nomeMarca, double precoProduto, int estoqueProduto )
    {
        Nome = nomeProduto;
        Marca = nomeMarca;
        Preco = precoProduto;
        Estoque = estoqueProduto;
    }

    public string ExibeInformacoes =>
    (
        $"Nome do produto:{Nome}.\n" +
        $"Marca do produto: {Marca}.\n" +
        $"Preço do produto: {Preco}.\n" +
        $"Quantidade em estoque do produto: {Estoque}." 
    );
}
