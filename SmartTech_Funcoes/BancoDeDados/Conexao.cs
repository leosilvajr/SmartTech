using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartTech_Funcoes.BancoDeDados
{
    public sealed class Conexao
    {
        private static readonly string connectionString = "Data Source=LEO;Initial Catalog=SmartTech;Integrated Security=SSPI";
        private static SqlConnection conn = null;

        private Conexao() { }

        public static SqlConnection ObterConexao()
        {
            if (conn == null)
            {
                conn = new SqlConnection(connectionString);
                conn.Open();
            }
            return conn;
        }

        public static void FecharConexao()
        {
            if (conn != null && conn.State == System.Data.ConnectionState.Open)
            {
                conn.Close();
            }
        }
    }


}
