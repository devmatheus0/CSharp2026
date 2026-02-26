using static System.Console;
//declaração de variaveis
double valorA, valorB, valorC, areaTriangulo, perimetroTriangulo, areaTrapezio;
//Entrada de dados
Write("Digite o valor de A:");
valorA = double.Parse(ReadLine());
Write("Digite o valor de B:");
valorB = double.Parse(ReadLine());
Write("Digite o valor de C:");
valorC = double.Parse(ReadLine());
//Processamento de dados
perimetroTriangulo = (valorA + valorB +valorC) /2;
areaTriangulo = Math.Sqrt(perimetroTriangulo * (perimetroTriangulo-valorA) *(perimetroTriangulo-valorB) * (perimetroTriangulo-valorC));
areaTrapezio = ((valorA + valorB ) *valorC)/2;
//Estrutura de controle de dados
if (valorA < valorB + valorC & valorB < valorA + valorC & valorC < valorA +valorB )
{
    WriteLine("Com base nos cálculos isso é um triangulo!");
    Write ($"A área do triângulo é {areaTriangulo} ");
}
else 
{
    WriteLine("Isso definitivamente não é um trapézio!");
    WriteLine($"Calculando a área do trapézio o resultado é: {areaTrapezio}");
}
