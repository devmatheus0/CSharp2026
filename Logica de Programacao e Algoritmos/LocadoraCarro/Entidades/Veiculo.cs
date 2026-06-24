namespace LocadoraCarro.Entidades
{
    public class Veiculo
    {
        private string modelo;

        public string Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }

        public Veiculo(string modelo)
        {
            this.modelo = modelo;
        }
    }
}
