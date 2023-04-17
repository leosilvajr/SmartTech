using SmartTech_Funcoes.BancoDeDados;
using SmartTech_Funcoes.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartTech_Funcoes.DAO
{
    public class MunicipioDAO
    {
        public void Inserir(Municipio municipio)
        {
            using (SqlConnection conn = Conexao.ObterConexao())
            using (SqlCommand cmd = new SqlCommand("INSERT INTO Municipio (NOME_MUNICIPIO, ESTADO) VALUES (@Nome, @Estado)", conn))
            {
                cmd.Parameters.AddWithValue("@Nome", municipio.Nome);
                cmd.Parameters.AddWithValue("@Estado", municipio.Estado);

                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    // Logar a exceção em um arquivo ou banco de dados
                    throw new Exception("Erro ao inserir o município.", ex);
                }
            }
        }

        public void Atualizar(Municipio municipio)
        {
            using (SqlConnection conn = Conexao.ObterConexao())
            using (SqlCommand cmd = new SqlCommand("UPDATE Municipio SET NOME_MUNICIPIO = @Nome, ESTADO = @Estado WHERE COD_MUNICIPIO = @Codigo", conn))
            {
                cmd.Parameters.AddWithValue("@Codigo", municipio.Codigo);
                cmd.Parameters.AddWithValue("@Nome", municipio.Nome);
                cmd.Parameters.AddWithValue("@Estado", municipio.Estado);

                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    // Logar a exceção em um arquivo ou banco de dados
                    throw new Exception("Erro ao atualizar o município.", ex);
                }
            }
        }

        public void Excluir(int codigo)
        {
            using (SqlConnection conn = Conexao.ObterConexao())
            using (SqlCommand cmd = new SqlCommand("DELETE FROM Municipio WHERE COD_MUNICIPIO = @Codigo", conn))
            {
                cmd.Parameters.AddWithValue("@Codigo", codigo);

                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    // Logar a exceção em um arquivo ou banco de dados
                    throw new Exception("Erro ao excluir o município.", ex);
                }
            }
        }

        public List<Municipio> ObterTodos()
        {
            List<Municipio> municipios = new List<Municipio>();

            using (SqlConnection conn = Conexao.ObterConexao())
            using (SqlCommand cmd = new SqlCommand("SELECT * FROM Municipio", conn))
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    Municipio municipio = new Municipio();
                    municipio.Codigo = (int)reader["COD_MUNICIPIO"];
                    municipio.Nome = reader["NOME_MUNICIPIO"].ToString();
                    municipio.Estado = reader["ESTADO"].ToString();
                    municipios.Add(municipio);
                }
            }

            return municipios;
        }

        public Municipio ObterPorCodigo(int codigo)
        {
            using (SqlConnection conn = Conexao.ObterConexao())
            using (SqlCommand cmd = new SqlCommand("SELECT * FROM Municipio WHERE COD_MUNICIPIO = @Codigo", conn))
            {
                cmd.Parameters.AddWithValue("@Codigo", codigo);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        Municipio municipio = new Municipio();
                        municipio.Codigo = (int)reader["COD_MUNICIPIO"];
                        municipio.Nome = Convert.ToString(reader["NOME_MUNICIPIO"]);
                        municipio.Estado = Convert.ToString(reader["ESTADO"]);
                        return municipio;
                    }
                }
            }

            return null;
        }


        public List<Municipio> ObterPorNome(string nome)
        {
            List<Municipio> municipios = new List<Municipio>();

            using (SqlConnection conn = Conexao.ObterConexao())
            using (SqlCommand cmd = new SqlCommand("SELECT * FROM Municipio WHERE NOME_MUNICIPIO LIKE @Nome", conn))
            {
                cmd.Parameters.AddWithValue("@Nome", "%" + nome + "%");

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Municipio municipio = new Municipio();
                        municipio.Codigo = (int)reader["COD_MUNICIPIO"];
                        municipio.Nome = Convert.ToString(reader["NOME_MUNICIPIO"]);
                        municipio.Estado = Convert.ToString(reader["ESTADO"]);
                        municipios.Add(municipio);
                    }
                }
            }

            return municipios;
        }

    }

}
