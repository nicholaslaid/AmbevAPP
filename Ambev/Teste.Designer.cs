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
            txtUser.Location = new Point(183, 69);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(232, 27);
            txtUser.TabIndex = 0;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(183, 123);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(232, 27);
            txtSenha.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(105, 69);
            label1.Name = "label1";
            label1.Size = new Size(38, 20);
            label1.TabIndex = 2;
            label1.Text = "User";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(95, 126);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 3;
            label2.Text = "Senha";
            // 
            // btnVerificar
            // 
            btnVerificar.Location = new Point(451, 79);
            btnVerificar.Name = "btnVerificar";
            btnVerificar.Size = new Size(155, 52);
            btnVerificar.TabIndex = 4;
            btnVerificar.Text = "Verificar";
            btnVerificar.UseVisualStyleBackColor = true;
            btnVerificar.Click += btnVerificar_Click;
            // 
            // btnHandshake
            // 
            btnHandshake.Location = new Point(95, 362);
            btnHandshake.Name = "btnHandshake";
            btnHandshake.Size = new Size(125, 43);
            btnHandshake.TabIndex = 5;
            btnHandshake.Text = "Handshake";
            btnHandshake.UseVisualStyleBackColor = true;
            btnHandshake.Click += btnHandshake_Click;
            // 
            // btnAccess
            // 
            btnAccess.Location = new Point(616, 362);
            btnAccess.Name = "btnAccess";
            btnAccess.Size = new Size(116, 43);
            btnAccess.TabIndex = 6;
            btnAccess.Text = "AccessTest";
            btnAccess.UseVisualStyleBackColor = true;
            btnAccess.Click += btnAccess_Click;
            // 
            // txtToken
            // 
            txtToken.Location = new Point(289, 370);
            txtToken.Name = "txtToken";
            txtToken.Size = new Size(305, 27);
            txtToken.TabIndex = 7;
            // 
            // txtTk
            // 
            txtTk.Location = new Point(183, 191);
            txtTk.Name = "txtTk";
            txtTk.Size = new Size(392, 27);
            txtTk.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(95, 194);
            label3.Name = "label3";
            label3.Size = new Size(48, 20);
            label3.TabIndex = 9;
            label3.Text = "Token";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // Teste
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(769, 450);
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