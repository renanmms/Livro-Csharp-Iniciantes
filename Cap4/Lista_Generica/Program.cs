// See https://aka.ms/new-console-template for more information

// Declarando lista do tipo inteiro
ListaGenerica<int> lista1 = new ListaGenerica<int>();

// Declarando lista do tipo string
ListaGenerica<string> lista2 = new ListaGenerica<string>();

// Declarando lista de uma classe
ListaGenerica<ExampleClass> lista3 = new ListaGenerica<ExampleClass>();

private class ExampleClass {}

public class ListaGenerica<T>{
    public void Adicionar(T input){ }
}
