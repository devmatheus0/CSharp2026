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
        abstract protected double imposto();
    }
}
