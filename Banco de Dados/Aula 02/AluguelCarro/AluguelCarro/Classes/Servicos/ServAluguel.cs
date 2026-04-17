using System;
using System.Collections.Generic;
using System.Text;

namespace Carros.Classes.Servicos
{
    internal class ServAluguel
    {
		//Campos
		private double PrecoPorDia;
		private double PrecoPorHora;
		private double taxServBrasil;


		//Propriedades
		protected double PrecoDia
		{
			get { return PrecoPorDia; }
			set { PrecoPorDia = value; }
		}
        protected double PrecoHora
		{
			get { return PrecoPorHora; }
			set { PrecoPorHora = value; }
		}



		//Construtor
        public ServAluguel()
        {
        }

	}
}
