using SistemaVendasRestaurante.Controller.TelaVendas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaVendasRestaurante.Views
{
    public partial class TelaVendas : Form
    {
        public TelaVendas()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AdicionarProdutosController adicionar = new AdicionarProdutosController();
            double? valor = adicionar.AdicionarProduto(txtBoxNome.Text, int.Parse(txtBoxQnt.Text));
            if (valor != null)
            {
                txtTotal.Text = (double.Parse(txtTotal.Text) + valor).ToString();
                txtBoxQuantidadeTotal.Text = (int.Parse(txtBoxQuantidadeTotal.Text) + int.Parse(txtBoxQnt.Text)).ToString();
                MessageBox.Show("Produto adionado com sucesso!"); 
            }
            else
            {
                MessageBox.Show("Não foi possível localizar o produto!");
            }
        }
    }
}
