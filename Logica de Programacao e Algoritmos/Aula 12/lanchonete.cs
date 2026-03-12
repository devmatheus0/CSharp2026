using static System.Console;
//Declaração de variáveis
int codigo, quantidade;
//Declaração do dicionário
Dictionary<int, double> clanche = new Dictionary<int, double>()
//Adicionando dados ao dicionario

{
    {1, 5.00},
    {2, 3.50},
    {3, 4.80},
    {4, 8.90},
    {5, 7.32}
};

try {
//Entrada de dados
WriteLine("Digite o código do seu lanche: ");
codigo = int.Parse(ReadLine());
WriteLine("Digite a quantidade que quer levar: ");
quantidade = int.Parse(ReadLine());
WriteLine($"O total do pedido é de:  {quantidade * clanche[codigo]}");
}

catch (Exception ex) {
    Write($"Valor inválido, tente novamente, erro: {ex.Message}" );
};












