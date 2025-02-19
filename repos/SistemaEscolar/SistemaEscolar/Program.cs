using System;

class Program
{
    public static void Main(string[] args )
    {
        Professor professor = new();
        professor.NomeProfessor = "Pedro Moises";
        
        Disciplina disciplina = new();
        disciplina.NomeDisciplina = "Matemática Discreta";
        
        Aluno aluno = new();
        aluno.Nome = "Kayky Cristof Eduardo Domingos Silva";
        aluno.Matricula = 8118;
        aluno.InsereNotas( 10 );
        aluno.InsereNotas( 30 );
        aluno.InsereNotas( 45 );

        disciplina.InsereAluno( aluno );
        professor.InsereDisciplina( disciplina );

        professor.ExibeProfessor();

    }
    
    
}
