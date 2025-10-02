using System;
using System.Data;
using System.Data.SQLite;

namespace CSharp_logistica.Classes
{
    public class Viagem
    {
        private int codigoViagem { get; set; }
        private int veiculoId { get; set; }
        private int motoristaId { get; set; }
        private int rotaId { get; set; }
        private DateTime dataSaida { get; set; }
        private DateTime dataChegada { get; set; }
        private string situacao { get; set; }

        // Construtores para gravação/leitura simples (usando IDs)
        public Viagem(int veiculoId, int motoristaId, int rotaId, DateTime dataSaida, DateTime dataChegada, string situacao)
        {
            this.veiculoId = veiculoId;
            this.motoristaId = motoristaId;
            this.rotaId = rotaId;
            this.dataSaida = dataSaida;
            this.dataChegada = dataChegada;
            this.situacao = situacao;
        }

        public Viagem(int codigoViagem, int veiculoId, int motoristaId, int rotaId, DateTime dataSaida, DateTime dataChegada, string situacao)
            : this(veiculoId, motoristaId, rotaId, dataSaida, dataChegada, situacao)
        {
            this.codigoViagem = codigoViagem;
        }

        // Métodos CRUD

        public bool AddViagemBanco()
        {
            using (var connection = Conexao.ObterConexao())
            {
                string query = @"INSERT INTO VIAGEM 
                    (VEICULOID, MOTORISTAID, ROTAID, DATA_SAIDA, DATA_CHEGADA, SITUACAO)
                    VALUES (@VeiculoId, @MotoristaId, @RotaId, @DataSaida, @DataChegada, @Situacao)";
                try
                {
                    using (var command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@VeiculoId", veiculoId);
                        command.Parameters.AddWithValue("@MotoristaId", motoristaId);
                        command.Parameters.AddWithValue("@RotaId", rotaId);
                        command.Parameters.AddWithValue("@DataSaida", dataSaida);
                        command.Parameters.AddWithValue("@DataChegada", dataChegada);
                        command.Parameters.AddWithValue("@Situacao", situacao);
                        command.ExecuteNonQuery();
                    }
                    MessageBox.Show("Viagem cadastrada com sucesso!");
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao cadastrar viagem: " + ex.Message);
                    return false;
                }
            }
        }

        public void EditViagem()
        {
            using var connection = Conexao.ObterConexao();
            string query = @"UPDATE VIAGEM SET 
                VEICULOID = @VeiculoId,
                MOTORISTAID = @MotoristaId,
                ROTAID = @RotaId,
                DATA_SAIDA = @DataSaida, 
                DATA_CHEGADA = @DataChegada, 
                SITUACAO = @Situacao
                WHERE VIAGEMID = @ViagemId";
            var cmd = new SQLiteCommand(query, connection);
            try
            {
                cmd.Parameters.AddWithValue("@VeiculoId", veiculoId);
                cmd.Parameters.AddWithValue("@MotoristaId", motoristaId);
                cmd.Parameters.AddWithValue("@RotaId", rotaId);
                cmd.Parameters.AddWithValue("@DataSaida", dataSaida);
                cmd.Parameters.AddWithValue("@DataChegada", dataChegada);
                cmd.Parameters.AddWithValue("@Situacao", situacao);
                cmd.Parameters.AddWithValue("@ViagemId", codigoViagem);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Viagem alterada com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao editar viagem: " + ex.Message);
            }
        }

        public void DeleteViagemBanco()
        {
            using var connection = Conexao.ObterConexao();
            string query = "DELETE FROM VIAGEM WHERE VIAGEMID = @ViagemId";
            try
            {
                using var command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@ViagemId", codigoViagem);
                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                    MessageBox.Show("Viagem deletada com sucesso!");
                else
                    MessageBox.Show("Nenhuma viagem encontrada com esse ID.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao deletar viagem: " + ex.Message);
            }
        }

        public static DataTable ObterTabelaTodasViagens()
        {
            using var connection = Conexao.ObterConexao();
            string query = @"SELECT 
                                v.VIAGEMID,
                                v.VEICULOID,
                                ve.MODELO || ' - ' || ve.PLACA AS Veiculo,
                                v.MOTORISTAID,
                                m.NOME || ' - ' || m.CNH AS Motorista,
                                v.ROTAID,
                                r.ORIGEM || ' - ' || r.DESTINO AS Rota,
                                v.DATA_SAIDA,
                                v.DATA_CHEGADA,
                                v.SITUACAO
                            FROM VIAGEM v
                            JOIN VEICULO ve ON v.VEICULOID = ve.VEICULOID
                            JOIN MOTORISTA m ON v.MOTORISTAID = m.MOTORISTAID
                            JOIN ROTA r ON v.ROTAID = r.ROTAID;
                            ";
            try
            {
                using var da = new SQLiteDataAdapter(query, connection);
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao obter viagens: " + ex.Message);
                return new DataTable();
            }
        }


        public bool EqualsViagem(Viagem outro)
        {
            if (outro == null) return false;

            return this.veiculoId == outro.veiculoId &&
                   this.motoristaId == outro.motoristaId &&
                   this.rotaId == outro.rotaId &&
                   this.dataChegada == outro.dataChegada &&
                   this.dataSaida == outro.dataSaida &&
                   this.situacao == outro.situacao;
                    
        }
    }
}
