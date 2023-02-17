using SistemaVendasRestaurante.DAL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVendasRestaurante.Models.TelaCadastrarProduto
{
    internal class ExcluirProdutoModel
    {
        ConexaoBd conexao = new ConexaoBd();

        public bool ExcluirProduto(string nome)
        {
            conexao.StrSql = "delete from TabelaProdutos where nome = @nome";
            SqlCommand comandos = new SqlCommand(conexao.StrSql, conexao.Conectar());
            comandos.Parameters.Add("nome", System.Data.SqlDbType.VarChar).Value = nome;
            try
            {
                comandos.ExecuteNonQuery();
                return true; 
            }
            catch (SqlException)
            {
                return false;
            }
            finally { conexao.Desconectar(); }
        }
    }
}
