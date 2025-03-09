using ScreenSound.Modelos;
using ScreenSound.Menus;

internal class ScreenSoundApp
{
    public static void Main( string[] args )
    {
        Dictionary<string, Banda> bandasRegistradas = new Dictionary<string, Banda>();

        Dictionary<int, Menu> menus = new Dictionary<int, Menu> 
        {
            { 1, new InsereBandaMenu() },
            { 2, new InsereAlbumMenu() },
            { 3, new InsereMusicaMenu() },
            { 4, new AvaliacaoMenu() },
            { 5, new ExibeMenu() },
            { 0, new SairMenu() },
        };

        int opcao = 0;
        do
        {
            Menu.ExibeLogo();
            Menu.ExibeOpcoes();
            opcao = int.Parse( Console.ReadLine()! );
            Menu executa = menus[opcao];
            executa.Insere( bandasRegistradas );
        } while( opcao != 0 );
    } 
}