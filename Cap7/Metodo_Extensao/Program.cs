// O método de extensão deve ser static
using System;
using static MinhasExtensoes.MetodosExtensoes;

decimal valor = 4578.78M;

Console.WriteLine(DateTime.Today.FormatarData("dd/MMM/yyyy"));
Console.WriteLine(DateTime.Today.FormatarData("dddd dd/MMM/yyyy"));
Console.WriteLine(DateTime.Today.FormatarData("MMMM yyyy"));
Console.WriteLine(DateTime.Today.FormatarData("yyyy"));

Console.WriteLine(valor.Formatar("C2"));
Console.WriteLine($"{4578.87M.Formatar("C2")}");

Console.ReadKey();


namespace MinhasExtensoes{
    public static class MetodosExtensoes{
        public static string Formatar(this decimal valor, string formato) => valor.ToString(formato); 

        public static string FormatarData(this DateTime data, string formato) => data.ToString(formato);
    }
}


