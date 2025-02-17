using System.Reflection.Metadata.Ecma335;

class Conta
{
    private Titular titularConta;
    private double saldo;
    private double limite;

    public int NumConta { get; set; }
    public int Agencia { get; set; }

    public double Saldo
    {
        get => saldo;

        set
        {
            saldo = ( value > 0 ) ? value : 0;
        }

    }
    
    public double Limite
    {
        get => limite;

        set
        {
            limite = ( value > 0 ) ? value : 0;
        }
    }

    public Conta( Titular titular )
    {
        Console.WriteLine( "Construtor..." );
        titularConta = titular;
    }

    public string ExibeConta => 
    (
        $"{titularConta.ExibeInformacoes}" +
        $"Saldo da conta:{Saldo}.\n" +
        $"Limite da conta:{Limite}.\n" +
        $"Número da conta:{NumConta}.\n" +
        $"Número da agência:{Agencia}.\n"
    );
}