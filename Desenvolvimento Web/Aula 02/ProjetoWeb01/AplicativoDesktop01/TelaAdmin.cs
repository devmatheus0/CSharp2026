using AplicativoDesktop01.Classes.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net;
using System.Net.Http.Json;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AplicativoDesktop01
{
    public partial class TelaAdmin : Form
    {

        private static readonly HttpClient clientHttp = new();
        private const string urlApiLogin = "http://localhost:5151/api/usuarios/login";
        public TelaAdmin()
        {
            InitializeComponent();

        }


        private void button1_Click(object sender, EventArgs e)
        {
            var dadosAdmin = new 
            {

            }
           


        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            var dadosAdmin = new Classes.DTO.LoginRequestDTO
            {
               
            };
        }
    }
}
