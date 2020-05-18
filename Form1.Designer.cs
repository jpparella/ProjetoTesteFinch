namespace pFinchFila
{
    partial class frmLogin
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlFundo = new System.Windows.Forms.Panel();
            this.pnlConfigEmail = new System.Windows.Forms.Panel();
            this.btnConfigEmail = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtConfigEmail = new System.Windows.Forms.TextBox();
            this.pnlButton = new System.Windows.Forms.Panel();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.pnlDados = new System.Windows.Forms.Panel();
            this.lblUsuarioIncorreto = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbSenha = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txbLogin = new System.Windows.Forms.TextBox();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.pnlFechar = new System.Windows.Forms.Panel();
            this.lbFechar = new System.Windows.Forms.Label();
            this.pnlFundo.SuspendLayout();
            this.pnlConfigEmail.SuspendLayout();
            this.pnlButton.SuspendLayout();
            this.pnlDados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.pnlFechar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlFundo
            // 
            this.pnlFundo.BackColor = System.Drawing.Color.LightCoral;
            this.pnlFundo.Controls.Add(this.pnlConfigEmail);
            this.pnlFundo.Controls.Add(this.pnlButton);
            this.pnlFundo.Controls.Add(this.pnlDados);
            this.pnlFundo.Controls.Add(this.picLogo);
            this.pnlFundo.Controls.Add(this.pnlFechar);
            this.pnlFundo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFundo.Location = new System.Drawing.Point(0, 0);
            this.pnlFundo.Name = "pnlFundo";
            this.pnlFundo.Size = new System.Drawing.Size(770, 380);
            this.pnlFundo.TabIndex = 0;
            // 
            // pnlConfigEmail
            // 
            this.pnlConfigEmail.BackColor = System.Drawing.Color.LightCoral;
            this.pnlConfigEmail.Controls.Add(this.btnConfigEmail);
            this.pnlConfigEmail.Controls.Add(this.label5);
            this.pnlConfigEmail.Controls.Add(this.txtConfigEmail);
            this.pnlConfigEmail.Location = new System.Drawing.Point(171, 187);
            this.pnlConfigEmail.Name = "pnlConfigEmail";
            this.pnlConfigEmail.Size = new System.Drawing.Size(303, 89);
            this.pnlConfigEmail.TabIndex = 6;
            // 
            // btnConfigEmail
            // 
            this.btnConfigEmail.BackColor = System.Drawing.Color.Brown;
            this.btnConfigEmail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnConfigEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfigEmail.ForeColor = System.Drawing.Color.White;
            this.btnConfigEmail.Location = new System.Drawing.Point(28, 53);
            this.btnConfigEmail.Name = "btnConfigEmail";
            this.btnConfigEmail.Size = new System.Drawing.Size(121, 27);
            this.btnConfigEmail.TabIndex = 2;
            this.btnConfigEmail.Text = "Confirmar";
            this.btnConfigEmail.UseVisualStyleBackColor = false;
            this.btnConfigEmail.Click += new System.EventHandler(this.btnConfigEmail_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "E-Mail de recebimento";
            // 
            // txtConfigEmail
            // 
            this.txtConfigEmail.BackColor = System.Drawing.Color.IndianRed;
            this.txtConfigEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtConfigEmail.ForeColor = System.Drawing.Color.White;
            this.txtConfigEmail.Location = new System.Drawing.Point(29, 27);
            this.txtConfigEmail.MaxLength = 60;
            this.txtConfigEmail.Name = "txtConfigEmail";
            this.txtConfigEmail.Size = new System.Drawing.Size(250, 20);
            this.txtConfigEmail.TabIndex = 0;
            // 
            // pnlButton
            // 
            this.pnlButton.Controls.Add(this.btnRegistrar);
            this.pnlButton.Controls.Add(this.btnLogin);
            this.pnlButton.Location = new System.Drawing.Point(179, 327);
            this.pnlButton.Name = "pnlButton";
            this.pnlButton.Size = new System.Drawing.Size(295, 41);
            this.pnlButton.TabIndex = 3;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.Brown;
            this.btnRegistrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.ForeColor = System.Drawing.Color.White;
            this.btnRegistrar.Location = new System.Drawing.Point(154, 7);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(121, 27);
            this.btnRegistrar.TabIndex = 1;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Brown;
            this.btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(25, 7);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(121, 27);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // pnlDados
            // 
            this.pnlDados.BackColor = System.Drawing.Color.LightCoral;
            this.pnlDados.Controls.Add(this.lblUsuarioIncorreto);
            this.pnlDados.Controls.Add(this.label2);
            this.pnlDados.Controls.Add(this.txbSenha);
            this.pnlDados.Controls.Add(this.label1);
            this.pnlDados.Controls.Add(this.txbLogin);
            this.pnlDados.Location = new System.Drawing.Point(178, 202);
            this.pnlDados.Name = "pnlDados";
            this.pnlDados.Size = new System.Drawing.Size(296, 119);
            this.pnlDados.TabIndex = 2;
            // 
            // lblUsuarioIncorreto
            // 
            this.lblUsuarioIncorreto.AutoSize = true;
            this.lblUsuarioIncorreto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarioIncorreto.ForeColor = System.Drawing.Color.White;
            this.lblUsuarioIncorreto.Location = new System.Drawing.Point(26, 104);
            this.lblUsuarioIncorreto.Name = "lblUsuarioIncorreto";
            this.lblUsuarioIncorreto.Size = new System.Drawing.Size(166, 13);
            this.lblUsuarioIncorreto.TabIndex = 4;
            this.lblUsuarioIncorreto.Text = "Usuário ou senha incorretos";
            this.lblUsuarioIncorreto.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Senha";
            // 
            // txbSenha
            // 
            this.txbSenha.BackColor = System.Drawing.Color.IndianRed;
            this.txbSenha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbSenha.ForeColor = System.Drawing.Color.White;
            this.txbSenha.Location = new System.Drawing.Point(25, 77);
            this.txbSenha.MaxLength = 60;
            this.txbSenha.Name = "txbSenha";
            this.txbSenha.PasswordChar = '*';
            this.txbSenha.Size = new System.Drawing.Size(250, 20);
            this.txbSenha.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "E-Mail";
            // 
            // txbLogin
            // 
            this.txbLogin.BackColor = System.Drawing.Color.IndianRed;
            this.txbLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbLogin.ForeColor = System.Drawing.Color.White;
            this.txbLogin.Location = new System.Drawing.Point(25, 27);
            this.txbLogin.MaxLength = 60;
            this.txbLogin.Name = "txbLogin";
            this.txbLogin.Size = new System.Drawing.Size(250, 20);
            this.txbLogin.TabIndex = 0;
            // 
            // picLogo
            // 
            this.picLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picLogo.BackColor = System.Drawing.Color.LightCoral;
            this.picLogo.Image = global::pFinchFila.Properties.Resources.Sem_Título_11;
            this.picLogo.Location = new System.Drawing.Point(22, 12);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(500, 150);
            this.picLogo.TabIndex = 1;
            this.picLogo.TabStop = false;
            // 
            // pnlFechar
            // 
            this.pnlFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlFechar.Controls.Add(this.lbFechar);
            this.pnlFechar.Location = new System.Drawing.Point(736, 3);
            this.pnlFechar.Name = "pnlFechar";
            this.pnlFechar.Size = new System.Drawing.Size(31, 31);
            this.pnlFechar.TabIndex = 0;
            this.pnlFechar.MouseEnter += new System.EventHandler(this.pnlFechar_MouseEnter);
            this.pnlFechar.MouseLeave += new System.EventHandler(this.pnlFechar_MouseLeave);
            // 
            // lbFechar
            // 
            this.lbFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFechar.ForeColor = System.Drawing.Color.Black;
            this.lbFechar.Location = new System.Drawing.Point(0, 0);
            this.lbFechar.Name = "lbFechar";
            this.lbFechar.Size = new System.Drawing.Size(31, 31);
            this.lbFechar.TabIndex = 0;
            this.lbFechar.Text = "X";
            this.lbFechar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbFechar.Click += new System.EventHandler(this.lbFechar_Click);
            this.lbFechar.MouseEnter += new System.EventHandler(this.lbFechar_MouseEnter);
            this.lbFechar.MouseLeave += new System.EventHandler(this.lbFechar_MouseLeave);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 380);
            this.Controls.Add(this.pnlFundo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Shown += new System.EventHandler(this.frmLogin_Shown);
            this.ResizeBegin += new System.EventHandler(this.frmLogin_ResizeBegin);
            this.pnlFundo.ResumeLayout(false);
            this.pnlConfigEmail.ResumeLayout(false);
            this.pnlConfigEmail.PerformLayout();
            this.pnlButton.ResumeLayout(false);
            this.pnlDados.ResumeLayout(false);
            this.pnlDados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.pnlFechar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlFundo;
        private System.Windows.Forms.Panel pnlFechar;
        private System.Windows.Forms.Label lbFechar;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Panel pnlDados;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbSenha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbLogin;
        private System.Windows.Forms.Panel pnlButton;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblUsuarioIncorreto;
        private System.Windows.Forms.Panel pnlConfigEmail;
        private System.Windows.Forms.Button btnConfigEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtConfigEmail;
    }
}

