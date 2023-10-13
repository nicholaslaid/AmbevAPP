namespace Ambev
{
    partial class VendasForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvVendas = new DataGridView();
            button1 = new Button();
            btnDetalhes = new Button();
            id = new DataGridViewTextBoxColumn();
            dataVenda = new DataGridViewTextBoxColumn();
            Cliente = new DataGridViewTextBoxColumn();
            Vendedor = new DataGridViewTextBoxColumn();
            valorTotal = new DataGridViewTextBoxColumn();
            qtd_produtos = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvVendas).BeginInit();
            SuspendLayout();
            // 
            // dgvVendas
            // 
            dgvVendas.AllowUserToAddRows = false;
            dgvVendas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVendas.Columns.AddRange(new DataGridViewColumn[] { id, dataVenda, Cliente, Vendedor, valorTotal, qtd_produtos });
            dgvVendas.Location = new Point(62, 27);
            dgvVendas.Name = "dgvVendas";
            dgvVendas.ReadOnly = true;
            dgvVendas.RowHeadersWidth = 51;
            dgvVendas.RowTemplate.Height = 29;
            dgvVendas.Size = new Size(683, 260);
            dgvVendas.TabIndex = 0;
            dgvVendas.CellClick += dgvVendas_CellClick;
            dgvVendas.CellContentClick += dgvVendas_CellContentClick;
            // 
            // button1
            // 
            button1.Location = new Point(172, 327);
            button1.Name = "button1";
            button1.Size = new Size(171, 58);
            button1.TabIndex = 1;
            button1.Text = "Cancel";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnDetalhes
            // 
            btnDetalhes.Location = new Point(438, 327);
            btnDetalhes.Name = "btnDetalhes";
            btnDetalhes.Size = new Size(150, 58);
            btnDetalhes.TabIndex = 2;
            btnDetalhes.Text = "Detalhes";
            btnDetalhes.UseVisualStyleBackColor = true;
            btnDetalhes.Click += btnDetalhes_Click;
            // 
            // id
            // 
            id.DataPropertyName = "id";
            id.HeaderText = "identificador";
            id.MinimumWidth = 6;
            id.Name = "id";
            id.ReadOnly = true;
            id.Visible = false;
            id.Width = 125;
            // 
            // dataVenda
            // 
            dataVenda.DataPropertyName = "dataVenda";
            dataVenda.HeaderText = "Data";
            dataVenda.MinimumWidth = 6;
            dataVenda.Name = "dataVenda";
            dataVenda.ReadOnly = true;
            dataVenda.Width = 125;
            // 
            // Cliente
            // 
            Cliente.DataPropertyName = "Cliente";
            Cliente.HeaderText = "Cliente";
            Cliente.MinimumWidth = 6;
            Cliente.Name = "Cliente";
            Cliente.ReadOnly = true;
            Cliente.Width = 125;
            // 
            // Vendedor
            // 
            Vendedor.DataPropertyName = "Vendedor";
            Vendedor.HeaderText = "Vendedor";
            Vendedor.MinimumWidth = 6;
            Vendedor.Name = "Vendedor";
            Vendedor.ReadOnly = true;
            Vendedor.Width = 125;
            // 
            // valorTotal
            // 
            valorTotal.DataPropertyName = "valorTotal";
            valorTotal.HeaderText = "Valor_total";
            valorTotal.MinimumWidth = 6;
            valorTotal.Name = "valorTotal";
            valorTotal.ReadOnly = true;
            valorTotal.Width = 125;
            // 
            // qtd_produtos
            // 
            qtd_produtos.DataPropertyName = "qtd_produtos";
            qtd_produtos.HeaderText = "qtd_produtos";
            qtd_produtos.MinimumWidth = 6;
            qtd_produtos.Name = "qtd_produtos";
            qtd_produtos.ReadOnly = true;
            qtd_produtos.Width = 125;
            // 
            // VendasForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(807, 450);
            Controls.Add(btnDetalhes);
            Controls.Add(button1);
            Controls.Add(dgvVendas);
            Name = "VendasForm";
            Text = "VendasForm";
            Load += VendasForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvVendas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvVendas;
        private Button button1;
        private Button btnDetalhes;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn dataVenda;
        private DataGridViewTextBoxColumn Cliente;
        private DataGridViewTextBoxColumn Vendedor;
        private DataGridViewTextBoxColumn valorTotal;
        private DataGridViewTextBoxColumn qtd_produtos;
    }
}