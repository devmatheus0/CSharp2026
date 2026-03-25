using ExercicioDolar;
using static ExercicioDolar.Conversor;
using static System.Console;
using static System.ConsoleColor;

Title = "Converter Dolar";

Write("Qual é a cotação do dólar?: ");
ForegroundColor = Red;
double cotacao = double.Parse(ReadLine());
ResetColor();
Write("Quantos dólares você vai comprar?: ");
double qtd = double.Parse(ReadLine());
//Saída de dados

WriteLine($"Valor a ser pago em reais: {Converter(cotacao,qtd)}");