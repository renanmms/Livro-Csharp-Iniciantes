// See https://aka.ms/new-console-template for more information
using LibraryClass;

Biblioteca MinhaBiblioteca = new Biblioteca();
MinhaBiblioteca.Autor = "Des Dearlove";
MinhaBiblioteca.Titulo = "O Estilo Bill Gates de Gerir";
MinhaBiblioteca.Paginas = 203;
MinhaBiblioteca.Status = true;

Console.WriteLine($"Autor: {MinhaBiblioteca.Autor}");
Console.WriteLine($"Titulo: {MinhaBiblioteca.Titulo}");
Console.WriteLine($"Paginas: {MinhaBiblioteca.Paginas}");
Console.WriteLine($"Status: {MinhaBiblioteca.Status}");
Console.WriteLine();

