using SistemaVendasRestaurante.DAL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVendasRestaurante.Models.TelaCadastrarProduto
{
    internal class BuscarProdutoModel
    {
        ConexaoBd conexao = new ConexaoBd();

        public string[] BuscarProduto(string nome)
        {
            conexao.StrSql = "select * from TabelaProdutos where nome = @nome";
            SqlCommand comandos = new SqlCommand(conexao.StrSql, conexao.Conectar());
            comandos.Parameters.Add("nome", System.Data.SqlDbType.VarChar).Value = nome; 
            try
            {
                SqlDataReader dataReader = comandos.ExecuteReader(); 
                if(dataReader.HasRows == true)
                {
                    dataReader.Read();
                    string[] campos = new string[2];
                    campos[0] = Convert.ToString(dataReader["nome"]);
                    campos[1] = Convert.ToString(dataReader["preco"]);

                    return campos; 
                }
                else
                {
                    return null;
                }
            }
            catch (SqlException)
            {
                return null; 
            }
            finally { conexao.Desconectar(); }
        }
    }
}
