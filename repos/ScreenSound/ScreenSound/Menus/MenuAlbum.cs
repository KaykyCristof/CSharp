using ScreenSound.Models;
namespace ScreenSound.Menus;

class MenuAlbum : Menu
{
    public void InsertedAlbum( Dictionary<string, Band> registeredBands )
    {
        if( EmptyDictionary( registeredBands ) ) 
            Console.WriteLine( "Nothing band inserted!" );
        else
        {
            Console.WriteLine( "Please, inserted the name os band:" );
            string nameBand = Console.ReadLine()!;

            if( CheckKey( registeredBands, nameBand ) )
            {
                Console.WriteLine( $"Band: {nameBand} found!" );
                Console.WriteLine( "Please, inserted the name of album: " );
                string nameAlbum = Console.ReadLine()!;

                Album newAlbum = new Album( nameAlbum );
                registeredBands[nameBand].InsertAlbum( newAlbum );
            }
            else
            {
                Console.WriteLine( $"Band: {nameBand} not found!" );
            }
        }
    }
}
