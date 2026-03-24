using funcionario;
using static System.Console;
double porcentagem;

WriteLine("Digite as informações do funcionário:");

Write("Digite o nome do funcionário: ");
string nome = ReadLine();
Write("Digite o salário do funcionário: ");
double salario = double.Parse(ReadLine());
Write("Digite o valor do imposto sobre o salário funcionário: ");
double imposto = double.Parse(ReadLine());
Write("Digite a porcentagem de aumento do salário do funcionário: ");
porcentagem = double.Parse(ReadLine());
Write($"Salário do funcionário aumentado em: {porcentagem}%");



Dados f = new Dados (nome, salario, imposto);
f.aumento_porcentagem(porcentagem);
f.salario_liquido(salario - imposto);
f.Dados_atualizados(nome, salario);
