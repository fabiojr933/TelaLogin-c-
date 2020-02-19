namespace TelaLogin.Telas
{
    partial class TelaCadastro
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCadastroLogin = new System.Windows.Forms.TextBox();
            this.txtCadastroSenha = new System.Windows.Forms.TextBox();
            this.txtCadastroSenhaConfirma = new System.Windows.Forms.TextBox();
            this.btnCadastroCadastrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Senha";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Confirma Senha";
            // 
            // txtCadastroLogin
            // 
            this.txtCadastroLogin.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCadastroLogin.Location = new System.Drawing.Point(26, 54);
            this.txtCadastroLogin.Name = "txtCadastroLogin";
            this.txtCadastroLogin.Size = new System.Drawing.Size(155, 26);
            this.txtCadastroLogin.TabIndex = 3;
            // 
            // txtCadastroSenha
            // 
            this.txtCadastroSenha.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCadastroSenha.Location = new System.Drawing.Point(26, 107);
            this.txtCadastroSenha.Name = "txtCadastroSenha";
            this.txtCadastroSenha.PasswordChar = '*';
            this.txtCadastroSenha.Size = new System.Drawing.Size(155, 26);
            this.txtCadastroSenha.TabIndex = 4;
            // 
            // txtCadastroSenhaConfirma
            // 
            this.txtCadastroSenhaConfirma.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCadastroSenhaConfirma.Location = new System.Drawing.Point(26, 163);
            this.txtCadastroSenhaConfirma.Name = "txtCadastroSenhaConfirma";
            this.txtCadastroSenhaConfirma.PasswordChar = '*';
            this.txtCadastroSenhaConfirma.Size = new System.Drawing.Size(155, 26);
            this.txtCadastroSenhaConfirma.TabIndex = 5;
            // 
            // btnCadastroCadastrar
            // 
            this.btnCadastroCadastrar.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastroCadastrar.Location = new System.Drawing.Point(55, 204);
            this.btnCadastroCadastrar.Name = "btnCadastroCadastrar";
            this.btnCadastroCadastrar.Size = new System.Drawing.Size(87, 30);
            this.btnCadastroCadastrar.TabIndex = 6;
            this.btnCadastroCadastrar.Text = "Cadastrar";
            this.btnCadastroCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastroCadastrar.Click += new System.EventHandler(this.btnCadastroCadastrar_Click);
            // 
            // TelaCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(219, 264);
            this.Controls.Add(this.btnCadastroCadastrar);
            this.Controls.Add(this.txtCadastroSenhaConfirma);
            this.Controls.Add(this.txtCadastroSenha);
            this.Controls.Add(this.txtCadastroLogin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "TelaCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CadastroUsuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCadastroLogin;
        private System.Windows.Forms.TextBox txtCadastroSenha;
        private System.Windows.Forms.TextBox txtCadastroSenhaConfirma;
        private System.Windows.Forms.Button btnCadastroCadastrar;
    }
}