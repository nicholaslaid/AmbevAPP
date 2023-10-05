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


            Config.user = txtUser.Text;
            Config.senha = txtSenha.Text;

           

            string result = ambev.GetToken(Config.user, Config.senha);

            txtTk.Text = result;

            Config.tokenMemory = result;
            if (result.Length > 1)
            {
                View view = new View();
                view.ShowDialog();

               
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

            bool result = ambev.AccessTest(Config.token);

            if (result)
            {

                MessageBox.Show("Token correto");
                Log.Add(LogType.success, "Token correto");
               
            }
            else if (Config.token == Config.tokenMemory)
            {
                string token = ambev.GetToken(Config.user, Config.senha);

                bool teste = ambev.AccessTest(token);

                if (teste)
                {

                    MessageBox.Show("Token correto");
                    Log.Add(LogType.success, "Token renovado com successo");
                   
                }
            }
            else
            {
                MessageBox.Show("Erro");
                Log.Add(LogType.error, "erro no token");
            }
        }

        private void Teste_Load(object sender, EventArgs e)
        {

        }

    }
}