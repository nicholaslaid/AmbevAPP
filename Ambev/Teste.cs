using Ambev.Api;
using Ambev.Global;
using Microsoft.VisualBasic.ApplicationServices;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;

namespace Ambev
{
    public partial class Teste : Form
    {
        public Teste()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            txtTk.Clear();

            AmbevAPI ambev = new AmbevAPI();

            String user = txtUser.Text;
            String senha = txtSenha.Text;


            string result = ambev.GetToken(user, senha);

            Config.tokenMemory = result;

            txtTk.Text = result;


            if (txtTk.Text.Length > 1)
            {
                MessageBox.Show("Logado");
               // Log.Save("Logado");

            }
            else
            {
                MessageBox.Show("Erro ao tentar logar");
                //Log.Save("Erro ao tentar logar");
            }


        }

        private void btnHandshake_Click(object sender, EventArgs e)
        {
            AmbevAPI ambev = new AmbevAPI();

            bool result = ambev.Handshake();
            if (result)
            {
                MessageBox.Show("Handshake feito");


            }
            else
            {
                MessageBox.Show("Erro");

            }
        }

        private void btnAccess_Click(object sender, EventArgs e)
        {
            AmbevAPI ambev = new AmbevAPI();

            bool result = ambev.AccessTest(txtToken.Text);

            if (result)
            {
                MessageBox.Show("Token correto");
              //  Log.Save("Token correto");
            }
            else if (txtToken.Text == Config.tokenMemory)
            {
                string token = ambev.GetToken("admin", "admin");
                bool teste = ambev.AccessTest(token);

                if (teste)
                {
                    MessageBox.Show("Token correto");
                    //Log.Save("Token renovado com successo");
                }
            }
            else
            {
                MessageBox.Show("Erro");
              //  Log.Save("Token incorreto");
            }
        }
    }
}