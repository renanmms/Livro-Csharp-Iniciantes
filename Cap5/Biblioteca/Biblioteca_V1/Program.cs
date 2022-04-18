// See https://aka.ms/new-console-template for more information
using LibraryClass;

// Inicializando o objeto com o construtor sem parâmetros
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

// Inicializando o objeto através do construtor
Biblioteca MeusLivros = new Biblioteca("Juan Garcia Sola", "Linguagem C", 296, true);
Console.WriteLine($"Autor: {MeusLivros.Autor}");
Console.WriteLine($"Titulo: {MeusLivros.Titulo}");
Console.WriteLine($"Paginas: {MeusLivros.Paginas}");
Console.WriteLine($"Status: {MeusLivros.Status}");
Console.WriteLine();


