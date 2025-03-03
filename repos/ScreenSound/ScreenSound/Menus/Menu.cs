using ScreenSound.Models;
using System.Runtime.InteropServices;
namespace ScreenSound.Menus;

internal class Menu
{
    public bool EmptyDictionary( Dictionary<string, Band> registeredBands )
    {
        if( registeredBands.Count == 0 ) return true;
        return false;
    }

    public bool CheckKey( Dictionary<string, Band> registeredBands, string nameBand )
    {
        if( registeredBands.ContainsKey( nameBand ) ) return true;
        return false;
    }

    public Album CheckAlbum( Dictionary <string, Band> registeredBands, string nameBand )
    {
        Console.WriteLine( "Please, inserted the name of album:" );
        string nameAlbum = Console.ReadLine()!;

        List<Album> album = registeredBands[nameBand].GetAlbum();


        foreach( Album i in album )
        {
            if( nameAlbum == i.Name )
            {
                Album found = i;
                return found;
            }
        }
        
        return null!;
    }

    public void DisplayTitle( string title )
    {
        int numCharacters = title.Length;
        string equal = string.Empty.PadLeft( numCharacters, '=');
        Console.WriteLine( equal );
        Console.WriteLine( title );
        Console.WriteLine( equal );
    }


}
