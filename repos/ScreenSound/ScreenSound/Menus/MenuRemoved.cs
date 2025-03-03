using ScreenSound.Models;
namespace ScreenSound.Menus;

class MenuRemoved : Menu
{
    public void RemovedBand( Dictionary<string, Band> registeredBands )
    {
        Console.WriteLine( "Please, inserted the name of the band:" );
        string nameBand = Console.ReadLine()!;

        if( EmptyDictionary( registeredBands ) )
        {
            Console.WriteLine( $"Band: {nameBand} found!" );
            registeredBands.Remove( nameBand );
            Console.WriteLine( $"Band: {nameBand} removed!" );
        }
        else
        {
            Console.WriteLine( $"Band: {nameBand} not found!" );
        }
    }
}
