using SistemaBancario;

var objetoGerente = new Gerente(); // Instanciamento de classe

// sbyte a = 2;
// byte b = 3;
// short c = 4;
Console.WriteLine("Tamanho das variáveis");
Console.WriteLine("sbyte.MaxValue = {0}", sbyte.MaxValue);
Console.WriteLine($"sbyte.MinValue = {sbyte.MinValue}");

Console.WriteLine($"byte.MaxValue = {byte.MaxValue}");
Console.WriteLine($"byte.MinValue = {byte.MinValue}");

Console.WriteLine($"short.MaxValue = {short.MaxValue}");
Console.WriteLine($"short.MinValue = {short.MinValue}");

Console.WriteLine();

// tipo_de_dados nome_da_variavel = valor;



Console.ReadKey();


namespace SistemaBancario {
    public class Gerente { 
        public string Nome {get; set; }
        public int Idade { get; set; }
        public int Cpf { get; set; }
        public void AprovarHorasDeFuncionarios(int cpf){

        }
    }
}
