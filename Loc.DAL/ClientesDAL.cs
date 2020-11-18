using Loc.DTO;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loc.DAL
{
    public class ClientesDAL
    {
       private string AbrirConexao()
        {
            //return ConfigurationManager.ConnectionStrings["Conexao"].ConnectionString;
            return @"Server=.;Data Source=PC_MENDES\SQLEXPRESS;Initial Catalog=BDLOCADORA;Integrated Security=True;";
        }

       public void Salvar(Clientes cli)
       {
            string sql = @"INSERT INTO Clientes(Nome, Sexo, Cpf, DtNascimento, Telefone, Email, Cep, Endereco, Bairro, Cidade, Estado)"
                         + "VALUES(@Nome, @Sexo, @Cpf, @DtNascimento, @Telefone, @Email, @Cep, @Endereco, @Bairro, @Cidade, @Estado)";
            string conexao = AbrirConexao();
            SqlConnection con = new SqlConnection(conexao);
            SqlCommand cmd = new SqlCommand(sql,con);
            cmd.Parameters.AddWithValue("Nome", cli.Nome);
            cmd.Parameters.AddWithValue("Sexo", cli.Sexo);
            cmd.Parameters.AddWithValue("Cpf", cli.Cpf);
            cmd.Parameters.AddWithValue("DtNascimento", cli.DtNascimento);
            cmd.Parameters.AddWithValue("Telefone", cli.Telefone);
            cmd.Parameters.AddWithValue("Email", cli.Email);
            cmd.Parameters.AddWithValue("Cep",cli.Cep);
            cmd.Parameters.AddWithValue("Endereco",cli.Endereco);
            cmd.Parameters.AddWithValue("Bairro", cli.Bairro);
            cmd.Parameters.AddWithValue("Cidade", cli.Cidade);
            cmd.Parameters.AddWithValue("Estado", cli.Estado);
            cmd.CommandType = CommandType.Text;
            con.Open();

            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Salvo com Sucesso!!!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.ToString());
            }
            finally
            {
                con.Close();
            }
       }

    }
}
