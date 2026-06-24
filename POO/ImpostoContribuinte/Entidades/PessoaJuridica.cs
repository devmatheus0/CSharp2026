namespace ImpostoContribuinte.Entidades
{
    public class PessoaJuridica : Contribuinte
    {
        private int _numFuncionarios;

        public int NumFuncionarios
        {
            get { return _numFuncionarios; }
            set { _numFuncionarios = value; }
        }

        public PessoaJuridica(string nome, double rendaAnual, int numFuncionarios)
            : base(nome, rendaAnual)
        {
            _numFuncionarios = numFuncionarios;
        }

        public override double CalcularImposto()
        {
            double aliquota = _numFuncionarios > 10 ? 0.14 : 0.16;
            return RendaAnual * aliquota;
        }
    }
}
