/*

Livro - C# para iniciantes 
Link: https://livrocsharp.com.br/wp-content/uploads/dae-uploads/CSharpIniciantes.pdf
Capítulo 2 - Criando Namespaces


Autor: github.com/renanmms
*/


using System;
using PP = ProgramaPrincipal;

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

namespace Namespaces
{

    class ClasseDois {
        public int Id {get ; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //ClasseUm c1 = new ClasseUm();
            ClasseDois c1 = new ClasseDois(); // Classe do namespace 'Namespaces'
            // Acessando membros de um namespace
            PP.ClasseDois c2 = new PP.ClasseDois();
            c1.Id = 2;
            c2.Id = 3;
            c2.nome = "Classe 2";

            Console.WriteLine(c1.Id);
            Console.WriteLine($"{c2.nome}");
            Console.WriteLine($"{c2.Id}");
        }
    }
}
