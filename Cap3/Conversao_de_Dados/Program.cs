// See https://aka.ms/new-console-template for more information
using static System.Console;
using System.Linq;
using System.Globalization;

// Boxing é a conversão de um tipo de valor para um tipo de objeto
int percentual = 10;
object objPercentual = percentual;
WriteLine($"percentual: {percentual} - {percentual.GetType()}");
WriteLine($"objPercentual: {objPercentual} - {objPercentual.GetType()}");

decimal salario = 12500.50M;
object objSalario = salario;
WriteLine($"salario: {salario} - {salario.GetType()}"); // 
WriteLine($"objSalario: {objSalario} - {objSalario.GetType()}");


WriteLine();

string nome = "Visual C#";
object objNome = nome;
WriteLine($"nome: {nome} - {nome.GetType()}"); // System.String
WriteLine($"objNome: {objNome} - {objNome.GetType()}"); // System.String

DateTime hoje = DateTime.Today;
object objHoje = hoje;
WriteLine($"hoje: {hoje} - {hoje.GetType()}"); // System.DateTime
WriteLine($"objHoje: {objHoje.GetType()}"); // System.DateTime

// Unboxing
object objDesconto = 10;
int desconto = (int)objDesconto;
WriteLine("----- Unboxing");
WriteLine($"desconto: {desconto} - {desconto.GetType()}"); // System.Int32
WriteLine($"objDesconto: {objDesconto} - {objDesconto.GetType()}"); // System.Int32