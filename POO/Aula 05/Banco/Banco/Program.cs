using Banco;
using static System.Globalization.CultureInfo;
using static System.Console;
try
{
    Title = "Abertura de conta";
ContaBancaria conta;


WriteLine("Abertura de conta - Nika Investiment");
Write("Entre com um número de conta: ");
int numero = int.Parse(ReadLine());
Write("Entre com o nome do titular: ");
string nome = ReadLine();
Write("Deseja fazer depósito inicial (s/n): ");
char resposta = char.Parse(ReadLine().ToLower());

if ( resposta == 's')
{
    Write("Entre com o valor do depósito inicial: R$ ");
    double deposito = double.Parse(ReadLine());
    conta = new ContaBancaria(numero, nome, deposito);
    
}
else
{
    conta = new ContaBancaria (numero, nome);
}

conta.Dados();

WriteLine("Entre com um valor para depósito: R$ ");
double quantia = double.Parse(ReadLine());
conta.deposito(quantia);
    conta.Dados();
WriteLine("Entre com um valor para saque: R$ ");
quantia = double.Parse(ReadLine());
conta.Saque(quantia);
    conta.Dados();
ReadKey();
}
catch (Exception ex) 
{
    WriteLine($"Informações não encontradas ou digitadas incorretamente! tente novamente! {ex.Message}");
}
