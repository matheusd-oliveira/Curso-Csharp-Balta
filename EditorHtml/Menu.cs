
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

    }
}