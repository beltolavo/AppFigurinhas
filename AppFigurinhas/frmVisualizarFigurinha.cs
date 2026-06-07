using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace AppFigurinhas
{
    public partial class frmVisualizarFigurinha : Form
    {
        string[] _registro;

        public frmVisualizarFigurinha(string[] registro)
        {
            InitializeComponent();

            _registro = registro;

            _registro[6] = _registro[6].Replace("STATUS=", "").Trim();

            CarregarDados();
        }

        void CarregarDados()
        {
            picFotoFigurinha.ImageLocation = _registro[2];
            picFotoFigurinha.Refresh();

            txtNome.Text = _registro[3];
            txtSelecao.Text = _registro[4];
            txtRaridade.Text = _registro[5];

            AtualizarStatus();
        }

        void AtualizarStatus()
        {
            txtStatus.Text = _registro[6].Replace("STATUS=", "").Trim();
        }

        string GetCadastro()
        {
            string cadastro =
                "FOTO=" + _registro[2] +
                Environment.NewLine +
                "NOME=" + _registro[3] +
                Environment.NewLine +
                "SELECAO=" + _registro[4] +
                Environment.NewLine +
                "RARIDADE=" + _registro[5] +
                Environment.NewLine +
                "STATUS=" + _registro[6].Replace("STATUS=", "").Trim();

            return cadastro;
        }

        void SalvarAlteracao()
        {
            try
            {
                File.WriteAllText(_registro[1], GetCadastro());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao salvar alteração: " + ex.Message);
            }
        }

        private void btnObtido_Click(object sender, EventArgs e)
        {
            _registro[6] = "Obtido";

            SalvarAlteracao();
            AtualizarStatus();

            MessageBox.Show("Figurinha marcada como obtida.");
        }

        private void btnDesejado_Click(object sender, EventArgs e)
        {
            _registro[6] = "Desejado";

            SalvarAlteracao();
            AtualizarStatus();

            MessageBox.Show("Figurinha marcada como desejada.");
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult retorno =
                MessageBox.Show("Deseja realmente excluir esta figurinha?",
                                "Confirmação",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question);

            if (retorno == DialogResult.Yes)
            {
                try
                {
                    File.Delete(_registro[1]);

                    MessageBox.Show("Figurinha excluída com sucesso.");

                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Falha ao excluir figurinha: " + ex.Message);
                }
            }
        }
    }
}
