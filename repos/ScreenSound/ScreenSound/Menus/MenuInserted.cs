using ScreenSound.Models;
namespace ScreenSound.Menus;

class MenuInserted : Menu
{
    public void InsertedBand( Dictionary<string, Band> registeredBands )
    {
        Console.WriteLine( "Please, inserted the name of band:" );
        string nameBand = Console.ReadLine()!;

        Band newBand = new Band( nameBand );
        registeredBands.Add( nameBand, newBand );
    }
}
