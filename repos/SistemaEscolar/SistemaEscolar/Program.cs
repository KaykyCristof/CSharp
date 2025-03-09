using System;
using System.Globalization;
using SistemaEscolar.Modelos;

namespace SistemaEscolarApp
{
    class Program
    { 
        public static void Main( string[] args )
        {
            //Menu.ExibeMenu();
            Aluno aluno0 = new Aluno( "Pedro", 1475 );
            Aluno aluno1 = aluno0;
            //aluno0 = null!;
            aluno1.ExibeAluno();
            aluno0.ExibeAluno();

        }       
    }
}
