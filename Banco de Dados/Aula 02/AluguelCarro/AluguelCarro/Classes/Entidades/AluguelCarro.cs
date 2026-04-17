using System;
using System.Collections.Generic;
using System.Text;

namespace Carros.Classes.Entidades
{
    internal class AluguelCarro
    {
		//Campos

		private DateTime inicio;
		private DateTime fim;
		private DateTime veiculo;


        //Propriedades
        public DateTime Veiculo
		{
			get { return veiculo; }
			set { veiculo = value; }
		}


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

		//Construtor
		public AluguelCarro()
        {
        }

	}
}
