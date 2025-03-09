namespace ScreenSound.Modelos;
internal class Avaliacao
{
    public double Nota { get; }
    
    public Avaliacao( double notaAvaliacao )
    {
        if( notaAvaliacao <= 0 || notaAvaliacao > 10 ) throw new ArgumentException( "Valor inválido!" );
        Nota = notaAvaliacao;
    }

    public static Avaliacao Parse( double notaAvaliacao )
    {
        return new Avaliacao( notaAvaliacao );
    }
}
