// Definindo a classe principal do programa

namespace SistemaMusica
{
    class Program
    {
        public static void Main( string[] args )
        {
            Musica musica0 = new Musica( "Bohamian Rhapsody", 310 );
            musica0.Disponivel = true;

            Musica musica1 = new Musica( "Love of my life", 210 );

            Album album0 = new Album( "A night at the opera" );
            album0.AdicionaMusica( musica0 );
            album0.AdicionaMusica( musica1 );
           
            Banda banda0 = new Banda( "Queen" );
            banda0.AdicionaAlbum( album0 );
            banda0.ExibeBanda();
        }
    }
}