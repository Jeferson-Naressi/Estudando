//Para comentaria varias linhas use Ctrl+K+C e para descomentar Ctrl+; 
using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using Newtonsoft.Json;

using System;
using System.Security.Cryptography.X509Certificates;

public class Robo
{
    private string nome;
    private string modelo;
    private int anoFabricacao;

    public Robo(string nome, string modelo, int anoFabricacao)
    {
        this.nome = nome;
        this.modelo = modelo;
        this.anoFabricacao = anoFabricacao;
    }

    public  void ExibirInformacoes()
    {
        //TODO: Imprimir as informações de acordo com o enunciado deste desafio.
        Console.WriteLine($"O robô {nome}, modelo {modelo}, foi fabricado em {anoFabricacao}.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        string nome, modelo;
        int anoFabricacao;
        
        nome = "Robozão";
        modelo = "RBZ1000";
        anoFabricacao = 2022 ;

    //TODO: Instanciar um Robo passando os valores lidos em seu construtor.
    Robo robo = new Robo(nome, modelo, anoFabricacao);
    robo.ExibirInformacoes();

    //TODO: Invocar o método "exibirInformacoes".


    }
}