using ScreenSound.Modelos;
namespace ScreenSound.Gerenciador;

internal static class GerenciadorBandas
{
    public static bool VerificaBanda( Dictionary<string, Banda> bandasRegistradas, string nomeBanda )
    {
        if( bandasRegistradas.ContainsKey( nomeBanda ) ) return true;
        return false;
    }

    public static Album VerificaAlbum( Dictionary<string, Banda> bandasRegistradas, string nomeBanda, string nomeAlbum )
    {
        List<Album> albuns = bandasRegistradas[nomeBanda].GetAlbum();
        foreach( Album album in albuns )
        {
            if( album.Nome == nomeAlbum )
                return album;
        }
        return null!;
    }

    public static Musica VerificaMusica( Album album, string nomeMusica )
    {
        List<Musica> musicas = album.GetMusica();

        foreach( Musica musica in musicas )
        {
            if( nomeMusica == musica.Nome )
                return musica;
        }

        return null!;
    }
}
