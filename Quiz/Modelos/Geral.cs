namespace Quiz.Modelos;
internal class Geral
{
    int pontos = 0;
    string opcaoEscolhida = "";
    public int ConverteOpcaoEscolhida(string opcaoTexto)
    {
        return int.Parse(opcaoEscolhida);
    }
    public void VerificaResposta(int indiceResposta)
    {
        
        Console.Write("\nSua resposta: ");
        string opcaoEscolhida = Console.ReadLine()!;
        
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
}
