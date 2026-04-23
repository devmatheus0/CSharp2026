using Estudante.Classes.Dados;
using Estudante.Classes.Entidades;
using Microsoft.EntityFrameworkCore;

using var context = new AlunoContext();

context.Database.EnsureCreated();

Aluno pessoa1 = new Aluno("Cloadoaldo", 12345, "DEV");
context.Alunos.Add(pessoa1);
context.SaveChanges();