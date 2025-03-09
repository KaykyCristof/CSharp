using ScreenSound.Modelos;
namespace ScreenSound.Menus;

internal class InsereBandaMenu : Menu
{
    public override void Insere( Dictionary<string, Banda> bandasRegistradas )
    {
        base.Insere( bandasRegistradas );
        Menu.FormataOpcao( "Por favor, insira o nome da banda:" );
        Banda novaBanda = Banda.Parse( Console.ReadLine()! );
        bandasRegistradas.Add( novaBanda.Nome, novaBanda );
        Console.WriteLine( $"Banda: {novaBanda.Nome} inserida com sucesso!" );
        Menu.Intervalo();
    }
}

