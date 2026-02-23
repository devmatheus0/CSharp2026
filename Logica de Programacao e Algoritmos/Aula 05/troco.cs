using static System.Console;
 
double precound, quantidade, dinheirorecebido, troco;

Write("Preço unitario do produto: ");
precound = double.Parse(ReadLine());
Write("Quantidade comprada: ");
quantidade = double.Parse(ReadLine());
Write("Dinheiro Recebido: ");
dinheirorecebido = double.Parse(ReadLine());

troco = dinheirorecebido -(precound*quantidade);

WriteLine($"O troco recebido é: {troco}");