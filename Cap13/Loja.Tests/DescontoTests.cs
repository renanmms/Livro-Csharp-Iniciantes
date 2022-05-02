using Xunit;

namespace Loja.Tests;

public class DescontoTests
{
    [Fact]
    public void SeProdutoForVermelhoDescontoDe10Porcento()
    {
        // Preparar
        var desconto = new Desconto();

        // Executar
        var valor = desconto.Calcule(Cor.Vermelho);

        // Verificar
        
    }
}