using static System.Console;
//Declaração de variáveis
int primeiroValor, segundoValor, terceiroValor;
//Entrada de dados
Write("Digite o primeiro valor: ");
primeiroValor = int.Parse(ReadLine());
Write("Digite o segundo valor: ");
segundoValor = int.Parse(ReadLine());
Write("Digite o terceiro valor: ");
terceiroValor = int.Parse(ReadLine());
//Saída de dados

bool resultado1 = primeiroValor == terceiroValor;
bool resultado2 = segundoValor != primeiroValor;
bool resultado3 = segundoValor > terceiroValor;
bool resultado4 = primeiroValor <= terceiroValor;

WriteLine($"1- O primeiro valor é igual ao terceiro valor? R:{resultado1}");
Write("");
WriteLine($"2- O segundo valor é diferente do primeiro valor? R:{resultado2}");
Write("");
WriteLine($"3 - O segundo valor é maior que o terceiro valor? R:{resultado3}");
Write("");
WriteLine($"4 - O primeiro valor é menor ou igual que terceiro valor? R:{resultado4}");

Write("");


bool resposta1 = resultado1 & resultado3;
WriteLine($" --> A comparação da primeira e terceira pergunta é verdadeira? R: {resposta1} ");
Write("");
bool resposta2 = resultado2 | resultado4;
WriteLine($"--> A comparação da segunda pergunta e quarta pergunta pelo menos uma é verdadeira? R: {resposta2} ");
Write("");
bool resposta3 = !resultado1;
WriteLine($"--> A negação da primeira pergunta é verdadeira? R: {resposta3} ");
 







