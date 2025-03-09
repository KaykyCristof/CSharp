using ScreenSound.Modelos;
namespace ScreenSound.Menus;

class ExibeMenu : Menu
{
    public override void Insere( Dictionary<string, Banda> bandasRegistradas )
    {
        base.Insere( bandasRegistradas );
        if( DicionarioVazio( bandasRegistradas ) )
        {
            Console.WriteLine( "Nenhuma banda registrada!" );
            Menu.Intervalo();
        }
        else
        {
            foreach( var banda in bandasRegistradas.Values )
                banda.ExibeInformacoes();
            Console.WriteLine("Precione qualquer tecla para sair...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
