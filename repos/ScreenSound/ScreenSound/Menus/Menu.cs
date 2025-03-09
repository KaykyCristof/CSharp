using ScreenSound.Modelos;
namespace ScreenSound.Menus;

internal class Menu
{
    public static void ExibeLogo()
    {
        Console.WriteLine(@"
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░");

        Console.WriteLine("\nBem vindo ao ScreenSound!\n");
    }
    public static void FormataOpcao( string opcao )
    {
        int tamString = opcao.Length;
        string formata = string.Empty.PadLeft( tamString, '*' );
        Console.WriteLine( formata );
        Console.WriteLine( opcao );
        Console.WriteLine( formata );
    }
    public static void ExibeOpcoes()
    {
        Console.WriteLine( "Por favor, insira uma opção:" );
        Console.WriteLine( "1 - Inserir banda" );
        Console.WriteLine( "2 - Inserir álbum" );
        Console.WriteLine( "3 - Inserir música" );
        Console.WriteLine( "4 - Avalia banda" );
        Console.WriteLine( "5 - Exibe informações" );
        Console.WriteLine( "0 - Sair" );
    }
    public static void Intervalo()
    {
        Thread.Sleep( 2000 );
        Console.Clear();
    }
    public static bool DicionarioVazio( Dictionary<string, Banda> bandaRegistradas )
    {
        if( bandaRegistradas.Count == 0 ) return true;
        return false;
    }
    public virtual void Insere( Dictionary<string, Banda> bandasRegistradas )
    {
        Console.Clear();
    }
}
