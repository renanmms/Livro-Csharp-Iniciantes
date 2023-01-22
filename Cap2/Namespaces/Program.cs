/*

Livro - C# para iniciantes 
Link: https://livrocsharp.com.br/wp-content/uploads/dae-uploads/CSharpIniciantes.pdf
Capítulo 2 - Criando Namespaces


Autor: github.com/renanmms
*/


global using SampleNamespace;
using System;
using PP = ProgramaPrincipal;
using Namespaces.Client;

namespace ProgramaPrincipal {

    class ClasseDois {
        public int Id {get ; set; }

        public String nome {get; set; }
    }


    interface MinhaInterface {

    }

    struct MinhaStruct {
        int x;
    }

}

// Boa prática recomendada pela Microsoft
// NomeDaEmpresa.NomeDoProjeto.CamadaDoProjeto.Funcionalidade
namespace BlueFleet.GestaoDeVeiculos.API.GET {


}


namespace SampleNamespace
{
    class SampleClass
    {
        public void SampleMethod()
        {
            System.Console.WriteLine(
                "SampleMethod inside SampleNamespace");
        }
    }
}

namespace Namespaces
{

    class ClasseDois {
        public int Id {get ; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var client = new Namespaces.Client.ClientClass();
        }
    }

    
}


