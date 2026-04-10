using ImpostoDeRenda.Classes.Contratos;
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
        public PessoaFisica(string nome, double rendaAnual) : base(nome, rendaAnual)
        {
            GastosComSaude = GastosComSaude;
        }

        public double imposto()
        {
            return RendaAnual - GastosComSaude;
        }
    }
}
