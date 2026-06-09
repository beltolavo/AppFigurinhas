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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVisualizarFigurinha));
            this.btnObtido = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.txtRaridade = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtSelecao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblRaridadeFigurinha = new System.Windows.Forms.Label();
            this.lblSelecaoFigurinha = new System.Windows.Forms.Label();
            this.lblNomeFigurinha = new System.Windows.Forms.Label();
            this.picFotoFigurinha = new System.Windows.Forms.PictureBox();
            this.btnDesejado = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFotoFigurinha)).BeginInit();
            this.SuspendLayout();
            // 
            // btnObtido
            // 
            this.btnObtido.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnObtido.BackColor = System.Drawing.Color.Green;
            this.btnObtido.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnObtido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnObtido.Location = new System.Drawing.Point(17, 529);
            this.btnObtido.Name = "btnObtido";
            this.btnObtido.Size = new System.Drawing.Size(103, 29);
            this.btnObtido.TabIndex = 40;
            this.btnObtido.Text = "✓ Obtido";
            this.btnObtido.UseVisualStyleBackColor = false;
            this.btnObtido.Click += new System.EventHandler(this.btnObtido_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.BackColor = System.Drawing.Color.White;
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
            this.groupBox2.Location = new System.Drawing.Point(23, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(315, 510);
            this.groupBox2.TabIndex = 39;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Figurinha";
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(56, 456);
            this.txtStatus.Multiline = true;
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.Size = new System.Drawing.Size(244, 23);
            this.txtStatus.TabIndex = 44;
            // 
            // txtRaridade
            // 
            this.txtRaridade.Location = new System.Drawing.Point(75, 424);
            this.txtRaridade.Multiline = true;
            this.txtRaridade.Name = "txtRaridade";
            this.txtRaridade.ReadOnly = true;
            this.txtRaridade.Size = new System.Drawing.Size(225, 23);
            this.txtRaridade.TabIndex = 41;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(56, 357);
            this.txtNome.Multiline = true;
            this.txtNome.Name = "txtNome";
            this.txtNome.ReadOnly = true;
            this.txtNome.Size = new System.Drawing.Size(244, 23);
            this.txtNome.TabIndex = 42;
            // 
            // txtSelecao
            // 
            this.txtSelecao.Location = new System.Drawing.Point(66, 388);
            this.txtSelecao.Multiline = true;
            this.txtSelecao.Name = "txtSelecao";
            this.txtSelecao.ReadOnly = true;
            this.txtSelecao.Size = new System.Drawing.Size(234, 23);
            this.txtSelecao.TabIndex = 43;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 459);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 37;
            this.label2.Text = "Status:";
            // 
            // lblRaridadeFigurinha
            // 
            this.lblRaridadeFigurinha.AutoSize = true;
            this.lblRaridadeFigurinha.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRaridadeFigurinha.Location = new System.Drawing.Point(8, 427);
            this.lblRaridadeFigurinha.Name = "lblRaridadeFigurinha";
            this.lblRaridadeFigurinha.Size = new System.Drawing.Size(64, 17);
            this.lblRaridadeFigurinha.TabIndex = 28;
            this.lblRaridadeFigurinha.Text = "Raridade:";
            // 
            // lblSelecaoFigurinha
            // 
            this.lblSelecaoFigurinha.AutoSize = true;
            this.lblSelecaoFigurinha.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelecaoFigurinha.Location = new System.Drawing.Point(8, 391);
            this.lblSelecaoFigurinha.Name = "lblSelecaoFigurinha";
            this.lblSelecaoFigurinha.Size = new System.Drawing.Size(56, 17);
            this.lblSelecaoFigurinha.TabIndex = 29;
            this.lblSelecaoFigurinha.Text = "Seleção:";
            // 
            // lblNomeFigurinha
            // 
            this.lblNomeFigurinha.AutoSize = true;
            this.lblNomeFigurinha.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeFigurinha.Location = new System.Drawing.Point(8, 357);
            this.lblNomeFigurinha.Name = "lblNomeFigurinha";
            this.lblNomeFigurinha.Size = new System.Drawing.Size(47, 17);
            this.lblNomeFigurinha.TabIndex = 30;
            this.lblNomeFigurinha.Text = "Nome:";
            // 
            // picFotoFigurinha
            // 
            this.picFotoFigurinha.BackColor = System.Drawing.Color.Transparent;
            this.picFotoFigurinha.Location = new System.Drawing.Point(37, 22);
            this.picFotoFigurinha.Name = "picFotoFigurinha";
            this.picFotoFigurinha.Size = new System.Drawing.Size(250, 320);
            this.picFotoFigurinha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFotoFigurinha.TabIndex = 0;
            this.picFotoFigurinha.TabStop = false;
            // 
            // btnDesejado
            // 
            this.btnDesejado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDesejado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnDesejado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDesejado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDesejado.Location = new System.Drawing.Point(126, 529);
            this.btnDesejado.Name = "btnDesejado";
            this.btnDesejado.Size = new System.Drawing.Size(103, 29);
            this.btnDesejado.TabIndex = 38;
            this.btnDesejado.Text = "❤ Desejado";
            this.btnDesejado.UseVisualStyleBackColor = false;
            this.btnDesejado.Click += new System.EventHandler(this.btnDesejado_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnExcluir.BackColor = System.Drawing.Color.Red;
            this.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Location = new System.Drawing.Point(235, 529);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(103, 29);
            this.btnExcluir.TabIndex = 37;
            this.btnExcluir.Text = "🗑 Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // frmVisualizarFigurinha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(255)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(364, 575);
            this.Controls.Add(this.btnObtido);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnDesejado);
            this.Controls.Add(this.btnExcluir);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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