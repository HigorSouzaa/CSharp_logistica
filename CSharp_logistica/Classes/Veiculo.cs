using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_logistica.Classes
{
    public class Veiculo
    {
        private int codigoVeiculo { get; set; } 
        private string placaVeiculo { get; set; }
        private string modeloVeiculo { get; set; }  
        private decimal consumoMedio { get; set; }
        private decimal cargaMaxima { get; set; }

        public Veiculo(string placaVeiculo, string modeloVeiculo, decimal consumoMedio, decimal cargaMaxima)
        {
            this.placaVeiculo = placaVeiculo;
            this.modeloVeiculo = modeloVeiculo;
            this.consumoMedio = consumoMedio;
            this.cargaMaxima = cargaMaxima;
        }

        public Veiculo(int codigoVeiculo, string placaVeiculo, string modeloVeiculo, decimal consumoMedio, decimal cargaMaxima)
            : this(placaVeiculo, modeloVeiculo, consumoMedio, cargaMaxima)
        {
            this.codigoVeiculo = codigoVeiculo;
        }

        public void AddVeiculoBanco()
        {
            using(var connection = Conexao.ObterConexao())
            {
                string query = "INSERT INTO VEICULO (PlACA, MODELO, CONSUMO_MEDIO, CARGA_MAXIMA) VALUES (@Placa, @Modelo, @ConsumoMedio, @CargaMaxima)";
                try
                {
                    using (var command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Placa", placaVeiculo);
                        command.Parameters.AddWithValue("@Modelo", modeloVeiculo);
                        command.Parameters.AddWithValue("@ConsumoMedio", consumoMedio);
                        command.Parameters.AddWithValue("@CargaMaxima", cargaMaxima);
                        command.ExecuteNonQuery();
                    }
                    MessageBox.Show("Veículo adicionado com sucesso!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao adicionar veículo: " + ex.Message);
                }
            }        
        }

        public void DeleteVeiculoBanco()
        {
            using (var connection = Conexao.ObterConexao())
            {
                string query = "DELETE FROM VEICULO WHERE VEICULOID = @CodigoVeiculo";
                try
                {
                    using (var command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@CodigoVeiculo", codigoVeiculo);
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Veículo deletado com sucesso!");
                        }
                        else
                        {
                            MessageBox.Show("Nenhum veículo encontrado com o código fornecido.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao deletar veículo: " + ex.Message);
                }
            }
        }

        public static DataTable ObterTodosVeiculos()
        { 
            using var connection = Conexao.ObterConexao();
            string query = "SELECT * FROM VEICULO";
            try
            { 
                using var da = new SQLiteDataAdapter(query, connection);
                var dt = new DataTable();
                da.Fill(dt);

                return dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao obter veículos: " + ex.Message);
                var dt = new DataTable();
                return dt;
            }
        }

    }
}
