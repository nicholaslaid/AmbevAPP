﻿namespace Ambev
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
            id = new DataGridViewTextBoxColumn();
            Nome = new DataGridViewTextBoxColumn();
            Marca = new DataGridViewTextBoxColumn();
            Tipo = new DataGridViewTextBoxColumn();
            Volume = new DataGridViewTextBoxColumn();
            Frasco = new DataGridViewTextBoxColumn();
            Deletar = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dgvAmbev).BeginInit();
            SuspendLayout();
            // 
            // dgvAmbev
            // 
            dgvAmbev.AllowUserToAddRows = false;
            dgvAmbev.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAmbev.Columns.AddRange(new DataGridViewColumn[] { id, Nome, Marca, Tipo, Volume, Frasco, Deletar });
            dgvAmbev.Location = new Point(73, 18);
            dgvAmbev.Margin = new Padding(3, 2, 3, 2);
            dgvAmbev.Name = "dgvAmbev";
            dgvAmbev.ReadOnly = true;
            dgvAmbev.RowHeadersWidth = 51;
            dgvAmbev.RowTemplate.Height = 29;
            dgvAmbev.Size = new Size(704, 289);
            dgvAmbev.TabIndex = 0;
            dgvAmbev.CellClick += dgvAmbev_CellClick;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(869, 263);
            btnAdd.Margin = new Padding(3, 2, 3, 2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(82, 31);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Adicionar";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
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
            // View
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1030, 338);
            Controls.Add(btnAdd);
            Controls.Add(dgvAmbev);
            Margin = new Padding(3, 2, 3, 2);
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
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn Marca;
        private DataGridViewTextBoxColumn Tipo;
        private DataGridViewTextBoxColumn Volume;
        private DataGridViewTextBoxColumn Frasco;
        private DataGridViewButtonColumn Deletar;
    }
}