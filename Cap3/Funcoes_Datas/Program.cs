// See https://aka.ms/new-console-template for more information
using static System.Console;
using System.Globalization;

int dia = 12;
int mes = 05;
int ano = 2021;

DateTime dtAniversario = new DateTime(ano, mes, dia);

DateTime dtFesta = new DateTime(2021, 08, 25);
// Formatação de datas
WriteLine("----------Funções de Datas-----------");
WriteLine($"Aniversário: {dtAniversario}");
WriteLine($"Aniversario: {dtAniversario:dd/M/yy}");
WriteLine($"Aniversário: {dtAniversario: ddd/MMM/yyy}");
WriteLine($"Aniversario: {dtAniversario:dddd/MMM/yyyy}");
WriteLine($"Aniversário: {dtAniversario: dddd dd/MMMM/yyyy}");

WriteLine("TODAY - retorna a data atual");
WriteLine($"{DateTime.Today: dddd/MMM/yyyy}");

DateTime DataHora = DateTime.Now;

WriteLine("NOW - retorna a data e a hora atual");
WriteLine(DataHora);

WriteLine("DAY / MONTH / YEAR - capturar o dia, mês e ano");
WriteLine($"Dia: {DataHora.Day}");
WriteLine($"Mês: {DataHora.Month}");
WriteLine($"Ano: {DataHora.Year}");

WriteLine("AddDays - adiciona dias ao objeto do tipo DateTime");
WriteLine($"{DataHora.AddDays(4)}");

WriteLine("AddMonths - adiciona meses");
WriteLine($"{DataHora.AddMonths(3)}");

WriteLine("AddYears - adiciona anos");
WriteLine($"{DataHora.AddYears(10)}");

DateTime dtPedido = DateTime.Today;
// adiciona 35 dias
DateTime dtVencto = dtPedido.AddDays(35);
// adicionar 2 meses
DateTime dtPagto = dtVencto.AddMonths(2);

WriteLine();
WriteLine($"Pedido feito em {dtPedido: dd/MMM/yyyy} vence em {dtVencto: dd/MM/yyyy}");
WriteLine($"Formatação completa: {dtVencto.ToLongDateString()}");
WriteLine($"Formatação curta: {dtVencto.ToShortDateString()}");

// dia da semana
WriteLine($"dia da semana: {dtVencto.DayOfWeek}");
WriteLine($"dia da semana em português: {dtVencto.ToString("dddd", new CultureInfo("es-AR"))}");
WriteLine($"Número do dia da semana: {(int)dtVencto.DayOfWeek}");

// dia do ano
WriteLine($"dia do ano: {dtPedido.DayOfYear}");

// subtrai 2 datas
var qtdeDias = dtPagto.Subtract(dtPedido);
WriteLine($"Entre o pedido e o pagamento foram {qtdeDias:dd} dias");

WriteLine("Conversão de Texto para Date");

string dataTexto = "15/07/2021";
DateTime dataTextoConvertida = new DateTime();
TestaConversao(dataTexto, dataTextoConvertida);

string dataTextoErrada = "15/metade do ano/2021";
DateTime dataTextoErradaConvertida = new DateTime();

TestaConversao(dataTextoErrada, dataTextoErradaConvertida);

static void TestaConversao(string dataTexto, DateTime dataTextoConvertida){
    // tentativa (TryParse) de conversão de dataTexto
    // caso dê certo a saída OUT será em dataTextoConvertida
    WriteLine();
    if(DateTime.TryParse(dataTexto, out dataTextoConvertida)){
        WriteLine("Data {0} com conversão aceita", dataTextoConvertida);
    }
    else{
        WriteLine("Erro na conversão da data");
    }
}

var pedido = new Pedido
{
    PedidoID = 1,
    DtPedido = DateTime.Today,
    DtPagto = DateTime.Today.AddDays(45),
    Valor = 1500
};

WriteLine($"Pedido: {pedido.PedidoID} - " + $"vencto: {pedido.DtVencimento():dd/MMM/yyyy} - " + $"dias atraso: {pedido.DiasAtraso().TotalDays} - " + $"valor: {pedido.Valor:n2} - " + $"multa: {pedido.Multa:n2}");

public class Pedido
{
    public int PedidoID { get; set; }
    public DateTime DtPedido { get; set; }
    public DateTime DtVencimento() => DtPedido.AddDays(30);
    public DateTime DtPagto {get; set;}
    public TimeSpan DiasAtraso() => DtPagto.Subtract(DtVencimento());
    public decimal Valor { get; set; }
    public decimal Multa => Valor * 0.10M;
}