using System.Security.Cryptography.X509Certificates;

class Account
{
    // Atributos da classe
    private string name;
    private int numberAccount;
    private double balance;

    // Propriedades da classe
    public string Name
    {
        get
        {
            Console.WriteLine( "Acionando o getter do nome." );
            return name;
        }
        set
        {
            if ( string.IsNullOrEmpty(value) )
            {
                throw new ArgumentException("Error! Invalid value!");
            }
            else
            {
                Console.WriteLine( "Acionando o setter do nome." );
                name = value;
            }
        }
    }
    public int NumberAccount 
    { 
        get
        {
            Console.WriteLine( "Acionando o getter do numero da conta" );
            return numberAccount;
        }
        set
        {
            if( value < 0 )
            { 
                throw new ArgumentException( "Error! Invalid value!" );
            }
            else
            {
                Console.WriteLine( "Acionando o setter do número da conta." );
                numberAccount = value;
            }
        }
    }
    public double Balance
    {
        get
        {
            Console.WriteLine( "Acionando o getter do saldo." );
            return balance;
        }
        set
        {
            if( value < 0 )
            {
                throw new ArgumentException( "Error! Invalid value" );
            }
            else
            {
                Console.WriteLine( "Acionando o setter do saldo." );
                balance = value;
            }
        }
    }
 
    // Construtor
    public Account( string userName, int userAccount, double userBalance ) 
    {
        Console.WriteLine( "Construtor..." );
        Name = userName;
        NumberAccount = userAccount;
        Balance = userBalance;  
    }

    public void ManipulateString( string value )
    {
        int tam = value.Length;

        string asteriscos = string.Empty.PadLeft( tam, '*' );

        Console.WriteLine( asteriscos );
        Console.WriteLine( value );
        Console.WriteLine( asteriscos );

    }
    
    public void MostInformation()
    {
        ManipulateString
        (
            $"The user name is: {Name}.\n" +
            $"The user number account is: {NumberAccount}.\n" +
            $"The user balance is: {Balance}" 
        );
    }
}
