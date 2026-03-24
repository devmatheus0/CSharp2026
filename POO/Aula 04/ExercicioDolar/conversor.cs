namespace ExercicioDolar
{
    internal static class Conversor
    {
        //Campo
        public static double IOF = 6;


        //Método
        public static double Converter (double cotacao, double qtd)
        {
            return cotacao * qtd + IOF;
        }


    }
}
