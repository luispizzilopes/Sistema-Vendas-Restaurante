namespace SistemaVendasRestaurante.Views
{
    partial class TelaCadastroProduto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtBoxNome = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.txtBoxBusca = new System.Windows.Forms.TextBox();
            this.txtBoxValor = new System.Windows.Forms.TextBox();
            this.txtBoxNomeBusca = new System.Windows.Forms.TextBox();
            this.txtBoxValorBusca = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtBoxNome
            // 
            this.txtBoxNome.Location = new System.Drawing.Point(12, 24);
            this.txtBoxNome.Name = "txtBoxNome";
            this.txtBoxNome.Size = new System.Drawing.Size(222, 27);
            this.txtBoxNome.TabIndex = 0;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(140, 90);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(94, 29);
            this.btnCadastrar.TabIndex = 2;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(140, 174);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(94, 29);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(553, 90);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(94, 29);
            this.btnExcluir.TabIndex = 5;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(453, 90);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(94, 29);
            this.btnEditar.TabIndex = 4;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // txtBoxBusca
            // 
            this.txtBoxBusca.Location = new System.Drawing.Point(12, 141);
            this.txtBoxBusca.Name = "txtBoxBusca";
            this.txtBoxBusca.Size = new System.Drawing.Size(222, 27);
            this.txtBoxBusca.TabIndex = 6;
            // 
            // txtBoxValor
            // 
            this.txtBoxValor.Location = new System.Drawing.Point(12, 57);
            this.txtBoxValor.Name = "txtBoxValor";
            this.txtBoxValor.Size = new System.Drawing.Size(222, 27);
            this.txtBoxValor.TabIndex = 1;
            // 
            // txtBoxNomeBusca
            // 
            this.txtBoxNomeBusca.Location = new System.Drawing.Point(425, 24);
            this.txtBoxNomeBusca.Name = "txtBoxNomeBusca";
            this.txtBoxNomeBusca.Size = new System.Drawing.Size(222, 27);
            this.txtBoxNomeBusca.TabIndex = 8;
            // 
            // txtBoxValorBusca
            // 
            this.txtBoxValorBusca.Location = new System.Drawing.Point(425, 57);
            this.txtBoxValorBusca.Name = "txtBoxValorBusca";
            this.txtBoxValorBusca.Size = new System.Drawing.Size(222, 27);
            this.txtBoxValorBusca.TabIndex = 7;
            // 
            // TelaCadastroProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 243);
            this.Controls.Add(this.txtBoxNomeBusca);
            this.Controls.Add(this.txtBoxValorBusca);
            this.Controls.Add(this.txtBoxBusca);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.txtBoxValor);
            this.Controls.Add(this.txtBoxNome);
            this.Name = "TelaCadastroProduto";
            this.Text = "Tela Cadastro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtBoxNome;
        private Button btnCadastrar;
        private Button btnBuscar;
        private Button btnExcluir;
        private Button btnEditar;
        private TextBox txtBoxBusca;
        private TextBox txtBoxValor;
        private TextBox txtBoxNomeBusca;
        private TextBox txtBoxValorBusca;
    }
}