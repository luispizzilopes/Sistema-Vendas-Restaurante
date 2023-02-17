using SistemaVendasRestaurante.Models.TelaCadastrarProduto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVendasRestaurante.Controller.TelaCadastrarProduto
{
    internal class ExcluirProdutoController
    {
        ExcluirProdutoModel excluir = new ExcluirProdutoModel();

        public bool ExcluirProduto(string nome)
        {
            if(excluir.ExcluirProduto(nome) == true)
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
