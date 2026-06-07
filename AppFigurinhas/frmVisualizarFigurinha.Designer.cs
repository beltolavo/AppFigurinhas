namespace AppFigurinhas
{
    partial class frmVisualizarFigurinha
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
            this.btnObtido = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblRaridadeFigurinha = new System.Windows.Forms.Label();
            this.lblSelecaoFigurinha = new System.Windows.Forms.Label();
            this.lblNomeFigurinha = new System.Windows.Forms.Label();
            this.picFotoFigurinha = new System.Windows.Forms.PictureBox();
            this.btnDesejado = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.txtRaridade = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtSelecao = new System.Windows.Forms.TextBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFotoFigurinha)).BeginInit();
            this.SuspendLayout();
            // 
            // btnObtido
            // 
            this.btnObtido.Location = new System.Drawing.Point(9, 475);
            this.btnObtido.Name = "btnObtido";
            this.btnObtido.Size = new System.Drawing.Size(103, 29);
            this.btnObtido.TabIndex = 40;
            this.btnObtido.Text = "Obtido";
            this.btnObtido.UseVisualStyleBackColor = true;
            this.btnObtido.Click += new System.EventHandler(this.btnObtido_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtStatus);
            this.groupBox2.Controls.Add(this.txtRaridade);
            this.groupBox2.Controls.Add(this.txtNome);
            this.groupBox2.Controls.Add(this.txtSelecao);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.lblRaridadeFigurinha);
            this.groupBox2.Controls.Add(this.lblSelecaoFigurinha);
            this.groupBox2.Controls.Add(this.lblNomeFigurinha);
            this.groupBox2.Controls.Add(this.picFotoFigurinha);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(305, 442);
            this.groupBox2.TabIndex = 39;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Figurinha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(7, 416);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 37;
            this.label2.Text = "Status:";
            // 
            // lblRaridadeFigurinha
            // 
            this.lblRaridadeFigurinha.AutoSize = true;
            this.lblRaridadeFigurinha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblRaridadeFigurinha.Location = new System.Drawing.Point(7, 384);
            this.lblRaridadeFigurinha.Name = "lblRaridadeFigurinha";
            this.lblRaridadeFigurinha.Size = new System.Drawing.Size(70, 17);
            this.lblRaridadeFigurinha.TabIndex = 28;
            this.lblRaridadeFigurinha.Text = "Raridade:";
            // 
            // lblSelecaoFigurinha
            // 
            this.lblSelecaoFigurinha.AutoSize = true;
            this.lblSelecaoFigurinha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblSelecaoFigurinha.Location = new System.Drawing.Point(7, 348);
            this.lblSelecaoFigurinha.Name = "lblSelecaoFigurinha";
            this.lblSelecaoFigurinha.Size = new System.Drawing.Size(63, 17);
            this.lblSelecaoFigurinha.TabIndex = 29;
            this.lblSelecaoFigurinha.Text = "Seleção:";
            // 
            // lblNomeFigurinha
            // 
            this.lblNomeFigurinha.AutoSize = true;
            this.lblNomeFigurinha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblNomeFigurinha.Location = new System.Drawing.Point(7, 314);
            this.lblNomeFigurinha.Name = "lblNomeFigurinha";
            this.lblNomeFigurinha.Size = new System.Drawing.Size(49, 17);
            this.lblNomeFigurinha.TabIndex = 30;
            this.lblNomeFigurinha.Text = "Nome:";
            // 
            // picFotoFigurinha
            // 
            this.picFotoFigurinha.Location = new System.Drawing.Point(55, 31);
            this.picFotoFigurinha.Name = "picFotoFigurinha";
            this.picFotoFigurinha.Size = new System.Drawing.Size(220, 280);
            this.picFotoFigurinha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFotoFigurinha.TabIndex = 0;
            this.picFotoFigurinha.TabStop = false;
            // 
            // btnDesejado
            // 
            this.btnDesejado.Location = new System.Drawing.Point(118, 475);
            this.btnDesejado.Name = "btnDesejado";
            this.btnDesejado.Size = new System.Drawing.Size(103, 29);
            this.btnDesejado.TabIndex = 38;
            this.btnDesejado.Text = "Desejado";
            this.btnDesejado.UseVisualStyleBackColor = true;
            this.btnDesejado.Click += new System.EventHandler(this.btnDesejado_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(227, 475);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(103, 29);
            this.btnExcluir.TabIndex = 37;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // txtRaridade
            // 
            this.txtRaridade.Location = new System.Drawing.Point(74, 381);
            this.txtRaridade.Multiline = true;
            this.txtRaridade.Name = "txtRaridade";
            this.txtRaridade.ReadOnly = true;
            this.txtRaridade.Size = new System.Drawing.Size(225, 23);
            this.txtRaridade.TabIndex = 41;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(55, 314);
            this.txtNome.Multiline = true;
            this.txtNome.Name = "txtNome";
            this.txtNome.ReadOnly = true;
            this.txtNome.Size = new System.Drawing.Size(244, 23);
            this.txtNome.TabIndex = 42;
            // 
            // txtSelecao
            // 
            this.txtSelecao.Location = new System.Drawing.Point(65, 345);
            this.txtSelecao.Multiline = true;
            this.txtSelecao.Name = "txtSelecao";
            this.txtSelecao.ReadOnly = true;
            this.txtSelecao.Size = new System.Drawing.Size(234, 23);
            this.txtSelecao.TabIndex = 43;
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(55, 413);
            this.txtStatus.Multiline = true;
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.Size = new System.Drawing.Size(244, 23);
            this.txtStatus.TabIndex = 44;
            // 
            // frmVisualizarFigurinha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 524);
            this.Controls.Add(this.btnObtido);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnDesejado);
            this.Controls.Add(this.btnExcluir);
            this.Name = "frmVisualizarFigurinha";
            this.Text = "frmVisualizarFigurinha";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFotoFigurinha)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnObtido;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblRaridadeFigurinha;
        private System.Windows.Forms.Label lblSelecaoFigurinha;
        private System.Windows.Forms.Label lblNomeFigurinha;
        private System.Windows.Forms.PictureBox picFotoFigurinha;
        private System.Windows.Forms.Button btnDesejado;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.TextBox txtRaridade;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtSelecao;
    }
}