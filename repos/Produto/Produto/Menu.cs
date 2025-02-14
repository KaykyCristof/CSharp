static class Menu
{ 
    public static void Exibir()
    {
        int opcao = 0;

        do
        {
            Console.WriteLine( "\t--- Menu de opções ---" );
            Console.WriteLine( "1 - Inserir objeto" );
            Console.WriteLine( "2 - Remover objeto" );
            Console.WriteLine( "3 - Exibir informações" );
            Console.WriteLine( "0 - Sair" );

            opcao = int.Parse( Console.ReadLine()! );

            switch( opcao )
            {
                case 1:
                {
                    GerenciadorProduto.InsereProduto();
                    break;
                }
                case 2:
                {
                    GerenciadorProduto.RemoveProduto();
                    break;
                }
                case 3:
                {
                    GerenciadorProduto.ExibeProduto();
                    break;
                }
                default:
                {
                    Console.WriteLine( "Opção inválida!" );
                    break;
                }
                case 0:
                {
                    Console.WriteLine( "Saindo..." );
                    break;
                }
            }
        } while( opcao != 0 );
    }
}
