// Definindo a classe principal do programa

namespace SistemaMusica
{
    class Program
    {
        public static void Main( string[] args )
        {
            Convidado convidado0 = new Convidado( "Serjão" );

            Episodio episodio0 = new Episodio( "Podcast sobre foguetes espaciais", "Foguetes espaciais" );
            episodio0.Duracao = 210;
            episodio0.AdicionarConvidados( convidado0 );

            Podcast podcast0 = new Podcast( "Igor", "Flow Podcast" );
            podcast0.AdicionarEpisodio( episodio0 );
            podcast0.ExibirDetalhes();

            Convidado convidado1 = new Convidado( "Pedro José" );
            Convidado convidado2 = new Convidado( "Marcelo Alves" );

            Episodio episodio1 = new Episodio( "Podcast sobre Futebol Moderno", "Futebol Moderno" );
            episodio1.Duracao = 340;
            episodio1.AdicionarConvidados( convidado1 );
            episodio1.AdicionarConvidados( convidado2 );

            Podcast podcast1 = new Podcast( "Mitico", "Podpah" );
            podcast1.AdicionarEpisodio( episodio1 );
            podcast1.ExibirDetalhes();

        }
    }
}