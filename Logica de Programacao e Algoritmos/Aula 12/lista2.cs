//Exercicio de lista com a estrutura de repetição for
using static System.Console;

//Declaração de variáveis
int n; //guarda o repetir
List <double> numeros = new List<double>(); //instância
Write("Quantos números você vai digitar: ");
n = int.Parse(ReadLine());

for(int i = 0; i <n; i++)
{
    Write("Digite um número: ");
    numeros.Add(double.Parse(ReadLine()));
}

Write("Valores = ");

for (int i = 0; i < n; i++)
{
    Write ($" {numeros[i]}");
}

Write($"\nSoma =  {numeros.Sum()}");
Write($"\nMédia = {numeros.Average()}");
