using System;
using System.Collections.Generic;

namespace ExemploFunc
{
    public class Carro
    {
        public int ID { get; set; }
        public string Modelo { get; set; }
        public int Litros { get; set; }
        public double KmRodados { get; set; }
        public int AnoFabricacao { get; set; }
        public string Cor { get; set; }

        public double Consumo() => KmRodados / Litros;
        public string ConsumoString() => Litros > 0 ? $"{Consumo():n2}" : "----";
        public int Idade() => DateTime.Today.Year - AnoFabricacao;
        public override string ToString() => $"{ID} - {Modelo}";
        public static List<Carro> Get(){
            return new List<Carro> 
            {
                new Carro{ID = 1, Modelo = "Honda civic", AnoFabricacao = 2000, KmRodados = 22000, Cor = Cores.Azul.ToString(), Litros = 24},
                new Carro{ID = 2, Modelo = "Ford GT", AnoFabricacao = 2015, KmRodados = 14000, Cor = Cores.Verde.ToString(), Litros = 32},
                new Carro{ID  = 3, Modelo = "BMW X1", AnoFabricacao = 2017, KmRodados = 1000, Cor = Cores.Vermelho.ToString()}
            };

        }
    }
    enum Cores {
        Vermelho = 1,
        Verde = 2,
        Azul = 3
    }
}