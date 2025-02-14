// Sem Lambda
using System.Reflection.Metadata.Ecma335;

List <int> numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
List <int> numerosPares = numeros.FindAll( retornaPar );

bool retornaPar( int numero )
{
    return numero % 2 == 0;
}

foreach( int numero in numerosPares )
{
    Console.Write( numero + " " );
}

Console.WriteLine();

// Com Lambda
numerosPares = numeros.FindAll( numero => numero % 2 == 0 );
numerosPares.ForEach( numero => Console.Write( numero + " " ) );

// Definindo uma função lambda que soma dois números inteiros

// Sem lambda

Console.WriteLine();

int soma( int x, int y )
{
    int resultado = x + y;
    return resultado;
}

// Com Lambda

int SomaInteiros( int x, int y ) => x + y ;

Console.WriteLine( "Função sem lambda: " + soma( 10, 5 ) );
Console.WriteLine( "Função com lambda: " + SomaInteiros( 10, 5 ) );