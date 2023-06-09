namespace EstruturaDeDados
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            var funcionarios = new Funcionario[5];
            funcionarios[0] = new Funcionario() { Id = 2579 , Nome = "Matheus"};

            foreach (var funcionario in funcionarios)
            {
                Console.WriteLine(funcionario.Id);
                Console.WriteLine(funcionario.Nome);
            }
        }
    }

    public struct Funcionario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
    }
}



// Array / Vetor 
// var meuArray = new int[5] { 1, 2, 3, 4, 5 };
// meuArray[0] = 12;

// for (var index = 0; index < meuArray.Length; index++)
// {   
//     Console.WriteLine(meuArray[index]);
// }




