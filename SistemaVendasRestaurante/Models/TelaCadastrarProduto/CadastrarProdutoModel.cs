using SistemaVendasRestaurante.DAL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVendasRestaurante.Models.TelaCadastrarProduto
{
    internal class CadastrarProdutoModel
    {
        ConexaoBd conexao = new ConexaoBd();

        public bool CadastrarProduto(string nome, double preco)
        {
            if(VerificarNome(nome) == true)
            {
                conexao.StrSql = "insert into TabelaProdutos values(@nome, @preco)";
                SqlCommand comandos = new SqlCommand(conexao.StrSql, conexao.Conectar());
                comandos.Parameters.Add("nome", System.Data.SqlDbType.VarChar).Value = nome;
                comandos.Parameters.Add("preco", System.Data.SqlDbType.Money).Value = preco;
                try
                {
                    comandos.ExecuteNonQuery();
                    return true;
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                    return false;
                }
                finally { conexao.Desconectar(); }
            }
            else
            {
                return false; 
            }
        }

        public bool VerificarNome(string nome)
        {
            conexao.StrSql = "select * from TabelaProdutos where nome = @nome";
            SqlCommand comandos = new SqlCommand(conexao.StrSql, conexao.Conectar());
            comandos.Parameters.Add("nome", System.Data.SqlDbType.VarChar).Value = nome; 
            try
            {
                using(SqlDataReader dataReader = comandos.ExecuteReader())
                {
                    if(dataReader.HasRows != true)
                    {
                        return true; 
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (SqlException)
            {
                return false; 
            }
            finally { conexao.Desconectar(); }
        }
    }
}
