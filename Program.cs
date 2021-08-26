using System;

namespace MemeToNervoso
{
    class Program
    {
        static void Main(string[] args)
        {
            string resposta;

            Console.Write("Usuário o que você pensa sobre mim? ");
            resposta = Console.ReadLine().Remove(10);

            Console.Write("- E sabe o que eu penso de você USUÁRIO?\n {0}... ",resposta);
            Console.WriteLine("NÃO, PERA.\n Tô nervoso");
        }
            
    }
}
