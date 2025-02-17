using System.Reflection.Metadata.Ecma335;

class Album
{
    private List<Music> musicAlbum;
    public string Name { get; set; }

    public int AlbumDuration => musicAlbum.Sum( musicAlbum => musicAlbum.Duration );    

    public Album()
    {
        Console.WriteLine("Construtor...");

        musicAlbum = new List<Music>();
        Name = string.Empty;
    }

    public void AddMusic( Music music )
    {
        musicAlbum.Add( music );
    }

    public void ViewMusicAlbum()
    {
        foreach( var music in musicAlbum ) {
            Console.WriteLine( $"Music: {music.Name}" );
        }
    }

    public void somatorio()
    {
        int soma = 0;

        foreach( var duracao in musicAlbum )
        {
            soma += duracao.Duration;
        }
        
       Console.WriteLine( soma );
    }
}
