﻿class Music
{
    public string Name { get; set; }
    public string Artist { get; set; } 
    public int Duration { get; set; }
    public bool Avaliable { get; set; }

    public string Description => 
    ( $"{Name} music belongs to the artist: {Artist}" );
   
    public Music()
    {
       Console.WriteLine( "Construtor..." );
       Name = string.Empty;
       Artist = string.Empty;
       Duration = 0;
       Avaliable = true;

    }
    public void MostInformation()
    {
        Console.WriteLine( "Name of music: " + Name );
        Console.WriteLine( "Name of artist: " + Artist );
        Console.WriteLine( "Duration of music: " + Duration );
        Console.WriteLine( "Avaliable:" + Avaliable );
    }
}