using System.Net;

namespace SistemaEscolar
{
    static class Menu
    {
        private static List<Professor> listaProfessores = new List<Professor>();

        public static bool ListaVazia<T>( List<T> lista )
        {
            if( lista.Count == 0 )
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void CadastraProfessor()
        {
            Console.WriteLine( "Por favor, insira o nome do professor:" );
            string nomeProfessor = Console.ReadLine()!;
            Professor novoProfessor = new Professor( nomeProfessor );
            listaProfessores.Add( novoProfessor );
            Console.WriteLine( "Professor cadastrado com sucesso!" );
        }

        public static int VerificaProfessor()
        {
            Console.WriteLine( "Por favor, insira o nome do professor:" );
            string nomeProfessor = Console.ReadLine()!;

            for( int i = 0; i < listaProfessores.Count; i++ )
            {
                if( nomeProfessor == listaProfessores[i].NomeProfessor )
                {
                    return i;
                }
            }

            return -1;
        }

        public static Disciplina VerificaDisciplina( int posicaoProfessor )
        {
            Console.WriteLine( "Por favor, insira o nome da disciplina:" );
            string nomeDisciplina = Console.ReadLine()!;

            Disciplina posicaoDisciplina = listaProfessores[posicaoProfessor].BuscaDisciplina( nomeDisciplina );

            return posicaoDisciplina;
        }

        public static void CadastraDisciplina()
        {
            if( ListaVazia( listaProfessores) )
            {
                Console.WriteLine( "Nenhum professor cadastrado!" );
            }
            else
            {
                int posicao = VerificaProfessor();

                if( posicao != - 1 )
                {
                    Console.WriteLine( "Professor encontrado!" );
                    Console.WriteLine( "Por favor, insira o nome da disciplina:" );
                    string nomeDisciplina = Console.ReadLine()!;
                    Disciplina novaDisciplina = new Disciplina( nomeDisciplina );
                    listaProfessores[posicao].InsereDisciplina( novaDisciplina );
                    Console.WriteLine( "Disciplina cadastrada com sucesso!" );
                }
                else
                {
                    Console.WriteLine( "Professor não encontrado!" );
                }
            }
        }

        public static void CadastraAluno()
        {
            if( ListaVazia( listaProfessores ) )
            {
                Console.WriteLine( "Nenhum professor cadastrado!" );
            }
            else
            {
                int posicaoProfessor = VerificaProfessor();

                if( posicaoProfessor != - 1 )
                {
                    Console.WriteLine( "Professor encontrado!" );
                    Disciplina posicaoDisciplina = VerificaDisciplina( posicaoProfessor );
                    
                    if( posicaoDisciplina != null )
                    {
                        Console.WriteLine( "Disciplina encontrada!" );
                        Console.WriteLine( "Por favor, insira o nome do aluno:" );
                        string nomeAluno = Console.ReadLine()!;
                        Console.WriteLine( "Por favor, insira a matrícula do aluno:" );
                        int matriculaAluno = int.Parse( Console.ReadLine()! );
                        Aluno novoAluno = new Aluno( nomeAluno, matriculaAluno );
                        posicaoDisciplina.InsereAluno( novoAluno );
                        Console.WriteLine( "Aluno inserido com sucesso!" );
                    }
                    else
                    {
                        Console.WriteLine( "Disciplina não encontrada!" );
                    }
                }
                else
                {
                    Console.WriteLine( "Professor não encontrado!" );
                }

            }
        }

        public static void ExibeProfessores()
        {
            if( ListaVazia( listaProfessores ) )
            {
                Console.WriteLine( "Nenhum professor cadastrado!" );
            }
            else
            {
                foreach ( Professor professor in listaProfessores )
                {
                    professor.ExibeProfessor();
                }
            }
        }


        public static void ExibeOpcoes()
        {
            Console.WriteLine( "Por favor, insira uma opção:" );
            Console.WriteLine( "1 - Cadastrar professor" );
            Console.WriteLine( "2 - Cadastrar disciplina" );
            Console.WriteLine( "3 - Inserir aluno" );
            Console.WriteLine( "4 - Exibir informações" );
            Console.WriteLine( "0 - Sair" );
        }

        public static void ExibeMenu()
        {
            int opcao = 0;

            do
            {
                ExibeOpcoes();
                opcao = int.Parse( Console.ReadLine()! );

                switch ( opcao )
                {
                    case 1:
                    {
                        CadastraProfessor();
                        break;
                        }
                    case 2:
                    {
                        CadastraDisciplina();
                        break;
                    }
                    case 3:
                    {
                        CadastraAluno();
                        break;
                    }
                    case 4:
                    {
                        ExibeProfessores();
                        break;
                    }
                    case 0:
                    {
                        Console.WriteLine( "Saindo..." );
                        break;
                    }
                    default:
                    {
                        Console.WriteLine( "Erro! Opção inválida!" );
                        break;
                    }            
                }
            } while ( opcao != 0 );
        }
    }
}
