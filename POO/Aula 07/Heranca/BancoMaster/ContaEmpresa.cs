namespace BancoMaster
{
    internal class ContaEmpresa : Conta
    {
        //Campo
        private double limite;



        //Propriedade

        public double LimiteDeEmprestimo
        {
            get { return limite; }
            set { limite = value; }
        }

       //Construtor
        public ContaEmpresa(int numeroConta, string titularConta, double limite) 
        : base(numeroConta, titularConta)
        {
            LimiteDeEmprestimo = limite;
        }

        public ContaEmpresa(int numeroConta, string titularConta, double saldoConta, double limite)
        : base(numeroConta, titularConta, saldoConta)
        {
            LimiteDeEmprestimo = limite;
        }

        //Método
        public void Emprestimo (double qtd)
        {
            LimiteDeEmprestimo -= qtd;
            SaldoConta += qtd;
        }


    }
}
