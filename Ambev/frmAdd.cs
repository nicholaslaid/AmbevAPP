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
    public partial class frmAdd : Form
    {
        public frmAdd()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Produtos produtos = new Produtos();
            AmbevAPI api = new AmbevAPI();

            produtos.nome = txtNome.Text;
            produtos.marca = txtMarca.Text;
            produtos.tipo = txtTipo.Text;
            produtos.volume = Convert.ToInt32(txtVol.Text);
            produtos.frasco = txtFrasco.Text;
            produtos.valor_unitario = Convert.ToDouble(txtValue.Text);

            bool result = api.AccessTest(Config.token);

            if (result)
            {
                api.Add(Config.token, produtos);

            }
            else if (Config.token == Config.tokenMemory)
            {
                string token = api.GetToken(Config.user, Config.senha);

                bool teste = api.AccessTest(token);

                if (teste)
                {
                    Config.tokenMemory = token;

                    api.Add(Config.token, produtos);

                    Log.Add(LogType.success, "Token renovado com successo");

                }
            }
            else
            {
                MessageBox.Show("Erro");
                Log.Add(LogType.error, "erro no token");
            }






            Close();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmAdd_FormClosing(object sender, FormClosingEventArgs e)
        {


        }

        private void frmAdd_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
        }

        private void txtTipo_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
