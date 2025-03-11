/* Definindo um algoritmo para inserir uma nota na musica
 * Verificar se o dicionario esta vazio
        Se estiver vazio
            Dicionario vazio
        Senao
            Verificar se a banda existe
                se Banda existir
                    Verificar se album existe
                        se album existe 
                            Verificar se a musica existe
                                se existir
                                    Insere nota
                                senao
                                   musica nao encontrada
                        senao
                            album nao encontrado
                senao
                    Album não encontrado
           
 */
using ScreenSound.Modelos;
using ScreenSound.Gerenciador;
namespace ScreenSound.Menus;

class AvaliaMusica : Menu
{
    public override void Insere(Dictionary<string, Banda> bandasRegistradas)
    {
        base.Insere(bandasRegistradas);
    }
    /*public override void Insere( Dictionary<string, Banda> bandasRegistradas )
    {
        base.Insere( bandasRegistradas );
        if( DicionarioVazio( bandasRegistradas) ) Console.WriteLine( "Nenhuma banda registrada!" );
        else
        {
            Menu.FormataOpcao( "Por favor, insira o nome da banda:" );
            string nomeBanda = Console.ReadLine()!;
            if( GerenciadorBandas.VerificaBanda( bandasRegistradas, nomeBanda ) )
            {
                Console.WriteLine( $"Banda {nomeBanda} encontrada!" );
                Menu.FormataOpcao( "Por favor, insira o nome do álbum:" );
                string nomeAlbum = Console.ReadLine()!;
                Album album = GerenciadorBandas.VerificaAlbum( bandasRegistradas, nomeBanda, nomeAlbum );
                if( album != null )
                {
                    Console.WriteLine( $"Álbum: {nomeAlbum} encontrado!" );
                    Menu.FormataOpcao( "Por favor, insira o nome da música:" );
                    string nomeMusica = Console.ReadLine()!;
                    Musica musica = GerenciadorBandas.VerificaMusica( album, nomeMusica );
                    if( musica != null )
                    {
                        Console.WriteLine( $"Música: {nomeMusica} encontrada!" );
                        Menu.FormataOpcao( "Por favor, insira a nota:" );
                        int nota = int.Parse( Console.ReadLine()! ); 
                        musica.InsereNota( new Avaliacao( nota ) );
                        Console.WriteLine( "Nota inserida com sucesso!" );
                    }
                    else
                    {
                        Console.WriteLine( $"Música: {nomeMusica} não encontrada!" );
                    }
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
    }*/
}
