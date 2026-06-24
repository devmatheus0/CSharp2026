using System;

namespace LocadoraCarro.Entidades
{
    public class AluguelCarro
    {
        private DateTime fim;
        private DateTime inicio;
        private Veiculo veiculo;

        public DateTime Fim
        {
            get { return fim; }
            set { fim = value; }
        }

        public DateTime Inicio
        {
            get { return inicio; }
            set { inicio = value; }
        }

        public Veiculo Veiculo
        {
            get { return veiculo; }
            set { veiculo = value; }
        }

        public Fatura Fatura { get; set; }

        public AluguelCarro(DateTime inicio, DateTime fim, Veiculo veiculo)
        {
            this.inicio = inicio;
            this.fim = fim;
            this.veiculo = veiculo;
        }
    }
}
