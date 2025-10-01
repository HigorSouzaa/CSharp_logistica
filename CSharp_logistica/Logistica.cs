using System.Data.SQLite;
using System.Data;
using System.Windows.Forms;
using CSharp_logistica.Classes;

namespace CSharp_logistica
{
    public partial class form_logistica : Form
    {
        bool editMode = false;

        public form_logistica()
        {
            InitializeComponent();
        }

        private void form_logistica_Load(object sender, EventArgs e)
        {
            TestarConexao();
            // Configurações do DataGridView
            dgv_veiculos.RowTemplate.Height = 30;
            dgv_veiculos.RowTemplate.MinimumHeight = 25;
            dgv_veiculos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;

            dgv_veiculos.Visible = false;
        }

        public void TestarConexao()
        {
            try
            {
                using (var conexao = Conexao.ObterConexao())
                {
                    Console.WriteLine("Conexão bem-sucedida!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao conectar: " + ex.Message);
                this.Close();
            }
        }

        private void bt_cadveiculo_Click(object sender, EventArgs e)
        {
            string modeloVeiculo = txtbox_modeloveiculo.Text;
            string placaVeiculo = txtbox_placaveiculo.Text;

            if (string.IsNullOrEmpty(modeloVeiculo) || string.IsNullOrEmpty(placaVeiculo))
            {
                MessageBox.Show("Modelo e Placa do Veículo são obrigatórios!");
                return;
            }

            decimal consumoMedio;
            bool consumoValido = decimal.TryParse(txtbox_consumomedio.Text, out consumoMedio);

            decimal cargaMaxima;
            bool cargaValida = decimal.TryParse(txtbox_cargamaxima.Text, out cargaMaxima);

            if (!consumoValido || !cargaValida)
            {
                MessageBox.Show("Consumo Médio e Carga Máxima devem ser valores numéricos e obrigatorios!!");
                return;
            }
            if (editMode == false)
            {
                Veiculo veiculo = new Veiculo(placaVeiculo, modeloVeiculo, consumoMedio, cargaMaxima);
                try
                {

                    if (veiculo.AddVeiculoBanco()) { LimparCampos(); }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro" + ex);
                }
            }


        }

        public void bt_showveiculos_Click(object sender, EventArgs e)
        {
            if (dgv_veiculos.Visible == true)
            {
                dgv_veiculos.Visible = false;
                dgv_veiculos.ClearSelection();
                bt_showveiculos.Image = Properties.Resources.MostrarTodos;
                editMode = false;
                bt_cadveiculo.Image = Properties.Resources.Cadastrar;
                bt_delveiculo.Image = Properties.Resources.Deletar;

            }
            else
            {
                var dt = Veiculo.ObterTodosVeiculos();
                dgv_veiculos.DataSource = dt;
                dgv_veiculos.AutoResizeRows();
                bt_showveiculos.Image = Properties.Resources.Fechar;
                dgv_veiculos.Visible = true;
            }
        }

        private void bt_edtveiculo_Click(object sender, EventArgs e)
        {
            if (dgv_veiculos.Visible)
            {
                if (!editMode)
                {
                    bt_cadveiculo.Image = Properties.Resources.Salvar;
                    bt_delveiculo.Image = Properties.Resources.Cancelar;
                    editMode = true;
                }
                else
                {
                    MessageBox.Show("Modo de Edicao ja ativo!!", "Atencao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Mostre o grafico e selecione um Veiculo antes de editar.", "Atencao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                editMode = false;
            }
        }

        public void LimparCampos()
        {
            txtbox_cargamaxima.Text = string.Empty;
            txtbox_consumomedio.Text = string.Empty;
            txtbox_idveiculo.Text = string.Empty;
            txtbox_modeloveiculo.Text = string.Empty;
            txtbox_placaveiculo.Text = string.Empty;
        }

        private void bt_delveiculo_Click(object sender, EventArgs e)
        {
           if (!editMode)
            {
                MessageBox.Show("Deletado");
            }
            else
            {
                bt_cadveiculo.Image = Properties.Resources.Cadastrar;
                bt_delveiculo.Image = Properties.Resources.Deletar;
                editMode = false;
            }
        }
    }
}
