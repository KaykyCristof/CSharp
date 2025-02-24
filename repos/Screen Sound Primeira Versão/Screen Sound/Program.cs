public class ScreenSound
{
    public static Dictionary<string, List<int>> nomeDasBandas = new Dictionary<string, List<int>>
    { 
        { "The Beatles", new List<int>{ 10, 8, 7 } },
        { "Queen", new List<int>{ 8, 6, 9 } },
        { "Nirvana", new List<int>{ 10, 5, 8} }
    };

    public static Dictionary <string, double> mediaDasBandas = new Dictionary<string, double>();

    public static class Funcoes
    {
        public static void ExibirLogo()
        {
            Console.WriteLine(@"
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░"); // Verbatim literal;
        }

        public static void ExibeOpcoes( string nomeString )
        {
            int tamanhoString = nomeString.Length;
            string astericos = string.Empty.PadLeft( tamanhoString, '*' );

            Console.WriteLine( astericos );
            Console.WriteLine( nomeString );
            Console.WriteLine( astericos );
        }

        public static bool BandaVazia( Dictionary< string, List<int>> nomeBandas )
        {
            if( nomeBandas.Count == 0 )
            {
                return true;
            } else
            {
                return false;
            }
        }

        public static void SairFuncoes()
        {
            Console.WriteLine("Precione qualquer tecla para sair:");

            Console.ReadKey();
            Thread.Sleep(2000);
            Console.Clear();
        }

        public static void InsereBandas()
        {
            Console.Clear();

            string nomeBanda;

            Funcoes.ExibeOpcoes( "Por favor, insira o nome da banda a ser inserido:" );
            nomeBanda = Console.ReadLine()!;

            nomeDasBandas.Add( nomeBanda, new List<int>() );

            Console.WriteLine( $"A banda:{nomeBanda} foi inserida com sucesso!" );
            
            Thread.Sleep( 2000 );
            Console.Clear();
        }

        public static void ExibeTodasBandas()
        {
            Console.Clear();

            if( BandaVazia(nomeDasBandas) )
            {
                Funcoes.ExibeOpcoes( "Nenhuma banda registrada!" );
            } else
            {
                Console.WriteLine( "Lista de todas as bandas" );

                foreach( string nomeBandas in nomeDasBandas.Keys )
                {
                    Console.WriteLine( nomeBandas );
                }
            }

            Funcoes.SairFuncoes();
        }

        public static void InsereNotas()
        {
            string nomeBanda;
            int nota;

            Console.Clear();

            if( BandaVazia(nomeDasBandas) )
            {
                Funcoes.ExibeOpcoes( "Nenhuma banda registrada!" );
            }
            else
            {
                Funcoes.ExibeOpcoes( "Por favor, insira o nome da banda:" );
                nomeBanda = Console.ReadLine()!;

                if ( nomeDasBandas.ContainsKey(nomeBanda) )
                {
                    Funcoes.ExibeOpcoes( $"Por favor, insira a nota da banda: {nomeBanda}" );
                    nota = int.Parse(Console.ReadLine()!);

                    nomeDasBandas[nomeBanda].Add(nota);

                    Console.WriteLine( $"Nota:{nota} da banda:{nomeBanda} inserida com sucesso!" );
                }
                else
                {
                    Console.WriteLine( $"Banda: {nomeBanda} não encontrada!" );
                }
            }

            Funcoes.SairFuncoes();
        }

        public static void RemoverBanda()
        {
            string nomeBanda;

            Console.Clear();

            if( BandaVazia(nomeDasBandas) )
            {
                Funcoes.ExibeOpcoes( "Nenhuma banda registrada!" );
            } else
            {
                Funcoes.ExibeOpcoes("Por favor, insira o nome da banda para ser removida:");
                nomeBanda = Console.ReadLine()!;

                if (nomeDasBandas.ContainsKey(nomeBanda))
                {
                    Console.WriteLine($"A banda:{nomeBanda} foi encontrada com sucesso!");

                    nomeDasBandas.Remove(nomeBanda);

                    Console.WriteLine("Banda removida com sucesso!");
                }
                else
                {
                    Console.WriteLine($"Banda:{nomeBanda} não encontrada!");
                }
            }

            Funcoes.SairFuncoes();
        }

        public static void ExibeNotas()
        {
            string nomeBanda;

            Console.Clear();

            if( BandaVazia(nomeDasBandas) )
            {
                Console.WriteLine( "Nenhuma banda registrada!" );
            } 
            else
            {
                Funcoes.ExibeOpcoes("Por favor, insira o nome da banda para exibir as notas:");
                nomeBanda = Console.ReadLine()!;

                if ( nomeDasBandas.ContainsKey( nomeBanda ) )
                {
                    Console.WriteLine( $"Banda:{nomeBanda} encontrada!" );

                    if (nomeDasBandas[nomeBanda].Count == 0 ) {
                        Console.WriteLine($"Nenhuma nota registrada na banda:{nomeBanda}.");
                    } else
                    {
                        foreach (int i in nomeDasBandas[nomeBanda])
                        {
                            Console.WriteLine("Notas: " + i);
                        }
                    }
                }
            }

            Funcoes.SairFuncoes();
        }

        public static void CalculaMedia()
        {
            Console.Clear();

            string nomeBanda = "";
            double media = 0;
            List<int> listaNotas = new List< int >();

            if ( Funcoes.BandaVazia( nomeDasBandas ) )
            {
                Console.WriteLine( "Nenhuma banda registrada!" );
            }
            else
            {
                Funcoes.ExibeOpcoes( "Por favor, insira o nome da banda para calcular a sua média de notas:" );
                nomeBanda = Console.ReadLine()!;

                if( nomeDasBandas.ContainsKey( nomeBanda ) )
                {
                    Console.WriteLine( $"Banda: {nomeBanda} encontrada com sucesso!" );

                    if (nomeDasBandas[nomeBanda].Count == 0 )
                    {
                        Console.WriteLine( "Nenhuma nota registrada!" );
                    }
                    else
                    {
                        listaNotas = nomeDasBandas[nomeBanda];
                        media = listaNotas.Average();

                        Console.WriteLine($"A média da banda{nomeBanda} é: {media}.");
                    }
                }
                else
                {
                    Console.WriteLine( $"Banda não encontrada!" );
                }
            }
            Funcoes.SairFuncoes();
        }

        public static void CalculaMediaGeral()
        {
            if( BandaVazia( nomeDasBandas) )
            {
                Console.WriteLine( "Nenhuma banda registrada!" );
            }
            else
            {
                List <int> mediaBanda = new List<int>();
                double media = 0;

                foreach( string nomeBanda in nomeDasBandas.Keys )
                {
                    mediaBanda = nomeDasBandas[nomeBanda];

                    media = mediaBanda.Average();

                    mediaDasBandas.Add( nomeBanda, media );
                } 
            }
        }

        public static void ExibeMediaGeral()
        {
            Console.Clear();

            Funcoes.CalculaMediaGeral();

            foreach( var nomeBanda in mediaDasBandas )
            {
                Console.WriteLine( $"Nome da banda:{nomeBanda.Key}." );
                Console.WriteLine( $"Média da banda:{nomeBanda.Value}." );
            }

            Funcoes.SairFuncoes();
        }

        public static void Menu()
        {
            int opcao = 0;

            do
            {
                Funcoes.ExibirLogo();
                Funcoes.ExibeOpcoes( "Bem vindo ao Screen Sound!" );

                Console.WriteLine( "Digite uma opção:" );
                Console.WriteLine( "1 - Inserir uma nova banda" );
                Console.WriteLine( "2 - Exibir todas as bandas" );
                Console.WriteLine( "3 - Avaliar uma banda" );
                Console.WriteLine( "4 - Exibir a média de uma banda" );
                Console.WriteLine( "5 - Remover uma banda" );
                Console.WriteLine( "6 - Exibe notas" );
                Console.WriteLine( "7 - Exibe a média de todas as bandas:" );
                Console.WriteLine( "0 - Sair" );

                opcao = int.Parse( Console.ReadLine()! );

                switch( opcao )
                {
                    case 1:
                    {
                        Funcoes.InsereBandas();
                        break;
                    }
                    case 2:
                    {
                        Funcoes.ExibeTodasBandas();
                        break;
                    }
                    case 3:
                    {
                        Funcoes.InsereNotas();
                        break;
                    }
                    case 4:
                    {
                        Funcoes.CalculaMedia();
                        break;
                    }
                    case 5:
                    {
                        Funcoes.RemoverBanda(); 
                        break;
                    }
                    case 6:
                    {
                        Funcoes.ExibeNotas();
                        break;
                    }
                    case 7:
                    {
                        Funcoes.ExibeMediaGeral();
                        break;
                    }
                    case 0:
                    {
                        Console.Clear();
                        Console.WriteLine( "Saindo..." );
                        Thread.Sleep( 2000 );
                        break;
                    }
                    default:
                    {
                        break;
                    }
                }
            } while (opcao != 0);
        }
    }

    public static void Main( string[] args )
    {
        Funcoes.Menu();
    }
}