using System;
using System.Windows.Forms;
using System.IO;

namespace AppFigurinhas
{
    public partial class frmCadFigurinha : Form
    {
        public frmCadFigurinha()
        {
            InitializeComponent();
        }

        void MsgAtencao(string Msg)
        {
            MessageBox.Show(Msg, "Atenção",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        void MsgInfo(string Msg)
        {
            MessageBox.Show(Msg, "Informação",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        bool ArquivoExiste(string caminho)
        {
            return File.Exists(caminho);
        }

        void GravarArquivo(string Caminho, string Conteudo)
        {
            string pasta = Path.GetDirectoryName(Caminho);

            if (!Directory.Exists(pasta))
                Directory.CreateDirectory(pasta);

            File.WriteAllText(Caminho, Conteudo);
        }

        string GetDirArquivo(string TipoCadastro, string NomeArquivo)
        {
            string raiz = AppDomain.CurrentDomain.BaseDirectory;

            return Path.Combine(raiz, TipoCadastro, NomeArquivo + ".txt");
        }

        string GetCadastro()
        {
            string cadastro =
                "FOTO=" + txtDiretorio.Text +
                Environment.NewLine +
                "NOME=" + txtNome.Text +
                Environment.NewLine +
                "SELECAO=" + txtSelecao.Text +
                Environment.NewLine +
                "RARIDADE=" + cmbRaridade.Text +
                Environment.NewLine +
                "OBTIDO=" + chkObtido.Checked +
                Environment.NewLine +
                "DESEJADO=" + chkDesejado.Checked;

            return cadastro;
        }

        bool ValidarCampos()
        {
            if (string.IsNullOrEmpty(txtDiretorio.Text))
            {
                MsgAtencao("Selecione a foto da figurinha.");
                return false;
            }

            if (string.IsNullOrEmpty(txtNome.Text))
            {
                MsgAtencao("Preencha o nome da figurinha.");
                return false;
            }

            if (string.IsNullOrEmpty(txtSelecao.Text))
            {
                MsgAtencao("Preencha a seleção.");
                return false;
            }

            if (string.IsNullOrEmpty(cmbRaridade.Text))
            {
                MsgAtencao("Selecione a raridade.");
                return false;
            }

            return true;
        }

        void LimparCampos()
        {
            txtDiretorio.Clear();
            txtNome.Clear();
            txtSelecao.Clear();
            cmbRaridade.Text = "";
            chkObtido.Checked = false;
            chkDesejado.Checked = false;

            picFoto.Image = null;
            picFoto.ImageLocation = "";
            picFoto.Refresh();
        }

        void Salvar()
        {
            if (!ValidarCampos())
                return;

            string diretorio = GetDirArquivo("Figurinha", txtNome.Text);

            try
            {
                if (ArquivoExiste(diretorio))
                {
                    MsgAtencao("Já existe uma figurinha cadastrada com este nome.");
                    return;
                }
            }
            catch (Exception ex)
            {
                MsgAtencao("Falha ao validar o arquivo." + Environment.NewLine +
                    "Erro original: " + ex.Message);
                return;
            }

            try
            {
                GravarArquivo(diretorio, GetCadastro());

                MsgInfo("Figurinha cadastrada com sucesso!");

                LimparCampos();
            }
            catch (Exception ex)
            {
                MsgAtencao("Falha ao salvar a figurinha." + Environment.NewLine +
                    "Erro original: " + ex.Message);
            }
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            DialogResult retorno = openFileDialog1.ShowDialog();

            if (retorno == DialogResult.OK)
            {
                txtDiretorio.Text = openFileDialog1.FileName;

                picFoto.ImageLocation = txtDiretorio.Text;
                picFoto.Refresh();
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Salvar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult retorno =
                MessageBox.Show("Deseja realmente cancelar?",
                                "Confirmação",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question);

            if (retorno == DialogResult.Yes)
                this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmCadFigurinha_Load(object sender, EventArgs e)
        {

        }

        private void cmbRaridade_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
