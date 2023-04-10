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
            {

                try
                {
                    SqlCommand cmd = new SqlCommand("INSERT INTO Municipio (NOME_MUNICIPIO, ESTADO) VALUES (@Nome, @Estado)", conn);
                    cmd.Parameters.AddWithValue("@Nome", municipio.Nome);
                    cmd.Parameters.AddWithValue("@Estado", municipio.Estado);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    // Tratar a exceção
                }
                finally
                {
                    conn.Close();
                }
            }
        }


        public List<Municipio> ListarTodos()
        {
            List<Municipio> municipios = new List<Municipio>();
            using (SqlConnection conn = Conexao.ObterConexao())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("SELECT * FROM Municipio", conn);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Municipio municipio = new Municipio();
                            municipio.Nome = Convert.ToString(reader["NOME_MUNICIPIO"]);
                            municipio.Estado = Convert.ToString(reader["ESTADO"]);
                            municipios.Add(municipio);
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Tratar a exceção
                }
                finally
                {
                    conn.Close();
                }
            }
            return municipios;
        }

        public List<Municipio> ListarPorNome(string nome)
        {
            List<Municipio> municipios = new List<Municipio>();
            using (SqlConnection conn = Conexao.ObterConexao())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("SELECT * FROM Municipio WHERE NOME_MUNICIPIO LIKE @Nome", conn);
                    cmd.Parameters.AddWithValue("@Nome", "%" + nome + "%");
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Municipio municipio = new Municipio();
                            municipio.Nome = Convert.ToString(reader["NOME_MUNICIPIO"]);
                            municipio.Estado = Convert.ToString(reader["ESTADO"]);
                            municipios.Add(municipio);
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Tratar a exceção
                }
                finally
                {
                    conn.Close();
                }
            }
            return municipios;
        }
    }

}
