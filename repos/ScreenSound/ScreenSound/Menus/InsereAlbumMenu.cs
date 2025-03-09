using ScreenSound.Gerenciador;
using ScreenSound.Modelos;
namespace ScreenSound.Menus;

class InsereAlbumMenu : Menu
{
    public override void Insere( Dictionary<string, Banda> bandasRegistradas )
    {
        base.Insere( bandasRegistradas );
        Menu.FormataOpcao( "Por favor, insira o nome da banda:" );
        string nomeBanda = Console.ReadLine()!;
        if( GerenciadorBandas.VerificaBanda( bandasRegistradas, nomeBanda ) )
        {
            Console.WriteLine( $"Banda: {nomeBanda} encontrado com sucesso!" );
            Menu.FormataOpcao( "Por favor, insira o nome do álbum:" );
            Album novoAlbum = Album.Parse( Console.ReadLine()! );
            bandasRegistradas[nomeBanda].InsereAlbum( novoAlbum );
        }
        else
        {
            Console.WriteLine( $"Banda: {nomeBanda} não encontrada!" );
        }
        Menu.Intervalo();
    }
}
