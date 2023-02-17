using SistemaVendasRestaurante.DAL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVendasRestaurante.Models.TelaVendas
{
    internal class AdicionarProdutosModel
    {
        ConexaoBd conexao = new ConexaoBd();

        public double? AdicionarProduto(string nome, int quantidade)
        {
            conexao.StrSql = "select * from TabelaProdutos where nome = @nome";
            SqlCommand comandos = new SqlCommand(conexao.StrSql, conexao.Conectar());
            comandos.Parameters.Add("nome", System.Data.SqlDbType.VarChar).Value = nome;
            try
            {
                using (SqlDataReader dataReader = comandos.ExecuteReader())
                {
                    if (dataReader.HasRows == true)
                    {
                        dataReader.Read();
                        double preco = Convert.ToDouble(dataReader["preco"]) * quantidade;
                        return preco;
                    }
                    else
                    {
                        return null;
                    }
                } 
            }
            catch (SqlException)
            {
                return null; 
            }
        }

    }
}
