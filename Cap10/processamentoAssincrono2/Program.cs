using System;
using System.Threading.Tasks;

meuNome();
Console.WriteLine("função 1 foi executada");

meuSobrenome();
Console.WriteLine("função 2 foi executada");


Console.WriteLine("");

async Task meuNome(){
    Task.Delay(5000).Wait();
}

async Task meuSobrenome(){
    Task.Delay(1000).Wait();
}