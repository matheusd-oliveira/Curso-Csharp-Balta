using System.Globalization;


// Estudando números
Console.Clear();

decimal valor = 10536.25m;

//var cultura = new CultureInfo("en-US");

// Como formatar para moedas.
Console.WriteLine(valor.ToString("C",CultureInfo.CreateSpecificCulture("en-US")));
Console.WriteLine(valor.ToString("C",CultureInfo.CreateSpecificCulture("pt-BR")));
// Quando números são muito grandes.
Console.WriteLine(valor.ToString("E04",CultureInfo.CreateSpecificCulture("pt-BR")));
// Para formatar com maior precisão
Console.WriteLine(valor.ToString("F1",CultureInfo.CreateSpecificCulture("pt-BR")));
// Para formatar com porcentagem.
Console.WriteLine(valor.ToString("P", CultureInfo.CreateSpecificCulture("pt-BR")));
// Em formato de número.
Console.WriteLine(valor.ToString("N", CultureInfo.CreateSpecificCulture("pt-BR")));


// Arredondar valores com a classe Math
Console.WriteLine(Math.Round(valor));
// Arredondar para cima
Console.WriteLine(Math.Ceiling(valor));
// Arredondar para baixo
Console.WriteLine(Math.Floor(valor));