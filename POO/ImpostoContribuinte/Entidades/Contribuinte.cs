using ImpostoContribuinte.Interfaces;

namespace ImpostoContribuinte.Entidades
{
    public abstract class Contribuinte : IImposto
    {
        private string _nome;
        private double _rendaAnual;

        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        public double RendaAnual
        {
            get { return _rendaAnual; }
            set { _rendaAnual = value; }
        }

        protected Contribuinte(string nome, double rendaAnual)
        {
            _nome = nome;
            _rendaAnual = rendaAnual;
        }

        public abstract double CalcularImposto();
    }
}
