static class GerenciadorProduto
{ 
    private static List<Produto> listaProdutos = new List<Produto>();

    public static bool ListaVazia( List<Produto> listaProdutos )
    {
        if( listaProdutos.Count == 0 )
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public static void InsereDados( ref string nomeProduto, ref string nomeMarca, ref double precoProduto, ref int estoqueProduto )
    {
        Console.WriteLine( "Por favor, insira o nome do produto:" );
        nomeProduto = Console.ReadLine()!;

        Console.WriteLine( "Por favor, insira a marca do produto:" );
        nomeMarca = Console.ReadLine()!;

        Console.WriteLine( "Por favor, insira o preço do produto:" );
        precoProduto = int.Parse( Console.ReadLine()! );
        
        Console.WriteLine( "Por favor, insira a quantidade de estoque do produto:" );
        estoqueProduto = int.Parse( Console.ReadLine()! );
    }

    public static void InsereProduto()
    {
        string nome;
        string marca;
        double preco;
        int estoque;

        nome = marca = string.Empty;
        preco = estoque = 0;

        InsereDados( ref nome, ref marca, ref preco, ref estoque );

        Produto novoProduto = new Produto( nome, marca, preco, estoque );

        listaProdutos.Add( novoProduto );

        Console.WriteLine( "Novo produto inserido na lista com sucesso!" );
    }

    public static void RemoveProduto()
    {
        if( ListaVazia( listaProdutos ) )
        {
            Console.WriteLine( "Lista vazia!" );
        }
        else
        {
            int tamLista = listaProdutos.Count - 1;
            Produto produtoRemover = listaProdutos[tamLista];
            listaProdutos.Remove( produtoRemover );
        }
    }
    
    public static void ExibeProduto()
    {
        if( ListaVazia( listaProdutos) )
        {
            Console.WriteLine( "Lista vazia!" );
        }
        else
        {
            Console.WriteLine( "\t --- Lista de produtos ---" );
            foreach (var produtos in listaProdutos)
            {
                Console.WriteLine(produtos.ExibeInformacoes);
            }
        }
    }
       
}
