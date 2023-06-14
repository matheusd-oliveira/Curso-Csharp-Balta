namespace Exceptions
{

    class Program
    {
        static void Main()
        {   
            Console.Clear();
            var arr = new int[3];

            try
            {
                for (int index = 0; index < 10; index++)
                {
                    // System.IndexOutOfRangeException
                    Console.WriteLine(arr[index]);
                }
            }
            catch(IndexOutOfRangeException e)
            {
                Console.WriteLine("Ops, esse array não é tão grande assim...");
            }

        }
    }
}