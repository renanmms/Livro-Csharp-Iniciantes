using System;
using Xunit;

namespace Loja.Tests;
using Loja;

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
        Assert.Equal(10, valor);
    }
    
    [Fact]
    public void SeProdutoForVerdeDesconto20Porcento()
    {
        // Preparar
        var desconto = new Desconto();

        // Executar
        var valor = desconto.Calcule(Cor.Verde);

        // Verificar
        Assert.Equal(20, valor);


    }

    [Fact]
    public void SeProdutoForAzulDesconto30Porcento(){
        // Preparar 
        var desconto = new Desconto();

        // Executar
        var valor = desconto.Calcule(Cor.Azul);

        // Verificar
        Assert.Equal(30, valor);
    }
    
    [Fact]
    public void SeProdutoForLaranjaNaoHaDesconto(){
        // Preparar
        var desconto = new Desconto();

        // Executar
        var valor = desconto.Calcule(Cor.Laranja);

        // Verificar
        Assert.Equal(0, valor);
    }
}