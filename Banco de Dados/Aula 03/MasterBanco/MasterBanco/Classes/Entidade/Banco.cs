using Microsoft.Data.SqlClient;

namespace MasterBanco.Classes.Entidade
{
    internal class Banco
    {
        //Campo
        private const decimal TaxaSaque = 5.00m;

        //Propriedades
        public int Id { get; set; }
        public string Titular { get; set; }
        public int Numero_da_conta { get; set; }
        public decimal Saldo { get; set; }

        //Construtores
        public Banco() { }

        public Banco(string titular, int numero_da_conta, decimal saldo)
        {
            Titular = titular;
            Numero_da_conta = numero_da_conta;
            Saldo = saldo;
        }

        public Banco(string titular, int numero_da_conta) : this()
        {
            Saldo = 0;
        }

        //Caminho do servidor onde está o banco de dados
        private static string conectarCaminho =
@"Server=ECFP507D1319388\SQLEXPRESS;Database=Clodoaldo;Trusted_Connection=True;TrustServerCertificate=True;";

        //Operações CRUD
        //C - Create
        public static void CadastrarContas(Banco banco)
        {
            //Query
            string consulta = "INSERT INTO Contas (Titular, Numero_Da_Conta, Saldo) " +
                              "VALUES (@Titular, @Numero_Da_Conta, @Saldo)";

            using (var conexao = new SqlConnection(conectarCaminho))
            using (var comando = new SqlCommand(consulta, conexao))
            {
                comando.Parameters.AddWithValue("@Titular", banco.Titular);
                comando.Parameters.AddWithValue("@Numero_Da_Conta", banco.Numero_da_conta);
                comando.Parameters.AddWithValue("@Saldo", banco.Saldo);

                conexao.Open();
                int resultado = comando.ExecuteNonQuery();
                if (resultado > 0) Console.WriteLine("Conta cadastrada com sucesso!");
            }

        }
    }
}


////R - Read
//        public static void LerContas()
//        {
//            string consulta = "SELECT Id, Titular, Numero_Da_Conta, Saldo FROM Contas"
//            using (SqlConnection = new SqlConnection(conectarCaminho))
//            using (SqlCommand = new SqlCommand(consulta, conexao))
//            {
//                conexao.Open();
//                using (SqlDataReader Leitura = comando.ExecuteReader())
//                {
//                    if (Leitura.HasRows)
//                    {
//                        while (Leitura.Read())
//                        {
//                            Console.WriteLine($"ID: {Leitura["Id]}|" +
//                                $"Conta: {Leitura["Numero_da_Conta"]}|" +
//                                $"Titular: {Leitura["Titular"]}|" +
//                                $"Saldo: R$ {Leitura["Saldo"]}");
//                        }
//                                else{
//                                Console.WriteLine("Nenhuma conta encontrada");
//                                }
//                    }
//                }
//            }
//        }
//    }

//}        