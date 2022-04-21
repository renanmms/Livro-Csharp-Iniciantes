// See https://aka.ms/new-console-template for more information
using System.Collections.Generic;

var sexo = new Dictionary<string, string>();
sexo.Add("M", "Masculino");
sexo.Add("F", "Feminino");
Console.WriteLine($"{sexo["F"]}");

var cidades = new Dictionary<string, string>
{
    ["MG"] = "Minas Gerais",
    ["SC"] = "Santa Catarina",
    ["SP"] = "São Paulo",
    ["RS"] = "Rio Grande do Sul"
};

Console.WriteLine($"--- dicionário com {cidades.Count()} Cidades ---");

Console.WriteLine(cidades["MG"]);

Console.WriteLine("Iterando com Foreach em um Dicionário: ");
foreach(var cidade in cidades)
{
    Console.WriteLine($"sigla: {cidade.Key} - {cidade.Value}");
}

Console.WriteLine("--- dicionário Países ---");
var paises = new Dictionary<int, string>
{
    [100] = "Brasil",
    [2] = "Australia",
    [60] = "Nova Zelandia"
};

foreach(var pais in paises){
    Console.WriteLine($"{pais.Key} - {pais.Value}");
}

var texto = new string[]
{
            // índice do início     índice do final
    "Meu",          // 0                ^9
    "codigo",       // 1                ^8
    "rodou",        // 2                ^7
    "sem",          // 3                ^6
    "erros",        // 4                ^5
    "para",         // 5                ^4
    "ler",          // 6                ^3
    "cadastro",     // 7                ^2
    "clientes"      // 8                ^1
};

Console.WriteLine("--- Índices do dicionário ---");
Console.WriteLine($"A última palavra é {texto[^1]}"); // A última palavra é clientes
Console.WriteLine($"A primeira palavra é: {texto[^9]}"); // A primeira palavra é Meu

Console.WriteLine("--- parte do texto ---");
var pedacoTexto = texto[1..4];
foreach(var p in pedacoTexto)
{
    Console.WriteLine(p);
}

var intervalo = 1..6;
foreach(var p in texto[intervalo])
{
    Console.WriteLine(p);
}

var todas = texto[..];
Console.WriteLine("--- primeiras 4 ---");
var Primeiras4 = texto[..4]; // 'Meu' 'código' 'rodou' 'sem'
foreach(var p in Primeiras4)
{
    Console.WriteLine(p);
}

Console.WriteLine("--- últimas 3 ---");
var Ultimas3 = texto[6..]; //  3 ultimas pelo indice 6
foreach(var p in Ultimas3)
{
    Console.WriteLine(p);
}

Console.ReadLine();