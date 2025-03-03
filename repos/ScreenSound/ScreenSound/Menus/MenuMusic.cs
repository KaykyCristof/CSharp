using ScreenSound.Models;
namespace ScreenSound.Menus;

class MenuMusic : Menu
{
    public void InsertedMusic( Dictionary<string, Band> registeredBands )
    {
        if( EmptyDictionary( registeredBands ) )
            Console.WriteLine( "Nothing band inserted!" );
        else
        {
            Console.WriteLine( "Please, inserted the name of band:" );
            string nameBand = Console.ReadLine()!;

            if( CheckKey( registeredBands, nameBand ) )
            {
                Console.WriteLine( $"Band: {nameBand} found!" );
                Album album = CheckAlbum(registeredBands, nameBand );

                if( album != null )
                {
                    Console.WriteLine( $"Album: {album.Name} found!" );
                    Console.WriteLine( "Please, inserted the name of music:" );
                    string musicName = Console.ReadLine()!;
                    Console.WriteLine( "Please, inserted the duration of music:" );
                    int durationMusic = int.Parse( Console.ReadLine()! );
                    Music newMusic = new Music( musicName, durationMusic );
                    album.InsertMusic( newMusic );
                }
                else
                {
                    Console.WriteLine( "Album not found!" );
                }
            }
            else
            {
                Console.WriteLine( $"Band: {nameBand} not found!" );
            }
        }
    }

   
}
