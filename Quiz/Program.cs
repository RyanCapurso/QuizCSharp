using Quiz.Modelos;



ExibirMenu();
void ExibirMenu()
{
    Console.WriteLine("===================");
    Console.WriteLine("Seja bem vindo !!");
    Console.WriteLine("===================");

    Console.WriteLine("Aqui está nossos temas para jogar");
    Console.WriteLine("1 - Jogos");
    Console.WriteLine("2 - Filmes");
    Console.WriteLine("3 - Séries");
    Console.WriteLine("0 - Sair");

    Console.Write("Selecione o tema do Quiz que deseja jogar: ");
    string opcaoEscolhida = Console.ReadLine()!;
    Geral geral = new Geral();
    switch (geral.ConverteOpcaoEscolhida(opcaoEscolhida))
    {
        case 1:
            Console.WriteLine("Tema Jogos foi selecionado");
            Jogos jogos = new Jogos();
            jogos.TemaJogos();
            break;
        case 2:
            Console.WriteLine("Tema Filmes foi selecionado");
            break;
        case 3:
            Console.WriteLine("Tema Séries foi selecionado");
            break;
        case 0:
            Console.WriteLine("Até a próxima");
            Environment.Exit(0);
            break;
        default:
            Console.WriteLine("Error ! Digite uma opção válida");
            break;
    }
}


