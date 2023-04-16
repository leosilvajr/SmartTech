using SmartTech_Funcoes.BancoDeDados;
using SmartTech_Funcoes.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Resources.ResXFileRef;

namespace SmartTech_Funcoes.DAO
{
    public class ClienteDAO
    {
        public void Inserir(Cliente cliente)
        {
            using (SqlConnection conn = Conexao.ObterConexao())
            using (SqlCommand cmd = new SqlCommand("INSERT INTO CLIENTE (NOME_RAZAOSOCIAL, CPF_CNPJ, IE_RG," +
                " APELIDO_FANTASIA, COD_MUNICIPIO, ENDERECO, NUMERO, BAIRRO, TELEFONE, CELULAR, EMAIL, Foto,PESSOA, CEP)" +
                " VALUES (@NomeRazaoSocial, @CpfCnpj, @IeRg, @ApelidoFantasia, @CodMunicipio," +
                " @Endereco, @Numero, @Bairro, @Telefone, @Celular, @Email, @Foto,@Pessoa, @Cep)", conn))
            {
                cmd.Parameters.AddWithValue("@NomeRazaoSocial", cliente.NomeRazaoSocial);
                cmd.Parameters.AddWithValue("@CpfCnpj", cliente.CpfCnpj);
                cmd.Parameters.AddWithValue("@IeRg", cliente.IeRg);
                cmd.Parameters.AddWithValue("@ApelidoFantasia", cliente.ApelidoFantasia);
                cmd.Parameters.AddWithValue("@CodMunicipio", cliente.CodMunicipio);
                cmd.Parameters.AddWithValue("@Endereco", cliente.Endereco);
                cmd.Parameters.AddWithValue("@Numero", cliente.Numero);
                cmd.Parameters.AddWithValue("@Bairro", cliente.Bairro);
                cmd.Parameters.AddWithValue("@Telefone", cliente.Telefone);
                cmd.Parameters.AddWithValue("@Celular", cliente.Celular);
                cmd.Parameters.AddWithValue("@Email", cliente.Email);
                cmd.Parameters.AddWithValue("@Foto", cliente.Foto);
                cmd.Parameters.AddWithValue("@Pessoa", cliente.Pessoa);
                cmd.Parameters.AddWithValue("@Cep", cliente.Cep);

                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    // Logar a exceção em um arquivo ou banco de dados
                    throw new Exception("Erro ao inserir o cliente.", ex);
                }
            }
        }
        public void Atualizar(Cliente cliente)
        {
            using (SqlConnection conn = Conexao.ObterConexao())
            using (SqlCommand cmd = new SqlCommand("UPDATE Cliente SET NOME_RAZAOSOCIAL = @Nome, CPF_CNPJ = @CpfCnpj," +
                " IE_RG = @IeRg, APELIDO_FANTASIA = @ApelidoFantasia, COD_MUNICIPIO = @CodMunicipio," +
                " ENDERECO = @Endereco, NUMERO = @Numero, BAIRRO = @Bairro, TELEFONE = @Telefone," +
                " CELULAR = @Celular, EMAIL = @Email, FOTO = @Foto, PESSOA = @Pessoa, CEP = @Cep WHERE COD_CLIENTE = @Codigo", conn))
            {
                cmd.Parameters.AddWithValue("@Nome", cliente.NomeRazaoSocial);
                cmd.Parameters.AddWithValue("@CpfCnpj", cliente.CpfCnpj);
                cmd.Parameters.AddWithValue("@IeRg", cliente.IeRg);
                cmd.Parameters.AddWithValue("@ApelidoFantasia", cliente.ApelidoFantasia);
                cmd.Parameters.AddWithValue("@CodMunicipio", cliente.CodMunicipio);
                cmd.Parameters.AddWithValue("@Endereco", cliente.Endereco);
                cmd.Parameters.AddWithValue("@Numero", cliente.Numero);
                cmd.Parameters.AddWithValue("@Bairro", cliente.Bairro);
                cmd.Parameters.AddWithValue("@Telefone", cliente.Telefone);
                cmd.Parameters.AddWithValue("@Celular", cliente.Celular);
                cmd.Parameters.AddWithValue("@Email", cliente.Email);
                cmd.Parameters.AddWithValue("@Foto", cliente.Foto);
                cmd.Parameters.AddWithValue("@Cep", cliente.Cep);
                cmd.Parameters.AddWithValue("@Pessoa", cliente.Pessoa);
                cmd.Parameters.AddWithValue("@Codigo", cliente.Codigo);
                
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    // Logar a exceção em um arquivo ou banco de dados
                    throw new Exception("Erro ao atualizar o cliente.", ex);
                }
            }
        }

        public void Excluir(int codigo)
        {
            using (SqlConnection conn = Conexao.ObterConexao())
            using (SqlCommand cmd = new SqlCommand("DELETE FROM CLIENTE WHERE COD_CLIENTE = @Codigo", conn))
            {
                cmd.Parameters.AddWithValue("@Codigo", codigo);

                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    // Logar a exceção em um arquivo ou banco de dados
                    throw new Exception("Erro ao excluir o cliente.", ex);
                }
            }
        }

        public List<Cliente> ObterTodos()
        {
            List<Cliente> clientes = new List<Cliente>();

            using (SqlConnection conn = Conexao.ObterConexao())
            using (SqlCommand cmd = new SqlCommand("SELECT * FROM CLIENTE", conn))
            {
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Cliente cliente = new Cliente();
                        cliente.Codigo = reader.GetInt32(reader.GetOrdinal("COD_CLIENTE"));
                        cliente.NomeRazaoSocial = reader.GetString(reader.GetOrdinal("NOME_RAZAOSOCIAL"));
                        cliente.CpfCnpj = reader.GetString(reader.GetOrdinal("CPF_CNPJ"));
                        cliente.IeRg = reader.GetString(reader.GetOrdinal("IE_RG"));
                        cliente.ApelidoFantasia = reader.GetString(reader.GetOrdinal("APELIDO_FANTASIA"));
                        cliente.CodMunicipio = reader.GetInt32(reader.GetOrdinal("COD_MUNICIPIO"));
                        cliente.Endereco = reader.GetString(reader.GetOrdinal("ENDERECO"));
                        cliente.Numero = reader.GetString(reader.GetOrdinal("NUMERO"));
                        cliente.Bairro = reader.GetString(reader.GetOrdinal("BAIRRO"));
                        cliente.Telefone = reader.GetString(reader.GetOrdinal("TELEFONE"));
                        cliente.Celular = reader.GetString(reader.GetOrdinal("CELULAR"));
                        cliente.Email = reader.GetString(reader.GetOrdinal("EMAIL"));

                        if (!reader.IsDBNull(reader.GetOrdinal("Foto")))
                        {
                            byte[] fotoBytes = (byte[])reader["Foto"];
                            MemoryStream stream = new MemoryStream(fotoBytes);
                            Image foto = Image.FromStream(stream);
                            cliente.Foto = fotoBytes;
                            //ou
                            //ImageConverter converter = new ImageConverter();
                            //cliente.Foto = (byte[])converter.ConvertTo(foto, typeof(byte[]));
                        }
                        cliente.Pessoa = reader.GetString(reader.GetOrdinal("PESSOA"));
                        cliente.Cep = reader.GetString(reader.GetOrdinal("CEP"));


                        clientes.Add(cliente);
                    }
                }
            }

            return clientes;
        }

        public Cliente ObterPorCodigo(int codigo)
        {
            Cliente cliente = null;

            using (SqlConnection conn = Conexao.ObterConexao())
            using (SqlCommand cmd = new SqlCommand("SELECT * FROM CLIENTE WHERE COD_CLIENTE = @Codigo", conn))
            {
                cmd.Parameters.AddWithValue("@Codigo", codigo);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        cliente = new Cliente();
                        cliente.Codigo = reader.GetInt32(reader.GetOrdinal("COD_CLIENTE"));
                        cliente.NomeRazaoSocial = reader.GetString(reader.GetOrdinal("NOME_RAZAOSOCIAL"));
                        cliente.CpfCnpj = reader.GetString(reader.GetOrdinal("CPF_CNPJ"));
                        cliente.IeRg = reader.GetString(reader.GetOrdinal("IE_RG"));
                        cliente.ApelidoFantasia = reader.GetString(reader.GetOrdinal("APELIDO_FANTASIA"));
                        cliente.CodMunicipio = reader.GetInt32(reader.GetOrdinal("COD_MUNICIPIO"));
                        cliente.Endereco = reader.GetString(reader.GetOrdinal("ENDERECO"));
                        cliente.Numero = reader.GetString(reader.GetOrdinal("NUMERO"));
                        cliente.Bairro = reader.GetString(reader.GetOrdinal("BAIRRO"));
                        cliente.Telefone = reader.GetString(reader.GetOrdinal("TELEFONE"));
                        cliente.Celular = reader.GetString(reader.GetOrdinal("CELULAR"));
                        cliente.Email = reader.GetString(reader.GetOrdinal("EMAIL"));

                        if (!reader.IsDBNull(reader.GetOrdinal("Foto")))
                        {
                            byte[] fotoBytes = (byte[])reader["Foto"];
                            MemoryStream stream = new MemoryStream(fotoBytes);
                            Image foto = Image.FromStream(stream);
                            cliente.Foto = fotoBytes;
                            //ou
                            //ImageConverter converter = new ImageConverter();
                            //cliente.Foto = (byte[])converter.ConvertTo(foto, typeof(byte[]));
                        }
                        cliente.Pessoa = reader.GetString(reader.GetOrdinal("PESSOA"));
                        cliente.Cep = reader.GetString(reader.GetOrdinal("CEP"));
                    }
                }
            }

            return cliente;
        }

        public List<Cliente> ObterPorNome(string nome)
        {
            List<Cliente> clientes = new List<Cliente>();

            using (SqlConnection conn = Conexao.ObterConexao())
            using (SqlCommand cmd = new SqlCommand("SELECT * FROM CLIENTE WHERE NOME_RAZAOSOCIAL LIKE @Nome", conn))
            {
                cmd.Parameters.AddWithValue("@Nome", "%" + nome + "%");

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Cliente cliente = new Cliente();
                        cliente.Codigo = reader.GetInt32(reader.GetOrdinal("COD_CLIENTE"));
                        cliente.NomeRazaoSocial = reader.GetString(reader.GetOrdinal("NOME_RAZAOSOCIAL"));
                        cliente.CpfCnpj = reader.GetString(reader.GetOrdinal("CPF_CNPJ"));
                        cliente.IeRg = reader.GetString(reader.GetOrdinal("IE_RG"));
                        cliente.ApelidoFantasia = reader.GetString(reader.GetOrdinal("APELIDO_FANTASIA"));
                        cliente.CodMunicipio = reader.GetInt32(reader.GetOrdinal("COD_MUNICIPIO"));
                        cliente.Endereco = reader.GetString(reader.GetOrdinal("ENDERECO"));
                        cliente.Numero = reader.GetString(reader.GetOrdinal("NUMERO"));
                        cliente.Bairro = reader.GetString(reader.GetOrdinal("BAIRRO"));
                        cliente.Telefone = reader.GetString(reader.GetOrdinal("TELEFONE"));
                        cliente.Celular = reader.GetString(reader.GetOrdinal("CELULAR"));
                        cliente.Email = reader.GetString(reader.GetOrdinal("EMAIL"));

                        if (!reader.IsDBNull(reader.GetOrdinal("Foto")))
                        {
                            byte[] fotoBytes = (byte[])reader["Foto"];
                            MemoryStream stream = new MemoryStream(fotoBytes);
                            Image foto = Image.FromStream(stream);
                            cliente.Foto = fotoBytes;
                            //ou
                            //ImageConverter converter = new ImageConverter();
                            //cliente.Foto = (byte[])converter.ConvertTo(foto, typeof(byte[]));
                        }
                        cliente.Pessoa = reader.GetString(reader.GetOrdinal("PESSOA"));
                        cliente.Cep = reader.GetString(reader.GetOrdinal("CEP"));
                        clientes.Add(cliente);
                    }
                }
            }

            return clientes;
        }


    }
}
