using Ambev.Api;
using Ambev.Global;
using Ambev.Models;
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
    public partial class View : Form
    {
        public View()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAdd add = new frmAdd();
            add.ShowDialog();
            LoadAmbev();
        }

        private void LoadAmbev()
        {

            AmbevAPI api = new AmbevAPI();

            bool result = api.AccessTest(Config.token);

            if (result)
            {

                dgvAmbev.DataSource = api.GetAllProdutos(Config.token);
                Log.Add(LogType.success, "Token correto");

            }
            else if (Config.token == Config.tokenMemory)
            {
                string token = api.GetToken(Config.user, Config.senha);

                bool teste = api.AccessTest(token);

                if (teste)
                {
                    Config.tokenMemory = token;
                    dgvAmbev.DataSource = api.GetAllProdutos(Config.token);
                    Log.Add(LogType.success, "Token renovado com successo");

                }
            }
            else
            {
                MessageBox.Show("Erro");
                Log.Add(LogType.error, "erro no token");
            }




        }

        private void View_Load(object sender, EventArgs e)
        {
            LoadAmbev();
        }

        private void dgvAmbev_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                AmbevAPI api = new AmbevAPI();
                int id = Convert.ToInt32(dgvAmbev.Rows[dgvAmbev.CurrentRow.Index].Cells["id"].Value);

                if (e.ColumnIndex == dgvAmbev.Columns["Deletar"].Index)
                {
                    DialogResult dialogResult = MessageBox.Show(
                    "Comfirma Exclusão", "Excluir",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                    if (dialogResult == DialogResult.Yes)
                    {

                        bool result = api.AccessTest(Config.token);

                        if (result)
                        {

                            api.Delete(Config.token, id);
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

                                api.Delete(Config.token, id);

                                Log.Add(LogType.success, "Token renovado com successo");

                            }
                        }
                        else
                        {
                            result = false;
                            MessageBox.Show("Erro");
                            Log.Add(LogType.error, "erro no token");
                        }


                        if (result)
                        {
                            LoadAmbev();
                        }
                        else
                        {
                            MessageBox.Show("Erro ao tentar excluir");
                        }
                    }

                }
            }
            catch (Exception ex)
            { }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VendasForm vendas = new VendasForm();
            vendas.ShowDialog();
        }

        private void dgvAmbev_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

