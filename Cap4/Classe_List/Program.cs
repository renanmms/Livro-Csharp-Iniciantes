// See https://aka.ms/new-console-template for more information
List<string> nomesFuncionarios = new List<string>();

nomesFuncionarios.Add("Maria");
nomesFuncionarios.Add("João");
nomesFuncionarios.Add("André");
nomesFuncionarios.Add("Flávia");

nomesFuncionarios.Remove("Flávia");
nomesFuncionarios.RemoveAt(0);

Console.WriteLine();
foreach(string pessoa in nomesFuncionarios){
    Console.WriteLine($"{pessoa}");
}