using static System.Console;

WriteLine("Bem vindo ao Banco Master!");
WriteLine("Qual tipo de conta você deseja abrir?:\n\t 1 - Conta Poupança" +
    "\n\t2 - Conta Empresa");

int tipoconta = int.Parse(ReadLine());
if (tipoconta == 1)
{
    WriteLine("Você escolheu Poupança!");
}
