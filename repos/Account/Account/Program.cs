using System;

class Program
{
    public static void read_Values( ref string name, ref int numberAccount, ref double balance )
    {
        Console.WriteLine("Please, insert the name:");
        name = Console.ReadLine()!;

        Console.WriteLine("Please, insert the number account:");
        numberAccount = int.Parse( Console.ReadLine()! );

        Console.WriteLine( "Please, insert the balance:" );
        balance = double.Parse( Console.ReadLine()! );
    }

    public static void Main(string[] args)
    {
        int options = 0;
        List<Account> contasUsuarios = new List<Account>();

        do
        {
            Console.WriteLine( "Insert the option:" );
            Console.WriteLine( "1 - Insert" );
            Console.WriteLine( "2 - Remove" );
            Console.WriteLine( "3 - Most information" );
            Console.WriteLine( "0 - Exit" );
            
            options = int.Parse( Console.ReadLine()! );

            switch (options) 
            { 
                case 0:
                {
                    Console.WriteLine( "Exit..." );
                    break;
                }
                case 1:
                {
                    string name = string.Empty;
                    int numberAccount = 0;
                    double balance = 0;

                    read_Values( ref name, ref numberAccount, ref balance );

                    Account user0 = new( name, numberAccount, balance );

                    contasUsuarios.Add( user0 );
                    
                    break;
                }
                case 2:
                {
                    int tam = contasUsuarios.Count - 1;
                    Account userRemove = contasUsuarios[tam];
                    contasUsuarios.Remove( userRemove );
                    break;
                }
                case 3:
                {
                    foreach( Account users in contasUsuarios )
                    {
                        users.MostInformation();
                    }
                    break;
                }
                case 4:
                {
                    break;
                }
                default:
                {
                    Console.WriteLine( "Invalid value!" );
                    break;
                }
            }
        } while ( options != 0 );
    }
}