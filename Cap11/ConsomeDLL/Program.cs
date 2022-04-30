// See https://aka.ms/new-console-template for more information
using static System.Console;
using System;
using CompDLL;

int valorFat = 100000;
int diasFat = 50;
CalculoGeral objFat = new CalculoGeral(){ valor = valorFat, dias = diasFat};

WriteLine($"Faturamento: {objFat.valor:n0} - dias {objFat.dias} - Média: {objFat.FaturamentoMedioDiario():n0}");

double valorSeguro = 2500;
var corVerde = DescontoGeral.Cores.Verde;
var corAzul = DescontoGeral.Cores.Azul;
var corVermelho = DescontoGeral.Cores.Vermelho;

WriteLine("------ DESCONTO POR CORES ------");
WriteLine($"R$ bruto: {valorSeguro:n0} - desconto {corAzul}: {DescontoGeral.DescontoPorCor(valorSeguro, corAzul):n0}"); //
WriteLine($"R$ bruto: {valorSeguro:n0} - desconto {corVerde}: {DescontoGeral.DescontoPorCor(valorSeguro, corVerde):n0}");
WriteLine($"R$ bruto: {valorSeguro:n0} - desconto {corVermelho}: {DescontoGeral.DescontoPorCor(valorSeguro, corVermelho):n0}");