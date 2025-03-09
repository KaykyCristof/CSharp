using ScreenSound.Gerenciador;
using ScreenSound.Modelos;
namespace ScreenSound.Menus;

class InsereMusicaMenu : Menu
{
    public override void Insere( Dictionary<string, Banda> bandasRegistradas )
    {
        base.Insere( bandasRegistradas );
        Menu.FormataOpcao( "Por favor, insira o nome da banda:" );
        string nomeBanda = Console.ReadLine()!;
        if( GerenciadorBandas.VerificaBanda( bandasRegistradas, nomeBanda ) )
        {
            Console.WriteLine( $"Banda: {nomeBanda} encontrada!" );
            Menu.FormataOpcao( "Por favor, insira o nome do álbum:" );
            string nomeAlbum = Console.ReadLine()!;
            Album insereAlbum = GerenciadorBandas.VerificaAlbum( bandasRegistradas, nomeBanda, nomeAlbum );
            if( insereAlbum != null )
            {
                Console.WriteLine( $"Álbum: {nomeAlbum} encontrado!" );
                Menu.FormataOpcao( "Por favor, insira o nome e a duração da música:" );
                Musica novaMusica = Musica.Parse( Console.ReadLine()!, int.Parse( Console.ReadLine()! ) );
                insereAlbum.InsereMusica( novaMusica );
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
        Menu.Intervalo();
    }
}
