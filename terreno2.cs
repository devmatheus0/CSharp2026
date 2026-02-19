using static System.Console;

Write("Vamos calcular a área e encontrar o valor do  nosso terreno!");
Write("Digite a largura do terreno: ");
double x = double.Parse(ReadLine());
Write("Digite o comprimento do terreno: ");
double y = double.Parse(ReadLine());
Write("Digite o valor do m² do terreno: ");
double valor = double.Parse(ReadLine());

//----------------//
//processamento de dados
double conta = (x*y) * valor; 
// Saida de dados
Write($"O valor do terreno é igual {conta} ");


