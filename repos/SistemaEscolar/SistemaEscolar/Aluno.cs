// Definindo a classe Aluno

using System.ComponentModel;
using System.Data;

class Aluno
{
    private int matricula;
    private string nome;
    private List<double> notasAlunos;
    public int Matricula 
    { 
        get
        {
            //Console.WriteLine( "Acessando o getter da propriedade Matrícula." );
            return matricula;
        }
       
        set
        {
            //Console.WriteLine( "Acessando o setter da propriedade Matrícula." );
            matricula = ( value > 0 ) ? value : 
            throw new ArgumentException( "Valor inválido para Matrícula." );
        }
    }
    public string Nome 
    { 
        get
        {
            //Console.WriteLine( "Acessando o getter da propriedade Nome." );
            return nome;
        }
          
        set
        {
            //Console.WriteLine( "Acessando o setter da propriedade Nome." );
            nome = ( !string.IsNullOrEmpty( value ) ) ? value :
            throw new ArgumentException( "String vazia!" );
        }
    }
    
    // Definindo o Construtor
    public Aluno()
    {
        Console.WriteLine( "Construtor da classe aluno..." );
        notasAlunos = new List<double>();
    }

    public void InsereNotas( double nota )
    {
        notasAlunos.Add( nota );
    }

    public void ExibeAlunos()
    {
        Console.WriteLine( $"{Nome}." );
        Console.WriteLine( $"Matricula do aluno: {Matricula}." );
        
        Console.WriteLine( "\t--- Notas do aluno ---" );
        foreach( double nota in notasAlunos )
        {
            Console.Write( nota + " " );
        }
        Console.WriteLine();
    }
}
