namespace ScreenSound.Models;

internal class BandReview
{
    public int Rating { get; }

    public BandReview( int bandRating )
    {
        if( bandRating < 0 || bandRating > 10 ) throw new ArgumentException( "Invalid value!" );

        Rating = bandRating;
    }

    public void DisplayReview()
    {
        Console.Write( Rating + " " );
    }

    // Definimos um método estático, um método estático não depende de uma instância de objeto para ser utilizado.
    public static BandReview Parse( string text )
    {
        int review = int.Parse( text );
        return new BandReview( review );
    }
}