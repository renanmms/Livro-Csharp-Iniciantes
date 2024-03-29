﻿// See https://aka.ms/new-console-template for more information
using static System.Console;

try
{
    string produto = "peixe";
    DateTime lancto = new DateTime(2010, 2, 18);
    WriteLine($"o {produto} tem {idade(lancto.Year)} anos");
    // WriteLine($"o {produto} tem {idade(2023)} anos");

    WriteLine($"o {produto} tem {PescaAutorizada(lancto.Month, lancto.Day)}"); 
    WriteLine($"o {produto} tem {PescaAutorizada(7, 18)}");
}
catch (Exception ex)
{
    WriteLine(ex.Message);
}

static int idade(int pAno)
{
    if(pAno > DateTime.Today.Year)
    {
        throw new Exception($"ano invalido {nameof(pAno)}");
    }
    return DateTime.Today.Year - pAno;
}

static string PescaAutorizada(int pMes, int pDia){
    if(pDia < 16){
        throw new Exception($"primeira quinzena {nameof(pDia)}");
    }
    if(pMes >= 5 && pMes <= 8){
        throw new Exception($"pesca no inverno {nameof(pMes)}");
    }
    return "Pesca autorizada";
}