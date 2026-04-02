namespace Master
{
    internal struct Pessoa
    {
        //Campo
        public string nome;
        public long cpf;

        public Pessoa(string nome, long cpf)
        {
            this.nome = nome;
            this.cpf = cpf;
        }
    }
}
