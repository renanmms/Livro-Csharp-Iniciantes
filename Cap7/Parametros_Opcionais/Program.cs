// See https://aka.ms/new-console-template for more information
using System;

Console.WriteLine("Parâmetros Opcionais");
Console.WriteLine(Faturamento(500, 5, 10)); // 2510.0
Console.WriteLine("Parâmetros 1 e 2"); 
Console.WriteLine(Faturamento(50, 12)); // 605
Console.WriteLine("Parâmetros 1 e 3");
Console.WriteLine(Faturamento(53.2M, bonus: 32.12M)); // 564,12

static decimal Faturamento(decimal qtde, decimal preco = 10, decimal bonus = 5) => qtde * preco + bonus;