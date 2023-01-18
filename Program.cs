
using System.Text;
Console.BackgroundColor = ConsoleColor.DarkMagenta;
Console.ForegroundColor = ConsoleColor.White;
Console.Clear();
Menu();

static void Menu() {

	Console.WriteLine("\n\n **** BLOCO DE NOTAS **** \n\n");
	Console.WriteLine("O que você deseja fazer? \n");
	Console.WriteLine("1 - Abrir Arquivo");
	Console.WriteLine("2 - Criar Novo Arquivo");
	Console.WriteLine("0 - Sair\n");
	Console.Write("Selecione a opção numerica desejada: ");

short option = short.Parse(Console.ReadLine());

	switch (option) {
		case 0: System.Environment.Exit(0); break;
		case 1: Abrir(); break;
		case 2: Editar(); break;
	}
}
static void Abrir() {
}

static void Editar() {
	Console.Clear();
	Console.WriteLine("Digite o texto abaixo ( ESC para sair)");
	Console.WriteLine("\n\n---------------------\n\n");
	string text = "";
	
	do {
        
        text += Console.ReadLine();
		text += Environment.NewLine;
	}

	while (Console.ReadKey().Key != ConsoleKey.Escape);

	Console.Write(text);
}