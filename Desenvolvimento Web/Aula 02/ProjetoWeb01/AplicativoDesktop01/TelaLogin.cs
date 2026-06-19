using AplicativoDesktop01.Classes.DTO;
using System.Net;
using System.Net.Http.Json;
using System.Text.Json;


namespace AplicativoDesktop01
{
    public partial class TelaLogin : Form
    {

        private static readonly HttpClient clientHttp = new();
        private const string urlApiLogin = "http://localhost:5151/api/usuarios/login";
        public TelaLogin()
        {
            InitializeComponent();
        }


        private async void button1_Click(object sender, EventArgs e)
        {
            var dadosLogin = new Classes.DTO.LoginRequestDTO
            {
                Email = textBox1.Text.Trim(),
                Senha = textBox2.Text.Trim(),
            };

            try
            {
                var resposta = await clientHttp.PostAsJsonAsync(urlApiLogin, dadosLogin);

                if (resposta.StatusCode == HttpStatusCode.Unauthorized)
                {
                    MessageBox.Show("Usuário ou senha incorretos.");
                    return;
                }

                else if (!resposta.IsSuccessStatusCode)
                {
                    var mensagemErro = await resposta.Content.ReadAsStringAsync();
                    MessageBox.Show($"Não foi possível autenticar. Detalhes {mensagemErro}");
                    return;
                }

                var resultado = await resposta.Content.ReadFromJsonAsync<LoginResponseDTO>();
                if (resultado.Regra == 1)
                {
                    MessageBox.Show("Acesso negado. Este usuario não tem privilégios administrativos.");
                    return;
                }

                MessageBox.Show("Login realizado com sucesso!");
                this.Hide();
                using (var telaAdmin = new TelaAdmin())
                {
                    telaAdmin.ShowDialog();
                }
                this.Close();
            }

            catch (HttpRequestException) //ht
            {
                MessageBox.Show($"Não foi possível conectar na API "); //{ht.Message}
            }
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
