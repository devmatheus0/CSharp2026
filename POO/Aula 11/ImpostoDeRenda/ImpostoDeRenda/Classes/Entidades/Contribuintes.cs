using ImpostoDeRenda.Classes.Contratos;
using System;
using System.Collections.Generic;
using System.Text;

namespace ImpostoDeRenda.Classes.Entidades
{
    abstract internal class Contribuintes : Iimposto
    {
        
        //Campos
        private string nome;
        private double rendaanual;
        public const double baixoimpostopf = 0.15;
        protected const double altoimpostopf = 0.25;
        protected const double abatepf = 0.50;
        protected const double impostopj = 0.16;
        protected const double maisdezpj = 0.14;
        

        //Propriedades
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public double RendaAnual
        {
            get { return rendaanual; }
            set { rendaanual = value; }
        }

        //Construtor
        protected Contribuintes(string nome, double rendaAnual)
        {
            Nome = nome;
            RendaAnual = rendaAnual;
        }
        
        //Método
        public abstract double imposto();
    }
}
