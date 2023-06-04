var pratosSujos = new Stack<string>();

pratosSujos.Push("Prato 1");
pratosSujos.Push("Prato 2");
pratosSujos.Push("Prato 3");

Console.WriteLine($"Pratos Sujos: {pratosSujos.Peek()}"); // Pratos Sujos: Prato 3

var pratosLimpos = new Stack<string>();


Console.WriteLine("Lavando prato...");
pratosLimpos.Push(LavarPrato(pratosSujos));

Console.WriteLine($"Pratos Limpos: {pratosLimpos.Peek()}"); // Pratos Limpos: Prato 3
Console.WriteLine($"Pratos Sujos: {pratosSujos.Peek()}"); // Pratos Sujos: Prato 2

string LavarPrato(Stack<string> prato){
    return prato.Pop();
}