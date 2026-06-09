using System;
using System.IO;
using System.Windows.Forms;

namespace AppFigurinhas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cdasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadFigurinha frm = new frmCadFigurinha();
            frm.ShowDialog();
        }

        private void minhasFigurinhasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListaFigurinhas frm = new frmListaFigurinhas();
            frm.ShowDialog();
        }

        private void versãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "⚽ Bem-vindo ao App Figurinhas 2026!\r\n\r\nEste aplicativo foi criado para ajudar os colecionadores " +
                "a organizarem suas figurinhas da Copa do Mundo de 2026 de forma simples e divertida. Aqui você pode cadastrar " +
                "figurinhas, acompanhar quais já possui, marcar as que deseja conseguir e visualizar sua coleção com facilidade." +
                "\r\n\r\nMonte sua seleção dos sonhos, complete seu álbum e divirta-se colecionando!\r\n\r\n🏆 Boa sorte na busca pelas " +
                "figurinhas mais raras!" +
                Environment.NewLine +
                Environment.NewLine + "Versão 1.0.0");
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult retorno =
                MessageBox.Show(
                    "Deseja realmente sair do aplicativo?",
                    "Confirmação",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

            if (retorno == DialogResult.Yes)
                this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            frmListaFigurinhas frm = new frmListaFigurinhas();
            frm.ShowDialog();
        }

        private void pcbTelaCadastro_Click(object sender, EventArgs e)
        {
            frmCadFigurinha frm = new frmCadFigurinha();
            frm.ShowDialog();
        }

        private void ajudaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pcFundo_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        
    }
}
