

Menu();

static void Menu() {

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
static void Abrir() {}

static void Editar() {}