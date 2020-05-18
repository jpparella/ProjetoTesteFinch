using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace pFinchFila
{
    public partial class frmServicos : Form
    {
        List<Fila> JsonTest;
        Class_BD Conexao;
        
        public frmServicos(Class_BD Connect)
        {
            InitializeComponent();
            Conexao = Connect;
        }


        private void frmServicos_Load(object sender, EventArgs e)
        {

            if ((JsonTest == null))
            {
                string strJSON;


                strJSON = JSONHelper.GetJSONString(String.Format("http://virtserver.swaggerhub.com/finch/avaliacao/1.0.0/fila"));
                //lblBalancoContinentesJSON.Text = strJSON;




                //var JsonTest = JSONHelper.GetObjectFromJSONString<List<Fila>>(strJSON);
                JsonTest = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Fila>>(strJSON);



                //textBox6.Text = JsonTest.;
                
            }
            
            dgvServicos.DataSource = (JsonTest);
            
            for (int i = 0; i < dgvServicos.Columns.Count; i++)
            {
                dgvServicos.Columns[i].Visible = !((dgvServicos.Columns[i].HeaderText == "Id") || (dgvServicos.Columns[i].HeaderText == "Tipo"));
            }

            for (int i = 0; i < dgvServicos.Rows.Count; i++)
            {
                if (Conexao.TestaServico(dgvServicos.Rows[i].Cells[0].Value.ToString()))
                {
                    dgvServicos.Rows[i].Visible = false;
                }
            }
            


            //foreach(Guid ID in JsonTest.DataAgendamento)
        }



        

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            pnlDados.Visible = true;
            txbValor.Text = String.Format("{0:N}", JsonTest.ElementAt(dgvServicos.CurrentRow.Index).Tipo.Valor);
            txbTipo.Text= JsonTest.ElementAt(dgvServicos.CurrentRow.Index).Tipo.Descricao;
            txbAgendamento.Text = JsonTest.ElementAt(dgvServicos.CurrentRow.Index).DataAgendamento.ToString("dd/MM/yyyy");
            txbNomeCliente.Text = JsonTest.ElementAt(dgvServicos.CurrentRow.Index).Cliente;
            txbObs.Text = JsonTest.ElementAt(dgvServicos.CurrentRow.Index).Observacao;
            
        }

        private void panel1_VisibleChanged(object sender, EventArgs e)
        {
            pnlDados.Location = new Point((this.Size.Width / 2) - (pnlDados.Size.Width / 2), (this.Size.Height / 2) - (pnlDados.Size.Height / 2));
        }

        private void btnPegarSevico_Click(object sender, EventArgs e)
        {
            if (Conexao.InsertServico(JsonTest.ElementAt(dgvServicos.CurrentRow.Index).Id.ToString(),txbNomeCliente.Text))
            {
                Conexao.Envios.EmailInicio(JsonTest.ElementAt(dgvServicos.CurrentRow.Index).Id.ToString() , txbNomeCliente.Text, Conexao.getUsuariologado()) ;             
                btnCancel_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Não foi possível iniciar o serviço. "+Conexao.Error, "Erro", MessageBoxButtons.OK);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            pnlDados.Visible = false;
        }

        private void serviçosIniciadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new frmServicosIniciados(this.Conexao);
            f.Closed += (s, args) => this.Show();
            f.Show();
        }
    }
}
