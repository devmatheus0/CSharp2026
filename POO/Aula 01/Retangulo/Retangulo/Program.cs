using static System.Console;
using Retangulo;

retangulo x = new retangulo();
retangulo y = new retangulo();


WriteLine("Digite as medidas do retângulo X!");

Write("Digite o comprimento do retângulo: ");
x.Base = double.Parse(ReadLine());
Write("Digite o valor da altura: ");
x.Altura = double.Parse(ReadLine());

WriteLine("Digite as medidas do retângulo Y!");

Write("Digite o comprimento do retângulo Y: ");
y.Base = double.Parse(ReadLine());
Write("Digite o valor da altura do retângulo Y: ");
y.Altura = double.Parse(ReadLine());

WriteLine($"O perímetro do Retângulo X é igual a: {x.Perimetro()}"); 
WriteLine($"A área do Retângulo X é igual: {x.Area()}");
WriteLine($"A Diagonal do Retângulo X é igual: {x.Diagonal()}");
WriteLine($"O perímetro do Retângulo Y é igual a: {y.Perimetro()}");
WriteLine($"A área do Retângulo Y é igual: {y.Area()}");
WriteLine($"A Diagonal do Retângulo Y é igual: {y.Diagonal()}");