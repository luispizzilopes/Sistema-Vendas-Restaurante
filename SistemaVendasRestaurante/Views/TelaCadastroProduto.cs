using SistemaVendasRestaurante.Controller.TelaCadastrarProduto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaVendasRestaurante.Views
{
    public partial class TelaCadastroProduto : Form
    {
        public TelaCadastroProduto()
        {
            InitializeComponent();
        }

        public void BloquearCampos()
        {
            txtBoxNomeBusca.Enabled = false;
            txtBoxValorBusca.Enabled = false;
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
            txtBoxNomeBusca.Text = "";
            txtBoxValorBusca.Text = "";
        }

        public void DesbloquearCampos()
        {
            txtBoxNomeBusca.Enabled = true;
            txtBoxValorBusca.Enabled = true;
            btnEditar.Enabled = true;
            btnExcluir.Enabled = true;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            CadastrarProdutoController controllerCadastrar = new CadastrarProdutoController();
            if(controllerCadastrar.CadastrarProduto(txtBoxNome.Text, double.Parse(txtBoxValor.Text)) == true)
            {
                MessageBox.Show("Produto cadastrado com sucesso!");
                txtBoxValor.Text = "";
                txtBoxNome.Text = ""; 
            }
            else
            {
                MessageBox.Show("Não foi possível cadastrar o produto!"); 
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BuscarProdutoController buscar = new BuscarProdutoController();
            if(buscar.BuscarProduto(txtBoxBusca.Text) != null)
            {
                string[] campos = buscar.BuscarProduto(txtBoxBusca.Text);
                txtBoxNomeBusca.Text = campos[0];
                txtBoxValorBusca.Text = double.Parse(campos[1]).ToString("N2");
                DesbloquearCampos(); 
            }
            else
            {
                MessageBox.Show("Não foi possível localizar um produto com esse nome!"); 
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            EditarProdutoController editar = new EditarProdutoController(); 
            if(editar.EditarProduto(txtBoxNomeBusca.Text, double.Parse(txtBoxValorBusca.Text), txtBoxBusca.Text) == true)
            {
                MessageBox.Show("Produto editado com sucesso!");
                BloquearCampos();
            }
            else
            {
                MessageBox.Show("Erro ao tentar editar o produto!"); 
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            ExcluirProdutoController excluir = new ExcluirProdutoController(); 
            if(excluir.ExcluirProduto(txtBoxNomeBusca.Text) == true)
            {
                MessageBox.Show("Produto excluido com sucesso!");
                BloquearCampos(); 
            }
            else
            {
                MessageBox.Show("Não foi possível excluir o produto!"); 
            }
        }
    }
}
