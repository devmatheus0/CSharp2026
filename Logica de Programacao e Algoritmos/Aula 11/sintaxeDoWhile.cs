using static System.Console;

int n = 0;

do
{
    Write(n);
    n++;
    Task.Delay(1000).Wait(); //Trava o código TASK CLASSE - DELAY MÉTODO  
}while (n < 5);
WriteLine("Fim pogama");
n = 0;
while (n < 5)
{
     Write(n);
    n++;
    Task.Delay(1000).Wait();
}
WriteLine("Fim pogama 2");