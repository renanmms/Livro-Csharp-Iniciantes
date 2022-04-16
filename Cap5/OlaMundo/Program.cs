// See https://aka.ms/new-console-template for more information

// Criamos o objeto Pedido herdado da classe InteracaoUsuario
InteracaoUsuario Pedido = new InteracaoUsuario();

// Invocamos os métodos do objeto Pedido herdado da classe Mãe InteracaoUsuario
var Digitado = Pedido.SolicitarDigitacao();
Pedido.MostrarDigitacao(Digitado);


class InteracaoUsuario {
    public string SolicitarDigitacao()
    {
        return Console.ReadLine();
    }
    public void MostrarDigitacao(string Digitado)
    {
        Console.WriteLine(Digitado);
    }
}