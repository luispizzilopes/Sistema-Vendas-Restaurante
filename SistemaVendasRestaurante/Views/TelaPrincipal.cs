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
    public partial class TelaPrincipal : Form
    {
        public TelaPrincipal()
        {
            InitializeComponent();
        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            TelaCadastroProduto telaProdutos = new TelaCadastroProduto();
            telaProdutos.ShowDialog();
        }

        private void btnVendas_Click(object sender, EventArgs e)
        {
            TelaVendas tela = new TelaVendas();
            tela.ShowDialog(); 
        }
    }
}
