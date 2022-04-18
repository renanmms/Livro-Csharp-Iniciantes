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