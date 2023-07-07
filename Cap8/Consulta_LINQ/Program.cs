// See https://aka.ms/new-console-template for more information
using System.Collections;

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
var filaTopo = fila.First(); // Se a fila estiver vazia é gerada uma exceção
Console.WriteLine(filaTopo);

Console.WriteLine("--- (FIRSTORDEFAULT) ---");
filaTopo = fila.FirstOrDefault();
Console.WriteLine(filaTopo);

Console.WriteLine("--- (LAST) | (LASTORDEFAULT) ---");
// Executa o operador de paginação LastOrDefault na coleção
var numeroDefault = numeros.LastOrDefault(p => p == 10);
// Imprime número
Console.WriteLine(numeroDefault);

// Executa o operador de paginação Last na coleção
var ultimo = numeros.Last();

// Imprime número
Console.WriteLine($"{ultimo}");

Console.WriteLine("--- (SKIP) ---");
// Executa o operador de paginação Skip na coleção
var numerosPaginados = numeros.Skip(3);

// Faz iteração em numerosPaginados
foreach(var n in numerosPaginados){
    // Imprime número
    Console.WriteLine(n);
}

Console.WriteLine("--- (CONCAT) ---");

// Declarando duas listas com inteiros
var colecao1 = new List<int>{1, 2, 3};
var colecao2 = new List<int>{5, 6, 7};

// Concatenando a colecao2 com a colecao1
var colecao3 = colecao1.Concat(colecao2);

// Imprimindo valores da colecao1
foreach(var i in colecao3){
    Console.WriteLine(i);
}

Console.WriteLine("--- (ELEMENTAT) ---");

// Para recuperar um elemento passamos o índice para o método ElementAt
var elemento = numeros.ElementAt(5); // numeros[5]

// Imprimindo o elemento no indice 5
Console.WriteLine($"Elemento no indice 5: {elemento}");

Console.WriteLine("--- (SINGLE) | (SINGLEORDEFAULT) ---");
int x = numeros.Single( p => p == 10); //  Gerar uma exceção se existir mais de um elemento que satisfaça o filtro

Console.WriteLine($"Utilizando o Single: {x}"); 

int y = numeros.SingleOrDefault(p => p == 8);
Console.WriteLine($"Utilizando o SingleOrDefault: {y}"); // O Single traz garantia de unicidade e evita elementos duplicados

Console.WriteLine("");
Console.WriteLine("---- Operador de Projeção ----");
Console.WriteLine("--- (SELECT) ---");

var categorias = numeros.Select(p => 
    new 
    {
        Id = p,
        Descricao = $"Categoria {p}"
    }
);

foreach(var c in categorias)
{
    Console.WriteLine($"Descrição: {c.Descricao} Id: {c.Id}");
}


var sequence1 = new int[]{1, 2, 3, 4, 5};

var sequence2 = new int[]{2, 3, 7, 5};

var intersectSeq = sequence1.Intersect(sequence2);

foreach(var i in intersectSeq) {
    Console.WriteLine(i);
}

Console.WriteLine("========= OFTYPE ==========");
var sequence3 = new ArrayList();

sequence3.Add(3.1415);
sequence3.Add(2.8981M);
sequence3.Add(7);
sequence3.Add("Array    List");
sequence3.Add(3);

foreach(var i in sequence3.OfType<decimal>()){
    Console.WriteLine($" {i} ");
}

Console.WriteLine("========= EXCEPT ==========");
var oddNumbers = new List<int>{2, 4, 6, 8, 10, 12};
var primeNumbers = new List<int>{1, 2, 3, 5, 7, 11};

var resultSequence = oddNumbers.Except(primeNumbers); // 4, 6, 8, 10, 12
var resultSequence2 = primeNumbers.Except(oddNumbers);

Console.WriteLine("========= Prime Numbers except Odd Numbers ==========");
foreach(var n in resultSequence2) {
    Console.WriteLine($" {n} ");
}

Console.WriteLine("========= Odd Numbers except Prime Numbers ==========");
foreach(var n in resultSequence) {
    Console.WriteLine($" {n} ");
}

Console.WriteLine("========= REPEAT ==========");
foreach(var n in Enumerable.Repeat("********", 8)) {
    Console.WriteLine(n);
}