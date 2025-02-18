static class Menu
{
    private static List<Produto> listaProdutos = new List<Produto>();
    public static void ExibeOpcoes()
    {
        Console.WriteLine("\t--- Insira alguma opção ---\n");
        Console.WriteLine("\t1 - Inserir produto");
        Console.WriteLine("\t2 - Remover produto");
        Console.WriteLine("\t3 - Exibir produtos ");
        Console.WriteLine("\t0 - Sair");
    }
    public static void InsereDados( ref Produto produto )
    {
        Console.WriteLine( "Por favor, insira o nome do produto:" );
        string nome = Console.ReadLine()!;
        produto.Nome = nome;

        Console.WriteLine( "Por favor, insira a marca do produto:" );
        string marca = Console.ReadLine()!;
        produto.Marca = marca;

        Console.WriteLine( "Por favor, insira a quantidade em estoque do produto:" );
        int estoque = int.Parse( Console.ReadLine()! );
        produto.Estoque = estoque;

        Console.WriteLine( "Por favor, insira o preço do produto:" );
        double preco = double.Parse( Console.ReadLine()! );
        produto.Preco = preco;
    }
    public static void InsereProdutos()
    {
        Produto produto = new Produto();
        InsereDados( ref produto );
        listaProdutos.Add( produto );

        Console.WriteLine( "Produto inserido com sucesso!" );
    }
    public static void RemoveProdutos()
    {

        if( listaProdutos.Count == 0 )
        {
            Console.WriteLine( "Nenhum produto a remover!" );
        }
        else
        {
            int tamLista = listaProdutos.Count - 1;
            Produto produto = listaProdutos[tamLista];
            listaProdutos.Remove( produto );

            Console.WriteLine( "Produto removido com sucesso!" );
        }
    }
    public static void ExibeProdutos()
    {
        foreach( var produtos in listaProdutos )
        {
            Console.WriteLine( produtos.ExibeProduto );
        }
    }
    public static void ExibirMenu()
    {
        int opcao = 0;

        do
        {
            ExibeOpcoes();

            opcao = int.Parse( Console.ReadLine()! );

            switch ( opcao )
            { 
                case 1:
                {
                    InsereProdutos();
                    break;
                }
                case 2:
                {
                    RemoveProdutos();
                    break;
                }
                case 3:
                {
                    ExibeProdutos();
                    break;
                }
                case 0:
                {
                    Console.WriteLine( "Saindo..." );
                    break;
                }
                default:
                {
                    Console.WriteLine( "Opção inválida!" );
                    break;
                }
            }
         } while ( opcao != 0 );
    }
}