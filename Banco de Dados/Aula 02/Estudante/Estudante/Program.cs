using Estudante.Classes.Dados;
using Estudante.Classes.Entidades;
using Microsoft.EntityFrameworkCore;

using var context = new AlunoContext();

context.Database.EnsureCreated();
//Adicionar dados ao banco de dados
Aluno pessoa1 = new Aluno("Cloadoaldo", 12345, "Python");
context.Alunos.Add(pessoa1);
context.SaveChanges();

//Exibir o dado
var pessoas = context.Alunos.FirstOrDefault(c => c.id == 1);
pessoas.ExibirDados();

//Update
pessoas = context.Alunos.FirstOrDefault(c => c.id == 2);
pessoas.Curso = "BackEnd";
context.SaveChanges();