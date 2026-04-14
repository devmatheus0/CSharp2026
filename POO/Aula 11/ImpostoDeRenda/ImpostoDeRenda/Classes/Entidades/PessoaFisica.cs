using ImpostoDeRenda.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace ImpostoDeRenda.Classes.Entidades
{
    internal class PessoaFisica : Contribuintes
    {
        //Campo
		private double gastos;

        //Propriedades
        public double GastosComSaude
		{
			get { return gastos; }
			set { gastos = value; }
		}

        //Construtor
        public PessoaFisica(string nome, double rendaAnual, double gastosComSaude) : base(nome, rendaAnual)
        {
            GastosComSaude = gastosComSaude;
        }

        public override double imposto()
        {
           
        }
    }
}
