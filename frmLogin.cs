using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CryptSharp;

namespace pFinchFila
{    
    public partial class frmLogin : Form
    {
        public Class_BD Conexao;
        
        public frmLogin()
        {
            InitializeComponent();
        }

        private void fnChangeColorFocus(bool focus)
        {            
            pnlFechar.BackColor = focus ? System.Drawing.Color.Gray : System.Drawing.Color.LightCoral;
            lbFechar.BackColor = pnlFechar.BackColor;
            lbFechar.ForeColor = focus ? System.Drawing.Color.White : System.Drawing.Color.Black;
        }

        private void pnlFechar_MouseEnter(object sender, EventArgs e)
        {
            fnChangeColorFocus(true);
        }

        private void pnlFechar_MouseLeave(object sender, EventArgs e)
        {
            fnChangeColorFocus(false);
        }

        private void lbFechar_MouseEnter(object sender, EventArgs e)
        {
            fnChangeColorFocus(true);
        }

        private void lbFechar_MouseLeave(object sender, EventArgs e)
        {
            fnChangeColorFocus(false);
        }

        private void lbFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmLogin_ResizeBegin(object sender, EventArgs e)
        {          
            
        }

        private void frmLogin_Shown(object sender, EventArgs e)
        {
            Conexao = new Class_BD();
            if (!Conexao.Conectar())
            {
                MessageBox.Show("Banco de dados não conectado! Fechando Sistema", "Erro de banco", MessageBoxButtons.OK);
                Close();
            }
            picLogo.Location = new Point((this.Size.Width /2) - (picLogo.Size.Width / 2), (this.Size.Height / 4) - (picLogo.Size.Height / 2));
            pnlDados.Location = new Point((this.Size.Width / 2) - (pnlDados.Size.Width / 2), (picLogo.Location.Y+ picLogo.Size.Height) );
            pnlButton.Location = new Point((this.Size.Width / 2) - (pnlButton.Size.Width / 2), (pnlDados.Location.Y + pnlDados.Size.Height));
            pnlConfigEmail.Location = new Point((this.Size.Width / 2) - (pnlConfigEmail.Size.Width / 2), (this.Size.Height / 2) - (pnlConfigEmail.Size.Height / 2));
            pnlDados.Visible = false;
            pnlButton.Visible = false;

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new frmCadastro(this.Conexao);
            f.Closed += (s, args) => this.Show();
            f.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (Conexao.Login(txbLogin.Text, txbSenha.Text))
            {
                //MessageBox.Show("Login Efetuado", "Teste", MessageBoxButtons.OK);
                this.Hide();
                Form f = new frmServicos(this.Conexao);
                f.Closed += (s, args) => this.Close();
                f.Show();

                lblUsuarioIncorreto.Visible = false;
            }
            else
            {
                lblUsuarioIncorreto.Visible = true;
            }


        }
        private void btnConfigEmail_Click(object sender, EventArgs e)
        {
            if (txtConfigEmail.Text == "")
            {
                MessageBox.Show("Por favor, informe o e-mail para envio.", "Erro", MessageBoxButtons.OK);
                txtConfigEmail.Focus();
            }
            else
            {
                Conexao.ConfiguraEmail(txtConfigEmail.Text);
                pnlConfigEmail.Visible = false;
                pnlDados.Visible = true;
                pnlButton.Visible = true;
            }
        }
    }
}
