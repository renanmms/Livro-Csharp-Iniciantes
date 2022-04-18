// See https://aka.ms/new-console-template for more information
using MinhaClasseUsuario;

// Criamos o objeto pedido herdado da clase InteracaoUsuario
InteracaoUsuario Pedido = new InteracaoUsuario();

// Invocamos os métodos do objeto Pedido herdade da classe mãe InteracaoUsuario
Pedido.SolicitarDigitacao();
Pedido.MostrarDigitacao();

// Recuperamos pelo método GET o valor da mensagem digitada para futura manipulação
var Digitado = Pedido.Mensagem;

Console.WriteLine($"Nova Digitação sem Espaços -> " + Digitado.ToUpper());