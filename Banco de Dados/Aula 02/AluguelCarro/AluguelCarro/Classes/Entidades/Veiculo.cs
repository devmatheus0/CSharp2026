using System;
using System.Collections.Generic;
using System.Text;

namespace Carros.Classes.Entidades
{
	internal class Veiculo
	{
		//Campos
		private int modelo;

		//Propriedades
        protected int Modelo
		{
			get { return modelo; }
			set { modelo = value; }
		}

		//Contrutor
        public Veiculo()
        {
        }

	}
}
