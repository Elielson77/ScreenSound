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



void ExibirLogo()
{
    Console.WriteLine(@"
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
");
    Console.WriteLine("Boas vindas ao Screen Sound 2.0!");
}

void ExibirOpcoesDoMenu()
{
    ExibirLogo();
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para registrar o álbum de uma banda");
    Console.WriteLine("Digite 3 para mostrar todas as bandas");
    Console.WriteLine("Digite 4 para avaliar uma banda");
    Console.WriteLine("Digite 5 para exibir os detalhes de uma banda");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("\nDigite a sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    switch (opcaoEscolhidaNumerica)
    {
        case 1:
            MenuRegistrarBanda menu1 = new();
            menu1.Executar(bandasRegistradas);
            break;
        case 2:
            MenuRegistrarAlbum menu2 = new();
            menu2.Executar(bandasRegistradas);
            break;
        case 3:
            MenuMostrarBandas menu3 = new();
            menu3.Executar(bandasRegistradas);
            break;
        case 4:
            MenuAvaliarBanda menu4 = new();
            menu4.Executar(bandasRegistradas);
            break;
        case 5:
            MenuExibirDetalhes menu5 = new();
            menu5.Executar(bandasRegistradas);
            ExibirOpcoesDoMenu();
            break;
        case -1:
            MenuSair menu6 = new();
            menu6.Executar();
            break;
        default:
            Console.WriteLine("Opção inválida");
            break;
    }
}

ExibirOpcoesDoMenu();