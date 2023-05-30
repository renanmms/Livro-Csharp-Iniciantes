using static System.Console;

// See https://aka.ms/new-console-template for more information
WriteLine("------ Funções de Textos ------");
var empresa = "Microsoft Corporation";

WriteLine("TRIM - retira os espaços em branco antes e após a expressão");
WriteLine($"Nome com espaços: {empresa}");
WriteLine($"Nome sem espaços: {empresa.Trim()}");
WriteLine($"Length - retorna qtde de caracteres");
WriteLine($"Tamanho do texto: {empresa.Length}");

empresa = empresa.Trim();
WriteLine($"Tamanho do texto após o TRIM(): {empresa.Length}");

WriteLine("ToUpper - converte todo os caracteres para maiúsculo");
WriteLine($"Converte para maiúsculo: {empresa.Trim().ToUpper()}");

WriteLine("ToLower - converte todo os caracteres para minúsculo");
WriteLine($"Converte para minúsculo: {empresa.ToLower()}");

var nomeUpper = "AIRTON SENNA";
var nomeLower = "airton senna";

// comparação 1 
if(nomeUpper == nomeLower){
    WriteLine("1 - nomes iguais");
}
else {
    WriteLine("1 - nomes diferentes");
}

// comparação 2
if(nomeUpper.ToLower() == nomeLower){
    WriteLine("2 - nomes iguais");
}
else {
    WriteLine("2 - nomes diferentes");
}

// comparação 3
if(nomeUpper.Equals(nomeLower, StringComparison.OrdinalIgnoreCase)){
    WriteLine("3 - nomes iguais");
}
else {
    WriteLine("3 - nomes diferentes");
}

WriteLine("Remove - extrai x caracteres a partir da esquerda da expressão");
WriteLine($"texto esquerdo: {empresa.Remove(9)}");

WriteLine("Captura apenas o primeiro nome das pessoas");
string[] nomes = {"Fabricio dos Santos", "José da Silva", "Roberta Brasil"};

foreach(var n in nomes ){
    WriteLine($"{n.Remove(n.IndexOf(" "))}");
}

var novaEmpresa = empresa.Replace("Microsoft", "Google");
WriteLine("Replace - troca o conteúdo da expressão");
WriteLine($"texto atual: {empresa}");
WriteLine($"texto trocado: {novaEmpresa}");

WriteLine("Split - divide e extrai cada palavra em um array");
string NivelLivro = "Este livro é básico de C#.";
string[] blocos = NivelLivro.Split(' ');
var contador = 1;

foreach(var exp in blocos){
    WriteLine($"texto {contador++}: {exp}");
}

WriteLine($"Quantidade de palavras: {blocos.Count()}");

WriteLine("Substring - retorna uma parte da string");
WriteLine(NivelLivro.Substring(5, 14));

string[] cesta = {"5 Laranjas", "10 Goiabas vermelhas", "5 Pêssegos doces", "5 Bananas"};

foreach(var p in cesta){
    WriteLine(p.Substring(p.IndexOf(' ') + 1));
}

//Somar as quantidades contidas dos produtos das cesta
int soma = 0;

foreach(var qtd in cesta){
    soma += Int32.Parse(qtd.Split(' ')[0]);
}

WriteLine($"Resultado da soma das quantidades: {soma}");

WriteLine("IsNullOrEmpty verifica se a string está nula ou vazia");
string nome = "Renan";
string sobrenome = "Martins";

if(!String.IsNullOrEmpty(nome) && !String.IsNullOrEmpty(sobrenome)){
    WriteLine($"Nome completo: {nome} {sobrenome}");
}
else{
    WriteLine($"Nome: {nome}");
}

WriteLine("CONCAT");

var alunos = new List<string>{"Yuri\n", "Bruno\n", "Carlos\n", "Pedro\n"};

WriteLine(string.Concat(alunos));