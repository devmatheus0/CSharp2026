using static System.Console;
//Declaração de variáveis
int numero, valor;
try
{
    //Entrada de dados
    Write("Quantos números você vai digitar?: ");
    numero = int.Parse(ReadLine());
    //Processamento de dados
    for (int i = 0; i <numero; i++)
    {
        Write("Digite um número: ");
        valor = int.Parse(ReadLine());
        if (valor < 0)
        {
                WriteLine("Negativo");
        }
        else if (valor > 0)
        {
            WriteLine("Positivo");
        }
        else
        {
            WriteLine("Nulo");
        }

        if ((valor % 2) == 0)
        {
            WriteLine ("PAR");
        }
        else if ((valor % 2) != 0)
        {
            WriteLine ("IMPAR");
        }

    }
}
catch (Exception ex)
{
    WriteLine("Valor invalido, erro =", ex.Message);
}