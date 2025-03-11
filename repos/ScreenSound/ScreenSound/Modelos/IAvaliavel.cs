using ScreenSound.Modelos;

internal interface IAvaliavel 
{
    double Media { get; }
    void InsereNota( Avaliacao novaNota );
    bool ListaVazia<T>( List <T> lista );
}