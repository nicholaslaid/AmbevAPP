namespace Ambev
{
    partial class Teste
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtUser = new TextBox();
            txtSenha = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnVerificar = new Button();
            btnHandshake = new Button();
            btnAccess = new Button();
            txtToken = new TextBox();
            txtTk = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // txtUser
            // 
            txtUser.Location = new Point(229, 86);
            txtUser.Margin = new Padding(4, 4, 4, 4);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(289, 31);
            txtUser.TabIndex = 0;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(229, 154);
            txtSenha.Margin = new Padding(4, 4, 4, 4);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(289, 31);
            txtSenha.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(131, 86);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(47, 25);
            label1.TabIndex = 2;
            label1.Text = "User";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(119, 158);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(60, 25);
            label2.TabIndex = 3;
            label2.Text = "Senha";
            // 
            // btnVerificar
            // 
            btnVerificar.Location = new Point(564, 99);
            btnVerificar.Margin = new Padding(4, 4, 4, 4);
            btnVerificar.Name = "btnVerificar";
            btnVerificar.Size = new Size(194, 65);
            btnVerificar.TabIndex = 4;
            btnVerificar.Text = "Verificar";
            btnVerificar.UseVisualStyleBackColor = true;
            btnVerificar.Click += btnVerificar_Click;
            // 
            // btnHandshake
            // 
            btnHandshake.Location = new Point(55, 452);
            btnHandshake.Margin = new Padding(4, 4, 4, 4);
            btnHandshake.Name = "btnHandshake";
            btnHandshake.Size = new Size(156, 54);
            btnHandshake.TabIndex = 5;
            btnHandshake.Text = "Handshake";
            btnHandshake.UseVisualStyleBackColor = true;
            btnHandshake.Click += btnHandshake_Click;
            // 
            // btnAccess
            // 
            btnAccess.Location = new Point(770, 452);
            btnAccess.Margin = new Padding(4, 4, 4, 4);
            btnAccess.Name = "btnAccess";
            btnAccess.Size = new Size(145, 54);
            btnAccess.TabIndex = 6;
            btnAccess.Text = "AccessTest";
            btnAccess.UseVisualStyleBackColor = true;
            btnAccess.Click += btnAccess_Click;
            // 
            // txtToken
            // 
            txtToken.Location = new Point(361, 462);
            txtToken.Margin = new Padding(4, 4, 4, 4);
            txtToken.Name = "txtToken";
            txtToken.Size = new Size(380, 31);
            txtToken.TabIndex = 7;
            // 
            // txtTk
            // 
            txtTk.Location = new Point(229, 239);
            txtTk.Margin = new Padding(4, 4, 4, 4);
            txtTk.Name = "txtTk";
            txtTk.Size = new Size(489, 31);
            txtTk.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(119, 242);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(58, 25);
            label3.TabIndex = 9;
            label3.Text = "Token";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // Teste
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(961, 562);
            Controls.Add(label3);
            Controls.Add(txtTk);
            Controls.Add(txtToken);
            Controls.Add(btnAccess);
            Controls.Add(btnHandshake);
            Controls.Add(btnVerificar);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtSenha);
            Controls.Add(txtUser);
            Margin = new Padding(4, 4, 4, 4);
            Name = "Teste";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUser;
        private TextBox txtSenha;
        private Label label1;
        private Label label2;
        private Button btnVerificar;
        private Button btnHandshake;
        private Button btnAccess;
        private TextBox txtToken;
        private TextBox txtTk;
        private Label label3;
    }
}