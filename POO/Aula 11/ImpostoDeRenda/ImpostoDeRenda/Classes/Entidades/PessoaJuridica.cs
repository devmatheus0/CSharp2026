using System;
using System.Collections.Generic;
using System.Text;

namespace ImpostoDeRenda.Classes.Entidades
{
    internal class PessoaJuridica : Contribuintes
    {
		//Campo
		private int funcionarios;


        //Propriedade
        public int NumeroFuncionarios
		{
			get { return funcionarios; }
			set { funcionarios = value; }
		}


        //Construtor
        public PessoaJuridica(string nome, double rendaAnual, int numeroFuncionarios) : base(nome, rendaAnual)
        {
            NumeroFuncionarios = NumeroFuncionarios;
        }

        //Método
        public override double imposto()
        {
            
        }





    }
}
