namespace ScreenSound.Modelos;

internal abstract class Abstract
{
    public bool ListaVazia<T>( List<T> lista )
    {
        if( lista.Count == 0 ) return true;
        return false;
    }

    public virtual void ExibeInformacoes()
    {

    }
}
