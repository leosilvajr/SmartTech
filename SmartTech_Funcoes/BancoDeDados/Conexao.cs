using System.Data.SqlClient;

namespace SmartTech_Funcoes.BancoDeDados
{
    public static class Conexao
    {
        private const string connectionString = "Data Source=LEO;Initial Catalog=SmartTech;Integrated Security=SSPI";

        public static SqlConnection ObterConexao()
        {
            SqlConnection conexao = new SqlConnection(connectionString);
            conexao.Open();
            return conexao;
        }

        public static void FecharConexao(SqlConnection conexao)
        {
            if (conexao != null && conexao.State == System.Data.ConnectionState.Open)
            {
                conexao.Close();
            }
        }
    }
}
