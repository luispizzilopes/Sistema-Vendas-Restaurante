using SistemaVendasRestaurante.Models.TelaCadastrarProduto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVendasRestaurante.Controller.TelaCadastrarProduto
{
    internal class CadastrarProdutoController
    {
        CadastrarProdutoModel cadastrar = new CadastrarProdutoModel();
        
        public bool CadastrarProduto(string nome, float preco)
        {
            if(cadastrar.CadastrarProduto(nome,preco) == true)
            {
                return true; 
            }
            else
            {
                return false;
            }
        }
    }
}
