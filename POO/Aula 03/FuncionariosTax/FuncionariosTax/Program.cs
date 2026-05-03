using FuncionariosTax;
using static System.Console;

Write("Digite o nome do funcionario: ");
string nome = ReadLine();
Write("Digite o salário bruto do funcionario: ");
double salario = double.Parse(ReadLine());
Write("Digite o valor total de imposto a pago pelo funcionario: ");
double imposto = double.Parse(ReadLine());

Dados f = new Dados(nome, salario, imposto);

WriteLine("\nDados do funcionario");
WriteLine($"\tNome do funcionario: {f.nome}");
WriteLine($"\tSalario liquido: {f.SalarioLiquido():C}");

Write("\nDigite a porcentagem de aumento do salario do funcionario: ");
double porcentagem = double.Parse(ReadLine());

f.AumentarSalario(porcentagem);

WriteLine($"\nSalário do funcionario aumentado em {porcentagem:F2} %");
WriteLine("\nDados do funcionario atualizados");
WriteLine($"\tNome do funcionario: {f.nome}");
WriteLine($"\tSalario liquido: {f.SalarioLiquido():C}");