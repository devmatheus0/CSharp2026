namespace BancoMaster
{
    internal class Conta
    {
		private int numero;
		private string titular;
		private double saldo;
        

        public int NumeroConta
		{
			get { return numero; }
			set { numero = value; }
		}

		public string TitularConta
		{
			get { return titular; }
			set { titular = value; }
		}
		public double SaldoConta
		{
			get { return saldo; }
			set { saldo = value; }
		}
        public Conta(int numeroConta, string titularConta, double saldoConta)
        {
            NumeroConta = numeroConta;
            TitularConta = titularConta;
            SaldoConta = saldoConta;
        }

        public Conta(int numeroConta, string titularConta)
        {
            NumeroConta = numeroConta;
            TitularConta = titularConta;
        }

		public void Saque(double quantia)
		{
			SaldoConta -= quantia - TaxaJuros;
		}
        public void Deposito(double quantia)
        {
            SaldoConta += quantia;
        }

  

        public override string ToString()
        {
            return $"Dados da sua conta: " +
            $"\n\t Número da conta: {NumeroConta}" +
            $"\n\t Titular da conta: {TitularConta}" +
            $"\n\t Saldo da conta: {SaldoConta:C}";
         
        }
    }
}
