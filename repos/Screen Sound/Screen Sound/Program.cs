class Program
{
    public static void Main( string[] args )
    {
        Music music0 = new Music();

        music0.Name =  "Hey Jude" ;
        music0.Artist = "Paul McCartney";
        music0.Duration = 7 ;
        music0.Avaliable = true;
        
        Console.WriteLine( music0.DescricaoResumida );

        //music0.MostInformation();
    }
}

