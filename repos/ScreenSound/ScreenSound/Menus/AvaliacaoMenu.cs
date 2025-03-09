using ScreenSound.Modelos;
using ScreenSound.Gerenciador;
namespace ScreenSound.Menus;

class AvaliacaoMenu : Menu
{
    public override void Insere( Dictionary<string, Banda> bandasRegistradas )
    {
        base.Insere( bandasRegistradas );
        if( DicionarioVazio( bandasRegistradas) ) Console.WriteLine( "Nenhuma banda inserida!" );
        else
        {
            Menu.FormataOpcao( "Por favor, insira o nome da banda para ser avaliada:" );
            string nomeBanda = Console.ReadLine()!;
            if( !GerenciadorBandas.VerificaBanda( bandasRegistradas, nomeBanda ) ) 
                Console.WriteLine( $"Banda: {nomeBanda} não encontrada!" );
            else
            {
                Console.WriteLine( $"Banda: {nomeBanda} encontrada!" );
                Menu.FormataOpcao( "Por favor, insira a nota da banda:" );
                Avaliacao novaAvaliacao = Avaliacao.Parse( int.Parse( Console.ReadLine()! ) );
                bandasRegistradas[nomeBanda].InsereNota( novaAvaliacao );
            }
        }
        Menu.Intervalo();
    }
}
