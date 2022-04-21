// See https://aka.ms/new-console-template for more information
using static System.Console;
int contador = 0;

Func<int> numero = () => ++contador;
WriteLine($"chamada 1: {numero()}");
WriteLine($"chamada 2: {numero()}");
WriteLine($"contador: {contador}");

string texto = "Visual C#";
// Func<entrada, saída>
Func<string, int> MetodoQtdeCaracteres = (t) => t.Length;
WriteLine(MetodoQtdeCaracteres(texto));

Func<string, int> MetodoQtdePalavras = (t) => t.Split(" ").Where(x => x!= "").Count();

WriteLine($"--- Quantidade de palavras no texto --- \n{MetodoQtdePalavras("   Brasil    campeão mundial de volei")}");

// Declarada uma função delegate que retorna decimal
// Calcular o imposto
Func<decimal, decimal, decimal, decimal> Imposto = (salario, perc, aliquota) => {
    return salario <= 1000 ? 0 : salario * (perc/100) -  aliquota;
};

WriteLine("---- Calculo do Imposto ---");
WriteLine(Imposto(1000, 10, 10)); 
WriteLine(Imposto(5000, 27.5M, 80)); 
WriteLine(Imposto(23500, 32.5M, 180));