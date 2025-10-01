using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace CSharp_logistica.Classes
{
    public class PrecoCombustivel
    {
        private int precoId { get; set; }
        private string combustivel { get; set; }
        private decimal preco { get; set; }
        private DateTime dataConsulta { get; set; }

        public PrecoCombustivel(string combustivel, decimal preco, DateTime dataConsulta)
        {
            this.combustivel = combustivel;
            this.preco = preco;
            this.dataConsulta = dataConsulta;
        }

        public PrecoCombustivel(int precoId, string combustivel, decimal preco, DateTime dataConsulta)
            : this(combustivel, preco, dataConsulta)
        {
            this.precoId = precoId;
        }

        // Adiciona registro no banco
        public bool AddPrecoCombustivelBanco()
        {
            using (var connection = Conexao.ObterConexao())
            {
                string query = @"INSERT INTO PRECO_COMBUSTIVEL (COMBUSTIVEL, PRECO, DATA_CONSULTA) 
                                 VALUES (@Combustivel, @Preco, @DataConsulta)";
                try
                {
                    using (var command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Combustivel", combustivel);
                        command.Parameters.AddWithValue("@Preco", preco);
                        command.Parameters.AddWithValue("@DataConsulta", dataConsulta);
                        command.ExecuteNonQuery();
                    }
                    MessageBox.Show("Preço de combustível adicionado com sucesso!");
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao adicionar preço: " + ex.Message);
                    return false;
                }
            }
        }

        // Edita registro pelo ID
        public void EditPrecoCombustivel()
        {
            using var connection = Conexao.ObterConexao();
            string query = @"UPDATE PRECO_COMBUSTIVEL SET 
                                COMBUSTIVEL = @Combustivel, 
                                PRECO = @Preco, 
                                DATA_CONSULTA = @DataConsulta 
                             WHERE PRECOID = @PrecoId";
            var cmd = new SQLiteCommand(query, connection);
            try
            {
                cmd.Parameters.AddWithValue("@Combustivel", combustivel);
                cmd.Parameters.AddWithValue("@Preco", preco);
                cmd.Parameters.AddWithValue("@DataConsulta", dataConsulta);
                cmd.Parameters.AddWithValue("@PrecoId", precoId);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Preço de combustível alterado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao editar preço: " + ex.Message);
            }
        }

        // Exclui registro pelo ID
        public void DeletePrecoCombustivelBanco()
        {
            using (var connection = Conexao.ObterConexao())
            {
                string query = "DELETE FROM PRECO_COMBUSTIVEL WHERE PRECOID = @PrecoId";
                try
                {
                    using (var command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@PrecoId", precoId);
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                            MessageBox.Show("Preço de combustível deletado com sucesso!");
                        else
                            MessageBox.Show("Nenhum registro encontrado com o código fornecido.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao deletar preço: " + ex.Message);
                }
            }
        }

        // Consulta todos os registros de preço de combustível
        public static DataTable ObterTodosPrecos()
        {
            using var connection = Conexao.ObterConexao();
            string query = "SELECT * FROM PRECO_COMBUSTIVEL";
            try
            {
                using var da = new SQLiteDataAdapter(query, connection);
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao obter preços: " + ex.Message);
                return new DataTable();
            }
        }

        // Compara duas instâncias do registro para ver se são iguais
        public bool EqualsPrecoCombustivel(PrecoCombustivel outro)
        {
            if (outro == null) return false;

            return this.combustivel == outro.combustivel &&
                   this.preco == outro.preco &&
                   this.dataConsulta == outro.dataConsulta;
        }

        // Info com código
        public string MostrarInfoWtCode()
        {
            return $"Código: {precoId}, Combustível: {combustivel}, Preço: {preco}, Data: {dataConsulta:dd/MM/yyyy}";
        }

        // Info sem código
        public string MostrarInfoNoCode()
        {
            return $"Combustível: {combustivel}, Preço: {preco}, Data: {dataConsulta:dd/MM/yyyy}";
        }
    }
}
