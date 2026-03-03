using static System.Console;

//Declaração de variáveis
int numero;
//Entrada de dados
numero = int.Parse(ReadLine());
//Processamento de dados
for (int i = 0; i <10; i++)
{
    //Saida de dados
    WriteLine($"{numero} x {i+1} = {numero * (i+1)}");
}