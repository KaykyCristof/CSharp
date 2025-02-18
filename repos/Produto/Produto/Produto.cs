class Produto
{
    private string nome;
    private string marca;
    private int estoque;
    private double preco;

    public string Nome 
    { 
        get
        {
            Console.WriteLine( "Acessando o getter da propriedade Nome." );
            return nome;
        }

        set
        {
            Console.WriteLine( "Acessando o setter da propriedade Nome." );
            nome = ( !string.IsNullOrEmpty( value ) ) ? value : throw new ArgumentException( "Valor inválido para nome!" );
        }
    }

    public string Marca
    {
        get
        {
            Console.WriteLine( "Acessando o getter da propriedade Marca." );
            return marca;
        }
        set
        {
            Console.WriteLine( "Acessando o setter da propriedade Marca." );
            marca = ( !string.IsNullOrEmpty(value) ) ? value : throw new ArgumentException( "Valor inválido para marca!" );
        }
    }

    public int Estoque 
    {
        get
        {
            Console.WriteLine( "Acessando o getter da propriedade Estoque." );
            return estoque;
        }
        set
        {
            Console.WriteLine( "Acessando o setter da propriedade Estoque." );
            estoque = ( value > 0 ) ? value : throw new ArgumentException( "Valor inválido para estoque!" );
        }
    }

    public double Preco 
    { 
        get
        {
            Console.WriteLine( "Acessando o getter da propriedade Preco." );
            return preco;
        }
        set
        {
            Console.WriteLine( "Acessando o setter da propriedade Preco." );
            preco = ( value > 0 ) ? value : throw new ArgumentException( "Valor inválido para preço!" );
        }
    }

    public Produto()
    {
        Console.WriteLine( "Construtor..." ); 
    }

    public string ExibeProduto =>
    (
        $"Nome do produto: {Nome}.\n" +
        $"Marca do produto: {Marca}.\n" +
        $"Quantidade em estoque do produto: {Estoque}.\n" +
        $"Preço do produto: {Preco}.\n"
    );
}
