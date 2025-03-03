using ScreenSound.Models;
namespace ScreenSound.Menus;

class MenuReview : Menu
{
    public void Review( Dictionary<string, Band> registeredBands )
    {
        if( EmptyDictionary( registeredBands ) )
            Console.WriteLine( "Nothing band inserted!" );
        else
        {
            Console.WriteLine( "Please, inserted the name of band for the review:" );
            string nameBand = Console.ReadLine()!;

            if( CheckKey( registeredBands, nameBand ) )
            {
                Console.WriteLine( $"Band: {nameBand} found!" );
                Console.WriteLine( "Please, inserted the review: " );
                BandReview review = BandReview.Parse( Console.ReadLine()! );
                registeredBands[nameBand].InsertReview( review );
            }
            else
            {
                Console.WriteLine( "Band not found!" );
            }
        }
    }
}
