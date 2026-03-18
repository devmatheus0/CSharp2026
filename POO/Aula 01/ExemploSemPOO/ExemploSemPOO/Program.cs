using System.ComponentModel.Design;
using static System.Console;
Title = "Calculadora de triângulo";
//Entrada de dados
WriteLine("Digite as medidas do triâgulo X");
Write("Digite o valor de a: ");
double ax = double.Parse(ReadLine());
Write("Digite o valor de b: ");
double bx = double.Parse(ReadLine());
Write("Digite o valor de c: ");
double cx = double.Parse(ReadLine());

WriteLine("Digite as medidas do triâgulo Y");
Write("Digite o valor de a: ");
double ay = double.Parse(ReadLine());
Write("Digite o valor de b: ");
double by = double.Parse(ReadLine());
Write("Digite o valor de c: ");
double cy = double.Parse(ReadLine());

//Processamento de dados
double px = (ax + bx + cx) / 2;
double py = (ay + by + cy) / 2;
double areax = Math.Sqrt(px * (px-ax) * (px - bx ) * (px - cx));
double areay = Math.Sqrt(px * (px-ay) * (px - by ) * (px - cy));

//Saída de dados
WriteLine($"A área do triângulo x é de {areax:F2}");
WriteLine($"A área do triângulo y é de {areay:F2}");


if (areax > areay){
    WriteLine("Maior área é do Triangulo X");
}
else if (areay > areax) {
    WriteLine("Maior área é do Triangulo Y");
}
    
else
{
    WriteLine("Os triangulos de áreas iguais");
}
ReadKey();