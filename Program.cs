string resposta = " Eu sou Groot";
string pergunta = "";
Console.Clear();
Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine(@"--- Groot Chatbot ---");
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("Olá esse é meu amigo Groot, converse com ele!");
Console.WriteLine("Assim que ficarem sem assunto apeans digite tchau");
Console.ResetColor();

while (pergunta != "TCHAU")
{
    Console.Write("Pergunta:   "); pergunta = Console.ReadLine()!.ToUpper();
    if (pergunta != "tchau")
    {
    Console.WriteLine($"     Resposta: {resposta}.");}

    else if (pergunta == "tchau")
    {
        Console.WriteLine($"     Resposta:{resposta}!");
    }
}