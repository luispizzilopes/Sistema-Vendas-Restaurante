using SistemaVendasRestaurante.DAL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVendasRestaurante.Models.TelaCadastrarProduto
{
    internal class EditarProdutoModel
    {
        ConexaoBd conexao = new ConexaoBd();

        public bool EditarProduto(string nome, double preco, string busca)
        {
            conexao.StrSql = "update TabelaProdutos set nome=@nome, preco=@preco where nome=@busca"; 
            SqlCommand comandos = new SqlCommand(conexao.StrSql, conexao.Conectar());
            comandos.Parameters.Add("nome", System.Data.SqlDbType.VarChar).Value = nome; 
            comandos.Parameters.Add("preco", System.Data.SqlDbType.Money).Value = preco;
            comandos.Parameters.Add("busca", System.Data.SqlDbType.VarChar).Value = busca;
            try
            {
                comandos.ExecuteNonQuery();
                return true;
            }
            catch(SqlException)
            {
                return false;
            }
            finally { conexao.Desconectar(); }
        }
    }
}
