//Versão 3 - método estático
using static System.Console;
using static System.ConsoleColor;
using static Circunferencia03.Calculadora;

Title = "Calculadora 03";
Write("Digite o raio da circunferencia: ");
ForegroundColor = Red;
double raio = double.Parse(ReadLine());
ResetColor();
//Sáida de dados 
WriteLine($"Circunferencia: {Circunferencia(raio):F2}");
WriteLine($"Volume: {Volume(raio):F2}");
WriteLine($"PI: {PI}");