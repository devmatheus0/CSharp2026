using static System.Console;
using terreno;

Write("Digite a largura do terreno: ");
double largura = double.Parse(ReadLine());
Write("Digite o comprimento do terreno: ");
double comprimento = double.Parse(ReadLine());
Write("Digite o preço do m² do terreno: ");
double valor = double.Parse(ReadLine());

Terreno t = new Terreno(largura, comprimento, valor);

t.Saida();
ReadKey();﻿
