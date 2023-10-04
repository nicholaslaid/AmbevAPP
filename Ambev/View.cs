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

            dgvAmbev.DataSource = api.GetAllProdutos(Config.tokenMemory);



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

                        bool response = api.Delete(Config.tokenMemory, id);

                        if (response)
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
    }
}

