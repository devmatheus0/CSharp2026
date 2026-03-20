namespace funcionario
{
    internal class Dados
    {
        public string nome;
        public double salario;
        public double imposto;
    }

        //Construtor
    public Dados (string nome, double salario, double imposto)
        {
            this.nome = nome;
            this.salario = salario;
            this.imposto = imposto;
        }

     //Métodos
     public string nome_funcionario () {
            return nome;
        }
        public double salario_funcionario()
        {
            return salario;
        }
        public double imposto_salario()
        {
            return imposto;
        }

        public double aumento_porcentagem(double porcentagem)
        {
            return salario + salario * porcentagem/100;
        }

        public double salario_liquido()
        {
            return (salario +  - imposto);
        }



        public string Dados_atualizados()
        {
            return $"Nome do funcionario :{nome_funcionario}," +
                $"Salario líquido: " 
               
        }
    }


    }

}


