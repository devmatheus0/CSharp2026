using System;
using System.Collections.Generic;
using System.Text;

namespace Carros.Classes.Entidades
{
	internal class Fatura
	{
		//Campos
		private int pagamentobasico;
		private int taxa;
		private int totalPagamento;

		//Propriedades
        public int PagamentoBasico
		{
			get { return pagamentobasico; }
			set { pagamentobasico = value; }
		}
		public int Taxa
		{
			get { return taxa; }
			set { taxa = value; }
		}

		protected int TotalPagamento
		{
			get { return totalPagamento; }
			set { totalPagamento = value; }
		}

		//Construtor
        public Fatura()
        {
        }

	}
}
