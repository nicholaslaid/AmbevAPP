using Ambev.Api;
using Ambev.Global;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ambev
{
    public partial class FormVendaProdutos : Form
    {
        public FormVendaProdutos()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LoadProducts()
        {

            AmbevAPI api = new AmbevAPI();

            bool result = api.AccessTest(Config.token);

            if (result)
            {

                MessageBox.Show("Token correto");
                dgvListProd.DataSource = api.VendasProdutos(Config.token);
                Log.Add(LogType.success, "Token correto");

            }
            else if (Config.token == Config.tokenMemory)
            {
                string token = api.GetToken(Config.user, Config.senha);

                bool teste = api.AccessTest(token);

                if (teste)
                {
                    Config.tokenMemory = token;
                    dgvListProd.DataSource = api.VendasProdutos(Config.token);
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

        private void FormVendaProdutos_Load(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void dgvListProd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
