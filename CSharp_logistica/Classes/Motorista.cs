using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_logistica.Classes
{
    public class Motorista
    {
        private int codigoMotorista { get; set; }
        private string nomeMotorista { get; set; }
        private string cnhMotorista { get; set; }
        private string telefoneMotorista {get; set; }

        public Motorista(string nomeMotorista, string cnhMotorista, string telefoneMotorista)
        {
            this.nomeMotorista = nomeMotorista;
            this.cnhMotorista = cnhMotorista;
            this.telefoneMotorista = telefoneMotorista;
        }
        public Motorista(int codigoMotorista, string nomeMotorista, string cnhMotorista, string telefoneMotorista)
            : this(nomeMotorista, cnhMotorista, telefoneMotorista)
        {
            this.codigoMotorista = codigoMotorista;
        }

        public int GetCodigo()
        {
            return codigoMotorista;
        }

        public override string ToString()
        {
            return $"{nomeMotorista} - {cnhMotorista}";
        }

        // Adiciona motorista ao banco
        public bool AddMotoristaBanco()
        {
            using (var connection = Conexao.ObterConexao())
            {
                string query = @"INSERT INTO MOTORISTA (NOME, CNH, TELEFONE) 
                                 VALUES (@Nome, @CNH, @Telefone)";
                try
                {
                    using (var command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Nome", nomeMotorista);
                        command.Parameters.AddWithValue("@CNH", cnhMotorista);
                        command.Parameters.AddWithValue("@Telefone", telefoneMotorista);
                        command.ExecuteNonQuery();
                    }
                    MessageBox.Show("Motorista adicionado com sucesso!");
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao adicionar motorista: " + ex.Message);
                    return false;
                }
            }
        }

        // Exclui motorista pelo ID
        public void DeleteMotoristaBanco()
        {
            using (var connection = Conexao.ObterConexao())
            {
                string query = "DELETE FROM MOTORISTA WHERE MOTORISTAID = @CodigoMotorista";
                try
                {
                    using (var command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@CodigoMotorista", codigoMotorista);
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Motorista deletado com sucesso!");
                        }
                        else
                        {
                            MessageBox.Show("Nenhum motorista encontrado com o código fornecido.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao deletar motorista: " + ex.Message);
                }
            }
        }

        // Consulta todos os motoristas
        public static DataTable ObterTabelaTodosMotoristas()
        {
            using var connection = Conexao.ObterConexao();
            string query = "SELECT * FROM MOTORISTA";
            try
            {
                using var da = new SQLiteDataAdapter(query, connection);
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao obter motoristas: " + ex.Message);
                return new DataTable();
            }
        }

        // Edita motorista pelo ID
        public void EditMotorista()
        {
            using var connection = Conexao.ObterConexao();
            string query = @"UPDATE MOTORISTA SET NOME = @Nome, CNH = @CNH, TELEFONE = @Telefone 
                             WHERE MOTORISTAID = @CodigoMotorista";
            var cmd = new SQLiteCommand(query, connection);
            try
            {
                cmd.Parameters.AddWithValue("@Nome", nomeMotorista);
                cmd.Parameters.AddWithValue("@CNH", cnhMotorista);
                cmd.Parameters.AddWithValue("@Telefone", telefoneMotorista);
                cmd.Parameters.AddWithValue("@CodigoMotorista", codigoMotorista);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Motorista alterado com sucesso!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao editar motorista!!" + ex);
            }
        }

        // Compara dois motoristas
        public bool EqualsMotorista(Motorista outro)
        {
            if (outro == null) return false;

            return this.nomeMotorista == outro.nomeMotorista &&
                   this.cnhMotorista == outro.cnhMotorista &&
                   this.telefoneMotorista == outro.telefoneMotorista;
        }

        public static List<Motorista> ObterTodosMotoristas()
        {
            var motoristas = new List<Motorista>();
            using (var connection = Conexao.ObterConexao())
            {
                string query = "SELECT * FROM MOTORISTA";
                try
                {
                    using (var command = new SQLiteCommand(query, connection))
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int codigo = reader.GetInt32(0);
                            string nome = reader.GetString(1);
                            string cnh = reader.GetString(2);
                            string telefone = reader.GetString(3);
                            var motorista = new Motorista(codigo, nome, cnh, telefone);
                            motoristas.Add(motorista);
                        }
                    }
                    return motoristas;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao obter motoristas: " + ex.Message);
                    return motoristas;
                }
            }
        }

        // Info com código
        public string MostrarInfoWtCode()
        {
            return $"Código: {codigoMotorista}, Nome: {nomeMotorista}, CNH: {cnhMotorista}, Telefone: {telefoneMotorista}";
        }

        // Info sem código
        public string MostrarInfoNoCode()
        {
            return $"Nome: {nomeMotorista}, CNH: {cnhMotorista}, Telefone: {telefoneMotorista}";
        }


    }
}
