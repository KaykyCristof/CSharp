// Definindo a classe Disciplinas

class Disciplina
{
    private List<Aluno> listaAlunos;
    private string nomeDisciplina;
    //private string nomeProfessor;

    public string NomeDisciplina
    { 
        get
        {
            Console.WriteLine( "Acessando o getter da propriedade NomeDisciplina." );
            return nomeDisciplina;
        }   
        set
        {
            Console.WriteLine( "Acessando o setter da propriedade NomeDisciplina." );
           
            nomeDisciplina = ( string.IsNullOrEmpty( value) ) ? 
            throw new ArgumentException( "Valor inválido para Disciplina!." ) : value;
        }
        
    }

    /*public string NomeProfessor
    {

        get
        {
            Console.WriteLine( "Acessando o getter da propriedade NomeProfessor." );
            return nomeProfessor;
        }
        set
        {
            Console.WriteLine( "Acessando o setter da propriedade NomeProfessor." );
            
            nomeProfessor = ( string.IsNullOrEmpty( value) ) ?
            throw new ArgumentException( "Valor inválido para o nome do professor!" ) :
            value;
        }
    }*/

    // Definindo o construtor...

    public Disciplina()
    {
        Console.WriteLine( "Construtor da classe disciplina..." );
        listaAlunos = new List<Aluno>();
    }

    public void InsereAluno( Aluno aluno )
    {
        listaAlunos.Add( aluno );
        Console.WriteLine( "Aluno inserido com sucesso!" );
    }

    public void ExibeDisciplinas()
    {
        Console.WriteLine( $"{nomeDisciplina}." );
        Console.WriteLine( " \t--- Lista de alunos vinculados a disciplina ---" );

        foreach( var aluno in listaAlunos )
        {
            aluno.ExibeAlunos();
        }
    }
}
