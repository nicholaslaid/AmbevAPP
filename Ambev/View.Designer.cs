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
            btnAdd = new Button();
            Identificador = new DataGridViewTextBoxColumn();
            Nome = new DataGridViewTextBoxColumn();
            Marca = new DataGridViewTextBoxColumn();
            Tipo = new DataGridViewTextBoxColumn();
            Volume = new DataGridViewTextBoxColumn();
            Frasco = new DataGridViewTextBoxColumn();
            Delete = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dgvAmbev).BeginInit();
            SuspendLayout();
            // 
            // dgvAmbev
            // 
            dgvAmbev.AllowUserToAddRows = false;
            dgvAmbev.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAmbev.Columns.AddRange(new DataGridViewColumn[] { Identificador, Nome, Marca, Tipo, Volume, Frasco, Delete });
            dgvAmbev.Location = new Point(83, 24);
            dgvAmbev.Name = "dgvAmbev";
            dgvAmbev.ReadOnly = true;
            dgvAmbev.RowHeadersWidth = 51;
            dgvAmbev.RowTemplate.Height = 29;
            dgvAmbev.Size = new Size(678, 385);
            dgvAmbev.TabIndex = 0;
            dgvAmbev.CellClick += dgvAmbev_CellClick;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(789, 368);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 41);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Adicionar";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // Identificador
            // 
            Identificador.DataPropertyName = "id";
            Identificador.HeaderText = "Identificador";
            Identificador.MinimumWidth = 6;
            Identificador.Name = "Identificador";
            Identificador.ReadOnly = true;
            Identificador.Visible = false;
            Identificador.Width = 125;
            // 
            // Nome
            // 
            Nome.DataPropertyName = "nome";
            Nome.HeaderText = "Nome";
            Nome.MinimumWidth = 6;
            Nome.Name = "Nome";
            Nome.ReadOnly = true;
            Nome.Visible = false;
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
            // Delete
            // 
            Delete.DataPropertyName = "Delete";
            Delete.HeaderText = "Delete";
            Delete.MinimumWidth = 6;
            Delete.Name = "Delete";
            Delete.ReadOnly = true;
            Delete.Text = "Delete";
            Delete.Width = 125;
            // 
            // View
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(910, 450);
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
        private DataGridViewTextBoxColumn Identificador;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn Marca;
        private DataGridViewTextBoxColumn Tipo;
        private DataGridViewTextBoxColumn Volume;
        private DataGridViewTextBoxColumn Frasco;
        private DataGridViewButtonColumn Delete;
    }
}