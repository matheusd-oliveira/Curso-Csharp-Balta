using System;
using System.Globalization;
// O datetime é um tipo de struct.

Console.Clear();
// Pegando a data atual
// var data = DateTime.Now;

// Escrevendo a propria data e obtendo valores 
// var data = new DateTime(2023, 06, 08, 13, 23, 14);
// Console.WriteLine(data);
// Console.WriteLine(data.Year);
// Console.WriteLine(data.Day);
// Console.WriteLine(data.Month);
// Console.WriteLine(data.Hour);
// Console.WriteLine(data.Minute);
// Console.WriteLine(data.Second);
// Console.WriteLine(data.DayOfWeek);

// Formatando datas
// var data = DateTime.Now;
// var dataFormatada = string.Format("{0:dd/MM/yyyy hh:mm:ss}", data);

// Padrões de formatação
// Short DateTime
// var dataFormatada = string.Format("{0:t}", data);

// Long DateTime
// var dataFormatada = string.Format("{0:T}", data);

// Short dd/MM/yyyy
// var dataFormatada = string.Format("{0:d}", data);

// Data por extenso
// var dataFormatada = string.Format("{0:D}", data);

// formatação no padrão que muitos sistemas usam
// var dataFormatada = string.Format("{0:r}", data);
// var dataFormatada = string.Format("{0:R}", data);

// Universal
// var dataFormatada = string.Format("{0:u}", data);

// Geralmente é utilizado em JSON
// var dataFormatada = string.Format("{0:s}", data);

// Comparando datas
// var data = DateTime.Now;
// if (data.Date == DateTime.Now.Date) Console.WriteLine("é igual");


// CultureInfo
// var pt = new CultureInfo("pt-PT");
// var br = new CultureInfo("pt-BR");
// var atual = CultureInfo.CurrentCulture;

// Console.WriteLine(DateTime.Now.ToString("D", pt));
// Console.WriteLine(DateTime.Now.ToString("D", br));
// Console.WriteLine(DateTime.Now.ToString("d", atual));


// Timezone
// var utcDate = DateTime.UtcNow;
// Console.WriteLine(DateTime.Now);
// Console.WriteLine(utcDate);
// Console.WriteLine(utcDate.ToLocalTime());

// var timezoneAustralia = TimeZoneInfo.FindSystemTimeZoneById("Pacific/Auckland");
// var horaAustralia = TimeZoneInfo.ConvertTimeFromUtc(utcDate, timezoneAustralia);
// Console.WriteLine(timezoneAustralia);
// Console.WriteLine(horaAustralia);

// var timezones = TimeZoneInfo.GetSystemTimeZones();
// foreach (var timezone in timezones)
// {
//     Console.WriteLine(timezone.Id);
//     Console.WriteLine(timezone);
//     Console.WriteLine(TimeZoneInfo.ConvertTimeFromUtc(utcDate, timezone));
//     Console.WriteLine("----------");
// }


// var timeSpan = new TimeSpan(08, 12, 23);
// Console.WriteLine(timeSpan);

// var timeSpanDiaHoraMinutoSegundo = new TimeSpan(5, 08, 12, 23);



Console.WriteLine(DateTime.DaysInMonth(2023, 06));
Console.WriteLine(IsWeekend(DateTime.Now.DayOfWeek));
Console.WriteLine(DateTime.Now.IsDaylightSavingTime());

static bool IsWeekend(DayOfWeek today)
{
    return today == DayOfWeek.Saturday || today == DayOfWeek.Sunday;
}