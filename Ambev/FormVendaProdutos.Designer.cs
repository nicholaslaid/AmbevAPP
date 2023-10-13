namespace Ambev
{
    partial class FormVendaProdutos
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
            dgvListProd = new DataGridView();
            btnCancel = new Button();
            identificador = new DataGridViewTextBoxColumn();
            id_produto = new DataGridViewTextBoxColumn();
            quantidade = new DataGridViewTextBoxColumn();
            valor_unitario = new DataGridViewTextBoxColumn();
            subtotal = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvListProd).BeginInit();
            SuspendLayout();
            // 
            // dgvListProd
            // 
            dgvListProd.AllowUserToAddRows = false;
            dgvListProd.AllowUserToDeleteRows = false;
            dgvListProd.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListProd.Columns.AddRange(new DataGridViewColumn[] { identificador, id_produto, quantidade, valor_unitario, subtotal });
            dgvListProd.Location = new Point(61, 58);
            dgvListProd.Name = "dgvListProd";
            dgvListProd.ReadOnly = true;
            dgvListProd.RowHeadersWidth = 51;
            dgvListProd.RowTemplate.Height = 29;
            dgvListProd.Size = new Size(680, 188);
            dgvListProd.TabIndex = 0;
            dgvListProd.CellContentClick += dgvListProd_CellContentClick;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(325, 318);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(191, 46);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Cancelar";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // identificador
            // 
            identificador.DataPropertyName = "id_venda";
            identificador.HeaderText = "Numero Venda";
            identificador.MinimumWidth = 6;
            identificador.Name = "identificador";
            identificador.ReadOnly = true;
            identificador.Width = 125;
            // 
            // id_produto
            // 
            id_produto.DataPropertyName = "id_produto";
            id_produto.HeaderText = "id_product";
            id_produto.MinimumWidth = 6;
            id_produto.Name = "id_produto";
            id_produto.ReadOnly = true;
            id_produto.Width = 125;
            // 
            // quantidade
            // 
            quantidade.DataPropertyName = "qtd";
            quantidade.HeaderText = "quantidade";
            quantidade.MinimumWidth = 6;
            quantidade.Name = "quantidade";
            quantidade.ReadOnly = true;
            quantidade.Width = 125;
            // 
            // valor_unitario
            // 
            valor_unitario.DataPropertyName = "valor_unitario";
            valor_unitario.HeaderText = "valor_unitario";
            valor_unitario.MinimumWidth = 6;
            valor_unitario.Name = "valor_unitario";
            valor_unitario.ReadOnly = true;
            valor_unitario.Width = 125;
            // 
            // subtotal
            // 
            subtotal.DataPropertyName = "subtotal";
            subtotal.HeaderText = "subtotal";
            subtotal.MinimumWidth = 6;
            subtotal.Name = "subtotal";
            subtotal.ReadOnly = true;
            subtotal.Width = 125;
            // 
            // FormVendaProdutos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancel);
            Controls.Add(dgvListProd);
            Name = "FormVendaProdutos";
            Text = "FormVendaProdutos";
            Load += FormVendaProdutos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvListProd).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvListProd;
        private Button btnCancel;
        private DataGridViewTextBoxColumn identificador;
        private DataGridViewTextBoxColumn id_produto;
        private DataGridViewTextBoxColumn quantidade;
        private DataGridViewTextBoxColumn valor_unitario;
        private DataGridViewTextBoxColumn subtotal;
    }
}