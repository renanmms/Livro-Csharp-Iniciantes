﻿// See https://aka.ms/new-console-template for more information
using System;
using System.Linq;
using System.Collections.Generic;

// Array de inteiros (fonte de dados)
var numeros = new[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19};

// Declarando um dicionário
Dictionary<int, int> hash = new Dictionary<int, int>();

// Adicionando elementos no array
hash.Add(1, 0xa);
hash.Add(2, 0xb);
hash.Add(3, 0xc);
hash.Add(4, 0xd);
hash.Add(5, 0xe);
hash.Add(6, 0xf);

// Query (Sintaxe de Método)
var numerosFiltrados = numeros.Where( n => n > 5 );

// Query (Sintaxe de Consulta)
var numerosFiltrados2 = from n in numeros where n > 5 select n;

// Executando a query
foreach(var num in numerosFiltrados2){
    Console.WriteLine(num);
}

Console.WriteLine("---- Operador de Restrição ----");
Console.WriteLine("--- (WHERE) ---");
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

foreach(var num in doisElementos){
    Console.WriteLine(num);
}

Console.WriteLine();
Console.WriteLine("--- (AVERAGE) ---");

// Media dos elementos da coleção
var media = numeros.Average();

// Imprime valor da média
Console.WriteLine(media);

Console.WriteLine();
Console.WriteLine("---- Operador de Ordenação ----");
Console.WriteLine("--- (REVERSE) ---");

var numerosOrdenados = numeros.OrderByDescending(n => n);

foreach(var n in numerosOrdenados)
{
    Console.WriteLine(n);
}

Console.WriteLine("--- (ORDERBY) ---");
// Declarando uma pilha
Stack<int> pilha = new Stack<int>();

// Empilhando os inteiros
pilha.Push(3);
pilha.Push(2);
pilha.Push(5);

var pilhaOrdenada = pilha.OrderBy(n => n);

foreach(var p in pilhaOrdenada){
    Console.WriteLine(p);
}

Console.WriteLine();
Console.WriteLine("--- (ORDERBYDESCENDING) ---");

pilhaOrdenada = pilha.OrderByDescending(n => n);

foreach(var p in pilhaOrdenada){
    Console.WriteLine(p);
}

Console.WriteLine();
Console.WriteLine("---- Operador de Paginação ----");
Console.WriteLine("--- (TAKE) ---");

var items = numeros.Take(4);

foreach(var i in items){
    Console.WriteLine(i);
}

Console.WriteLine("--- (TAKEWHILE) ---");

// Aplica um filtro no array numeros
items = numeros.TakeWhile(n => n < 6);

foreach(var i in items){
    Console.WriteLine(i);
}

Console.WriteLine();
// Executa o operador de paginação First no array
var numero = numeros.First();
Console.WriteLine(numero);

Console.WriteLine("Usando o First na pilha: ");
var pilhaTopo = pilha.First();
Console.WriteLine($"{pilhaTopo}");

var fila = new Queue<int>();
fila.Enqueue(3);
fila.Enqueue(10);
fila.Enqueue(6);
fila.Enqueue(7);


Console.WriteLine("Usando o First na fila: ");
var filaTopo = fila.First();
Console.WriteLine(filaTopo);

Console.WriteLine("--- (FIRSTORDEFAULT) ---");