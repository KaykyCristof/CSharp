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
*/

