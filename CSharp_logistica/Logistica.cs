using System.Data.SQLite;
using System.Data;
using System.Windows.Forms;
using CSharp_logistica.Classes;

namespace CSharp_logistica
{
    public partial class form_logistica : Form
    {
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
            Veiculo veiculo = new Veiculo(5, "ABC1AA5", "Aviao", 55, 10000);
            //veiculo.AddVeiculoBanco();
            veiculo.DeleteVeiculoBanco();
        }

        private void bt_showveiculos_Click(object sender, EventArgs e)
        {
            var dt = Veiculo.ObterTodosVeiculos();
            dgv_veiculos.DataSource = dt;
            dgv_veiculos.AutoResizeRows();
            dgv_veiculos.Visible = true;
        }
    }
}
