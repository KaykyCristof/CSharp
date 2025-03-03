namespace ScreenSound.Models;

internal class Music
{
    public string Name { get; }
    public int Duration { get; }
    public bool Avaliable { get; set; }

    public Music( string musicName, int musicDuration )
    {
        if( string.IsNullOrEmpty( musicName) || musicDuration <= 0 ) 
            throw new ArgumentException( "Error! Invalid value!" );
        
        Name = musicName;
        Duration = musicDuration;
    }

    public string CheckAvaliable => Avaliable == true ? 
    "The music is avaliable!" : "Purshase the plus+ plan.";

    public void DisplayMusic()
    {
        Console.WriteLine( $"Name of music: {Name}." );
        Console.WriteLine( $"Duration of music: {Duration}." );
        Console.WriteLine( "Avaliable: " + CheckAvaliable );
    }
}