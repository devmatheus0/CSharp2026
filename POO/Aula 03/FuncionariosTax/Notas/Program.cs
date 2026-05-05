using Notas;
using static System.Console;
NotasAluno n = new NotasAluno();

Write("Digite Seu nome: ");
n.NomeDoAluno = ReadLine();
Write("Digite as três notas do aluno: ");
Write("Digite a 1ª nota: ");
n.Nota1 = double.Parse(ReadLine());
Write("Digite a 2ª nota: ");
n.Nota2 = double.Parse(ReadLine());
Write("Digite a 3ª nota: ");
n.Nota3 = double.Parse(ReadLine());
n.NotaFinal();
WriteLine($"Nota final do aluno: {n.NotaFinal()}");
if (n.AprovadoOuReprovado())
{
    WriteLine("Aprovado");
}
else
{
    WriteLine($"Reprovado, faltaram {n.Ponto()} pontos");
}
