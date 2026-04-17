using static System.Console;

Write("Entre com a data do aluguel do carro: ");
DateTime data = DateTime.Parse(ReadLine());
Write("Digite o nome do modelo do carro: ");
string modelo = ReadLine();
Write("Digite a data da retirada: ");
DateTime retirada = DateTime.Parse(ReadLine());
Write("Digite a data de devolução: ");
DateTime devolucao = DateTime.Parse(ReadLine());
Write("Entre com o preco por hora: ");
double phora = double.Parse(ReadLine());
Write("Entre com o preco por dia: ");
double pdia = double.Parse(ReadLine());

