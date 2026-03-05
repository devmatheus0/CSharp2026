using static System.Console;
//Declaração de variáveis
int turistas = 0, entrada, saida, contagem = 0;
//Data e hora
DateTime data = DateTime.Now;
WriteLine("APLICATIVO DE CONTROLE DE FLUXO DE CARROS");
WriteLine("Parque Nacional os Lençois Maranhenses");
WriteLine("");
WriteLine("Bem-vindo ao aplicativo de controle de fluxo de carros!");

while (true){
{
    try
    {
    //Entrada de dados
    WriteLine("Digite o fluxo de carro (entrada/saida) ou sair para encerrar a aplicação: ");
    string fluxo = ReadLine(); 
    if (fluxo == "entrada")
        {
           Write("Digite o número de turistas: ");
            entrada = int.Parse(ReadLine());
            WriteLine($"Entrada registrada em {data}");
            WriteLine($"Entrada registrada de {entrada} turistas");
            contagem += entrada;
        }
        else if (fluxo == "saida")
        {
            Write("Digite o número de turistas: ");
            saida = int.Parse(ReadLine());
            WriteLine($"Saida registrada em {data}");
            WriteLine($"Saida registrada de {saida} turistas");
            contagem -= saida;
        }
        else if (fluxo == "sair")
        {
            WriteLine("Saindo do aplicativo...");
            Write("Aplicativo encerrado");
        }
        else
            {
                WriteLine ("Valor inválido, tente novamente!");
            }

            WriteLine ($"Numéro de turistas no parque: {contagem}");

    }

    
  catch (Exception ex)
{
    WriteLine($"Valor inválido. Erro {ex.Message}");
}
}
}