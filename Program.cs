using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Lista para armazenar os itens
        List<string> itens = new List<string>();

        // TODO: Solicite os itens ao usuário
        for (int contato = 0; contato < 3 ; contato++)
        {
            Console.Write("Digite seu nome: ");
            string nome = string.Concat(Console.ReadLine());
            itens.Add(nome);
        }

        // Exibe a lista de itens
        Console.WriteLine("Lista de itens:");
        foreach (string item in itens)
        {
            Console.WriteLine($"- {item}");
        }
    }
}