/* Estamos estudando os fundamentos sobre como funciona a linguagem C#
    CLR( Common Language Runtime )
        Basicamente é como se fosse a Java Virtual Machine, irá pegar o código em C#
        e o transformar em IL( Intermediate Language ) no qual será armazenado junto
        a um assembly, um assembly é um conteiner que armazena a IL do código, e metadados
        que contém informações sobre o código, como classes, funções e etc.
        A compilação é feita em tempo de execução JIT( Just in Time ), mais o que significa isto ?
        O programa é compilado junto a execução do programa de forma dinâmica, ao uma função ou uma classe
        ser necessária durante o programa a mesma é executada em tempo de execução.
        A IL é convertida em linguagem de máquina conforme a arquitetura do computador x64 x84.
        Existe também a compilação antecipada que compila o código antes da sua execução, para assembies muito
        grandes ou para sistemas embarcados no qual possuem um hardware mais limitado.
    
    Base class library( BCL )
        A CLR vem acompanhada de uma série de assemblies chamados de BCL. A mesma fornece diversas ferramentas
        para auxiliar o programador durante a construção de programas, desde a estruturas de dados já implementadas
        chamadas de coleções, a entrada e saída e entre outros.
        Também implementa tipos essenciais como Enums, LINQ( Consulta de dados ) e async/await( Programação assincróna ).

    RunTimes ( Frameworks )
        Basicamente são os frameworks da aplicação, ele é composto do CLR juntamente da sua própria BCL, irá definir
        sobre qual o suporte da aplicação, o software ao ser desenvolvido com Frameworks irá depender das funcionalidades
        do qual o framework oferece.

    // --- Resumo da opera ---
        De forma geral a linguagem C# é uma linguagem compilada, fortemente tipada, pelo seu tipo ser fortemente tipado
        é definido em tempo de compilação e durante a execução do código evitando uma série de erros, a linguagem possui
        a CLR que converte o código C# em IR ( intermediate language ) e que é colocada dentro de um assembly, que possui
        dois tipos .DLL( Bibliotecas que podem ser reutilizadas ) e .EXE( Programas Windows Forms e Console ), a BCL executa
        o código no modo JIT( Just in time ) que basicamente a compilação é feita em tempo de execução, é mais lenta do que a 
        compilação antecipada.
        A CLR também possui a BCL uma série de assemblies que dão suporte e ferramentas ao programador para desenvolver a suas 
        aplicações.
        E por último vem os frameworks que possuem a sua própria CLR e BCL que oferecem uma série de ferramentas para diferentes
        tipos de aplicações, uma dos principais frameworks do C# é o .NET Framework.

        Aqui acabamos de definir como funciona arquitetura básica de uma aplicação em C#, e espero conseguir me aprofundar ainda 
        mais nos meus conhecimentos.
        
*/

