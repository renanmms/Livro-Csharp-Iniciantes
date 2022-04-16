using static System.Console;

// See https://aka.ms/new-console-template for more information
int[] primeirArray = new int[5];
int[] segundArray = new int[] {1, 3, 5, 7, 9};


string s;

for(int i = 0; i < primeirArray.Length - 1; i++){
    primeirArray[i] = Convert.ToInt32(ReadLine());
}

// somando elementos
int soma = 0;
foreach(int n in primeirArray){
    soma += n;
}

WriteLine($"Soma dos elementos do primeiro Array: {soma}");
WriteLine($"Acessando a posição 0 -> {segundArray[0]}");


