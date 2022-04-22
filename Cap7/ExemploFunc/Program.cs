// See https://aka.ms/new-console-template for more information
using static System.Console;
using ExemploFunc;

// int contador = 0;

// Func<int> numero = () => ++contador;
// WriteLine($"chamada 1: {numero()}");
// WriteLine($"chamada 2: {numero()}");
// WriteLine($"contador: {contador}");

// string texto = "Visual C#";
// // Func<entrada, saída>
// Func<string, int> MetodoQtdeCaracteres = (t) => t.Length;
// WriteLine(MetodoQtdeCaracteres(texto));

// Func<string, int> MetodoQtdePalavras = (t) => t.Split(" ").Where(x => x!= "").Count();

// WriteLine($"--- Quantidade de palavras no texto --- \n{MetodoQtdePalavras("   Brasil    campeão mundial de volei")}");

// // Declarada uma função delegate que retorna decimal
// // Calcular o imposto
// Func<decimal, decimal, decimal, decimal> Imposto = (salario, perc, aliquota) => {
//     return salario <= 1000 ? 0 : salario * (perc/100) -  aliquota;
// };

// WriteLine("---- Calculo do Imposto ---");
// WriteLine(Imposto(1000, 10, 10)); 
// WriteLine(Imposto(5000, 27.5M, 80)); 
// WriteLine(Imposto(23500, 32.5M, 180));

WriteLine("---- cálculo de FUNC em coleções");

// Pegando o ano atual
int anoAtual = DateTime.Today.Year;

// Declarando uma função delegate que recebe como 1º parametro o inteiro ano, e a kilometragem do Carro km q e double
Func<int, double, double> CalculoKmPorAno = (ano, km) => ano >= anoAtual ? km : km / (anoAtual - ano);

// Pega os objetos declarados na classe e armazena na variavel dados
var dados = Carro.Get();

// Faz um loop foreach, calculando a kilometragem de cada objeto Carro e imprimindo os dados
dados.ForEach(x => 
{
    var kmPorAno = CalculoKmPorAno(x.AnoFabricacao, x.KmRodados);

    WriteLine($"{x.Modelo}  |   ano: {x.AnoFabricacao}  |   km: {x.KmRodados:n0}   |   litros: {x.Litros}  |    km/ano: {kmPorAno:n0}");
});

// Input para pausar o console
ReadLine();