namespace Quiz.Modelos;
internal class Jogos
{
    public void TemaJogos()
    {

        Console.Clear();
        Console.WriteLine("Pergunta 1");
        Console.WriteLine("1 - Respota Errada");
        Console.WriteLine("2 - Resposta Errada");
        Console.WriteLine("3 - Resposta Certa");
        Console.WriteLine("4 - Resposta Errada");
        Geral geral = new Geral();
        geral.VerificaResposta(3);

        Console.WriteLine("Pergunta 2");
        Console.WriteLine("1 - Respota Errada");
        Console.WriteLine("2 - Resposta Certa");
        Console.WriteLine("3 - Resposta Errada");
        Console.WriteLine("4 - Resposta Errada");

        geral.VerificaResposta(2);

        Console.WriteLine("Pergunta 3");
        Console.WriteLine("1 - Respota Errada");
        Console.WriteLine("2 - Resposta Errada");
        Console.WriteLine("3 - Resposta Errada");
        Console.WriteLine("4 - Resposta Certa");

        geral.VerificaResposta(4);

    }
}
