//Entrada de dados
/*-----------------------*/
Console.WriteLine("Digite o seu nome:");
string nome = Console.ReadLine(); //Entrada de dados
System.Console.WriteLine($"O valor digitado é de {nome}");
System.Console.WriteLine("Digite o primeiro número:");
double x = double.Parse(Console.ReadLine()); //Entrada de dados
System.Console.WriteLine("Digite o segundo número: ");
double y = double.Parse(Console.ReadLine()); //Conversão de dados
/*-----------------------*/
//Processamento de dados
/*-----------------------*/
double soma = x + y;
/*-----------------------*/
//Saída de dados
/*-----------------------*/
System.Console.WriteLine($"A soma dos dois valores é de {soma}");
/*-----------------------*/