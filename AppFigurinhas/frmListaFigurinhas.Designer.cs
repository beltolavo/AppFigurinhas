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
            this.txtFiltroNome = new System.Windows.Forms.TextBox();
            this.lblNomeBusca = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.chkFiltroDesejadas = new System.Windows.Forms.CheckBox();
            this.chkFiltroObtidas = new System.Windows.Forms.CheckBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.lblSelecao = new System.Windows.Forms.Label();
            this.txtFiltroSelecao = new System.Windows.Forms.TextBox();
            this.lblRaridade = new System.Windows.Forms.Label();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstFigurinhas = new System.Windows.Forms.ListBox();
            this.lblFigurinhas = new System.Windows.Forms.Label();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnVisualizar = new System.Windows.Forms.Button();
            this.btnDesejado = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.txtRaridade = new System.Windows.Forms.TextBox();
            this.txtSelecao = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblRaridadeFigurinha = new System.Windows.Forms.Label();
            this.lblSelecaoFigurinha = new System.Windows.Forms.Label();
            this.lblNomeFigurinha = new System.Windows.Forms.Label();
            this.picFotoFigurinha = new System.Windows.Forms.PictureBox();
            this.btnObtido = new System.Windows.Forms.Button();
            this.cmbFiltroRaridade = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFotoFigurinha)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFiltroNome
            // 
            this.txtFiltroNome.Location = new System.Drawing.Point(9, 37);
            this.txtFiltroNome.Name = "txtFiltroNome";
            this.txtFiltroNome.Size = new System.Drawing.Size(286, 20);
            this.txtFiltroNome.TabIndex = 0;
            // 
            // lblNomeBusca
            // 
            this.lblNomeBusca.AutoSize = true;
            this.lblNomeBusca.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblNomeBusca.Location = new System.Drawing.Point(6, 18);
            this.lblNomeBusca.Name = "lblNomeBusca";
            this.lblNomeBusca.Size = new System.Drawing.Size(49, 17);
            this.lblNomeBusca.TabIndex = 1;
            this.lblNomeBusca.Text = "Nome:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(628, 56);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(244, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 25);
            this.label1.TabIndex = 20;
            this.label1.Text = "Lista de Figurinhas";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // chkFiltroDesejadas
            // 
            this.chkFiltroDesejadas.AutoSize = true;
            this.chkFiltroDesejadas.Location = new System.Drawing.Point(450, 83);
            this.chkFiltroDesejadas.Name = "chkFiltroDesejadas";
            this.chkFiltroDesejadas.Size = new System.Drawing.Size(76, 17);
            this.chkFiltroDesejadas.TabIndex = 21;
            this.chkFiltroDesejadas.Text = "Desejadas";
            this.chkFiltroDesejadas.UseVisualStyleBackColor = true;
            // 
            // chkFiltroObtidas
            // 
            this.chkFiltroObtidas.AutoSize = true;
            this.chkFiltroObtidas.Location = new System.Drawing.Point(382, 83);
            this.chkFiltroObtidas.Name = "chkFiltroObtidas";
            this.chkFiltroObtidas.Size = new System.Drawing.Size(62, 17);
            this.chkFiltroObtidas.TabIndex = 22;
            this.chkFiltroObtidas.Text = "Obtidas";
            this.chkFiltroObtidas.UseVisualStyleBackColor = true;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(464, 130);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(114, 29);
            this.btnPesquisar.TabIndex = 23;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // lblSelecao
            // 
            this.lblSelecao.AutoSize = true;
            this.lblSelecao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblSelecao.Location = new System.Drawing.Point(313, 18);
            this.lblSelecao.Name = "lblSelecao";
            this.lblSelecao.Size = new System.Drawing.Size(63, 17);
            this.lblSelecao.TabIndex = 25;
            this.lblSelecao.Text = "Seleção:";
            // 
            // txtFiltroSelecao
            // 
            this.txtFiltroSelecao.Location = new System.Drawing.Point(316, 37);
            this.txtFiltroSelecao.Name = "txtFiltroSelecao";
            this.txtFiltroSelecao.Size = new System.Drawing.Size(262, 20);
            this.txtFiltroSelecao.TabIndex = 24;
            // 
            // lblRaridade
            // 
            this.lblRaridade.AutoSize = true;
            this.lblRaridade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblRaridade.Location = new System.Drawing.Point(6, 74);
            this.lblRaridade.Name = "lblRaridade";
            this.lblRaridade.Size = new System.Drawing.Size(70, 17);
            this.lblRaridade.TabIndex = 27;
            this.lblRaridade.Text = "Raridade:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.cmbFiltroRaridade);
            this.groupBox1.Controls.Add(this.lblRaridade);
            this.groupBox1.Controls.Add(this.btnPesquisar);
            this.groupBox1.Controls.Add(this.chkFiltroObtidas);
            this.groupBox1.Controls.Add(this.lblSelecao);
            this.groupBox1.Controls.Add(this.chkFiltroDesejadas);
            this.groupBox1.Controls.Add(this.txtFiltroSelecao);
            this.groupBox1.Controls.Add(this.lblNomeBusca);
            this.groupBox1.Controls.Add(this.txtFiltroNome);
            this.groupBox1.Location = new System.Drawing.Point(15, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(601, 165);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // lstFigurinhas
            // 
            this.lstFigurinhas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lstFigurinhas.FormattingEnabled = true;
            this.lstFigurinhas.Location = new System.Drawing.Point(12, 267);
            this.lstFigurinhas.Name = "lstFigurinhas";
            this.lstFigurinhas.Size = new System.Drawing.Size(247, 381);
            this.lstFigurinhas.TabIndex = 29;
            // 
            // lblFigurinhas
            // 
            this.lblFigurinhas.AutoSize = true;
            this.lblFigurinhas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblFigurinhas.Location = new System.Drawing.Point(12, 241);
            this.lblFigurinhas.Name = "lblFigurinhas";
            this.lblFigurinhas.Size = new System.Drawing.Size(42, 17);
            this.lblFigurinhas.TabIndex = 28;
            this.lblFigurinhas.Text = "Lista:";
            this.lblFigurinhas.Click += new System.EventHandler(this.lblFigurinhas_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(513, 665);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(103, 29);
            this.btnExcluir.TabIndex = 30;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnVisualizar
            // 
            this.btnVisualizar.Location = new System.Drawing.Point(186, 665);
            this.btnVisualizar.Name = "btnVisualizar";
            this.btnVisualizar.Size = new System.Drawing.Size(103, 29);
            this.btnVisualizar.TabIndex = 31;
            this.btnVisualizar.Text = "Visualizar";
            this.btnVisualizar.UseVisualStyleBackColor = true;
            // 
            // btnDesejado
            // 
            this.btnDesejado.Location = new System.Drawing.Point(404, 665);
            this.btnDesejado.Name = "btnDesejado";
            this.btnDesejado.Size = new System.Drawing.Size(103, 29);
            this.btnDesejado.TabIndex = 32;
            this.btnDesejado.Text = "Desejado";
            this.btnDesejado.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtStatus);
            this.groupBox2.Controls.Add(this.txtRaridade);
            this.groupBox2.Controls.Add(this.txtSelecao);
            this.groupBox2.Controls.Add(this.txtNome);
            this.groupBox2.Controls.Add(this.lblRaridadeFigurinha);
            this.groupBox2.Controls.Add(this.lblSelecaoFigurinha);
            this.groupBox2.Controls.Add(this.lblNomeFigurinha);
            this.groupBox2.Controls.Add(this.picFotoFigurinha);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox2.Location = new System.Drawing.Point(312, 258);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(305, 390);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Figurinha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(7, 360);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 37;
            this.label2.Text = "Status:";
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(65, 357);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(217, 23);
            this.txtStatus.TabIndex = 36;
            // 
            // txtRaridade
            // 
            this.txtRaridade.Location = new System.Drawing.Point(83, 325);
            this.txtRaridade.Name = "txtRaridade";
            this.txtRaridade.Size = new System.Drawing.Size(199, 23);
            this.txtRaridade.TabIndex = 33;
            // 
            // txtSelecao
            // 
            this.txtSelecao.Location = new System.Drawing.Point(71, 289);
            this.txtSelecao.Name = "txtSelecao";
            this.txtSelecao.Size = new System.Drawing.Size(211, 23);
            this.txtSelecao.TabIndex = 32;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(55, 258);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(227, 23);
            this.txtNome.TabIndex = 28;
            // 
            // lblRaridadeFigurinha
            // 
            this.lblRaridadeFigurinha.AutoSize = true;
            this.lblRaridadeFigurinha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblRaridadeFigurinha.Location = new System.Drawing.Point(7, 328);
            this.lblRaridadeFigurinha.Name = "lblRaridadeFigurinha";
            this.lblRaridadeFigurinha.Size = new System.Drawing.Size(70, 17);
            this.lblRaridadeFigurinha.TabIndex = 28;
            this.lblRaridadeFigurinha.Text = "Raridade:";
            // 
            // lblSelecaoFigurinha
            // 
            this.lblSelecaoFigurinha.AutoSize = true;
            this.lblSelecaoFigurinha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblSelecaoFigurinha.Location = new System.Drawing.Point(7, 292);
            this.lblSelecaoFigurinha.Name = "lblSelecaoFigurinha";
            this.lblSelecaoFigurinha.Size = new System.Drawing.Size(63, 17);
            this.lblSelecaoFigurinha.TabIndex = 29;
            this.lblSelecaoFigurinha.Text = "Seleção:";
            // 
            // lblNomeFigurinha
            // 
            this.lblNomeFigurinha.AutoSize = true;
            this.lblNomeFigurinha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblNomeFigurinha.Location = new System.Drawing.Point(7, 258);
            this.lblNomeFigurinha.Name = "lblNomeFigurinha";
            this.lblNomeFigurinha.Size = new System.Drawing.Size(49, 17);
            this.lblNomeFigurinha.TabIndex = 30;
            this.lblNomeFigurinha.Text = "Nome:";
            // 
            // picFotoFigurinha
            // 
            this.picFotoFigurinha.Location = new System.Drawing.Point(83, 37);
            this.picFotoFigurinha.Name = "picFotoFigurinha";
            this.picFotoFigurinha.Size = new System.Drawing.Size(159, 215);
            this.picFotoFigurinha.TabIndex = 0;
            this.picFotoFigurinha.TabStop = false;
            // 
            // btnObtido
            // 
            this.btnObtido.Location = new System.Drawing.Point(295, 665);
            this.btnObtido.Name = "btnObtido";
            this.btnObtido.Size = new System.Drawing.Size(103, 29);
            this.btnObtido.TabIndex = 36;
            this.btnObtido.Text = "Obtido";
            this.btnObtido.UseVisualStyleBackColor = true;
            // 
            // cmbFiltroRaridade
            // 
            this.cmbFiltroRaridade.FormattingEnabled = true;
            this.cmbFiltroRaridade.Items.AddRange(new object[] {
            "Roxo",
            "Bronze",
            "Prata",
            "Dourado"});
            this.cmbFiltroRaridade.Location = new System.Drawing.Point(9, 94);
            this.cmbFiltroRaridade.Name = "cmbFiltroRaridade";
            this.cmbFiltroRaridade.Size = new System.Drawing.Size(247, 21);
            this.cmbFiltroRaridade.TabIndex = 28;
            // 
            // frmListaFigurinhas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 706);
            this.Controls.Add(this.btnObtido);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnDesejado);
            this.Controls.Add(this.btnVisualizar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.lblFigurinhas);
            this.Controls.Add(this.lstFigurinhas);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "frmListaFigurinhas";
            this.Text = "frmListaFigurinhas";
            this.Load += new System.EventHandler(this.frmListaFigurinhas_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFotoFigurinha)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFiltroNome;
        private System.Windows.Forms.Label lblNomeBusca;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkFiltroDesejadas;
        private System.Windows.Forms.CheckBox chkFiltroObtidas;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Label lblSelecao;
        private System.Windows.Forms.TextBox txtFiltroSelecao;
        private System.Windows.Forms.Label lblRaridade;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lstFigurinhas;
        private System.Windows.Forms.Label lblFigurinhas;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnVisualizar;
        private System.Windows.Forms.Button btnDesejado;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblRaridadeFigurinha;
        private System.Windows.Forms.Label lblSelecaoFigurinha;
        private System.Windows.Forms.Label lblNomeFigurinha;
        private System.Windows.Forms.PictureBox picFotoFigurinha;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtRaridade;
        private System.Windows.Forms.TextBox txtSelecao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Button btnObtido;
        private System.Windows.Forms.ComboBox cmbFiltroRaridade;
    }
}