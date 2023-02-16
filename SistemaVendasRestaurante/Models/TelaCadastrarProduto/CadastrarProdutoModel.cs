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

        public bool CadastrarProduto(string nome, float preco)
        {
            conexao.StrSql = "insert into TabelaProdutos values(nome = @nome, preco = @preco"; 
            SqlCommand comandos = new SqlCommand(conexao.StrSql, conexao.Conectar());
            comandos.Parameters.Add("nome", System.Data.SqlDbType.VarChar).Value = nome;
            comandos.Parameters.Add("preco", System.Data.SqlDbType.VarChar).Value = preco; 
            try
            {
                comandos.ExecuteNonQuery();
                return true; 
            }
            catch (SqlException)
            {
                return false;
            }
        }
    }
}
