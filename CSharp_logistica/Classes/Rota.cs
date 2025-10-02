using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_logistica.Classes
{
    public class Rota
    {
        private int codigoRota { get; set; }
        private string origemRota { get; set; }
        private string destinoRota { get; set; }
        private decimal distanciaRota { get; set; }
        public Rota(string origemRota, string destinoRota, decimal distanciaRota)
        {
            this.origemRota = origemRota;
            this.destinoRota = destinoRota;
            this.distanciaRota = distanciaRota;
        }
        public Rota(int codigoRota, string origemRota, string destinoRota, decimal distanciaRota)
            : this(origemRota, destinoRota, distanciaRota)
        {
            this.codigoRota = codigoRota;
        }

        public int GetCodigo()
        {
            return codigoRota;
        }

        public override string ToString()
        {
            return $"{origemRota} - {destinoRota}";
        }

        // Adiciona rota ao banco
        public bool AddRotaBanco()
        {
            using (var connection = Conexao.ObterConexao())
            {
                string query = @"INSERT INTO ROTA (ORIGEM, DESTINO, DISTANCIA) 
                                 VALUES (@Origem, @Destino, @Distancia)";
                try
                {
                    using (var command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Origem", origemRota);
                        command.Parameters.AddWithValue("@Destino", destinoRota);
                        command.Parameters.AddWithValue("@Distancia", distanciaRota);
                        command.ExecuteNonQuery();
                    }
                    MessageBox.Show("Rota adicionada com sucesso!");
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao adicionar rota: " + ex.Message);
                    return false;
                }
            }
        }

        // Exclui rota pelo ID
        public void DeleteRotaBanco()
        {
            using (var connection = Conexao.ObterConexao())
            {
                string query = "DELETE FROM ROTA WHERE ROTAID = @RotaId";
                try
                {
                    using (var command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@RotaId", codigoRota);
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Rota deletada com sucesso!");
                        }
                        else
                        {
                            MessageBox.Show("Nenhuma rota encontrada com o código fornecido.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao deletar rota: " + ex.Message);
                }
            }
        }

        // Consulta todas as rotas
        public static DataTable ObterTabelaTodasRotas()
        {
            using var connection = Conexao.ObterConexao();
            string query = "SELECT * FROM ROTA";
            try
            {
                using var da = new SQLiteDataAdapter(query, connection);
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao obter rotas: " + ex.Message);
                return new DataTable();
            }
        }

        // Edita rota pelo ID
        public void EditRota()
        {
            using var connection = Conexao.ObterConexao();
            string query = @"UPDATE ROTA SET ORIGEM = @Origem, DESTINO = @Destino, DISTANCIA = @Distancia 
                             WHERE ROTAID = @RotaId";
            var cmd = new SQLiteCommand(query, connection);
            try
            {
                cmd.Parameters.AddWithValue("@Origem", origemRota);
                cmd.Parameters.AddWithValue("@Destino", destinoRota);
                cmd.Parameters.AddWithValue("@Distancia", distanciaRota);
                cmd.Parameters.AddWithValue("@RotaId", codigoRota);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Rota alterada com sucesso!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao editar rota!!" + ex);
            }
        }

        // Compara duas rotas
        public bool EqualsRota(Rota outra)
        {
            if (outra == null) return false;

            return this.origemRota == outra.origemRota &&
                   this.destinoRota == outra.destinoRota &&
                   this.distanciaRota == outra.distanciaRota;
        }

        public static List<Rota> ObterTodasRotas()
        {
            var rotas = new List<Rota>();
            using (var connection = Conexao.ObterConexao())
            {
                string query = "SELECT * FROM ROTA";
                try
                {
                    using (var command = new SQLiteCommand(query, connection))
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int codigo = reader.GetInt32(0);
                            string origem = reader.GetString(1);
                            string destino = reader.GetString(2);
                            decimal distancia = reader.GetDecimal(3);
                            var rota = new Rota(codigo, origem, destino, distancia);
                            rotas.Add(rota);
                        }
                    }
                    return rotas;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao obter rotas: " + ex.Message);
                    return rotas;
                }
            }
        }


        // Exibe informações da rota com código
        public string MostrarInfoWtCode()
        {
            return $"Código: {codigoRota}, Origem: {origemRota}, Destino: {destinoRota}, Distância: {distanciaRota}";
        }

        // Exibe informações da rota sem código
        public string MostrarInfoNoCode()
        {
            return $"Origem: {origemRota}, Destino: {destinoRota}, Distância: {distanciaRota}";
        }

    }
}
