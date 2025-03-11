using ScreenSound.Modelos;
using ScreenSound.Gerenciador;
namespace ScreenSound.Menus;

class AvaliaAlbum : Menu
{
    public override void Insere(Dictionary<string, Banda> bandasRegistradas)
    {
        base.Insere(bandasRegistradas);
        if( DicionarioVazio( bandasRegistradas ) ) Console.WriteLine( "Nenhuma banda registrada!" );
        else
        {
            Menu.FormataOpcao( "Por favor, insira o nome da banda:" );
            string nomeBanda = Console.ReadLine()!;
            if( bandasRegistradas.ContainsKey( nomeBanda ) )
            {
                Banda banda = bandasRegistradas[nomeBanda];
                Menu.FormataOpcao( "Por favor, insira o nome do álbum:" );
                string nomeAlbum = Console.ReadLine()!;
                if( banda.albuns.Any( n => n.Nome.Equals( nomeAlbum ) ) )
                {
                    Album album = banda.albuns.First( n => n.Nome.Equals( nomeAlbum ) );
                    Menu.FormataOpcao( "Por favor, insira a nota do álbum:" );
                    int nota = int.Parse( Console.ReadLine()! );
                    album.InsereNota( new Avaliacao( nota ) );

                }
                else
                {
                    Console.WriteLine( $"Álbum: {nomeAlbum} não encontrado!" );
                }
            }
            else
            {
                Console.WriteLine( $"Banda: {nomeBanda} não encontrada!" );
            }

        }
    }
    /*public override void Insere( Dictionary<string, Banda> bandasRegistradas )
    {
        base.Insere( bandasRegistradas );
        Menu.FormataOpcao( "Por favor, insira o nome da banda:" );
        string nomeBanda = Console.ReadLine()!;
        
        if( GerenciadorBandas.VerificaBanda( bandasRegistradas, nomeBanda ) )
        {
            Console.WriteLine( $"Banda: {nomeBanda} encontrada!" );
            Menu.FormataOpcao( "Por favor, insira o nome do álbum:" );
            string nomeAlbum = Console.ReadLine()!;
            Album albumEncontrado = GerenciadorBandas.VerificaAlbum( bandasRegistradas, nomeBanda, nomeAlbum );
            Menu.FormataOpcao( "Por favor, insira a nota do álbum:" );
            int avaliacao = int.Parse( Console.ReadLine()! );
            albumEncontrado.InsereNota( new Avaliacao( avaliacao ) );
        }
        else
        {
            Console.WriteLine( $"Banda: {nomeBanda} não encontrada!" );
        }
    }*/
}
