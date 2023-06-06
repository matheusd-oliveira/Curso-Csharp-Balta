using System.IO;

Menu();

static void Menu()
{
    Console.Clear();
    Console.WriteLine("O que você deseja fazer? ");
    Console.WriteLine("1 - Abrir arquivo");
    Console.WriteLine("2 - Criar novo arquivo");
    Console.WriteLine("0 - Sair");
    short option = short.Parse(Console.ReadLine());

    switch (option)
    {
        case 0: System.Environment.Exit(0); break;
        case 1: Abrir(); break;
        case 2: Editar(); break;
        default: Menu(); break;
    }
}

static void Abrir()
{
    Console.Clear();
    Console.WriteLine("Qual o caminho do arquivo? ");
    string path = Console.ReadLine();
    
    using (var file = new StreamReader(path))
    {
        string text = file.ReadToEnd();
        Console.WriteLine(text);
    }
    
    Console.WriteLine("");
    Console.ReadKey();
    Menu();
}

static void Editar()
{
    Console.Clear();
    Console.WriteLine("Digite seu texto abaixo (ESC para sair) ");
    Console.WriteLine("-----------------");
    string text = "";

    do
    {
        text += Console.ReadLine();
        text += Environment.NewLine;
    }
    while (Console.ReadKey().Key != ConsoleKey.Escape);

    Salvar(text);
}

static void Salvar(string text)
{
    Console.Clear();
    Console.WriteLine(" Qual o caminho para salvar o arquivo? ");
    var path = Console.ReadLine();

    // Escrevendo um arquivo com o texto digitado pelo usuario.
    using (var file = new StreamWriter(path))
    {
        file.Write(text);
    }

    Console.WriteLine($"Arquivo salvo com sucesso no caminho: {path}");
    Console.ReadKey();
    Menu();
}


// A utilização do using é para evitar esquecer fechar o arquivo depois de usá-lo. O using abre e fecha o arquivo automaticamente.
// Na função Abrir, utilizei o StreamReader para ler o caminho do arquivo e para pegar todo o texto que estava escrito nele com o ReadToEnd()
// Na função Editar, é concatenado tudo que o usuário digitar e der ENTER.
// A função Editar funciona até o usuário clicar na tecla ESC.
// A função Editar possui uma chamada para a função Salvar.
// A função Salvar, salva o arquivo de texto no caminho desejado pelo usuário. Essa cria o arquivo a partir do StreamWriter, que pega o nome do caminho e escreve todo o texto com o file.Write()
// Todas as funções possuem uma chamada para a função pricipal, Menu().
