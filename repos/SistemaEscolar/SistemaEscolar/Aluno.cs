namespace SistemaEscolar
{
    class Aluno
    {
        private double media;
        private List<double> ListaNotas;

        public double Media => media;
        public string NomeAluno { get; set; }
        public int Matricula { get; }

        public Aluno( string nomeDoAluno, int matriculaAluno )
        {
            if( string.IsNullOrEmpty( nomeDoAluno ) )
            {
                throw new ArgumentException( "Erro! Valor inválido para o nome do aluno!" );
            }
           
            if( matriculaAluno < 0 )
            
                throw new ArgumentException( "Erro! Valor inválido para a matrícula do aluno!" );

            NomeAluno = nomeDoAluno;
            Matricula = matriculaAluno;
            ListaNotas = new List<double>();
        }

        public void CalculaMedia()
        {
            media = ListaNotas.Average();
        }
        public void InsereNota( double notaAluno )
        {
            if( notaAluno < 0 )
            {
                throw new ArgumentException( "Erro! Valor inválido para a nota!" );
            }

            ListaNotas.Add( notaAluno );
            CalculaMedia();

            Console.WriteLine( "Nota inserida com sucesso!" );
        }
        public void ExibeAluno()
        {
            Console.WriteLine( $"Nome do aluno: {NomeAluno}." );
            Console.WriteLine( $"Matrícula do aluno: {Matricula}." );
            
            if( ListaNotas.Count == 0 )
            {
                Console.WriteLine( "Nenhuma nota inserida!" );
            }
            else
            {
                Console.Write( "Notas do aluno: " );
                foreach( double nota in ListaNotas )
                {
                    Console.Write( nota + " " );
                }
                
                Console.WriteLine( $"\nMédia do aluno: {Media:F2}" );
                Console.WriteLine();
            }
        }
    }
}
