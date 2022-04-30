using System;

namespace CompDLL
{
    public class DescontoGeral
    {
        public enum Cores
        {
            Vermelho = 1,
            Verde = 2,
            Azul = 3
        };

        public static double DescontoPorCor(double valor, Cores cor) => 
            // Sintaxe moderna do switch
            cor switch 
            {
                Cores.Vermelho => valor * 0.9,
                Cores.Verde => valor * 0.8,
                Cores.Azul => valor * 0.7,
                _ => valor,
            };
    }
}