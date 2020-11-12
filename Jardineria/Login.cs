using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using Entidades;
using Negocio;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jardineria
{
    public partial class Login : Form
    {
        NegocioLogin log = new NegocioLogin();
        public Login()
        {
            InitializeComponent();
            ComprobacionInicial();
        }

        private void ComprobacionInicial()
        {
            string user = "admin";
            string contra = "1234";
            string pass = CodificarPassword(contra);
            log.PruebaInicial(user, pass);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblError.Text = txtPassword.Text;
            lblError.Visible = true;
        }

        private string CodificarPassword(string contra)
        {
            System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(contra);
            byte[] hash = md5.ComputeHash(inputBytes);

            StringBuilder sb = new StringBuilder();
            
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("x2"));
            }

            return sb.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {
            
        }
    }
}
