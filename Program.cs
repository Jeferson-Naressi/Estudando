//Para comentaria varias linhas use Ctrl+K+C e para descomentar Ctrl+; 
using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;

class Program
{
    static void Main(string[] args)
    {
        List<string> itens = new List<string>();

        for (int contato = 0; contato < 3 ; contato++)
        {
            Console.Write("Digite seu nome: ");
            string nome = string.Concat(Console.ReadLine());
            itens.Add(nome);
        }
        Console.WriteLine("Lista de itens:");
        foreach (string item in itens)
        {
            Console.WriteLine($"- {item}"); 
        }
    }
}