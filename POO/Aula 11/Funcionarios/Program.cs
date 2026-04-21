using funcionario;
using static System.Console;

WriteLine("Digite as informações do funcionário:");

Write("Digite o nome do funcionário: ");
string nome = ReadLine();
Write("Digite o salário do funcionário: ");
double salario = double.Parse(ReadLine());
Write("Digite o valor do imposto sobre o salário funcionário: ");
double imposto = double.Parse(ReadLine());

WriteLine("Dados do funcionário");
WriteLine($"Nome do funcionario: {nome}");
WriteLine($"Salario do funcionario: {salario - imposto}");
Dados f = new Dados(nome, salario, imposto);

WriteLine("Digite a porcentagem de aumento do salário do funcionário: ");
double porcentagem = double.Parse(ReadLine());
WriteLine($"Salário do funcionário aumentado em: {f.aumento_porcentagem}%");

f.aumento_porcentagem(porcentagem);
f.salario_liquido(salario);
f.Dados_atualizados(nome, salario);

WriteLine($"Dados do funcionário atualizados!" +
    $"{f.Dados_atualizados(nome, salario)}");


