//Para comentaria varias linhas use Ctrl+K+C e para descomentar Ctrl+; 
using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using Newtonsoft.Json;

using System;
using System.Security.Cryptography.X509Certificates;

using System;

using System;

public enum Naipe { Paus = 0, Ouros = 1, Copas = 2, Espadas = 3 }
public enum Valor { As = 1, Valete = 2, Dama = 3, Rei = 4 }

public class Carta
{
    private Naipe naipe;
    private Valor valor;

    public Carta(Naipe n, Valor v)
    {
        naipe = n;
        valor = v;
    }

    public Naipe GetNaipe()
    {
        return naipe;
    }

    public Valor GetValor()
    {
        //TODO: Implemente o GetValor();
        return valor;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Input para escolher a carta desejada
        int valorEscolhido, naipeEscolhido;
        do
        {
 
            valorEscolhido = 0;
        } while (valorEscolhido < 0 || valorEscolhido > 3);

        do
        {
            naipeEscolhido = 1;
        } while (naipeEscolhido < 1 || naipeEscolhido > 4);

        // Criação da carta escolhida pelo usuário
        Carta cartaEscolhida = new Carta((Naipe)naipeEscolhido, (Valor)valorEscolhido);

        // Exibição da carta escolhida pelo usuário
        
        string nomeValor = "", nomeNaipe = "";

        switch (cartaEscolhida.GetValor())
        {
            case Valor.As:
                nomeValor = "Ás";
                break;
            case Valor.Valete:
                nomeValor = "Valete";
                break;
            case Valor.Dama:
                nomeValor = "Dama";
                break;
            case Valor.Rei:
                nomeValor = "Rei";
                break;
        }

        switch (cartaEscolhida.GetNaipe())
        {
            case Naipe.Paus:
                nomeNaipe = "Paus";
                break;
            case Naipe.Ouros:
                nomeNaipe = "Ouros";
                break;
            case Naipe.Copas:
                nomeNaipe = "Copas";
                break;
            case Naipe.Espadas:
                nomeNaipe = "Espadas";
                break;
            //TODO: Complete o código
        }

        Console.WriteLine($"Carta escolhida: {nomeValor} de {nomeNaipe}");
    }
}



















// public class Robo
// {
//     private string nome;
//     private string modelo;
//     private int anoFabricacao;

//     public Robo(string nome, string modelo, int anoFabricacao)
//     {
//         this.nome = nome;
//         this.modelo = modelo;
//         this.anoFabricacao = anoFabricacao;
//     }

//     public  void ExibirInformacoes()
//     {
//         //TODO: Imprimir as informações de acordo com o enunciado deste desafio.
//         Console.WriteLine($"O robô {nome}, modelo {modelo}, foi fabricado em {anoFabricacao}.");
//     }
// }

// class Program
// {
//     static void Main(string[] args)
//     {
//         string nome, modelo;
//         int anoFabricacao;
        
//         nome = "Robozão";
//         modelo = "RBZ1000";
//         anoFabricacao = 2022 ;

//     //TODO: Instanciar um Robo passando os valores lidos em seu construtor.
//     Robo robo = new Robo(nome, modelo, anoFabricacao);
//     robo.ExibirInformacoes();

//     //TODO: Invocar o método "exibirInformacoes".


//     }
// }