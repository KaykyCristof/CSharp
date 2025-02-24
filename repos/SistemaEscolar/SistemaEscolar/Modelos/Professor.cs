namespace SistemaEscolar.Modelos;

class Professor
{
    private List<Disciplina> listaDisciplinas;
    public string NomeProfessor { get; }
   
    public Professor( string nomeDoProfessor )
    {
        if( string.IsNullOrEmpty( nomeDoProfessor ) )
        {
            throw new ArgumentException( "Erro! Valor inválido para o nome do professor!" );
        }

        NomeProfessor = nomeDoProfessor;
        listaDisciplinas = new List<Disciplina>();
    }
    
    public void InsereDisciplina( Disciplina novaDisciplina )
    {
        listaDisciplinas.Add( novaDisciplina );
        Console.WriteLine( "Disciplina inserida com sucesso!" );
    }
    public Disciplina BuscaDisciplina( string nomeDisciplina )
    {
        for( int i = 0; i < listaDisciplinas.Count; i++ )
        {
            if( nomeDisciplina == listaDisciplinas[i].NomeDisciplina )
            {
                return listaDisciplinas[i];
            }
        }
        
        return null!;
    }
    public void ExibeProfessor()
    {
        Console.WriteLine( $"Nome do professor:{NomeProfessor}." );
        Console.WriteLine( "Disciplinas ministradas:" );
        foreach( Disciplina disciplina in listaDisciplinas )
        {
            disciplina.ExibeDisciplina();
        }
    }   
}
