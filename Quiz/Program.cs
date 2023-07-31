int pontos = 0;
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

int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida); 


switch (opcaoEscolhidaNumerica)
{
	case 1:
        Console.WriteLine("Tema Jogos foi selecionado");
        TemaJogos();
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

int ConverteOpcaoEscolhida(string opcaoTexto)
{
    return int.Parse(opcaoEscolhida);
}
void ExibirPontuação()
{
    Console.WriteLine("Pontuação");
    Console.WriteLine($"{pontos} / 3");
}
void TemaJogos()
{
    Console.Clear();
    Console.WriteLine("Pergunta 1");
    Console.WriteLine("1 - Respota Errada");
    Console.WriteLine("2 - Resposta Errada");
    Console.WriteLine("3 - Resposta Certa");
    Console.WriteLine("4 - Resposta Errada");

    Console.Write("Sua resposta: ");

    opcaoEscolhida = Console.ReadLine()!;

    if (ConverteOpcaoEscolhida(opcaoEscolhida) == 3)
    {
        Console.WriteLine("Resposta Correta!");
        ++pontos;
        Console.WriteLine("Pontuação");
        Console.WriteLine($"{pontos} / 3");
    }
    else
    {
        Console.WriteLine("Resposta Incorreta!");
        Console.WriteLine("Pontuação");
        Console.WriteLine($"{pontos} / 3");
    }

    Console.Clear();
    Console.WriteLine("Pergunta 2");
    Console.WriteLine("1 - Respota Errada");
    Console.WriteLine("2 - Resposta Certa");
    Console.WriteLine("3 - Resposta Errada");
    Console.WriteLine("4 - Resposta Errada");

    Console.Write("Sua resposta: ");
    opcaoEscolhida = Console.ReadLine()!;

    opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    if (opcaoEscolhidaNumerica == 2)
    {
        Console.WriteLine("Resposta Correta!");
        ++pontos;
        Console.WriteLine("Pontuação");
        Console.WriteLine($"{pontos} / 3");
    }
    else
    {
        Console.WriteLine("Resposta Incorreta!");
        Console.WriteLine("Pontuação");
        Console.WriteLine($"{pontos} / 3");
    }

    Console.Clear();
    Console.WriteLine("Pergunta 2");
    Console.WriteLine("1 - Respota Errada");
    Console.WriteLine("2 - Resposta Errada");
    Console.WriteLine("3 - Resposta Errada");
    Console.WriteLine("4 - Resposta Certa");

    Console.Write("Sua resposta: ");
    opcaoEscolhida = Console.ReadLine()!;

    opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    if (opcaoEscolhidaNumerica == 4)
    {
        Console.WriteLine("Resposta Correta!");
        ++pontos;
        Console.WriteLine("Pontuação");
        Console.WriteLine($"{pontos} / 3");
    }
    else
    {
        Console.WriteLine("Resposta Incorreta!");
        Console.WriteLine("Pontuação");
        Console.WriteLine($"{pontos} / 3");

    }
}