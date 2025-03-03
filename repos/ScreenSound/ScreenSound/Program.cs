using ScreenSound.Models;
using ScreenSound.Menus;


internal class Program
{
    public static void Main( string[] args )
    {
        Music music0 = new Music( "Love of my life", 210 );
        Music music1 = new Music("Bohemian Rhapsody", 310 );

        Album album0 =  new Album( "A night of the Opera" );
        album0.InsertMusic( music0 );
        album0.InsertMusic( music1 );

        Band band0 = new Band( "Queen" );
        band0.InsertAlbum( album0 );

        band0.InsertReview( new BandReview( 10 ) );
        band0.InsertReview( new BandReview( 8 ) );
        band0.InsertReview( new BandReview( 7 ) );

        Dictionary<string, Band> registeredBands = new Dictionary<string, Band>();
        registeredBands.Add( band0.Name, band0 );

        Dictionary<int, Menu > menu = new Dictionary<int, Menu>();

        menu.Add( 1, new MenuInserted() );
        menu.Add( 2, new MenuRemoved() );
        menu.Add( 3, new MenuAlbum() );
        menu.Add( 4, new MenuMusic() );
        menu.Add( 5, new MenuReview() );
        menu.Add( 6, new MenuDisplay() );

        int option = 0;

        do
        {
            Console.WriteLine( "Please, insert the option:" );


        }while( option != 0 ); 



            
            
      






    }
}
