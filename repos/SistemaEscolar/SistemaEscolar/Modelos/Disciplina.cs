namespace SistemaEscolar.Modelos
{
    class Disciplina
    {
        private List<Aluno> listaAluno;
        public string NomeDisciplina { get; }

        public Disciplina( string nomeDaDisciplina )
        {
            if( string.IsNullOrEmpty( nomeDaDisciplina ) )
            {
                throw new ArgumentException( "Erro! Valor inválido para o nome da disciplina!" );
            }
           
            NomeDisciplina = nomeDaDisciplina;
            listaAluno = new List<Aluno>();
        }

        public void InsereAluno( Aluno novoAluno )
        {
            listaAluno.Add( novoAluno );
            Console.WriteLine( "Aluno inserido com sucesso!" );
        } 
        public void ExibeDisciplina()
        {
            Console.WriteLine( $"Nome da disciplina: {NomeDisciplina}." );

            if( listaAluno.Count == 0 )
            {
                Console.WriteLine( "Nenhum aluno cadastrado na disciplina!" );
            }
            else
            {
                Console.WriteLine("Alunos matriculados na disciplina:");
                foreach (Aluno aluno in listaAluno)
                {
                    aluno.ExibeAluno();
                }
            }
        }
    }
}
