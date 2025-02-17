using System;

class Program
{
    public static void Main(string[] args )
    {

        Titular titular0 = new Titular();

        Conta conta0 = new Conta( titular0 );
        
        titular0.Nome = "Pedro Ribeiro";
        titular0.Endereco = "Rua São José Batista - 764";
        titular0.NumTelefone = "(45) 99845-2765";
        titular0.cpf = "678.456.187-34";

        conta0.Saldo = 4500;
        conta0.Limite = 8000;
        conta0.NumConta = 5467;
        conta0.Agencia = 86031;

        Console.WriteLine( conta0.ExibeConta );
    }
}
