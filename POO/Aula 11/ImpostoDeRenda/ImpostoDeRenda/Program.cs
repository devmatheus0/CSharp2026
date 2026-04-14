using ImpostoDeRenda.Classes.Entidades;
using static System.Console;

List<Contribuintes> contribuintes = new();

WriteLine("Digite o número de contribuintes: ");
int n = int.Parse(ReadLine());

for (int i = 0; i < n; i++)
{
    Write($"Dados do contribuinte nº {i + 1}");
    Write("Escolha um dos tipos: " +
    "\n\t 1- Pessoa Física (f) +" +
    "\n\t 2- Pessoa Jurídica (j)");
    char escolha = char.Parse(ReadLine().ToLower());

    if (escolha == 'f')
    {
        Write("Digite a renda anual: ");
        double r = double.Parse(ReadLine());
        Write($"Valor do imposto a ser pago: ");
    }
}









