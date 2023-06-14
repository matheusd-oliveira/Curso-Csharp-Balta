namespace Exceptions
{

    class Program
    {
        static void Main()
        {
            var arr = new int[3];

            for (int index = 0; index < 10; index++)
            {   
                // System.IndexOutOfRangeException
                Console.WriteLine(arr[index]);
            }
        }
    }
}