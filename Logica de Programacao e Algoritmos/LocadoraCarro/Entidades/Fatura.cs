namespace LocadoraCarro.Entidades
{
    public class Fatura
    {
        private double pagamentoBasico;
        private double taxa;
        private double totalPagamento;

        public double PagamentoBasico
        {
            get { return pagamentoBasico; }
            set { pagamentoBasico = value; }
        }

        public double Taxa
        {
            get { return taxa; }
            set { taxa = value; }
        }

        public double TotalPagamento
        {
            get { return totalPagamento; }
            set { totalPagamento = value; }
        }

        public override string ToString()
        {
            return $"FATURA:\n" +
                   $"Pagamento basico: {pagamentoBasico:F2}\n" +
                   $"Taxa: {taxa:F2}\n" +
                   $"Pagamento total: {totalPagamento:F2}";
        }
    }
}
