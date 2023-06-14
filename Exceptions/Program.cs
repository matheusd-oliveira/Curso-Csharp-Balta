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
                // for (int index = 0; index < 10; index++)
                // {
                //     // System.IndexOutOfRangeException
                //     Console.WriteLine(arr[index]);
                // }

                Cadastrar("olá, acho que não vai dar erro");
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.InnerException);
                Console.WriteLine(e.Message);
                Console.WriteLine("Ops, esse array não é tão grande assim...");
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine(e.InnerException);
                Console.WriteLine(e.Message);
                Console.WriteLine("Falha ao cadastrar texto.");
            }
            catch (MinhaException e)
            {
                Console.WriteLine(e.InnerException);
                Console.WriteLine(e.Message);
                Console.WriteLine(e.QuandoAconteceu);
                Console.WriteLine("Exceção customizada");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.InnerException);
                Console.WriteLine(e.Message);
                Console.WriteLine("Ops, algo deu errado!");
            }
            finally
            {
                Console.WriteLine("Chegou ao fim!");
            }

        }
        private static void Cadastrar(string texto)
        {
            if (string.IsNullOrEmpty(texto))
                throw new MinhaException(DateTime.Now);
        }

        public class MinhaException : Exception
        {

            public MinhaException(DateTime date)
            {
                QuandoAconteceu = date;
            }
            public DateTime QuandoAconteceu { get; set; }

        }
    }
}