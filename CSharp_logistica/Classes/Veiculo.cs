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

        public int GetCodigo()
        {
            return codigoVeiculo;
        }

        public override string ToString()
        {
            return $"{modeloVeiculo} - {placaVeiculo}";
        }

        public bool AddVeiculoBanco()
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
                    return true;
                }
                catch (Exception ex)
                { 
                    MessageBox.Show("Erro ao adicionar veículo: " + ex.Message);
                    return false;
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

        public static DataTable ObterTabelaTodosVeiculos()
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

        public void EditVeiculo()
        {
            using var connection = Conexao.ObterConexao();
            string query = @"UPDATE VEICULO SET MODELO = @modelo,PLACA = @placa,CONSUMO_MEDIO = @consumo,CARGA_MAXIMA = @carga WHERE VEICULOID = @id";
            var cmd = new SQLiteCommand(query, connection);
            try
            {
                cmd.Parameters.AddWithValue("@modelo", modeloVeiculo);
                cmd.Parameters.AddWithValue("@placa", placaVeiculo);
                cmd.Parameters.AddWithValue("@consumo", consumoMedio);
                cmd.Parameters.AddWithValue("@carga", cargaMaxima);
                cmd.Parameters.AddWithValue("@id", codigoVeiculo);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Veiculo alterado com sucesso!!");

            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro ao editar Veiculo!!" + ex);
            }
        }

        public bool EqualsVeiculo(Veiculo outro)
        {
            if (outro == null) return false;

            return this.placaVeiculo == outro.placaVeiculo &&
                   this.modeloVeiculo == outro.modeloVeiculo &&
                   this.consumoMedio == outro.consumoMedio &&
                   this.cargaMaxima == outro.cargaMaxima;
        }

        public static List<Veiculo> ObterTodosVeiculos()
        {
            List<Veiculo> veiculos = new List<Veiculo>();
            using var connection = Conexao.ObterConexao();
            string query = "SELECT * FROM VEICULO";
            try
            {
                using var command = new SQLiteCommand(query, connection);
                using var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int codigoVeiculo = Convert.ToInt32(reader["VEICULOID"]);
                    string placaVeiculo = reader["PLACA"].ToString();
                    string modeloVeiculo = reader["MODELO"].ToString();
                    decimal consumoMedio = Convert.ToDecimal(reader["CONSUMO_MEDIO"]);
                    decimal cargaMaxima = Convert.ToDecimal(reader["CARGA_MAXIMA"]);
                    Console.WriteLine($"Código: {codigoVeiculo}, Placa: {placaVeiculo}, Modelo: {modeloVeiculo}, Consumo Médio: {consumoMedio}, Carga Máxima: {cargaMaxima}");
                   
                    Veiculo veiculo = new Veiculo(codigoVeiculo, placaVeiculo, modeloVeiculo, consumoMedio, cargaMaxima);
                    veiculos.Add(veiculo);

                }
                return veiculos;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao obter veículos: " + ex.Message);
                return new List<Veiculo>();
            }
        }

        public string mostrarInfoWtCode()
        {
            return $"Código: {codigoVeiculo}, Placa: {placaVeiculo}, Modelo: {modeloVeiculo}, Consumo Médio: {consumoMedio}, Carga Máxima: {cargaMaxima}";
        }

        public string mostrarInfoNoCode()
        {
            return $"Placa: {placaVeiculo}, Modelo: {modeloVeiculo}, Consumo Médio: {consumoMedio}, Carga Máxima: {cargaMaxima}";
        }


    }
}
