namespace BancoMaster
{
    internal class ContaEmpresa : Conta
    {
        private int limite;

        public int LimiteConta
        {
            get { return limite; }
            set { limite = value; }
        }

        public ContaEmpresa(int numeroConta, string titularConta) : base(numeroConta, titularConta)
        {
        }

        public ContaEmpresa(int numeroConta, string titularConta, double saldoConta) : base(numeroConta, titularConta, saldoConta)
        {
        }
    }
}
