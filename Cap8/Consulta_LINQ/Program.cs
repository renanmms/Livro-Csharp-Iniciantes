// See https://aka.ms/new-console-template for more information
using System;
using System.Linq;

// Array de inteiros (fonte de dados)
var numeros = new[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

// Query (Sintaxe de Método)
var numerosFiltrados = numeros.Where( n => n > 5 );

// Query (Sintaxe de Consulta)
var numerosFiltrados2 = from n in numeros where n > 5 select n;

// Executando a query
foreach(var numero in numerosFiltrados2){
    Console.WriteLine(numero);
}

Console.WriteLine("---- Operador de Restrição (WHERE) ----");
// Coleção de pessoas
var pessoas = new[]
{
    "Carlos dos Santos",
    "Renato Haddad",
    "Claudenir Andrade",
    "Andre Carlucci",
    "Ray Carneiro",
    "Rafael Almeida"
};

// Filtro de pessoas
var pessoasFiltradas = pessoas.Where( p => p.Contains("Almeida"));

// Execução da Query para as pessoas filtradas
foreach(var pessoa in pessoasFiltradas){
    Console.WriteLine(pessoa);
}

Console.WriteLine("--- Operadores de Agregação (COUNT)  ---");

// Conta todos os elementos da coleção
var countTotal = numeros.Count();

var countParcial = numeros.Count( n => n % 2 == 0);

var countImpar = numeros.Count( n => n % 2 != 0);


Console.WriteLine($"Número de elementos: {countTotal}");
Console.WriteLine($"Quantidade de numeros pares: {countParcial}");
Console.WriteLine($"Quantidade de numeros ímpares: {countImpar}");

Console.WriteLine();
Console.WriteLine($"--- (SUM) ---");

// Soma todos os elementos da coleção
var somaTotal = numeros.Sum();

// Soma todos os elementos menores que 5
var somaParcial = numeros.Where(n => n < 5).Sum();

// Soma o elemento da coleção multiplicado por 2
var somaComMultiplicacao = numeros.Sum(n => n * 2);

// Imprime soma
Console.WriteLine($"Soma de todos os números: {somaTotal}");
Console.WriteLine($"Soma dos números menores que 5: {somaParcial}");
Console.WriteLine($"Soma dos números multiplicados por 2: {somaComMultiplicacao}");
Console.WriteLine();

Console.WriteLine("--- (MAX) ---");
var maxTotal = numeros.Max();
var maxComMultiplicacao = numeros.Max(n => n * 2);

Console.WriteLine($"Valor mais alto do array: {maxTotal}");
Console.WriteLine($"Valor mais alto do array multiplicado por 2: {maxComMultiplicacao}");
Console.WriteLine();

Console.WriteLine("--- (MIN) ---");

var doisElementos = numeros.Take(2);

foreach(var numero in doisElementos){
    Console.WriteLine(numero);
}

Console.WriteLine();
Console.WriteLine("--- (AVERAGE) ---");

// Media dos elementos da coleção
var media = numeros.Average();

// Imprime valor da média
Console.WriteLine(media);