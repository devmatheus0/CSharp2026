using static System.Console;

namespace Notas
{
    internal class NotasAluno
    {
        public string NomeDoAluno;
        public double Nota1;
        public double Nota2;
        public double Nota3;

        public double NotaFinal()
        {
            return Nota1 + Nota2 + Nota3;
            
        }

        public bool AprovadoOuReprovado()
        {
            if (NotaFinal() >= 60)
            {
                return true;
               
            }
            else
            {
                return false;
                
            }
            
        }

        public double Ponto()
        {
            if (AprovadoOuReprovado () == true)
            {
                return 0;
            }
            else
            {
               return 60 - NotaFinal();

            }
        }
    }
}