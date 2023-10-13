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
    public partial class VendasForm : Form
    {
        public VendasForm()
        {
            InitializeComponent();
        }
        private void LoadVendas()
        {

            AmbevAPI api = new AmbevAPI();

            bool result = api.AccessTest(Config.token);

            if (result)
            {

                MessageBox.Show("Token correto");
                dgvVendas.DataSource = api.GetAllVendas(Config.token);
                Log.Add(LogType.success, "Token correto");

            }
            else if (Config.token == Config.tokenMemory)
            {
                string token = api.GetToken(Config.user, Config.senha);

                bool teste = api.AccessTest(token);

                if (teste)
                {
                    Config.tokenMemory = token;
                    dgvVendas.DataSource = api.GetAllVendas(Config.token);
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

        private void VendasForm_Load(object sender, EventArgs e)
        {
            LoadVendas();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvVendas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvVendas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                AmbevAPI api = new AmbevAPI();
                int id = Convert.ToInt32(dgvVendas.Rows[dgvVendas.CurrentRow.Index].Cells["id"].Value);

                if (e.ColumnIndex == dgvVendas.Columns["Detalhes"].Index)
                {

                    bool result = api.AccessTest(Config.token);

                    if (result)
                    {

                        FormVendaProdutos formVendaProdutos = new FormVendaProdutos();
                        formVendaProdutos.ShowDialog();
                        Log.Add(LogType.success, "Token correto");

                    }
                    else if (Config.token == Config.tokenMemory)
                    {
                        string token = api.GetToken(Config.user, Config.senha);

                        bool teste = api.AccessTest(token);

                        if (teste)
                        {
                            result = true;

                            Config.tokenMemory = token;

                            MessageBox.Show("Token correto");

                            FormVendaProdutos formVendaProdutos = new FormVendaProdutos();

                            Log.Add(LogType.success, "Token renovado com successo");

                        }
                    }
                    else
                    {
                        result = false;
                        MessageBox.Show("Erro");
                        Log.Add(LogType.error, "erro no token");
                    }
                }

            }
            catch (Exception ex)
            { }
        }

        private void btnDetalhes_Click(object sender, EventArgs e)
        {
            FormVendaProdutos formVendaProdutos = new FormVendaProdutos();
            formVendaProdutos.ShowDialog();
        }
    }
}
