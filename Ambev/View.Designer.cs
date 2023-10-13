namespace Ambev
{
    partial class View
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
            dgvAmbev = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            Valor_unitario = new DataGridViewTextBoxColumn();
            Nome = new DataGridViewTextBoxColumn();
            Marca = new DataGridViewTextBoxColumn();
            Tipo = new DataGridViewTextBoxColumn();
            Volume = new DataGridViewTextBoxColumn();
            Frasco = new DataGridViewTextBoxColumn();
            Deletar = new DataGridViewButtonColumn();
            btnAdd = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvAmbev).BeginInit();
            SuspendLayout();
            // 
            // dgvAmbev
            // 
            dgvAmbev.AllowUserToAddRows = false;
            dgvAmbev.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAmbev.Columns.AddRange(new DataGridViewColumn[] { id, Valor_unitario, Nome, Marca, Tipo, Volume, Frasco, Deletar });
            dgvAmbev.Location = new Point(35, 12);
            dgvAmbev.Name = "dgvAmbev";
            dgvAmbev.ReadOnly = true;
            dgvAmbev.RowHeadersWidth = 51;
            dgvAmbev.RowTemplate.Height = 29;
            dgvAmbev.Size = new Size(928, 385);
            dgvAmbev.TabIndex = 0;
            dgvAmbev.CellClick += dgvAmbev_CellClick;
            dgvAmbev.CellContentClick += dgvAmbev_CellContentClick;
            // 
            // id
            // 
            id.DataPropertyName = "id";
            id.HeaderText = "Identificador";
            id.MinimumWidth = 6;
            id.Name = "id";
            id.ReadOnly = true;
            id.Visible = false;
            id.Width = 125;
            // 
            // Valor_unitario
            // 
            Valor_unitario.DataPropertyName = "valor_unitario";
            Valor_unitario.HeaderText = "Valor_unitario";
            Valor_unitario.MinimumWidth = 6;
            Valor_unitario.Name = "Valor_unitario";
            Valor_unitario.ReadOnly = true;
            Valor_unitario.Width = 125;
            // 
            // Nome
            // 
            Nome.DataPropertyName = "nome";
            Nome.HeaderText = "Nome";
            Nome.MinimumWidth = 6;
            Nome.Name = "Nome";
            Nome.ReadOnly = true;
            Nome.Width = 125;
            // 
            // Marca
            // 
            Marca.DataPropertyName = "marca";
            Marca.HeaderText = "Marca";
            Marca.MinimumWidth = 6;
            Marca.Name = "Marca";
            Marca.ReadOnly = true;
            Marca.Width = 125;
            // 
            // Tipo
            // 
            Tipo.DataPropertyName = "tipo";
            Tipo.HeaderText = "Tipo";
            Tipo.MinimumWidth = 6;
            Tipo.Name = "Tipo";
            Tipo.ReadOnly = true;
            Tipo.Width = 125;
            // 
            // Volume
            // 
            Volume.DataPropertyName = "volume";
            Volume.HeaderText = "Volume";
            Volume.MinimumWidth = 6;
            Volume.Name = "Volume";
            Volume.ReadOnly = true;
            Volume.Width = 125;
            // 
            // Frasco
            // 
            Frasco.DataPropertyName = "frasco";
            Frasco.HeaderText = "Frasco";
            Frasco.MinimumWidth = 6;
            Frasco.Name = "Frasco";
            Frasco.ReadOnly = true;
            Frasco.Width = 125;
            // 
            // Deletar
            // 
            Deletar.DataPropertyName = "Deletar";
            Deletar.HeaderText = "Deletar";
            Deletar.MinimumWidth = 6;
            Deletar.Name = "Deletar";
            Deletar.ReadOnly = true;
            Deletar.Text = "Deletar";
            Deletar.ToolTipText = "Deletar";
            Deletar.Width = 125;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(1032, 187);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 41);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Adicionar";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // button1
            // 
            button1.Location = new Point(35, 410);
            button1.Name = "button1";
            button1.Size = new Size(928, 29);
            button1.TabIndex = 2;
            button1.Text = "Lista de Vendas";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // View
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1177, 451);
            Controls.Add(button1);
            Controls.Add(btnAdd);
            Controls.Add(dgvAmbev);
            Name = "View";
            Text = "View";
            Load += View_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAmbev).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvAmbev;
        private Button btnAdd;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn Valor_unitario;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn Marca;
        private DataGridViewTextBoxColumn Tipo;
        private DataGridViewTextBoxColumn Volume;
        private DataGridViewTextBoxColumn Frasco;
        private DataGridViewButtonColumn Deletar;
        private Button button1;
    }
}