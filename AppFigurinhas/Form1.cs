using System;
using System.Windows.Forms;

namespace AppFigurinhas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

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
                "Minha Coleção de Figurinhas" + Environment.NewLine +
                Environment.NewLine +
                "Esse aplicativo foi desenvolvido para que nossos usuários possam cadastrar suas" +
                "figurinhas do álbum copa do mundo de 2026 e poder analisar as figurinhas que lhe faltam e as que já obtiveram.");
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
    }
}
