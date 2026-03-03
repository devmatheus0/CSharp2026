using static System.Console;
//Declaração de variáveis
int numero_participantes, altura_pessoa, alturaMax, alturaMin;
try {
//Entrada de dados
Write ("Digite o número de pessoas: ");
numero_participantes = int.Parse(ReadLine());
Write ("Digite a altura mínima: ");
alturaMin = int.Parse(ReadLine());
Write("Digite a altura máxima: ");
alturaMax = int.Parse(ReadLine());
//Processamento de dados
for (int i = 0; i <numero_participantes; i++)
    {
        Write($"Digite a altura da pessoa número {i+1}: ");
        altura_pessoa = int.Parse(ReadLine());
        if (altura_pessoa <= alturaMax & altura_pessoa >= alturaMin)
        {
            WriteLine("Pessoa pode entrar!");
        }
        else 
        {
            WriteLine("Pessoa não pode entrar!");
        }  
        }
}
catch (Exception ex)
{
    WriteLine("Valor inválido. Erro: " + ex.Message);
}

