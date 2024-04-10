using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Lista para armazenar os itens
        List<string> itens = new List<string>();

        // TODO: Solicite os itens ao usuário
        string nome1 = string.Concat(Console.ReadLine());
        string nome2 = string.Concat(Console.ReadLine());
        string nome3 = string.Concat(Console.ReadLine());
        
        itens.Add(nome1);
        itens.Add(nome2);
        itens.Add(nome3);

        for (int contato = 0; contato < itens.Count ; contato++)
        {
         Console.WriteLine($"- {itens[contato]}");  
        }

        // Exibe a lista de itens
        Console.WriteLine("Lista de itens:");
        foreach (string item in itens)
        {
            Console.WriteLine($"- {item}");
        }
    }
}