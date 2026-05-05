namespace FuncionariosTax
{
    internal class Dados
    {
        public string nome;
        public double salario;
        public double imposto;

        // Construtor
        public Dados(string nome, double salario, double imposto)
        {
            this.nome = nome;
            this.salario = salario;
            this.imposto = imposto;
        }

        
        public double SalarioLiquido()
        {
            return salario - imposto;
        }

        
        public void AumentarSalario(double porcentagem)
        {
            salario = salario + (salario * porcentagem / 100);
        }
    }
}