//Para comentaria varias linhas use Ctrl+K+C e para descomentar Ctrl+; 
using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using Newtonsoft.Json;

class Program
{
    static bool VerificarAtributo(string atributo, int valorMinimo, int valorMaximo, int valorAtributo)
    {
        if (valorAtributo >= valorMinimo && valorAtributo <= valorMaximo){
            return "O valor do atributo está dentro do intervalo especificado";
        }else "O valor do atributo está fora do intervalo especificado";
    }
    
    static void Main(string[] args)
    {
        string atributo = Console.ReadLine();

        int valorMinimo = int.Parse(Console.ReadLine());

        int valorMaximo = int.Parse(Console.ReadLine());

        int valorAtributo = int.Parse(Console.ReadLine());

        VerificarAtributo(atributo, valorMinimo, valorMaximo, valorAtributo);
    }
}


















// class Program
// {
//     static void Main(string[] args)
//     {
//         List<string> itens = new List<string>();

//         for (int contato = 0; contato < 3 ; contato++)
//         {
//             Console.Write("Digite seu nome: ");
//             string nome = string.Concat(Console.ReadLine());
//             itens.Add(nome);
//         }
//         Console.WriteLine("Lista de itens:");
//         foreach (string item in itens)
//         {
//             Console.WriteLine($"- {item}"); 
//         }
//     }
// }


// Considero-me cusioso e esforçado, tenho facilidade em aprender as coisas, adaptabilidade, dedicação ao trabalho e bom relacionamento. Em busca de adquirir uma nova formação profissional na área de tecnologia, a qual venho pesquisando e me identificando cada vez mais. Dessa forma, venho me aprofundado nas áreas de tecnologias, e nesse caminhar tenho feito cursos e projetos referente a linguagens de programação e de marcação, segurança de rede, assim como, participando de programas de capacitação para me tornar um profissional de Tecnologia de Informação.