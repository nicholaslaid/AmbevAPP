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



            api.Add(Config.tokenMemory, produtos);
            Close();
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmAdd_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            
        }
    }
}
