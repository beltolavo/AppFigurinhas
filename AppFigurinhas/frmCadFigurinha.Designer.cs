namespace AppFigurinhas
{
    partial class frmCadFigurinha
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
            this.picFoto = new System.Windows.Forms.PictureBox();
            this.btnSelecionar = new System.Windows.Forms.Button();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtDiretorio = new System.Windows.Forms.TextBox();
            this.txtSelecao = new System.Windows.Forms.TextBox();
            this.lblSelecao = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.cmbRaridade = new System.Windows.Forms.ComboBox();
            this.chkObtido = new System.Windows.Forms.CheckBox();
            this.chkDesejado = new System.Windows.Forms.CheckBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.picFoto)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // picFoto
            // 
            this.picFoto.Location = new System.Drawing.Point(312, 71);
            this.picFoto.Name = "picFoto";
            this.picFoto.Size = new System.Drawing.Size(360, 194);
            this.picFoto.TabIndex = 0;
            this.picFoto.TabStop = false;
            // 
            // btnSelecionar
            // 
            this.btnSelecionar.Location = new System.Drawing.Point(597, 271);
            this.btnSelecionar.Name = "btnSelecionar";
            this.btnSelecionar.Size = new System.Drawing.Size(75, 23);
            this.btnSelecionar.TabIndex = 2;
            this.btnSelecionar.Text = "Selecionar foto";
            this.btnSelecionar.UseVisualStyleBackColor = true;
            this.btnSelecionar.Click += new System.EventHandler(this.btnSelecionar_Click);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(4, 94);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 4;
            this.lblNome.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(48, 91);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(258, 20);
            this.txtNome.TabIndex = 9;
            // 
            // txtDiretorio
            // 
            this.txtDiretorio.Location = new System.Drawing.Point(312, 271);
            this.txtDiretorio.Multiline = true;
            this.txtDiretorio.Name = "txtDiretorio";
            this.txtDiretorio.ReadOnly = true;
            this.txtDiretorio.Size = new System.Drawing.Size(279, 23);
            this.txtDiretorio.TabIndex = 10;
            // 
            // txtSelecao
            // 
            this.txtSelecao.Location = new System.Drawing.Point(59, 117);
            this.txtSelecao.Name = "txtSelecao";
            this.txtSelecao.Size = new System.Drawing.Size(247, 20);
            this.txtSelecao.TabIndex = 12;
            // 
            // lblSelecao
            // 
            this.lblSelecao.AutoSize = true;
            this.lblSelecao.Location = new System.Drawing.Point(4, 120);
            this.lblSelecao.Name = "lblSelecao";
            this.lblSelecao.Size = new System.Drawing.Size(49, 13);
            this.lblSelecao.TabIndex = 11;
            this.lblSelecao.Text = "Seleção:";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(4, 146);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(53, 13);
            this.lblTipo.TabIndex = 13;
            this.lblTipo.Text = "Raridade:";
            // 
            // cmbRaridade
            // 
            this.cmbRaridade.FormattingEnabled = true;
            this.cmbRaridade.Items.AddRange(new object[] {
            "Roxo",
            "Bronze",
            "Prata",
            "Dourado"});
            this.cmbRaridade.Location = new System.Drawing.Point(59, 143);
            this.cmbRaridade.Name = "cmbRaridade";
            this.cmbRaridade.Size = new System.Drawing.Size(247, 21);
            this.cmbRaridade.TabIndex = 14;
            this.cmbRaridade.SelectedIndexChanged += new System.EventHandler(this.cmbRaridade_SelectedIndexChanged);
            // 
            // chkObtido
            // 
            this.chkObtido.AutoSize = true;
            this.chkObtido.Location = new System.Drawing.Point(93, 181);
            this.chkObtido.Name = "chkObtido";
            this.chkObtido.Size = new System.Drawing.Size(57, 17);
            this.chkObtido.TabIndex = 15;
            this.chkObtido.Text = "Obtido";
            this.chkObtido.UseVisualStyleBackColor = true;
            // 
            // chkDesejado
            // 
            this.chkDesejado.AutoSize = true;
            this.chkDesejado.Location = new System.Drawing.Point(156, 181);
            this.chkDesejado.Name = "chkDesejado";
            this.chkDesejado.Size = new System.Drawing.Size(71, 17);
            this.chkDesejado.TabIndex = 16;
            this.chkDesejado.Text = "Desejado";
            this.chkDesejado.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(59, 232);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 17;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(156, 232);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(71, 23);
            this.btnCancelar.TabIndex = 18;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(685, 55);
            this.panel1.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(231, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 25);
            this.label1.TabIndex = 20;
            this.label1.Text = "Cadastro de Figurinha";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmCadFigurinha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(678, 305);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.chkDesejado);
            this.Controls.Add(this.chkObtido);
            this.Controls.Add(this.cmbRaridade);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.txtSelecao);
            this.Controls.Add(this.lblSelecao);
            this.Controls.Add(this.txtDiretorio);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.btnSelecionar);
            this.Controls.Add(this.picFoto);
            this.Name = "frmCadFigurinha";
            this.Text = "frmCadFigurinha";
            this.Load += new System.EventHandler(this.frmCadFigurinha_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picFoto)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picFoto;
        private System.Windows.Forms.Button btnSelecionar;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtDiretorio;
        private System.Windows.Forms.TextBox txtSelecao;
        private System.Windows.Forms.Label lblSelecao;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.ComboBox cmbRaridade;
        private System.Windows.Forms.CheckBox chkObtido;
        private System.Windows.Forms.CheckBox chkDesejado;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}