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
                Log.Add(LogType.success, "Logado");

            }
            else
            {
                MessageBox.Show("Erro ao tentar logar");
                Log.Add(LogType.error, "Erro ao tentar logar");
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
                Log.Add(LogType.success, "Token correto");
                View view = new View();
                view.ShowDialog();
            }
            else if (txtToken.Text == Config.tokenMemory)
            {
                string token = ambev.GetToken("admin", "admin");
                
                bool teste = ambev.AccessTest(token);

                if (teste)
                {
                    Config.tokenMemory = token;
                    MessageBox.Show("Token correto");
                    Log.Add(LogType.success, "Token renovado com successo");
                    View view = new View();
                    view.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Erro");
                Log.Add(LogType.error, "erro no token");
            }
        }
    }
}