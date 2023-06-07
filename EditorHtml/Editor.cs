using System;
using System.Text;

namespace EditorHtml
{
    public static class Editor
    {
        public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("MODO EDITOR");
            Console.WriteLine("-----------");
            Start();
        }

        public static void Start()
        {
            var file = new StringBuilder();

            do
            {
                file.Append(Console.ReadLine());
                file.Append(Environment.NewLine);
            } while (Console.ReadKey().Key != ConsoleKey.Escape);

            Console.WriteLine("-----------");
            Console.WriteLine(" Deseja salvar o arquivo? ");

            // Salvar o arquivo ou Não? Caso salve , mostra na tela o modo visualização. Se não salvar, também mostra
            var op = char.Parse(Console.ReadLine().ToLower());
            if (op == 's')
            {
                Console.WriteLine("Qual o Caminho para salvar o arquivo? ");
                var path = Console.ReadLine();

                using (StreamWriter sw = new StreamWriter(path))
                {
                    sw.Write(file);
                }
                Console.WriteLine($"Arquivo salvo com sucesso no caminho: {path}");
                Console.WriteLine("Enter para visualizar o arquivo.");
                Console.ReadKey();
                Viewer.Show(file.ToString());
            }
            else
            {
                Console.WriteLine("Você não salvou o arquivo. No entanto, aqui está ele para visualização...");
                Thread.Sleep(3000);
                Viewer.Show(file.ToString());
            }

        }

        public static void Open()
        {   
            Console.Clear();
            Console.WriteLine("Em qual caminho o arquivo está? ");
            var path = Console.ReadLine();

            using (var file = new StreamReader(path))
            {
                Console.WriteLine(file.ReadToEnd());
            }
            Console.ReadKey();
            Menu.Show();
        }
    }
}