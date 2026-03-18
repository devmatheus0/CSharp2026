namespace Retangulo
{
    internal class retangulo
    {
        //Campos
        public double Base;
        public double Altura;

        //Método
        public double Area()
        {
            double p = Base + Altura + Base + Altura;
            double area = Base * Altura;
            return area;
        }
        public double Perimetro() { 
        
            double perimetro = (Base * 2) + (Altura * 2);
            return perimetro;
        }
        public double Diagonal()
        {

            double diagonal = Math.Sqrt(Math.Pow(Base, 2) + Math.Pow(Altura, 2));
            return diagonal;
        }
    }
}
