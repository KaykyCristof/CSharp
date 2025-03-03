namespace ScreenSound.Models;

internal class Band
{
    private List<Album> albuns;
    private List<BandReview> reviews;
    public string Name { get; }
    public double Average
    {
        get
        {
            if( EmptyList( reviews ) ) return 0;
            return reviews.Average( n => n.Rating );
        }
    }

    public Band( string bandName ) 
    {
        if( string.IsNullOrEmpty( bandName ) ) throw new ArgumentException( "Invalid value!" );

        Name = bandName;
        albuns = [];
        reviews = [];
    }


    public void InsertAlbum( Album album )
    {
        albuns.Add( album );
        Console.WriteLine( "Success when to insert the album!" );
    }

    public void InsertReview( BandReview review )
    {
        reviews.Add( review );
        Console.WriteLine( "Success when to insert the review!" );
    }

    public bool EmptyList<T>( List<T> list )
    {
        if( list.Count == 0 ) return true;
        return false;
    }

    public void DisplayBand()
    {
        Console.WriteLine( $"Name of the band: {Name}" );

        if( EmptyList( albuns ) )
            Console.WriteLine( "No album inserted!" );
        else
        {
            foreach( Album album in albuns )
                album.DisplayAlbum();
        }
    }

    public void DisplayRating()
    {
        if( EmptyList( reviews ) )
            Console.WriteLine( "No rating provided!" );
        else
        {
            Console.WriteLine( "Reviews:" );
            
            foreach( BandReview review in reviews )
                review.DisplayReview();
            
            Console.WriteLine( $"\nAverage of the band: {Average}" );
        }
    }

    public List<Album> GetAlbum()
    {
        return albuns;
    }
}