namespace pFinchFila
{
    partial class frmServicos
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
            this.components = new System.ComponentModel.Container();
            this.dgvServicos = new System.Windows.Forms.DataGridView();
            this.cmsAlterar = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.serviçosIniciadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlDados = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnPegarSevico = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbTipo = new System.Windows.Forms.TextBox();
            this.txbValor = new System.Windows.Forms.TextBox();
            this.txbObs = new System.Windows.Forms.TextBox();
            this.txbAgendamento = new System.Windows.Forms.TextBox();
            this.txbNomeCliente = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServicos)).BeginInit();
            this.cmsAlterar.SuspendLayout();
            this.pnlDados.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvServicos
            // 
            this.dgvServicos.AllowUserToDeleteRows = false;
            this.dgvServicos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvServicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServicos.ContextMenuStrip = this.cmsAlterar;
            this.dgvServicos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvServicos.Location = new System.Drawing.Point(0, 0);
            this.dgvServicos.Name = "dgvServicos";
            this.dgvServicos.ReadOnly = true;
            this.dgvServicos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvServicos.Size = new System.Drawing.Size(701, 274);
            this.dgvServicos.TabIndex = 0;
            // 
            // cmsAlterar
            // 
            this.cmsAlterar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.serviçosIniciadosToolStripMenuItem});
            this.cmsAlterar.Name = "cmsAlterar";
            this.cmsAlterar.Size = new System.Drawing.Size(168, 48);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(167, 22);
            this.toolStripMenuItem1.Text = "Detalhar";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // serviçosIniciadosToolStripMenuItem
            // 
            this.serviçosIniciadosToolStripMenuItem.Name = "serviçosIniciadosToolStripMenuItem";
            this.serviçosIniciadosToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.serviçosIniciadosToolStripMenuItem.Text = "Serviços Iniciados";
            this.serviçosIniciadosToolStripMenuItem.Click += new System.EventHandler(this.serviçosIniciadosToolStripMenuItem_Click);
            // 
            // pnlDados
            // 
            this.pnlDados.Controls.Add(this.btnCancel);
            this.pnlDados.Controls.Add(this.btnPegarSevico);
            this.pnlDados.Controls.Add(this.label5);
            this.pnlDados.Controls.Add(this.label4);
            this.pnlDados.Controls.Add(this.label3);
            this.pnlDados.Controls.Add(this.label2);
            this.pnlDados.Controls.Add(this.label1);
            this.pnlDados.Controls.Add(this.txbTipo);
            this.pnlDados.Controls.Add(this.txbValor);
            this.pnlDados.Controls.Add(this.txbObs);
            this.pnlDados.Controls.Add(this.txbAgendamento);
            this.pnlDados.Controls.Add(this.txbNomeCliente);
            this.pnlDados.Location = new System.Drawing.Point(348, 12);
            this.pnlDados.Name = "pnlDados";
            this.pnlDados.Size = new System.Drawing.Size(317, 241);
            this.pnlDados.TabIndex = 2;
            this.pnlDados.Visible = false;
            this.pnlDados.VisibleChanged += new System.EventHandler(this.panel1_VisibleChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(163, 210);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(151, 25);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnPegarSevico
            // 
            this.btnPegarSevico.Location = new System.Drawing.Point(3, 210);
            this.btnPegarSevico.Name = "btnPegarSevico";
            this.btnPegarSevico.Size = new System.Drawing.Size(154, 25);
            this.btnPegarSevico.TabIndex = 10;
            this.btnPegarSevico.Text = "Pegar Serviço";
            this.btnPegarSevico.UseVisualStyleBackColor = true;
            this.btnPegarSevico.Click += new System.EventHandler(this.btnPegarSevico_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Observação";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(184, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Valor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Dt. Agendamento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tipo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nome Cliente";
            // 
            // txbTipo
            // 
            this.txbTipo.Location = new System.Drawing.Point(3, 62);
            this.txbTipo.Name = "txbTipo";
            this.txbTipo.ReadOnly = true;
            this.txbTipo.Size = new System.Drawing.Size(308, 20);
            this.txbTipo.TabIndex = 4;
            // 
            // txbValor
            // 
            this.txbValor.Location = new System.Drawing.Point(181, 99);
            this.txbValor.Name = "txbValor";
            this.txbValor.ReadOnly = true;
            this.txbValor.Size = new System.Drawing.Size(133, 20);
            this.txbValor.TabIndex = 3;
            // 
            // txbObs
            // 
            this.txbObs.Location = new System.Drawing.Point(3, 136);
            this.txbObs.Multiline = true;
            this.txbObs.Name = "txbObs";
            this.txbObs.ReadOnly = true;
            this.txbObs.Size = new System.Drawing.Size(311, 68);
            this.txbObs.TabIndex = 2;
            // 
            // txbAgendamento
            // 
            this.txbAgendamento.Location = new System.Drawing.Point(3, 99);
            this.txbAgendamento.Name = "txbAgendamento";
            this.txbAgendamento.ReadOnly = true;
            this.txbAgendamento.Size = new System.Drawing.Size(172, 20);
            this.txbAgendamento.TabIndex = 1;
            // 
            // txbNomeCliente
            // 
            this.txbNomeCliente.Location = new System.Drawing.Point(3, 24);
            this.txbNomeCliente.Name = "txbNomeCliente";
            this.txbNomeCliente.ReadOnly = true;
            this.txbNomeCliente.Size = new System.Drawing.Size(311, 20);
            this.txbNomeCliente.TabIndex = 0;
            // 
            // frmServicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 274);
            this.Controls.Add(this.pnlDados);
            this.Controls.Add(this.dgvServicos);
            this.Name = "frmServicos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Serviços";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmServicos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvServicos)).EndInit();
            this.cmsAlterar.ResumeLayout(false);
            this.pnlDados.ResumeLayout(false);
            this.pnlDados.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvServicos;
        private System.Windows.Forms.ContextMenuStrip cmsAlterar;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Panel pnlDados;
        private System.Windows.Forms.TextBox txbTipo;
        private System.Windows.Forms.TextBox txbValor;
        private System.Windows.Forms.TextBox txbObs;
        private System.Windows.Forms.TextBox txbAgendamento;
        private System.Windows.Forms.TextBox txbNomeCliente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPegarSevico;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ToolStripMenuItem serviçosIniciadosToolStripMenuItem;
    }
}