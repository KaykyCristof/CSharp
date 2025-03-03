namespace ScreenSound.Models;

internal class Album
{
    private List<Music> musics;
    public string Name { get; }
    public int TotalTime => musics.Sum( n => n.Duration );

    public static int TotalAlbum;
    
    public Album( string albumName )
    {
        if( string.IsNullOrEmpty( albumName ) ) throw new ArgumentException( "Invalid Value!" );
        
        Name = albumName;
        musics = [];
        TotalAlbum++;
    }

    public void InsertMusic( Music music )
    {
        musics.Add( music );
        Console.WriteLine( "Success when inserting the music!" );
    }

    public bool EmptyList => musics.Count == 0 ? true : false;

    public void DisplayAlbum()
    {
        Console.WriteLine( $"Name of the album: {Name}." );
        
        if( EmptyList ) 
            Console.WriteLine( "No music inserted!" );
        else
        {
            foreach( Music music in musics )
                music.DisplayMusic();
            
            Console.WriteLine( $"Total time: {TotalTime}" );
        }    
    }
}