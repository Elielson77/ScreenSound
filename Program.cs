﻿using ScreenSound.Menus;
using ScreenSound.Models;

Banda AvengedSevenfold = new("Avenged Sevenfold");
AvengedSevenfold.AdicionarNota(new Avaliacao(10));
AvengedSevenfold.AdicionarNota(new Avaliacao(10));

Banda MrBungle = new("Mr Bungle");
MrBungle.AdicionarNota(new Avaliacao(9));
MrBungle.AdicionarNota(new Avaliacao(10));

Dictionary<string, Banda> bandasRegistradas = new(){
{ AvengedSevenfold.Nome, AvengedSevenfold },
{ MrBungle.Nome, MrBungle }
};

Dictionary<int, Menu> menus = new()
{
    { 1, new MenuRegistrarBanda() },
    { 2, new MenuRegistrarAlbum() },
    { 3, new MenuMostrarBandas() },
    { 4, new MenuAvaliarBanda() },
    { 5, new MenuAvaliarAlbum()},
    { 6, new MenuExibirDetalhes() },
    { -1, new MenuSair() }
};

void ExibirLogo()
{
    Console.WriteLine(@"
░██████╗░█████╗░██████╗ ███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
".Replace("░", " ").Replace("█", "+"));
    Console.WriteLine("Boas vindas ao Screen Sound 2.0!");
}

void ExibirOpcoesDoMenu()
{
    ExibirLogo();
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para registrar o álbum de uma banda");
    Console.WriteLine("Digite 3 para mostrar todas as bandas");
    Console.WriteLine("Digite 4 para avaliar uma banda");
    Console.WriteLine("Digite 5 para avaliar o álbum de uma banda");
    Console.WriteLine("Digite 6 para exibir os detalhes de uma banda");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("\nDigite a sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    if (menus.ContainsKey(opcaoEscolhidaNumerica))
    {
        menus[opcaoEscolhidaNumerica].Executar(bandasRegistradas);
        if (opcaoEscolhidaNumerica > 0) ExibirOpcoesDoMenu();
    }
    else
    {
        Console.WriteLine("Opção inválida");
    }
}

ExibirOpcoesDoMenu();