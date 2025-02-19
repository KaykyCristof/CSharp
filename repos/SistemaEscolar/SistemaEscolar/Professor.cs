// Definindo a classe Professor

class Professor
{
    private List<Disciplina> listaDisciplinas;
    private string nomeProfessor;

    public string NomeProfessor
    {
        get
        {
            Console.WriteLine( "Acessando o getter da propriedade NomeProfessor." );
            return nomeProfessor;
        }

        set
        {
            Console.WriteLine( "Acessando o setter da propriedade NomeProfessor." );
            
            nomeProfessor = ( !string.IsNullOrEmpty(value) ) ? value :
            throw new ArgumentException( "Valor inválido para o nome do professor!" );
        }
    }
    
    // Definindo o construtor

    public Professor()
    {
        Console.WriteLine( "Construtor da classe professor..." );
        listaDisciplinas = new List<Disciplina>();
    }

    public void InsereDisciplina( Disciplina disciplina )
    {
        listaDisciplinas.Add( disciplina );
        Console.WriteLine( "Disciplina inserida com sucesso! " );
    }

    public void ExibeProfessor()
    {
        Console.WriteLine( $"\nNome do professor: {NomeProfessor}." );
        Console.WriteLine( $"\t--- Disciplinas associadas ao professor ---" );

        foreach( var disciplinas in listaDisciplinas )
        {
            disciplinas.ExibeDisciplinas();
        }
    } 

}
