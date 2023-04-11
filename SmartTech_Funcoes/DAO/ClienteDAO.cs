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
    public class ClienteDAO
    {
        public void Inserir(Cliente cliente)
        {
            using (SqlConnection conn = Conexao.ObterConexao())
            using (SqlCommand cmd = new SqlCommand("INSERT INTO Cliente (NOME_RAZAOSOCIAL, CPF_CNPJ, IE_RG, APELIDO_FANTASIA, COD_MUNICIPIO," +
                " ENDERECO, NUMERO, BAIRRO, TELEFONE, CELULAR, EMAIL) VALUES (@NomeRazaoSocial, @CpfCnpj, @IeRg, @ApelidoFantasia, @CodMunicipio," +
                " @Endereco, @Numero, @Bairro, @Telefone, @Celular, @Email)", conn))
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

    }
}
