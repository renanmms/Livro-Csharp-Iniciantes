// See https://aka.ms/new-console-template for more information
using static System.Console;
using LibraryClass;

// Inicializando nossa nova classe com herança
Revistas MinhasRevistas = new Revistas(3, 20);

// Inicializando os atributos do obj MinhasRevistas que foram herdados
MinhasRevistas.Autor = "Microsoft";
MinhasRevistas.Titulo = "MSDN Magazine";
MinhasRevistas.Paginas = 20;
MinhasRevistas.Status = true;

WriteLine($"Revista Mes: {MinhasRevistas.MesPublicacao}");
WriteLine($"Revista Ano: {MinhasRevistas.AnoPublicacao}");
WriteLine($"Revista Autor: {MinhasRevistas.Autor}");
WriteLine($"Revista Titulo: {MinhasRevistas.Titulo}");
WriteLine("Revista Paginas: {0}", MinhasRevistas.Paginas);
WriteLine("Revista Status: " + MinhasRevistas.Status);
WriteLine();

// Inicializando a classe com o construtor vazio
Biblioteca MinhaBiblioteca = new Biblioteca();

MinhaBiblioteca.Autor = "Des Dearlove";
MinhaBiblioteca.Titulo = "O Estilo Bill Gates de Gerir";
MinhaBiblioteca.Paginas = 203;
MinhaBiblioteca.Status = true;
WriteLine($"Autor: {MinhaBiblioteca.Autor}");
WriteLine($"Titulo: {MinhaBiblioteca.Titulo}");
WriteLine($"Paginas: {MinhaBiblioteca.Paginas}");
WriteLine($"Status: {MinhaBiblioteca.Status}");
WriteLine();

// Inicializando a classe com o construtor parametrizado
Biblioteca MeusLivros = new Biblioteca("Juan Garcia Sola", "Linguagem C", 296, true);
Console.WriteLine($"Autor: {MeusLivros.Autor}");
Console.WriteLine($"Titulo: {MeusLivros.Titulo}");
Console.WriteLine($"Paginas: {MeusLivros.Paginas}");
Console.WriteLine($"Status: {MeusLivros.Status}");
Console.WriteLine();

// Inicializando a classe Fotos
Fotos MinhasFotos = new Fotos("Colorida");
MinhasFotos.AnoPublicacao = 2021;
MinhasFotos.MesPublicacao = 3;
MinhasFotos.Autor = "Desconhecido";
MinhasFotos.Titulo = "Vida Eterna";
MinhasFotos.Paginas = 1;
MinhasFotos.Status = true;

// Imprimindo os valores da minha classe
WriteLine($"Foto Tipo: {MinhasFotos.Tipo}");
WriteLine($"Foto Mes: {MinhasFotos.MesPublicacao}");
WriteLine($"Foto Ano: {MinhasFotos.AnoPublicacao}");
WriteLine($"Foto Autor: {MinhasFotos.Autor}");
WriteLine($"Foto Titulo: {MinhasFotos.Titulo}");
WriteLine($"Foto Paginas: {MinhasFotos.Paginas}");
WriteLine($"Foto Status: {MinhasFotos.Status}");
WriteLine();

MeusLivros.Descarte(); // O Livro foi Doado
WriteLine($"Titulo: {MeusLivros.Titulo}"); // 
MinhasRevistas.Descarte(); // A Revista foi Reciclada
WriteLine($"Titulo: {MinhasRevistas.Titulo}");
MinhasFotos.Descarte(); // A Foto foi Destruída
WriteLine($"Titulo: {MinhasFotos.Titulo}");
WriteLine();