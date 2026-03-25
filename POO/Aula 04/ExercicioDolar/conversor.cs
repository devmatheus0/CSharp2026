namespace ExercicioDolar
{
    internal static class Conversor
    {
        //Campo
        public static double iof = 6;


        //Método
        public static double Converter (double cotacao, double qtd)
        {
            return cotacao * qtd + (cotacao * qtd * iof/100);
        }


    }
}
