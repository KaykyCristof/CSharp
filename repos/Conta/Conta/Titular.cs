class Titular
{
    public string Nome { get; set; }
    public string Endereco { get; set; }
    public string NumTelefone { get; set; }
    public string cpf { get; set; }

    public Titular()
    {
        Console.WriteLine( "Construtor..." );
    }

    public string ExibeInformacoes => 
    (
        $"Nome do titular da conta:{Nome}.\n" + 
        $"Endereço do titular da conta:{Endereco}.\n" +
        $"Número de telefone do titular da conta:{NumTelefone}.\n" +
        $"Cpf do titular da conta:{cpf}.\n"
    );  
}
