using System.Globalization;

namespace funcionario
{
    internal class Dados
    {
        public string nome;
        public double salario;
        public double imposto;
    

    //Construtor
    public Dados (string nome, double salario, double imposto, double porcentagem)
        {
            this.nome = nome;
            this.salario = salario;
            this.imposto = imposto;
   
        }

     //Métodos
     public string nome_funcionario (string nome) {
            return nome;
        }
        public double salario_funcionario(double salario)
        {
            return salario;
        }
        public double imposto_salario(double imposto)
        {
            return imposto;
        }

        public double aumento_porcentagem(double porcentagem)
        {
            return salario * porcentagem/100;
        }

        public double salario_liquido(double salario)
        {
            return salario - imposto;
        }



        public string Dados_atualizados(string nome, double salario)
        {
            return 
                $"Nome do funcionario :{nome_funcionario}," +
                $"Salario líquido: {salario_liquido}"; 
               
        }
    }


    }




