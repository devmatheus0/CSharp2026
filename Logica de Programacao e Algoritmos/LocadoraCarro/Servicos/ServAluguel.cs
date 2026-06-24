using System;
using LocadoraCarro.Entidades;

namespace LocadoraCarro.Servicos
{
    public class ServAluguel
    {
        private double precoPorDia;
        private double precoPorHora;
        private TaxaServBrasil taxaServBrasil;

        public double PrecoDia
        {
            get { return precoPorDia; }
        }

        public double PrecoHora
        {
            get { return precoPorHora; }
        }

        public ServAluguel(double precoPorHora, double precoPorDia)
        {
            this.precoPorHora = precoPorHora;
            this.precoPorDia = precoPorDia;
            this.taxaServBrasil = new TaxaServBrasil();
        }

        public void CalcularFatura(AluguelCarro aluguel)
        {
            TimeSpan duracao = aluguel.Fim - aluguel.Inicio;
            double totalHoras = duracao.TotalHours;

            double pagamentoBasico;

            if (totalHoras <= 12.0)
            {
                // Cobra por hora
                pagamentoBasico = Math.Ceiling(totalHoras) * precoPorHora;
            }
            else
            {
                // Cobra por dia (arredonda dias para cima)
                double totalDias = duracao.TotalDays;
                pagamentoBasico = Math.Ceiling(totalDias) * precoPorDia;
            }

            double percentualTaxa = taxaServBrasil.Taxa(pagamentoBasico);
            double taxa = pagamentoBasico * percentualTaxa;
            double totalPagamento = pagamentoBasico + taxa;

            aluguel.Fatura = new Fatura
            {
                PagamentoBasico = pagamentoBasico,
                Taxa = taxa,
                TotalPagamento = totalPagamento
            };
        }
    }
}
