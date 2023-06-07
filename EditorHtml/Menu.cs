
namespace EditorHtml
{
    public static class Menu
    {

        public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Black;

            DrawScreen();
            WriteOptions();

            var option = short.Parse(Console.ReadLine());
            HandleMenuOption(option);
        }

        public static void DrawScreen()
        {
            DrawColumns(30, "+", "-");
            DrawLines(10);
            DrawColumns(30, "+", "-");
        }

        public static void DrawColumns(int quantityColums, string drawFirstCaracter, string drawSecondCaracter)
        {
            Console.Write(drawFirstCaracter);
            for (int i = 0; i <= quantityColums; i++)
                Console.Write(drawSecondCaracter);

            Console.Write(drawFirstCaracter);
            Console.Write("\n");
        }

        public static void DrawLines(int quantityLines)
        {
            for (int lines = 0; lines <= quantityLines; lines++)
            {
                DrawColumns(30, "|", " ");
            }
        }

        public static void WriteOptions()
        {
            Console.SetCursorPosition(3, 2);
            Console.WriteLine("Editor HTML");
            Console.SetCursorPosition(3, 3);
            Console.WriteLine("===========");
            Console.SetCursorPosition(3, 4);
            Console.WriteLine("Selecione uma opção abaixo: ");
            Console.SetCursorPosition(3, 6);
            Console.WriteLine("1 - Novo arquivo");
            Console.SetCursorPosition(3, 7);
            Console.WriteLine("2 - Abrir");
            Console.SetCursorPosition(3, 9);
            Console.WriteLine("0 - Sair");
            Console.SetCursorPosition(3, 10);
            Console.Write("Opção: ");


        }

        public static void HandleMenuOption(short option)
        {
            switch (option)
            {
                case 1: Editor.Show(); break;
                case 2: Editor.Open(); break;
                case 0:
                    {   
                        Console.Clear();
                        System.Environment.Exit(0); 
                        break;
                    }
                default: Show(); break;
            }
        }
    }
}