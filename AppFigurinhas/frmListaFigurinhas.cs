using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace AppFigurinhas
{
    public partial class frmListaFigurinhas : Form
    {
        string[] _arquivos;
        string[] _registro;

        List<string[]> _lista = new List<string[]>();

        public frmListaFigurinhas()
        {
            InitializeComponent();

            cmbFiltroRaridade.Items.Add("");
            cmbFiltroStatus.Items.Add("Obtido");
            cmbFiltroStatus.Items.Add("Desejado");

            CarregarCadastro();
        }

        void CarregarArquivos()
        {
            string caminho = Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory, "Figurinha");

            try
            {
                if (!Directory.Exists(caminho))
                    Directory.CreateDirectory(caminho);

                _arquivos = Directory.GetFiles(caminho, "*.txt");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao carregar arquivos: " + ex.Message);
            }
        }

        void CarregarRegistros()
        {
            _lista.Clear();

            if (_arquivos == null || _arquivos.Length == 0)
                return;

            string[] linhas;

            try
            {
                for (int i = 0; i < _arquivos.Length; i++)
                {
                    linhas = File.ReadAllLines(_arquivos[i]);

                    _registro = new string[7];

                    _registro[0] = i.ToString();
                    _registro[1] = _arquivos[i];
                    _registro[2] = linhas[0].Replace("FOTO=", "");
                    _registro[3] = linhas[1].Replace("NOME=", "");
                    _registro[4] = linhas[2].Replace("SELECAO=", "");
                    _registro[5] = linhas[3].Replace("RARIDADE=", "");
                    _registro[6] = linhas[4].Replace("STATUS=", "");

                    _lista.Add(_registro);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao carregar registros: " + ex.Message);
            }
        }

        void FiltrarLista()
        {
            List<string[]> listaFiltrada = new List<string[]>();

            for (int i = 0; i < _lista.Count; i++)
            {
                bool adicionar = true;

                if (!string.IsNullOrEmpty(txtFiltroNome.Text))
                {
                    if (!_lista[i][3].ToUpper().Contains(txtFiltroNome.Text.ToUpper()))
                        adicionar = false;
                }

                if (!string.IsNullOrEmpty(txtFiltroSelecao.Text))
                {
                    if (!_lista[i][4].ToUpper().Contains(txtFiltroSelecao.Text.ToUpper()))
                        adicionar = false;
                }

                if (!string.IsNullOrEmpty(cmbFiltroRaridade.Text))
                {
                    if (_lista[i][5] != cmbFiltroRaridade.Text)
                        adicionar = false;
                }

                if (!string.IsNullOrEmpty(cmbFiltroStatus.Text))
                {
                    if (_lista[i][6] != cmbFiltroStatus.Text)
                        adicionar = false;
                }

                if (adicionar)
                    listaFiltrada.Add(_lista[i]);
            }

            for (int i = 0; i < listaFiltrada.Count; i++)
                listaFiltrada[i][0] = i.ToString();

            _lista.Clear();
            _lista = listaFiltrada;
        }

        void CarregarListBox()
        {
            lstFigurinhas.Items.Clear();

            for (int i = 0; i < _lista.Count; i++)
            {
                lstFigurinhas.Items.Add(
                    _lista[i][3] + " - " + _lista[i][4]);
            }
        }

        void CarregarCadastro()
        {
            CarregarArquivos();
            CarregarRegistros();
            FiltrarLista();
            CarregarListBox();
        }

        string[] GetRegistro()
        {
            if (lstFigurinhas.SelectedIndex == -1)
            {
                MessageBox.Show("Nenhuma figurinha selecionada.");
                return null;
            }

            int indice = lstFigurinhas.SelectedIndex;
            return _lista[indice];
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            CarregarCadastro();
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            string[] registro = GetRegistro();

            if (registro == null)
                return;

            frmVisualizarFigurinha frm = new frmVisualizarFigurinha(registro);
            frm.ShowDialog();

            CarregarCadastro();
        }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmListaFigurinhas_Load(object sender, EventArgs e)
        {

        }

        private void lblFigurinhas_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
