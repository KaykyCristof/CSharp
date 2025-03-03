namespace ScreenSound.Menus;
using ScreenSound.Models;

internal class MenuDisplay : Menu
{
    public void DisplayBand( Dictionary<string, Band> registeredBands )
    {
        if( EmptyDictionary( registeredBands) ) 
            Console.WriteLine( "Nothing band inserted!" );
        else
        {
            foreach( var bands in registeredBands.Values )
            {
                bands.DisplayBand();
            }
        }
    }
}
