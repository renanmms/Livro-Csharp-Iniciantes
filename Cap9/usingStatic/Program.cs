// See https://aka.ms/new-console-template for more information
using static System.Console;
using static System.Math;
using static System.String;

// System.Math
// raiz quadrada
WriteLine($"Raiz quadrada: {Sqrt(3*3 + 4*4)}");

// Retorna o valor absoluto
WriteLine($"Valor absoluto positivo: {Abs(1234.78)}");
WriteLine($"Valor absoluto negativo: {Abs(-1234.78)}");
WriteLine($"Valor Máximo: {Max(100, 590)}");
WriteLine($"Valor Mínimo: {Min(100, 590)}");

// Arredonda um valor para o inteiro mais próximo ou para o número especificado de casas decimais
WriteLine($"Arrendonda com 1 casa decimal: {Round(Math.PI, 1)}"); // 3,1
WriteLine($"Arrendonda com 2 casas decimais: {Round(Math.PI, 2)}"); // 3,14

// System.String
WriteLine($"Tamanho da String: {"Livro de C#".Length}");

string livro = "Livro de EF Core";

WriteLine($"Concatena 2 strings: {Concat("Livro de C#,", "Livro de EF Core")}");
WriteLine($"{livro.Insert(6, "avançado ").ToUpper()}");