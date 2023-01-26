﻿

static void Menu() {

    Console.BackgroundColor = ConsoleColor.DarkMagenta;
    Console.Clear();
    Console.Clear();
    Console.WriteLine("\n\n\n***** BLOCO DE ANOTAÇÕES ******\n\n");
    Console.WriteLine("1 - CRIAR UMA NOVA NOTA ");
    Console.WriteLine("2 - CONSULTAR UMA NOTA");
    Console.WriteLine("3 - ATUALIZAR UMA NOTA");
    Console.WriteLine("4 - DELETAR UMA NOTA");
    Console.WriteLine("0 - SAIR\n\n");
    Console.WriteLine("*************************************\n");
    Console.Write("\nSELECIONE A OPÇÃO DESEJADA: ");
    short option = short.Parse(Console.ReadLine());
    switch (option) {

        case 0:
            Console.Clear();
            Console.WriteLine("\n\nBLOCO DE NOTAS FINALIZADO!\n\n");
            Environment.Exit(0);
            break;
        case 1:
            Criar();
            break;
        case 2:
            Consultar();
            break;
        case 3:
            Atualizar();
            break;
        case 4:
            Deletar();
            break;
        default:
            break;
    }
}

static void Criar() {
    Console.Clear();
    string text = "";
    Console.WriteLine("DIGITE SEU TEXTO ABAIXO: (PRESSIONE 'ESC' PARA SAIR) ");
    Console.WriteLine("\n\n--------------------------------------------\n\n");
    do {
        text += Console.ReadLine();
        text += Environment.NewLine;
    }
    while (Console.ReadKey().Key != ConsoleKey.Escape);

    Console.WriteLine("TEXTO FINALIZADO!");
    Salvar(text);

    static void Salvar(string SaveText) {
        Console.Write("\n\nPOR FAVOR, INFORME O CAMINHO PARA SALVAR O ARQUIVO: ");
        string path = Console.ReadLine();

        using (var file = new StreamWriter(path)) {

            file.Write(SaveText);
        }
        Console.WriteLine("\n\nARQUIVO SALVO COM SUCESSO! PRESSIONE QUALQUER TECLA PARA RETORNAR AO MENU.");
        Console.ReadKey();
        Menu();
    }
}

static void Consultar() {

    Console.Clear();
    string text = "";
    string path = "";
    Console.WriteLine("\n\n **************************************************");
    Console.Write("\n\n INFORME O CAMINHO QUE DESEJA CONSULTAR O ARQUIVO:");
    path = Console.ReadLine();

    try {

        using (StreamReader sr = new StreamReader(path)) {

            text = sr.ReadToEnd();
        }
        Console.Clear();
        Console.WriteLine("\n\n CONSULTANDO ARQUIVO NO DIRETORIO INFORMADO....");
        Thread.Sleep(3000);
        Console.Clear();
        Console.WriteLine("\n\n A SUA CONSULTA RETORNOU O SEGUINTE TEXTO:\n");
        Console.WriteLine("\n ----------------INICIO DA MENSAGEM--------------------\n\n");
        Console.BackgroundColor = ConsoleColor.Black;
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(text);
        Console.BackgroundColor = ConsoleColor.DarkMagenta;
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("\n ------------------FIM DA MENSAGEM---------------------\n\n");
    }
    catch (Exception) {

        Console.Clear();
        Console.Write("\n\n ARQUIVO NAO EXISTE NO DIRETORIO INFORMADO! \n\n POR FAVOR, VERIFIQUE O DIRETORIO! ");
        Console.ReadKey();
        Consultar();
    }
    Console.Write("\n\n DESEJA CONSULTAR UM NOVO ARQUIVO: 'SIM' 'NAO' : ");
    string option = Console.ReadLine();
    string LowerOption = option.ToLower();

    if (LowerOption == "nao") {
        Console.Clear();
        Menu();
    }
    else {
        Console.Clear();
        Consultar();
    }
}