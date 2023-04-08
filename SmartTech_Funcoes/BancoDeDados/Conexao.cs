using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartTech_Funcoes.BancoDeDados
{
    public class Conexao
    {
        private static string connectionString = "Data Source=LEO;Initial Catalog=SmartTech;Integrated Security=SSPI";

        public static SqlConnection GetConexao()
        {
            SqlConnection conexao = new SqlConnection(connectionString);
            conexao.Open();
            return conexao;
        }


        public static bool TestConnection()
        {
            using (SqlConnection conexao = GetConexao())
            {
                return (conexao.State == System.Data.ConnectionState.Open);
            }
        }
    }
}
