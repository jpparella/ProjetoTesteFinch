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
    public partial class frmServicosIniciados : Form
    {
        Class_BD Conexao;
        public frmServicosIniciados(Class_BD Connect)
        {
            InitializeComponent();
            Conexao = Connect;
            dgvServicos.DataSource = Conexao.DadosServicosIniciados().DefaultView;
        }

        private void frmServicosIniciados_Load(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Conexao.FinalizaServico(dgvServicos.CurrentRow.Cells[0].Value.ToString()))
            {
                Conexao.Envios.EmailFecha(dgvServicos.CurrentRow.Cells[0].Value.ToString(),
                                            dgvServicos.CurrentRow.Cells[2].Value.ToString(),
                                            dgvServicos.CurrentRow.Cells[1].Value.ToString());
            }
            else
            {
                MessageBox.Show("Não foi possível fechar o serviço. " + Conexao.Error, "Erro", MessageBoxButtons.OK);
            }
            dgvServicos.DataSource = Conexao.DadosServicosIniciados().DefaultView;
        }
    }
}
