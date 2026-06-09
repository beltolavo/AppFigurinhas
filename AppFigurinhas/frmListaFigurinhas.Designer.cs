namespace AppFigurinhas
{
    partial class frmListaFigurinhas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListaFigurinhas));
            this.txtFiltroNome = new System.Windows.Forms.TextBox();
            this.lblNomeBusca = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.lblSelecao = new System.Windows.Forms.Label();
            this.txtFiltroSelecao = new System.Windows.Forms.TextBox();
            this.lblRaridade = new System.Windows.Forms.Label();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblStatusFigurinha = new System.Windows.Forms.Label();
            this.cmbFiltroStatus = new System.Windows.Forms.ComboBox();
            this.cmbFiltroRaridade = new System.Windows.Forms.ComboBox();
            this.lstFigurinhas = new System.Windows.Forms.ListBox();
            this.lblFigurinhas = new System.Windows.Forms.Label();
            this.btnVisualizar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtFiltroNome
            // 
            this.txtFiltroNome.Location = new System.Drawing.Point(9, 37);
            this.txtFiltroNome.Name = "txtFiltroNome";
            this.txtFiltroNome.Size = new System.Drawing.Size(286, 25);
            this.txtFiltroNome.TabIndex = 0;
            // 
            // lblNomeBusca
            // 
            this.lblNomeBusca.AutoSize = true;
            this.lblNomeBusca.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeBusca.Location = new System.Drawing.Point(6, 18);
            this.lblNomeBusca.Name = "lblNomeBusca";
            this.lblNomeBusca.Size = new System.Drawing.Size(47, 17);
            this.lblNomeBusca.TabIndex = 1;
            this.lblNomeBusca.Text = "Nome:";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.Color.Transparent;
            this.btnPesquisar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisar.Image")));
            this.btnPesquisar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPesquisar.Location = new System.Drawing.Point(464, 126);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(114, 40);
            this.btnPesquisar.TabIndex = 23;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // lblSelecao
            // 
            this.lblSelecao.AutoSize = true;
            this.lblSelecao.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelecao.Location = new System.Drawing.Point(313, 18);
            this.lblSelecao.Name = "lblSelecao";
            this.lblSelecao.Size = new System.Drawing.Size(56, 17);
            this.lblSelecao.TabIndex = 25;
            this.lblSelecao.Text = "Seleção:";
            // 
            // txtFiltroSelecao
            // 
            this.txtFiltroSelecao.Location = new System.Drawing.Point(316, 37);
            this.txtFiltroSelecao.Name = "txtFiltroSelecao";
            this.txtFiltroSelecao.Size = new System.Drawing.Size(262, 25);
            this.txtFiltroSelecao.TabIndex = 24;
            // 
            // lblRaridade
            // 
            this.lblRaridade.AutoSize = true;
            this.lblRaridade.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRaridade.Location = new System.Drawing.Point(6, 74);
            this.lblRaridade.Name = "lblRaridade";
            this.lblRaridade.Size = new System.Drawing.Size(64, 17);
            this.lblRaridade.TabIndex = 27;
            this.lblRaridade.Text = "Raridade:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox1.Controls.Add(this.lblStatusFigurinha);
            this.groupBox1.Controls.Add(this.cmbFiltroStatus);
            this.groupBox1.Controls.Add(this.cmbFiltroRaridade);
            this.groupBox1.Controls.Add(this.lblRaridade);
            this.groupBox1.Controls.Add(this.btnPesquisar);
            this.groupBox1.Controls.Add(this.lblSelecao);
            this.groupBox1.Controls.Add(this.txtFiltroSelecao);
            this.groupBox1.Controls.Add(this.lblNomeBusca);
            this.groupBox1.Controls.Add(this.txtFiltroNome);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(58, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(601, 172);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // lblStatusFigurinha
            // 
            this.lblStatusFigurinha.AutoSize = true;
            this.lblStatusFigurinha.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusFigurinha.Location = new System.Drawing.Point(313, 74);
            this.lblStatusFigurinha.Name = "lblStatusFigurinha";
            this.lblStatusFigurinha.Size = new System.Drawing.Size(122, 17);
            this.lblStatusFigurinha.TabIndex = 30;
            this.lblStatusFigurinha.Text = "Status da Figurinha:";
            // 
            // cmbFiltroStatus
            // 
            this.cmbFiltroStatus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbFiltroStatus.FormattingEnabled = true;
            this.cmbFiltroStatus.Location = new System.Drawing.Point(316, 94);
            this.cmbFiltroStatus.Name = "cmbFiltroStatus";
            this.cmbFiltroStatus.Size = new System.Drawing.Size(191, 25);
            this.cmbFiltroStatus.TabIndex = 29;
            this.cmbFiltroStatus.SelectedIndexChanged += new System.EventHandler(this.cmbStatus_SelectedIndexChanged);
            // 
            // cmbFiltroRaridade
            // 
            this.cmbFiltroRaridade.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbFiltroRaridade.FormattingEnabled = true;
            this.cmbFiltroRaridade.Items.AddRange(new object[] {
            "Roxo",
            "Bronze",
            "Prata",
            "Dourado"});
            this.cmbFiltroRaridade.Location = new System.Drawing.Point(9, 94);
            this.cmbFiltroRaridade.Name = "cmbFiltroRaridade";
            this.cmbFiltroRaridade.Size = new System.Drawing.Size(247, 25);
            this.cmbFiltroRaridade.TabIndex = 28;
            // 
            // lstFigurinhas
            // 
            this.lstFigurinhas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lstFigurinhas.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstFigurinhas.FormattingEnabled = true;
            this.lstFigurinhas.ItemHeight = 17;
            this.lstFigurinhas.Location = new System.Drawing.Point(58, 276);
            this.lstFigurinhas.Name = "lstFigurinhas";
            this.lstFigurinhas.Size = new System.Drawing.Size(360, 225);
            this.lstFigurinhas.TabIndex = 29;
            // 
            // lblFigurinhas
            // 
            this.lblFigurinhas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFigurinhas.AutoSize = true;
            this.lblFigurinhas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblFigurinhas.Location = new System.Drawing.Point(55, 256);
            this.lblFigurinhas.Name = "lblFigurinhas";
            this.lblFigurinhas.Size = new System.Drawing.Size(162, 17);
            this.lblFigurinhas.TabIndex = 28;
            this.lblFigurinhas.Text = "Figurinhas Cadastradas:";
            this.lblFigurinhas.Click += new System.EventHandler(this.lblFigurinhas_Click);
            // 
            // btnVisualizar
            // 
            this.btnVisualizar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnVisualizar.BackColor = System.Drawing.Color.Transparent;
            this.btnVisualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVisualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVisualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnVisualizar.Image")));
            this.btnVisualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVisualizar.Location = new System.Drawing.Point(522, 366);
            this.btnVisualizar.Name = "btnVisualizar";
            this.btnVisualizar.Size = new System.Drawing.Size(94, 43);
            this.btnVisualizar.TabIndex = 31;
            this.btnVisualizar.Text = "Visualizar";
            this.btnVisualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVisualizar.UseVisualStyleBackColor = false;
            this.btnVisualizar.Click += new System.EventHandler(this.btnVisualizar_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(0, 584);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(720, 64);
            this.panel1.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(313, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 52);
            this.label2.TabIndex = 0;
            this.label2.Text = "Versão 1.0.0\nOlavo Beltran\nKaique Messias\nKauã Emanuel";
            // 
            // lblHora
            // 
            this.lblHora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHora.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.Color.White;
            this.lblHora.Location = new System.Drawing.Point(548, 8);
            this.lblHora.Name = "lblHora";
            this.lblHora.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblHora.Size = new System.Drawing.Size(169, 25);
            this.lblHora.TabIndex = 5;
            this.lblHora.Text = "hora";
            // 
            // lblData
            // 
            this.lblData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.ForeColor = System.Drawing.Color.White;
            this.lblData.Location = new System.Drawing.Point(545, 33);
            this.lblData.Name = "lblData";
            this.lblData.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblData.Size = new System.Drawing.Size(169, 25);
            this.lblData.TabIndex = 6;
            this.lblData.Text = "hora";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(277, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 21);
            this.label1.TabIndex = 10;
            this.label1.Text = "Minhas Figurinhas";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.lblData);
            this.panel2.Controls.Add(this.lblHora);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(720, 56);
            this.panel2.TabIndex = 33;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // frmListaFigurinhas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.ClientSize = new System.Drawing.Size(720, 648);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnVisualizar);
            this.Controls.Add(this.lblFigurinhas);
            this.Controls.Add(this.lstFigurinhas);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmListaFigurinhas";
            this.Text = "frmListaFigurinhas";
            this.Load += new System.EventHandler(this.frmListaFigurinhas_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFiltroNome;
        private System.Windows.Forms.Label lblNomeBusca;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Label lblSelecao;
        private System.Windows.Forms.TextBox txtFiltroSelecao;
        private System.Windows.Forms.Label lblRaridade;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lstFigurinhas;
        private System.Windows.Forms.Label lblFigurinhas;
        private System.Windows.Forms.Button btnVisualizar;
        private System.Windows.Forms.ComboBox cmbFiltroRaridade;
        private System.Windows.Forms.Label lblStatusFigurinha;
        private System.Windows.Forms.ComboBox cmbFiltroStatus;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
    }
}