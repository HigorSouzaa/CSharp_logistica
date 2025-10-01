using System.Data.SQLite;
using System.Data;
using System.Windows.Forms;
using CSharp_logistica.Classes;

namespace CSharp_logistica
{
    public partial class form_logistica : Form
    {
        bool editMode = false;
        Veiculo editedVeiculo;
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
            dgv_veiculos.AllowUserToAddRows = false;

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


            try
            {
                if (editMode == false)
                {
                    Veiculo veiculo = new Veiculo(placaVeiculo, modeloVeiculo, consumoMedio, cargaMaxima);
                    if (veiculo.AddVeiculoBanco()) { LimparCampos(); }
                }
                else
                {
                    string id = txtbox_idveiculo.Text;
                    if (string.IsNullOrEmpty(id))
                    {
                        MessageBox.Show("Escolha um Veiculo para editar no grid antes de salvar!!", "Antenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    int codigoVeiculo = int.Parse(txtbox_idveiculo.Text);

                    Veiculo veiculo = new Veiculo(codigoVeiculo, placaVeiculo, modeloVeiculo, consumoMedio, cargaMaxima);

                    if (veiculo.EqualsVeiculo(editedVeiculo))
                    {
                        MessageBox.Show("Tentando Salvar o veiculo com os mesmo valores!!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        veiculo.EditVeiculo();
                        LimparCampos();
                        bt_cadveiculo.Image = Properties.Resources.Cadastrar;
                        bt_delveiculo.Image = Properties.Resources.Deletar;
                        editMode = false;
                        AtualizarGrid();

                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro" + ex);
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
                LimparCampos();

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
            if (dgv_veiculos.Visible && dgv_veiculos.SelectedRows.Count > 0)
            {
                if (!editMode)
                {
                    var linha = dgv_veiculos.SelectedRows[0];

                    string placaVeiculo = linha.Cells["PLACA"].Value.ToString();
                    txtbox_placaveiculo.Text = placaVeiculo;

                    string modeloVeiculo = linha.Cells["MODELO"].Value.ToString();
                    txtbox_modeloveiculo.Text = modeloVeiculo;

                    decimal consumoMedio = decimal.Parse(linha.Cells["CONSUMO_MEDIO"].Value.ToString());
                    txtbox_consumomedio.Text = consumoMedio.ToString();

                    decimal cargaMaxima = decimal.Parse(linha.Cells["CARGA_MAXIMA"].Value.ToString());
                    txtbox_cargamaxima.Text = cargaMaxima.ToString();

                    int codigoVeiculo = int.Parse(linha.Cells["VEICULOID"].Value.ToString());
                    txtbox_idveiculo.Text = codigoVeiculo.ToString();


                    editedVeiculo = new Veiculo(codigoVeiculo, placaVeiculo, modeloVeiculo, consumoMedio, cargaMaxima);

                    bt_cadveiculo.Image = Properties.Resources.Salvar;
                    bt_delveiculo.Image = Properties.Resources.Cancelar;
                    editMode = true;
                }
                else
                {
                    MessageBox.Show("Modo de Edição ja ativo!!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Mostre o grafico e selecione um Veiculo antes de editar.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                LimparCampos();
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


        public void AtualizarGrid()
        {
            var dt = Veiculo.ObterTodosVeiculos();
            dgv_veiculos.DataSource = dt;
            dgv_veiculos.AutoResizeRows();
        }

        private void bt_delveiculo_Click(object sender, EventArgs e)
        {
           if (!editMode)
            {
                if (dgv_veiculos.SelectedRows.Count != 1)
                {
                    MessageBox.Show("Selecione um veículo para excluir.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int codigoVeiculo = int.Parse(dgv_veiculos.SelectedRows[0].Cells["VEICULOID"].Value.ToString());
                decimal cargaMaxima = decimal.Parse(dgv_veiculos.SelectedRows[0].Cells["CARGA_MAXIMA"].Value.ToString());
                decimal consumoMedio = decimal.Parse(dgv_veiculos.SelectedRows[0].Cells["CONSUMO_MEDIO"].Value.ToString());
                string modeloVeiculo = dgv_veiculos.SelectedRows[0].Cells["MODELO"].Value.ToString();
                string placaVeiculo = dgv_veiculos.SelectedRows[0].Cells["PLACA"].Value.ToString();

                Veiculo veiculo = new Veiculo(codigoVeiculo, placaVeiculo, modeloVeiculo, consumoMedio, cargaMaxima);
                veiculo.DeleteVeiculoBanco();
                AtualizarGrid();
                LimparCampos();
            }
            else
            {
                bt_cadveiculo.Image = Properties.Resources.Cadastrar;
                bt_delveiculo.Image = Properties.Resources.Deletar;
                editMode = false;
                LimparCampos();
            }
        }
    }
}
