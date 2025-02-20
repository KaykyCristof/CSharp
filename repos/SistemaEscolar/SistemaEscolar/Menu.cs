static class Menu
{ 
    private static List<Professor> listaProfessores = new List<Professor>();
    //private static List<Disciplina> listaDisciplinas = new List<Disciplina>();

    // Exibe o menu para inserir as opções;
    public static void MenuProfessor()
    {
        Console.WriteLine( "Por favor, escolha alguma opção:" );
        Console.WriteLine( "1 - Cadastrar professor" );
        Console.WriteLine( "2 - Cadastrar disciplinas" );
        Console.WriteLine( "3 - Exibir informações" );
        Console.WriteLine( "4 - Cadastrar alunos" );
        Console.WriteLine( "0 - Sair" );
    }

    // Verifica se uma lista genérica está vazia.
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

    // Insere os dados do professor.
    public static void InsereProfessor( ref Professor professor )
    {
        Console.WriteLine( "Por favor, insira o nome do professor:" );
        string nomeProfessor = Console.ReadLine()!;
        professor.NomeProfessor = nomeProfessor;
    }

    // Realiza o cadastro do professor e o insere dentro da lista.
    public static void CadastraProfessor()
    {
        Professor professor = new Professor();
        InsereProfessor( ref professor );
        listaProfessores.Add( professor );

        Console.WriteLine("Professor cadastrado com sucesso!");
    }

    // Verifica se o respectivo professor existe dentro da lista e retorna a sua posição.
    public static int VerificaProfessor( List<Professor> professor )
    {
        Console.WriteLine( "Por favor, insira o nome do professor:" );
        string nomeProfessor = Console.ReadLine()!;

        int contador = 0;

        for (contador = 0; contador < professor.Count; contador++ )
        {
            if( nomeProfessor == professor[contador].NomeProfessor )
            {
                return contador;
            }
        }

        return -1;
    }

    // Insere a disciplina dentro do respectivo professor no qual irá ministra-lá.
    public static void InsereDisciplina( ref Disciplina disciplina )
    {
        int posicao = VerificaProfessor( listaProfessores );
        
        if( posicao == -1 )
        {
            Console.WriteLine( "Professor não encontrado!" );
        }
        else
        {
            Console.WriteLine( "Professor encontrado!" );
            
            Console.WriteLine( "Por favor, insira o nome da disciplina:" );
            string nomeDisciplina = Console.ReadLine()!;
            disciplina.NomeDisciplina = nomeDisciplina;

            listaProfessores[posicao].InsereDisciplina( disciplina );
        }
    }

    // Realiza o cadastro da disciplina.
    public static void CadastraDisciplina()
    {
        if( ListaVazia( listaProfessores ) )
        {
            Console.WriteLine( "Erro! Nenhum professor cadastrado!" );
        }
        else
        {
            Disciplina disciplina = new Disciplina();
            InsereDisciplina( ref disciplina );
        }
    }


    public static int VerificaDisciplina( int posProfessor )
    {
        Console.WriteLine( "Por favor, insira o nome da disciplina para inserir o aluno:" );
        string nomeDisciplina = Console.ReadLine()!;

        
        int posDisciplina;

        for ( posDisciplina = 0; posDisciplina < listaProfessores[posProfessor].TamanhoLista(); posDisciplina++ )
        {
           if( nomeDisciplina == listaProfessores[posProfessor].listaDisciplinas[posDisciplina].NomeDisciplina )
            {
                return posDisciplina;
            }
        }

        return -1;
    }

    public static void CadastraAluno()
    {
        if( ListaVazia( listaProfessores ) )
        {
            Console.WriteLine( "Nenhum professor cadastrado!" );
        }
        else
        {
            int posicao = VerificaProfessor( listaProfessores );

            if( posicao == -1 )
            {
                Console.WriteLine( "Professor não encontrado!" );
            }
            else
            {
                Console.WriteLine( "Professor encontrado!" );
                int posicaoDisciplina = VerificaDisciplina( posicao );

                if( posicaoDisciplina == -1 )
                {
                    Console.WriteLine( "Disciplina não encontrada!" );
                }
                else
                {
                    Console.WriteLine( "Disciplina encontrada!" );
                }
            }
        }
    }

    public static void ExibeMenu()
    {
        int opcao = 0;

        do
        {
            MenuProfessor();
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
                        // Definir função para inserir alunos em suas respectivas disciplinas.
                        break;
                    }
                case 4:
                    {
                        CadastraAluno();
                        break;
                    }
                case 0:
                    {
                        Console.WriteLine( "Saindo..." );
                        break;
                    }
                default:
                    {
                        Console.WriteLine( "Opção inválida!" );
                        break;
                    }    
            }
        } while ( opcao != 0 );
    }
}
