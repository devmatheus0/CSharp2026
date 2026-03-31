namespace BancoMaster
{
    internal class ContaPoupanca : Conta
    {
		private int TaxaJuros;

        public double taxa
		{
			get { return TaxaJuros; }
			set { TaxaJuros = 5; }
		}

        public ContaPoupanca(int numeroConta, string titularConta) : 
        base(numeroConta, titularConta)
        {

        }

        public ContaPoupanca(int numeroConta, string titularConta, double saldoConta) : 
        base(numeroConta, titularConta, saldoConta)
        {
        }





	}
}
