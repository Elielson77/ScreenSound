using ScreenSound.Models;

namespace ScreenSound.Menus

{
    internal class MenuAvaliarAlbum : Menu
    {
        public override void Executar(Dictionary<string, Banda> bandasRegistradas)
        {
            base.Executar(bandasRegistradas);
            ExibirTituloDaOpcao("Avaliar um álbum");
            Console.Write("Digite o nome da banda: ");
            Console.Write("Digite o nome da banda cujo álbum deseja avaliar: ");
            string nomeDaBanda = Console.ReadLine()!;
            if (bandasRegistradas.ContainsKey(nomeDaBanda))
            {
                Banda banda = bandasRegistradas[nomeDaBanda];

                Console.Write("Agora digite o título do álbum: ");
                string tituloAlbum = Console.ReadLine()!;

                if (banda.Albuns.Any(a => a.Nome.Equals(tituloAlbum)))
                {
                    Album album = banda.Albuns.First(a => a.Nome.Equals(tituloAlbum));
                    Console.WriteLine("Digite a nota que deseja dar para o álbum:");
                    Avaliacao nota = Avaliacao.Parse(Console.ReadLine()!);

                    album.AdicionarNota(nota);

                    Console.WriteLine($"A nota {nota.Nota} foi registrada com sucesso para o álbum {tituloAlbum}!");
                }
                else
                {
                    Console.WriteLine($"\nO album {tituloAlbum} não foi encontrada!");
                    Console.WriteLine("Digite uma tecla para voltar ao menu principal");
                    Console.ReadKey();
                    Console.Clear();
                }

                Thread.Sleep(4000);
                Console.Clear();
            }
            else
            {
                Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!");
                Console.WriteLine("Digite uma tecla para voltar ao menu principal");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
