using static System.Console;

//Declaração de variáveis
double Base, altura, area, perimetro, diagonal;
//Entrada de dados
perimetro = 18;
diagonal = 6.4031;
Write("Digite a base do retângulo: ");
Base = double.Parse(ReadLine());
Write("");
Write("Digite a altura do retângulo:");
altura = double.Parse(ReadLine());
Write("");
area = Base * altura;
Write($"A área do retângulo é igual a: {area}\n");
WriteLine("");
Write("A hipotenusa do retângulo é igual a: " + Math.Sqrt(Math.Pow(Base, 2) + Math.Pow(altura, 2)));




