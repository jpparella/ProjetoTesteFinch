using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pFinchFila
{
    
    public partial class frmCadastro : Form
    {
        Class_BD Conexao;
        public frmCadastro(Class_BD Connect)
        {
            InitializeComponent();
            Conexao = Connect;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (txtSenha.PasswordChar == '*')
            { 
                picPass.BackgroundImage = pFinchFila.Properties.Resources.eye2;
                txtSenha.PasswordChar = '\0';
            }
            else
            {
                picPass.BackgroundImage = pFinchFila.Properties.Resources.eye1;
                txtSenha.PasswordChar = '*';
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int abort = 0;
            if (txtEmail.Text == "")
            {
                MessageBox.Show("Email não informado, item obrigatório.", "Item Obrigatório", MessageBoxButtons.OK);
                txtEmail.Focus();
                abort = 1;
            }
            if (txtNome.Text == "")
            {
                MessageBox.Show("Nome não informado, item obrigatório.", "Item Obrigatório", MessageBoxButtons.OK);
                txtNome.Focus();
                abort = 1;
            }
            if (txtSenha.Text == "")
            {
                MessageBox.Show("Senha não informada, item obrigatório.", "Item Obrigatório", MessageBoxButtons.OK);
                txtSenha.Focus();
                abort = 1;
            }
            if (msktxtCPF.Text == "")
            {
                MessageBox.Show("CPF não informado, item obrigatório.", "Item Obrigatório", MessageBoxButtons.OK);
                msktxtCPF.Focus();
                abort = 1;
            }
            if (Conexao.TestaUser(txtEmail.Text,msktxtCPF.Text))
            {
                MessageBox.Show("Usuario ja cadastrado, efetue login.", "Usuario cadastrado", MessageBoxButtons.OK);
            }
            else if (abort != 1)
            {
                if (Conexao.InsertUsuario(msktxtCPF.Text, txtNome.Text, txtEmail.Text, txtSenha.Text))
                {
                    Close();
                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar usuário. Erro: "+Conexao.Error, "Erro", MessageBoxButtons.OK);
                }
            }
        }
    }
}
