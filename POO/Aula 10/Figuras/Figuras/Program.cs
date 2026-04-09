using Figuras.Classes.Entidades;
using Figuras.Classes.Enumeracoes;
using static System.Console;

List<Forma> formas = new();

Write("Entre com a quantidade de formas: ");
int qtd = int.Parse(ReadLine());

for (int i = 0; i< qtd; i++)
{
    WriteLine($"Dados do objeto geometrico nº {i + 1}: ");
    Write($"Retângulo ou Círculo (R/C): ");
    char escolha = char.Parse(ReadLine().ToLower());
    if (escolha == 'r')
    {
        WriteLine("Qual é a cor do objeto?" +
            "\n\t 1 - Vermelho " +
            "\n\t2 - Azul" +
            "\n\t3 - Amarelo" +
            "\n\t4 - Rosa");
int cor = int.Parse(ReadLine());
    }
}



