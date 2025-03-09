using ScreenSound.Modelos;

namespace ScreenSound.Menus;

class SairMenu : Menu
{
    public override void Insere(Dictionary<string, Banda> bandasRegistradas)
    {
        base.Insere( bandasRegistradas );
        Console.WriteLine( "Saindo..." );
    }
}
