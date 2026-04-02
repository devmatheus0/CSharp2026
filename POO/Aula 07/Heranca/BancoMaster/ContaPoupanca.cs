namespace BancoMaster
{
    internal class ContaPoupanca : Conta
    {
        //Campos
		private double Juros;

        //Propriedade
        public double TaxaDeJuros
        {
            get { return Juros; }
            set { Juros = value; }
        }

        //Construtores
        public ContaPoupanca(int numeroConta, string titularConta, double TaxaDeJuros) : base(numeroConta, titularConta)
        {
            TaxaDeJuros = TaxaDeJuros;
        }
        public ContaPoupanca(int numeroConta, string titularConta, double saldoConta, double TaxaDeJuros) 
        : base(numeroConta, titularConta, saldoConta)
        {
            TaxaDeJuros = TaxaDeJuros;
        }

        //Métodos
        public void Atualizacao()
        {
            SaldoConta = SaldoConta + (SaldoConta * TaxaDeJuros);
        }
        
        public override void Saque (double qtd)
        {
            SaldoConta -= qtd;
        }
	}
}
