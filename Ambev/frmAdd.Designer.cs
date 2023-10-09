namespace Ambev
{
    partial class frmAdd
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
            txtId = new TextBox();
            txtNome = new TextBox();
            txtMarca = new TextBox();
            txtVol = new TextBox();
            txtFrasco = new TextBox();
            txtTipo = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btnAdd = new Button();
            btnCancel = new Button();
            label7 = new Label();
            txtValue = new TextBox();
            SuspendLayout();
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(236, 54);
            txtId.Name = "txtId";
            txtId.Size = new Size(161, 27);
            txtId.TabIndex = 0;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(236, 111);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(161, 27);
            txtNome.TabIndex = 1;
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(236, 166);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(161, 27);
            txtMarca.TabIndex = 2;
            // 
            // txtVol
            // 
            txtVol.Location = new Point(236, 228);
            txtVol.Name = "txtVol";
            txtVol.Size = new Size(161, 27);
            txtVol.TabIndex = 3;
            // 
            // txtFrasco
            // 
            txtFrasco.Location = new Point(236, 292);
            txtFrasco.Name = "txtFrasco";
            txtFrasco.Size = new Size(161, 27);
            txtFrasco.TabIndex = 4;
            // 
            // txtTipo
            // 
            txtTipo.Location = new Point(236, 353);
            txtTipo.Name = "txtTipo";
            txtTipo.Size = new Size(161, 27);
            txtTipo.TabIndex = 5;
            txtTipo.TextChanged += txtTipo_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(125, 61);
            label1.Name = "label1";
            label1.Size = new Size(22, 20);
            label1.TabIndex = 6;
            label1.Text = "Id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(125, 111);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 7;
            label2.Text = "Nome";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(125, 173);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 8;
            label3.Text = "Marca";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(125, 235);
            label4.Name = "label4";
            label4.Size = new Size(59, 20);
            label4.TabIndex = 9;
            label4.Text = "Volume";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(125, 299);
            label5.Name = "label5";
            label5.Size = new Size(51, 20);
            label5.TabIndex = 10;
            label5.Text = "Frasco";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(125, 360);
            label6.Name = "label6";
            label6.Size = new Size(39, 20);
            label6.TabIndex = 11;
            label6.Text = "Tipo";
            label6.Click += label6_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(599, 324);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(121, 47);
            btnAdd.TabIndex = 12;
            btnAdd.Text = "Adicionar";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(450, 324);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(113, 47);
            btnCancel.TabIndex = 13;
            btnCancel.Text = "Cancelar";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(125, 407);
            label7.Name = "label7";
            label7.Size = new Size(43, 20);
            label7.TabIndex = 14;
            label7.Text = "Valor";
            // 
            // txtValue
            // 
            txtValue.Location = new Point(236, 407);
            txtValue.Name = "txtValue";
            txtValue.Size = new Size(161, 27);
            txtValue.TabIndex = 15;
            // 
            // frmAdd
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtValue);
            Controls.Add(label7);
            Controls.Add(btnCancel);
            Controls.Add(btnAdd);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtTipo);
            Controls.Add(txtFrasco);
            Controls.Add(txtVol);
            Controls.Add(txtMarca);
            Controls.Add(txtNome);
            Controls.Add(txtId);
            Name = "frmAdd";
            Text = "frmAdd";
            FormClosing += frmAdd_FormClosing;
            Load += frmAdd_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtId;
        private TextBox txtNome;
        private TextBox txtMarca;
        private TextBox txtVol;
        private TextBox txtFrasco;
        private TextBox txtTipo;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btnAdd;
        private Button btnCancel;
        private Label label7;
        private TextBox txtValue;
    }
}