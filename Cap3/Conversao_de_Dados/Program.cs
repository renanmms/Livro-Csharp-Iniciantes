// See https://aka.ms/new-console-template for more information
using static System.Console;
using System.Linq;
using System.Globalization;

// Boxing é a conversão de um tipo de valor para um tipo de objeto
// int percentual = 10; // Tipo VALOR
// object objPercentual = percentual; // Tipo REFERÊNCIA

// WriteLine();

// WriteLine($"percentual: {percentual} - {percentual.GetType()}");
// WriteLine($"objPercentual: {objPercentual} - {objPercentual.GetType()}");

// decimal salario = 12500.50M;
// object objSalario = salario;
// WriteLine($"salario: {salario} - {salario.GetType()}"); // 
// WriteLine($"objSalario: {objSalario} - {objSalario.GetType()}");


// WriteLine();

// string nome = "Visual C#";
// object objNome = nome;
// WriteLine($"nome: {nome} - {nome.GetType()}"); // System.String
// WriteLine($"objNome: {objNome} - {objNome.GetType()}"); // System.String

// DateTime hoje = DateTime.Today;
// object objHoje = hoje;
// WriteLine($"hoje: {hoje} - {hoje.GetType()}"); // System.DateTime
// WriteLine($"objHoje: {objHoje.GetType()}"); // System.DateTime

// // Unboxing
// object objDesconto = 10;
// int desconto = (int)objDesconto;
// WriteLine("----- Unboxing");
// WriteLine($"desconto: {desconto} - {desconto.GetType()}"); // System.Int32
// WriteLine($"objDesconto: {objDesconto} - {objDesconto.GetType()}"); // System.Int32

// try {
//     // Conversões com PARSE
//     WriteLine("----- .Parse");
//     WriteLine($"{Int16.Parse("150")}");

//     // retorna -150, os parênteses representam o valor negativo
//     WriteLine($"{Int16.Parse("(150)", NumberStyles.AllowParentheses)}");

//     // retorna 50000 mesmo com o pto de milhar
//     WriteLine($"{int.Parse("50.000", NumberStyles.AllowThousands)}");

//     // retorna 50000 mesmo com o símbolo monetário
//     WriteLine($"Cultura atual: {CultureInfo.CurrentCulture.Name}");
//     WriteLine($"Símbolo da moeda: {NumberFormatInfo.CurrentInfo.CurrencySymbol}");
//     WriteLine($"{int.Parse("R$50000", NumberStyles.AllowCurrencySymbol)}");


//     // retorna -200 mesmo com o símbolo de negativo
//     WriteLine($"{int.Parse("-200", NumberStyles.AllowLeadingSign)}");

//     // retorna 200 mesmo com os espaços em branco antes e depois
//     WriteLine($"{int.Parse(" 100", NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite)}");

//     // retorna 5432123456
//     WriteLine($"{Int64.Parse("5432123456")}");

//     WriteLine($"Data: {DateTime.Parse("21/4/2021"):dd/MMM/yy}");

// } catch (Exception ex) {
//     WriteLine(ex);
// }

try {
    // Conversões com Convert.To
    WriteLine("----- Convert Números");
    int n1 = Convert.ToInt16("100");
    WriteLine($"{n1.GetType()} - {n1}"); // System.Int32 - 100
    Int32 n2 = Convert.ToInt32("200500");
    WriteLine($"{n2.GetType()} - {n2}"); // System.Int32 - 200500
    Int64 n3 = Convert.ToInt64("1003232131321321");
    WriteLine($"{n3.GetType()} - {n3}"); // System.Int64 - 1003232131321321
    decimal preco = Convert.ToDecimal("1420,50");
    WriteLine($"{preco.GetType()} - {preco:n3}"); // System.Decimal - 1420,500

    WriteLine("----- Convert String");
    // Operador ?? valida se a expressão à esquerda não é nulo, se for, retorna a expressão à direita
    string texto1 = Convert.ToString(250.59M); 
    WriteLine($"{texto1.GetType()} - {texto1} - resultado: {texto1 ?? "texto é nulo"}"); // System.String - 250.59M - resultado: 250.59M

    string texto2 = Convert.ToString(DateTime.Today);
    WriteLine($"{texto2.GetType()} - {texto2}"); // System.String - 15/04/2022 00:00:00

    WriteLine("----- Convert Booleano");
    bool valido = Convert.ToBoolean("false");
    WriteLine($"{valido.GetType()} - {valido}"); // System.Boolean - False
    WriteLine($"0 - {Convert.ToBoolean(0)}"); // 0 - False
    WriteLine($"1 - {Convert.ToBoolean(1)}"); // 1 - True
    WriteLine($"100 - {Convert.ToBoolean(100)}"); // 100 - True

    WriteLine("----- Convert Data");
    DateTime natal = Convert.ToDateTime("25/12/2022"); 
    WriteLine($"Natal: {natal.GetType()} - {natal:dd/MMMM/yyyy}"); // Natal: System.DateTime - 25/dez/2022
    WriteLine($"Natal: {natal.Day} - {natal.Month} - {natal.Year}"); // Natal: 25 - 12 - 2022
}
catch (Exception ex){
    WriteLine(ex); 
}