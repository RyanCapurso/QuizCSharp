int pontos = 0;
string opcaoEscolhida;
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
    opcaoEscolhida = Console.ReadLine()!;

    switch (ConverteOpcaoEscolhida(opcaoEscolhida))
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
}
int ConverteOpcaoEscolhida(string opcaoTexto)
{
    return int.Parse(opcaoEscolhida);
}
void VerificaResposta(int indiceResposta)
{
    Console.Write("\nSua resposta: ");
    opcaoEscolhida = Console.ReadLine()!;

    if (ConverteOpcaoEscolhida(opcaoEscolhida) == indiceResposta)
    {
        Console.WriteLine("Resposta Correta!");
        ++pontos;
        ExibirPontuação();
    }
    else
    {
        Console.WriteLine("Resposta Incorreta!");
        ExibirPontuação();
    }
    Thread.Sleep(1000);
    Console.Clear();
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

    VerificaResposta(3);

    Console.WriteLine("Pergunta 2");
    Console.WriteLine("1 - Respota Errada");
    Console.WriteLine("2 - Resposta Certa");
    Console.WriteLine("3 - Resposta Errada");
    Console.WriteLine("4 - Resposta Errada");

    VerificaResposta(2);

    Console.WriteLine("Pergunta 2");
    Console.WriteLine("1 - Respota Errada");
    Console.WriteLine("2 - Resposta Errada");
    Console.WriteLine("3 - Resposta Errada");
    Console.WriteLine("4 - Resposta Certa");

    VerificaResposta(4);

}