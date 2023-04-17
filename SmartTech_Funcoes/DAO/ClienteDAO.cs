using SmartTech_Funcoes.BancoDeDados;
using SmartTech_Funcoes.Entidades;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace SmartTech_Funcoes.DAO
{
    public class ClienteDAO
    {
        public void Inserir(Cliente cliente)
        {
            using (SqlConnection conn = Conexao.ObterConexao())
            using (SqlCommand cmd = new SqlCommand("INSERT INTO CLIENTE (NOME_RAZAOSOCIAL, CPF_CNPJ, IE_RG," +
                " APELIDO_FANTASIA, COD_MUNICIPIO, ENDERECO, NUMERO, BAIRRO, TELEFONE, CELULAR, EMAIL, PESSOA, CEP)" +
                " VALUES (@NomeRazaoSocial, @CpfCnpj, @IeRg, @ApelidoFantasia, @CodMunicipio," +
                " @Endereco, @Numero, @Bairro, @Telefone, @Celular, @Email, @Pessoa, @Cep)", conn))
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
                " CELULAR = @Celular, EMAIL = @Email, PESSOA = @Pessoa, CEP = @Cep WHERE COD_CLIENTE = @Codigo", conn))
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
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    Cliente cliente = new Cliente();
                    cliente.Codigo = (int)reader["COD_CLIENTE"];
                    cliente.NomeRazaoSocial = reader["NOME_RAZAOSOCIAL"].ToString();
                    cliente.CpfCnpj = reader["CPF_CNPJ"].ToString();
                    cliente.IeRg = reader["IE_RG"].ToString();
                    cliente.ApelidoFantasia = reader["APELIDO_FANTASIA"].ToString();
                    cliente.CodMunicipio = (int)reader["COD_MUNICIPIO"];
                    cliente.Endereco = reader["ENDERECO"].ToString();
                    cliente.Numero = reader["NUMERO"].ToString();
                    cliente.Bairro = reader["BAIRRO"].ToString();
                    cliente.Telefone = reader["TELEFONE"].ToString();
                    cliente.Celular = reader["CELULAR"].ToString();
                    cliente.Email = reader["EMAIL"].ToString();
                    cliente.Pessoa = reader["PESSOA"].ToString();
                    cliente.Cep = reader["CEP"].ToString();
                    if (cliente.CodMunicipio > 0)
                    {
                        MunicipioDAO municipio = new MunicipioDAO();
                        cliente.Municipio = municipio.ObterPorCodigo(cliente.CodMunicipio);
                    }


                    clientes.Add(cliente);
                }
            }

            return clientes;
        }

        public Cliente ObterPorCodigo(int codigo)
        {
            using (SqlConnection conn = Conexao.ObterConexao())
            using (SqlCommand cmd = new SqlCommand("SELECT * FROM CLIENTE WHERE COD_CLIENTE = @Codigo", conn))
            {
                cmd.Parameters.AddWithValue("@Codigo", codigo);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        Cliente cliente = new Cliente();
                        cliente.Codigo = (int)reader["COD_CLIENTE"];
                        cliente.NomeRazaoSocial = reader["NOME_RAZAOSOCIAL"].ToString();
                        cliente.CpfCnpj = reader["CPF_CNPJ"].ToString();
                        cliente.IeRg = reader["IE_RG"].ToString();
                        cliente.ApelidoFantasia = reader["APELIDO_FANTASIA"].ToString();
                        cliente.CodMunicipio = (int)reader["COD_MUNICIPIO"];
                        cliente.Endereco = reader["ENDERECO"].ToString();
                        cliente.Numero = reader["NUMERO"].ToString();
                        cliente.Bairro = reader["BAIRRO"].ToString();
                        cliente.Telefone = reader["TELEFONE"].ToString();
                        cliente.Celular = reader["CELULAR"].ToString();
                        cliente.Email = reader["EMAIL"].ToString();
                        cliente.Pessoa = reader["PESSOA"].ToString();
                        cliente.Cep = reader["CEP"].ToString();
                        if (cliente.CodMunicipio > 0)
                        {
                            MunicipioDAO municipio = new MunicipioDAO();
                            cliente.Municipio = municipio.ObterPorCodigo(cliente.CodMunicipio);
                        }
                        return cliente;
                    }
                }
            }

            return null;
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
                        cliente.Codigo = (int)reader["COD_CLIENTE"];
                        cliente.NomeRazaoSocial = reader["NOME_RAZAOSOCIAL"].ToString();
                        cliente.CpfCnpj = reader["CPF_CNPJ"].ToString();
                        cliente.IeRg = reader["IE_RG"].ToString();
                        cliente.ApelidoFantasia = reader["APELIDO_FANTASIA"].ToString();
                        cliente.CodMunicipio = (int)reader["COD_MUNICIPIO"];
                        cliente.Endereco = reader["ENDERECO"].ToString();
                        cliente.Numero = reader["NUMERO"].ToString();
                        cliente.Bairro = reader["BAIRRO"].ToString();
                        cliente.Telefone = reader["TELEFONE"].ToString();
                        cliente.Celular = reader["CELULAR"].ToString();
                        cliente.Email = reader["EMAIL"].ToString();
                        cliente.Pessoa = reader["PESSOA"].ToString();
                        cliente.Cep = reader["CEP"].ToString();
                        clientes.Add(cliente);
                    }
                }
            }

            return clientes;
        }


    }
}
