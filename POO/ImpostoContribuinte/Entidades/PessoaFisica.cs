namespace ImpostoContribuinte.Entidades
{
    public class PessoaFisica : Contribuinte
    {
        private double _gastosComSaude;

        public double GastosComSaude
        {
            get { return _gastosComSaude; }
            set { _gastosComSaude = value; }
        }

        public PessoaFisica(string nome, double rendaAnual, double gastosComSaude)
            : base(nome, rendaAnual)
        {
            _gastosComSaude = gastosComSaude;
        }

        public override double CalcularImposto()
        {
            double aliquota = RendaAnual < 20000.00 ? 0.15 : 0.25;
            double imposto = RendaAnual * aliquota;
            double deducao = _gastosComSaude * 0.50;
            return imposto - deducao;
        }
    }
}
