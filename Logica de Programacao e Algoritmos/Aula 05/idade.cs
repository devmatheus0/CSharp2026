using static System.Console;

int ano, meses, dias;

Write("Digite a idade em dias: ");
dias = int.Parse(ReadLine());

ano = dias / 365;
meses = (dias % 365) / 30;  
dias = (dias % 365) % 30;

WriteLine($"Sua idade em anos é {ano} ano (s) ");
WriteLine($"Sua idade em meses é {meses} mes (es)");
WriteLine($"Sua idade em dias é {dias} dia (as)");
