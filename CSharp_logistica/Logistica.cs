using System.Data.SQLite;
using System.Data;
using System.Windows.Forms;
using CSharp_logistica.Classes;

namespace CSharp_logistica
{
    public partial class form_logistica : Form
    {
        bool editModeVeiculos = false;
        bool editModeMotorista = false;
        bool editModeRota = false;
        bool editModeCombustivel = false;
        PrecoCombustivel editedPrecoCombustivel;
        Rota editedRota;
        Veiculo editedVeiculo;
        Motorista editedMotorista;

        public form_logistica()
        {
            InitializeComponent();
        }

        // Evento load do form - configuração inicial
        private void form_logistica_Load(object sender, EventArgs e)
        {
            TestarConexao();
            OcultarTodosDataGrids(); // Inicialmente o grid está oculto
        }

        // Testa conexão com banco de dados
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

        // Começa com todas data grid view invisível
        public void OcultarTodosDataGrids()
        {
            dgv_veiculos.Visible = false;
            dgv_veiculos.RowTemplate.Height = 30;
            dgv_veiculos.RowTemplate.MinimumHeight = 25;
            dgv_veiculos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            dgv_veiculos.AllowUserToAddRows = false;


            dgv_mta.Visible = false;
            dgv_mta.RowTemplate.Height = 30;
            dgv_mta.RowTemplate.MinimumHeight = 25;
            dgv_mta.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            dgv_mta.AllowUserToAddRows = false;

            dgv_rt.Visible = false;
            dgv_rt.RowTemplate.Height = 30;
            dgv_rt.RowTemplate.MinimumHeight = 25;
            dgv_rt.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            dgv_rt.AllowUserToAddRows = false;

            dgv_comb.Visible = false;
            dgv_comb.RowTemplate.Height = 30;
            dgv_comb.RowTemplate.MinimumHeight = 25;
            dgv_comb.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            dgv_comb.AllowUserToAddRows = false;
        }

        /// ------------------------------------ 
        /// 
        /// 
        /// Veiculo
        /// 
        /// 
        /// ------------------------------------    

        // Limpa os campos de input do formulário
        public void LimparCamposVeiculo()
        {
            txtbox_cargamaxima.Text = string.Empty;
            txtbox_consumomedio.Text = string.Empty;
            txtbox_idveiculo.Text = string.Empty;
            txtbox_modeloveiculo.Text = string.Empty;
            txtbox_placaveiculo.Text = string.Empty;
        }

        // Atualiza o DataGridView com os dados da tabela VEICULO
        public void AtualizarGridVeiculos()
        {
            var dt = Veiculo.ObterTodosVeiculos();
            dgv_veiculos.DataSource = dt;
            dgv_veiculos.AutoResizeRows();
        }

        // Botão para mostrar/ocultar veículos no DataGridView
        public void bt_showveiculos_Click(object sender, EventArgs e)
        {
            if (dgv_veiculos.Visible)
            {
                dgv_veiculos.Visible = false;
                dgv_veiculos.ClearSelection();
                bt_showveiculos.Image = Properties.Resources.MostrarTodos; // Botão volta a mostrar 'mostrar todos'
                editModeVeiculos = false;
                bt_cadveiculo.Image = Properties.Resources.Cadastrar;
                bt_delveiculo.Image = Properties.Resources.Deletar;
                LimparCamposVeiculo();
            }
            else
            {
                var dt = Veiculo.ObterTodosVeiculos();
                dgv_veiculos.DataSource = dt;
                dgv_veiculos.AutoResizeRows();
                bt_showveiculos.Image = Properties.Resources.Fechar; // Botão muda para 'fechar'
                dgv_veiculos.Visible = true;
            }
        }

        // Botão para cadastro ou salvar edição de veículo
        private void bt_cadveiculo_Click(object sender, EventArgs e)
        {
            string modeloVeiculo = txtbox_modeloveiculo.Text;
            string placaVeiculo = txtbox_placaveiculo.Text;

            // Valida campos obrigatórios
            if (string.IsNullOrEmpty(modeloVeiculo) || string.IsNullOrEmpty(placaVeiculo))
            {
                MessageBox.Show("Modelo e Placa do Veículo são obrigatórios!");
                return;
            }

            // Validação dos campos numéricos
            if (!decimal.TryParse(txtbox_consumomedio.Text, out decimal consumoMedio) ||
                !decimal.TryParse(txtbox_cargamaxima.Text, out decimal cargaMaxima))
            {
                MessageBox.Show("Consumo Médio e Carga Máxima devem ser valores numéricos e obrigatórios!!");
                return;
            }

            try
            {
                if (!editModeVeiculos) // Modo cadastro
                {
                    Veiculo veiculo = new Veiculo(placaVeiculo, modeloVeiculo, consumoMedio, cargaMaxima);
                    if (veiculo.AddVeiculoBanco())
                    {
                        LimparCamposVeiculo();
                    }
                }
                else // Modo edição
                {
                    string id = txtbox_idveiculo.Text;
                    if (string.IsNullOrEmpty(id))
                    {
                        MessageBox.Show("Escolha um Veículo para editar no grid antes de salvar!!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    int codigoVeiculo = int.Parse(id);

                    Veiculo veiculo = new Veiculo(codigoVeiculo, placaVeiculo, modeloVeiculo, consumoMedio, cargaMaxima);

                    if (veiculo.EqualsVeiculo(editedVeiculo))
                    {
                        MessageBox.Show("Tentando Salvar o veiculo com os mesmos valores!!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        veiculo.EditVeiculo();
                        LimparCamposVeiculo();
                        bt_cadveiculo.Image = Properties.Resources.Cadastrar;
                        bt_delveiculo.Image = Properties.Resources.Deletar;
                        editModeVeiculos = false;
                        AtualizarGridVeiculos();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro" + ex);
            }
        }

        // Botão para entrar no modo edição - preenche os campos com o veículo selecionado
        private void bt_edtveiculo_Click(object sender, EventArgs e)
        {
            if (dgv_veiculos.Visible && dgv_veiculos.SelectedRows.Count > 0)
            {
                if (!editModeVeiculos)
                {
                    var linha = dgv_veiculos.SelectedRows[0];

                    txtbox_placaveiculo.Text = linha.Cells["PLACA"].Value.ToString();
                    txtbox_modeloveiculo.Text = linha.Cells["MODELO"].Value.ToString();
                    txtbox_consumomedio.Text = linha.Cells["CONSUMO_MEDIO"].Value.ToString();
                    txtbox_cargamaxima.Text = linha.Cells["CARGA_MAXIMA"].Value.ToString();
                    txtbox_idveiculo.Text = linha.Cells["VEICULOID"].Value.ToString();

                    editedVeiculo = new Veiculo(
                        int.Parse(txtbox_idveiculo.Text),
                        txtbox_placaveiculo.Text,
                        txtbox_modeloveiculo.Text,
                        decimal.Parse(txtbox_consumomedio.Text),
                        decimal.Parse(txtbox_cargamaxima.Text)
                    );

                    bt_cadveiculo.Image = Properties.Resources.Salvar;
                    bt_delveiculo.Image = Properties.Resources.Cancelar;
                    editModeVeiculos = true;
                }
                else
                {
                    MessageBox.Show("Modo de Edição já ativo!!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Mostre o grid e selecione um Veículo antes de editar.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                LimparCamposVeiculo();
                editModeVeiculos = false;
            }
        }

        // Botão para deletar veículo selecionado
        private void bt_delveiculo_Click(object sender, EventArgs e)
        {
            if (!editModeVeiculos)
            {
                // Verifica se selecionou apenas uma linha no grid
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
                AtualizarGridVeiculos();
                LimparCamposVeiculo();
            }
            else
            {
                // Cancelar modo edição
                bt_cadveiculo.Image = Properties.Resources.Cadastrar;
                bt_delveiculo.Image = Properties.Resources.Deletar;
                editModeVeiculos = false;
                LimparCamposVeiculo();
            }
        }

        /// ------------------------------------ 
        /// 
        /// 
        /// Motorista
        /// 
        /// 
        /// ------------------------------------ 
        

        // Limpa os campos dos inputs do Motorista
        public void LimparCamposMotorista()
        {
            txtbox_mtaid.Text = string.Empty;
            txtbox_mtanome.Text = string.Empty;
            txtbox_mtacnh.Text = string.Empty;
            txtbox_mtatele.Text = string.Empty;
        }

        // Atualiza o DataGridView com os dados da tabela MOTORISTA
        public void AtualizarGridMotorista()
        {
            var dt = Motorista.ObterTodosMotoristas();
            dgv_mta.DataSource = dt;
            dgv_mta.AutoResizeRows();
        }


        // Botão para mostrar/ocultar motoristas no DataGridView
        private void bt_mtashow_Click(object sender, EventArgs e)
        {
            if (dgv_mta.Visible)
            {
                dgv_mta.Visible = false;
                dgv_mta.ClearSelection();
                bt_mtashow.Image = Properties.Resources.MostrarTodos;
                editModeMotorista = false;
                bt_mtacad.Image = Properties.Resources.Cadastrar;
                bt_mtadelete.Image = Properties.Resources.Deletar;
                LimparCamposMotorista();
            }
            else
            {
                var dt = Motorista.ObterTodosMotoristas();
                dgv_mta.DataSource = dt;
                dgv_mta.AutoResizeRows();
                bt_mtashow.Image = Properties.Resources.Fechar;
                dgv_mta.Visible = true;
            }
        }

        // Botão para cadastrar ou salvar edição de motorista
        private void bt_mtacad_Click(object sender, EventArgs e)
        {
            string nomeMotorista = txtbox_mtanome.Text;
            string cnhMotorista = txtbox_mtacnh.Text;
            string telefoneMotorista = txtbox_mtatele.Text;

            // Validação campos obrigatórios
            if (string.IsNullOrEmpty(nomeMotorista) || string.IsNullOrEmpty(cnhMotorista) || string.IsNullOrEmpty(telefoneMotorista))
            {
                MessageBox.Show("Nome, CNH e Telefone do Motorista são obrigatórios!");
                return;
            }

            try
            {
                if (!editModeMotorista)
                {
                    Motorista motorista = new Motorista(nomeMotorista, cnhMotorista, telefoneMotorista);
                    if (motorista.AddMotoristaBanco())
                    {
                        LimparCamposMotorista();
                    }
                }
                else
                {
                    if (string.IsNullOrEmpty(txtbox_mtaid.Text))
                    {
                        MessageBox.Show("Escolha um Motorista para editar no grid antes de salvar!!");
                        return;
                    }

                    int codigoMotorista = int.Parse(txtbox_mtaid.Text);
                    Motorista motorista = new Motorista(codigoMotorista, nomeMotorista, cnhMotorista, telefoneMotorista);

                    if (motorista.EqualsMotorista(editedMotorista))
                    {
                        MessageBox.Show("Tentando salvar o motorista com os mesmos valores!!");
                    }
                    else
                    {
                        motorista.EditMotorista();
                        LimparCamposMotorista();
                        bt_mtacad.Image = Properties.Resources.Cadastrar;
                        bt_mtadelete.Image = Properties.Resources.Deletar;
                        editModeMotorista = false;
                        AtualizarGridMotorista();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        // Botão para entrar no modo edição motorista
        private void bt_mtaedit_Click(object sender, EventArgs e)
        {
            if (dgv_mta.Visible && dgv_mta.SelectedRows.Count > 0)
            {
                if (!editModeMotorista)
                {
                    var linha = dgv_mta.SelectedRows[0];

                    txtbox_mtanome.Text = linha.Cells["NOME"].Value.ToString();
                    txtbox_mtacnh.Text = linha.Cells["CNH"].Value.ToString();
                    txtbox_mtatele.Text = linha.Cells["TELEFONE"].Value.ToString();
                    txtbox_mtaid.Text = linha.Cells["MOTORISTAID"].Value.ToString();

                    editedMotorista = new Motorista(
                        int.Parse(txtbox_mtaid.Text),
                        txtbox_mtanome.Text,
                        txtbox_mtacnh.Text,
                        txtbox_mtatele.Text
                    );

                    bt_mtacad.Image = Properties.Resources.Salvar;
                    bt_mtadelete.Image = Properties.Resources.Cancelar;
                    editModeMotorista = true;
                }
                else
                {
                    MessageBox.Show("Modo de edição já está ativo!!");
                }
            }
            else
            {
                MessageBox.Show("Mostre o grid e selecione um Motorista antes de editar.");
                LimparCamposMotorista();
                editModeMotorista = false;
            }
        }

        // Botão para deletar motorista selecionado
        private void bt_mtadelete_Click(object sender, EventArgs e)
        {
            if (!editModeMotorista)
            {
                if (dgv_mta.SelectedRows.Count != 1)
                {
                    MessageBox.Show("Selecione um motorista para excluir.");
                    return;
                }

                int codigoMotorista = int.Parse(dgv_mta.SelectedRows[0].Cells["MOTORISTAID"].Value.ToString());
                string nomeMotorista = dgv_mta.SelectedRows[0].Cells["NOME"].Value.ToString();
                string cnhMotorista = dgv_mta.SelectedRows[0].Cells["CNH"].Value.ToString();
                string telefoneMotorista = dgv_mta.SelectedRows[0].Cells["TELEFONE"].Value.ToString();

                Motorista motorista = new Motorista(codigoMotorista, nomeMotorista, cnhMotorista, telefoneMotorista);
                motorista.DeleteMotoristaBanco();

                AtualizarGridMotorista();
                LimparCamposMotorista();
            }
            else
            {
                // Cancelar modo edição
                bt_mtacad.Image = Properties.Resources.Cadastrar;
                bt_mtadelete.Image = Properties.Resources.Deletar;
                editModeMotorista = false;
                LimparCamposMotorista();
            }
        }


        /// ------------------------------------ 
        /// 
        /// 
        /// Rota
        /// 
        /// 
        /// ------------------------------------ 


        // Limpa os campos dos inputs da Rota
        public void LimparCamposRota()
        {
            txtbox_rtid.Text = string.Empty;
            txtbox_rtorigem.Text = string.Empty;
            txtbox_rtdestino.Text = string.Empty;
            txtbox_rtdistancia.Text = string.Empty;
        }

        // Atualiza o DataGridView com os dados da tabela ROTA
        public void AtualizarGridRota()
        {
            var dt = Rota.ObterTodasRotas();
            dgv_rt.DataSource = dt;
            dgv_rt.AutoResizeRows();
        }

        // Botão para mostrar/ocultar rotas no DataGridView
        private void bt_rtshow_Click(object sender, EventArgs e)
        {
            if (dgv_rt.Visible)
            {
                dgv_rt.Visible = false;
                dgv_rt.ClearSelection();
                bt_rtshow.Image = Properties.Resources.MostrarTodos;
                editModeRota = false;
                bt_rtcad.Image = Properties.Resources.Cadastrar;
                bt_rtdelete.Image = Properties.Resources.Deletar;
                LimparCamposRota();
            }
            else
            {
                var dt = Rota.ObterTodasRotas();
                dgv_rt.DataSource = dt;
                dgv_rt.AutoResizeRows();
                bt_rtshow.Image = Properties.Resources.Fechar;
                dgv_rt.Visible = true;
            }
        }

        // Botão para cadastrar ou salvar edição de rota
        private void bt_rtcad_Click(object sender, EventArgs e)
        {
            string origemRota = txtbox_rtorigem.Text;
            string destinoRota = txtbox_rtdestino.Text;

            // Validar campos obrigatórios
            if (string.IsNullOrEmpty(origemRota) || string.IsNullOrEmpty(destinoRota))
            {
                MessageBox.Show("Origem e Destino da rota são obrigatórios!");
                return;
            }

            if (!decimal.TryParse(txtbox_rtdistancia.Text, out decimal distanciaRota))
            {
                MessageBox.Show("Distância deve ser um valor numérico válido!");
                return;
            }

            try
            {
                if (!editModeRota)
                {
                    Rota rota = new Rota(origemRota, destinoRota, distanciaRota);
                    if (rota.AddRotaBanco())
                    {
                        LimparCamposRota();
                    }
                }
                else
                {
                    if (string.IsNullOrEmpty(txtbox_rtid.Text))
                    {
                        MessageBox.Show("Escolha uma Rota para editar no grid antes de salvar!!");
                        return;
                    }

                    int codigoRota = int.Parse(txtbox_rtid.Text);
                    Rota rota = new Rota(codigoRota, origemRota, destinoRota, distanciaRota);

                    if (rota.EqualsRota(editedRota))
                    {
                        MessageBox.Show("Tentando salvar a rota com os mesmos valores!!");
                    }
                    else
                    {
                        rota.EditRota();
                        LimparCamposRota();
                        bt_rtcad.Image = Properties.Resources.Cadastrar;
                        bt_rtdelete.Image = Properties.Resources.Deletar;
                        editModeRota = false;
                        AtualizarGridRota();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        // Botão para entrar no modo edição rota
        private void bt_rtedit_Click(object sender, EventArgs e)
        {
            if (dgv_rt.Visible && dgv_rt.SelectedRows.Count > 0)
            {
                if (!editModeRota)
                {
                    var linha = dgv_rt.SelectedRows[0];

                    txtbox_rtorigem.Text = linha.Cells["ORIGEM"].Value.ToString();
                    txtbox_rtdestino.Text = linha.Cells["DESTINO"].Value.ToString();
                    txtbox_rtdistancia.Text = linha.Cells["DISTANCIA"].Value.ToString();
                    txtbox_rtid.Text = linha.Cells["ROTAID"].Value.ToString();

                    editedRota = new Rota(
                        int.Parse(txtbox_rtid.Text),
                        txtbox_rtorigem.Text,
                        txtbox_rtdestino.Text,
                        decimal.Parse(txtbox_rtdistancia.Text)
                    );

                    bt_rtcad.Image = Properties.Resources.Salvar;
                    bt_rtdelete.Image = Properties.Resources.Cancelar;
                    editModeRota = true;
                }
                else
                {
                    MessageBox.Show("Modo de edição já ativo!!");
                }
            }
            else
            {
                MessageBox.Show("Mostre o grid e selecione uma Rota antes de editar.");
                LimparCamposRota();
                editModeRota = false;
            }
        }

        // Botão para deletar rota selecionada
        private void bt_rtdelete_Click(object sender, EventArgs e)
        {
            if (!editModeRota)
            {
                if (dgv_rt.SelectedRows.Count != 1)
                {
                    MessageBox.Show("Selecione uma rota para excluir.");
                    return;
                }

                int codigoRota = int.Parse(dgv_rt.SelectedRows[0].Cells["ROTAID"].Value.ToString());
                string origemRota = dgv_rt.SelectedRows[0].Cells["ORIGEM"].Value.ToString();
                string destinoRota = dgv_rt.SelectedRows[0].Cells["DESTINO"].Value.ToString();
                decimal distanciaRota = decimal.Parse(dgv_rt.SelectedRows[0].Cells["DISTANCIA"].Value.ToString());

                Rota rota = new Rota(codigoRota, origemRota, destinoRota, distanciaRota);
                rota.DeleteRotaBanco();

                AtualizarGridRota();
                LimparCamposRota();
            }
            else
            {
                // Cancelar modo edição
                bt_rtcad.Image = Properties.Resources.Cadastrar;
                bt_rtdelete.Image = Properties.Resources.Deletar;
                editModeRota = false;
                LimparCamposRota();
            }
        }

        /// ------------------------------------ 
        /// 
        /// 
        /// Combustivel
        /// 
        /// 
        /// ------------------------------------ 



        // Limpa campos da aba Preço Combustível
        public void LimparCamposCombustivel()
        {
            txtbox_combid.Text = string.Empty;
            cb_combconsulta.SelectedIndex = -1;
            dtp_combconsulta.Value = DateTime.Today;
            txtbox_combpreco.Text = string.Empty;
        }

        // Atualiza o DataGridView com os dados da tabela PRECO_COMBUSTIVEL
        public void AtualizarGridCombustivel()
        {
            var dt = PrecoCombustivel.ObterTodosPrecos();
            dgv_comb.DataSource = dt;
            dgv_comb.AutoResizeRows();
        }

        // Mostrar/ocultar o DataGridView do preco combustivel
        private void bt_combshow_Click(object sender, EventArgs e)
        {
            if (dgv_comb.Visible)
            {
                dgv_comb.Visible = false;
                dgv_comb.ClearSelection();
                bt_combshow.Image = Properties.Resources.MostrarTodos;
                editModeCombustivel = false;
                bt_combcad.Image = Properties.Resources.Cadastrar;
                bt_combdelete.Image = Properties.Resources.Deletar;
                LimparCamposCombustivel();
            }
            else
            {
                var dt = PrecoCombustivel.ObterTodosPrecos();
                dgv_comb.DataSource = dt;
                dgv_comb.AutoResizeRows();
                dgv_comb.Visible = true;
                bt_combshow.Image = Properties.Resources.Fechar;
            }
        }

        // Cadastro ou salvar edição do preco combustivel
        private void bt_combcad_Click(object sender, EventArgs e)
        {
            string tipo = cb_combconsulta.SelectedItem?.ToString() ?? string.Empty;
            DateTime dataConsulta = dtp_combconsulta.Value;
            string precoTxt = txtbox_combpreco.Text;

            if (string.IsNullOrEmpty(tipo))
            {
                MessageBox.Show("Tipo de Combustível é obrigatório!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(precoTxt, out decimal preco))
            {
                MessageBox.Show("Preço deve ser um número válido!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (!editModeCombustivel)
                {
                    PrecoCombustivel pc = new PrecoCombustivel(tipo, preco, dataConsulta);
                    if (pc.AddPrecoCombustivelBanco())
                        LimparCamposCombustivel();
                }
                else
                {
                    if (string.IsNullOrEmpty(txtbox_combid.Text))
                    {
                        MessageBox.Show("Escolha um registro para editar no grid antes de salvar!!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    int codigo = int.Parse(txtbox_combid.Text);
                    PrecoCombustivel pc = new PrecoCombustivel(codigo, tipo, preco, dataConsulta);

                    if (pc.EqualsPrecoCombustivel(editedPrecoCombustivel))
                        MessageBox.Show("Tentando salvar com os mesmos valores!!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else
                    {
                        pc.EditPrecoCombustivel();
                        LimparCamposCombustivel();
                        bt_combcad.Image = Properties.Resources.Cadastrar;
                        bt_combdelete.Image = Properties.Resources.Deletar;
                        editModeCombustivel = false;
                        AtualizarGridCombustivel();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        // Modo edição preco combustível
        private void bt_combedit_Click(object sender, EventArgs e)
        {
            if (dgv_comb.Visible && dgv_comb.SelectedRows.Count > 0)
            {
                if (!editModeCombustivel)
                {
                    var linha = dgv_comb.SelectedRows[0];

                    txtbox_combid.Text = linha.Cells["PRECOID"].Value.ToString();

                    // Restaura seleção do ComboBox conforme valor do banco
                    string tipoCombBanco = linha.Cells["COMBUSTIVEL"].Value.ToString();
                    int index = cb_combconsulta.FindStringExact(tipoCombBanco);
                    cb_combconsulta.SelectedIndex = index;

                    dtp_combconsulta.Value = Convert.ToDateTime(linha.Cells["DATA_CONSULTA"].Value);
                    txtbox_combpreco.Text = linha.Cells["PRECO"].Value.ToString();

                    editedPrecoCombustivel = new PrecoCombustivel(
                        int.Parse(txtbox_combid.Text),
                        cb_combconsulta.SelectedItem?.ToString() ?? string.Empty,
                        decimal.Parse(txtbox_combpreco.Text),
                        dtp_combconsulta.Value
                    );

                    bt_combcad.Image = Properties.Resources.Salvar;
                    bt_combdelete.Image = Properties.Resources.Cancelar;
                    editModeCombustivel = true;
                }
                else
                {
                    MessageBox.Show("Modo de edição já ativo!!");
                }
            }
            else
            {
                MessageBox.Show("Mostre o grid e selecione um registro antes de editar.");
                LimparCamposCombustivel();
                editModeCombustivel = false;
            }
        }

        // Apaga registro selecionado
        private void bt_combdelete_Click(object sender, EventArgs e)
        {
            if (!editModeCombustivel)
            {
                if (dgv_comb.SelectedRows.Count != 1)
                {
                    MessageBox.Show("Selecione um registro para excluir.");
                    return;
                }

                int codigo = int.Parse(dgv_comb.SelectedRows[0].Cells["PRECOID"].Value.ToString());
                string tipo = dgv_comb.SelectedRows[0].Cells["COMBUSTIVEL"].Value.ToString();
                DateTime dataConsulta = Convert.ToDateTime(dgv_comb.SelectedRows[0].Cells["DATA_CONSULTA"].Value);
                decimal preco = decimal.Parse(dgv_comb.SelectedRows[0].Cells["PRECO"].Value.ToString());


                PrecoCombustivel pc = new PrecoCombustivel(codigo, tipo,preco,dataConsulta);
                pc.DeletePrecoCombustivelBanco();

                AtualizarGridCombustivel();
                LimparCamposCombustivel();
            }
            else
            {
                bt_combcad.Image = Properties.Resources.Cadastrar;
                bt_combdelete.Image = Properties.Resources.Deletar;
                editModeCombustivel = false;
                LimparCamposCombustivel();
            }
        }

    }
}
