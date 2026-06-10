namespace AppFigurinhas
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cdasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minhasFigurinhasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.versãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.suporteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pcbTelaFigurinhas = new System.Windows.Forms.PictureBox();
            this.pcbTelaCadastro = new System.Windows.Forms.PictureBox();
            this.picFundo = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbTelaFigurinhas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbTelaCadastro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFundo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(0, 396);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(739, 65);
            this.panel1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(329, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 52);
            this.label2.TabIndex = 0;
            this.label2.Text = "Versão 1.0.0\nOlavo Beltran\nKaique Messias\nKauã Emanuel";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(561, 271);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(0, 13);
            this.lbl.TabIndex = 5;
            this.lbl.Click += new System.EventHandler(this.label4_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(0)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cdasToolStripMenuItem,
            this.minhasFigurinhasToolStripMenuItem,
            this.ajudaToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(739, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cdasToolStripMenuItem
            // 
            this.cdasToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(0)))));
            this.cdasToolStripMenuItem.Name = "cdasToolStripMenuItem";
            this.cdasToolStripMenuItem.Size = new System.Drawing.Size(140, 20);
            this.cdasToolStripMenuItem.Text = "Cadastro de Figurinhas";
            this.cdasToolStripMenuItem.Click += new System.EventHandler(this.cdasToolStripMenuItem_Click);
            // 
            // minhasFigurinhasToolStripMenuItem
            // 
            this.minhasFigurinhasToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(0)))));
            this.minhasFigurinhasToolStripMenuItem.Name = "minhasFigurinhasToolStripMenuItem";
            this.minhasFigurinhasToolStripMenuItem.Size = new System.Drawing.Size(114, 20);
            this.minhasFigurinhasToolStripMenuItem.Text = "Minhas figurinhas";
            this.minhasFigurinhasToolStripMenuItem.Click += new System.EventHandler(this.minhasFigurinhasToolStripMenuItem_Click);
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(0)))));
            this.ajudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.versãoToolStripMenuItem,
            this.suporteToolStripMenuItem});
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            this.ajudaToolStripMenuItem.Click += new System.EventHandler(this.ajudaToolStripMenuItem_Click);
            // 
            // versãoToolStripMenuItem
            // 
            this.versãoToolStripMenuItem.Name = "versãoToolStripMenuItem";
            this.versãoToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.versãoToolStripMenuItem.Text = "Sobre/Versão";
            this.versãoToolStripMenuItem.Click += new System.EventHandler(this.versãoToolStripMenuItem_Click);
            // 
            // suporteToolStripMenuItem
            // 
            this.suporteToolStripMenuItem.Name = "suporteToolStripMenuItem";
            this.suporteToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.suporteToolStripMenuItem.Text = "Suporte";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(0)))));
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pcbTelaFigurinhas);
            this.panel2.Controls.Add(this.pcbTelaCadastro);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(739, 56);
            this.panel2.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(324, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 21);
            this.label1.TabIndex = 10;
            this.label1.Text = "Menu Inicial";
            // 
            // pcbTelaFigurinhas
            // 
            this.pcbTelaFigurinhas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pcbTelaFigurinhas.BackgroundImage")));
            this.pcbTelaFigurinhas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbTelaFigurinhas.Location = new System.Drawing.Point(58, 8);
            this.pcbTelaFigurinhas.Name = "pcbTelaFigurinhas";
            this.pcbTelaFigurinhas.Size = new System.Drawing.Size(40, 40);
            this.pcbTelaFigurinhas.TabIndex = 1;
            this.pcbTelaFigurinhas.TabStop = false;
            this.pcbTelaFigurinhas.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pcbTelaCadastro
            // 
            this.pcbTelaCadastro.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pcbTelaCadastro.BackgroundImage")));
            this.pcbTelaCadastro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbTelaCadastro.Location = new System.Drawing.Point(12, 8);
            this.pcbTelaCadastro.Name = "pcbTelaCadastro";
            this.pcbTelaCadastro.Size = new System.Drawing.Size(40, 40);
            this.pcbTelaCadastro.TabIndex = 0;
            this.pcbTelaCadastro.TabStop = false;
            this.pcbTelaCadastro.Click += new System.EventHandler(this.pcbTelaCadastro_Click);
            // 
            // picFundo
            // 
            this.picFundo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picFundo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picFundo.BackgroundImage")));
            this.picFundo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picFundo.Location = new System.Drawing.Point(0, 123);
            this.picFundo.Name = "picFundo";
            this.picFundo.Size = new System.Drawing.Size(739, 274);
            this.picFundo.TabIndex = 1;
            this.picFundo.TabStop = false;
            this.picFundo.Click += new System.EventHandler(this.pcFundo_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(167, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(410, 37);
            this.label3.TabIndex = 11;
            this.label3.Text = "App de Cadastro de Figurinhas";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(739, 461);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.picFundo);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbTelaFigurinhas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbTelaCadastro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFundo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cdasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem minhasFigurinhasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem versãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem suporteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pcbTelaFigurinhas;
        private System.Windows.Forms.PictureBox pcbTelaCadastro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picFundo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

