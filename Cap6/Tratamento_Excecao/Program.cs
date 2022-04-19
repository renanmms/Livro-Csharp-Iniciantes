// See https://aka.ms/new-console-template for more information
Console.WriteLine("Divisão de dois números");
Console.WriteLine();

Console.WriteLine("Digite o primeiro número: ");
var strNum1 = Console.ReadLine();

Console.WriteLine("Digite o segundo número: ");
var strNum2 = Console.ReadLine();

// O bloco de código que queremos tratar fica dentro do try
try{
    int num1 = int.Parse(strNum1);
    int num2 = int.Parse(strNum2);

    var divisao = num1 / num2;
    Console.WriteLine($"A divisão de {num1} por {num2} é {divisao}");
}
// Caso a exceção seja pega o catch é executado
catch (DivideByZeroException ex){ 
    Console.WriteLine($"Erro de Divisão por Zero: {ex.Message}");
}
catch (FormatException ex){
    Console.WriteLine($"Erro de Formatação: {ex.Message}");
}
catch (Exception ex){
    Console.WriteLine($"Erro: {ex.Message}");
}
finally
{
    Console.WriteLine("Sempre vai executar o finally");
}
Console.WriteLine("Fim");