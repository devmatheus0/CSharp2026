//tupla

var clodoaldo = (34, 5000.34, "Heitor", "SENAI Americana", 'B');

System.Console.WriteLine($"Idade do clodoaldo: {clodoaldo.Item1}");
System.Console.WriteLine($"nome do filme do clodo: {clodoaldo.Item3}");

clodoaldo.Item1 = 54;
System.Console.WriteLine($"Idade do clodoaldo: {clodoaldo.Item1}");

(int,int,int) numeros = (1, 2, 5);
System.Console.WriteLine($"numeros {numeros.Item1},{numeros.Item2}, {numeros.Item3} ");