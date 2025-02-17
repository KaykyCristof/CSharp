class Program
{
    public static void Main( string[] args )
    {
        Album queenAlbum = new Album();
        queenAlbum.Name = "A night of the opera.";

        Music music0 = new Music();
        music0.Name = "Love Of My Life.";
        music0.Artist = "Queen";
        music0.Duration = 202;
        music0.Avaliable = false;

        Music music1 = new Music();
        music1.Name = "Bohamian Rhapsody";
        music1.Artist = "Queen";
        music1.Duration = 213;
        music1.Avaliable = true;

        queenAlbum.AddMusic( music0 );
        queenAlbum.AddMusic( music1 );

        queenAlbum.ViewMusicAlbum();

        
        queenAlbum.somatorio();

        
    }
}

