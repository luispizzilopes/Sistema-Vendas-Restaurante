namespace SistemaVendasRestaurante.Views
{
    partial class TelaVendas
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
            this.lblNome = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtBoxNome = new System.Windows.Forms.TextBox();
            this.lblQnt = new System.Windows.Forms.Label();
            this.txtBoxQnt = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtBoxQuantidadeTotal = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(12, 23);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(132, 20);
            this.lblNome.TabIndex = 12;
            this.lblNome.Text = "Nome do Produto:";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(140, 142);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(94, 29);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Adicionar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtBoxNome
            // 
            this.txtBoxNome.Location = new System.Drawing.Point(12, 46);
            this.txtBoxNome.Name = "txtBoxNome";
            this.txtBoxNome.Size = new System.Drawing.Size(222, 27);
            this.txtBoxNome.TabIndex = 10;
            // 
            // lblQnt
            // 
            this.lblQnt.AutoSize = true;
            this.lblQnt.Location = new System.Drawing.Point(12, 86);
            this.lblQnt.Name = "lblQnt";
            this.lblQnt.Size = new System.Drawing.Size(87, 20);
            this.lblQnt.TabIndex = 14;
            this.lblQnt.Text = "Quantidade";
            // 
            // txtBoxQnt
            // 
            this.txtBoxQnt.Location = new System.Drawing.Point(12, 109);
            this.txtBoxQnt.Name = "txtBoxQnt";
            this.txtBoxQnt.Size = new System.Drawing.Size(222, 27);
            this.txtBoxQnt.TabIndex = 13;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(12, 224);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(49, 20);
            this.lblTotal.TabIndex = 15;
            this.lblTotal.Text = "Total: ";
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Location = new System.Drawing.Point(12, 256);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(94, 20);
            this.lblQuantidade.TabIndex = 16;
            this.lblQuantidade.Text = "Quantidade: ";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(67, 221);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(222, 27);
            this.txtTotal.TabIndex = 17;
            // 
            // txtBoxQuantidadeTotal
            // 
            this.txtBoxQuantidadeTotal.Location = new System.Drawing.Point(112, 256);
            this.txtBoxQuantidadeTotal.Name = "txtBoxQuantidadeTotal";
            this.txtBoxQuantidadeTotal.Size = new System.Drawing.Size(177, 27);
            this.txtBoxQuantidadeTotal.TabIndex = 18;
            // 
            // TelaVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtBoxQuantidadeTotal);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.lblQuantidade);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblQnt);
            this.Controls.Add(this.txtBoxQnt);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtBoxNome);
            this.Name = "TelaVendas";
            this.Text = "TelaVendas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblNome;
        private Button btnAdd;
        private TextBox txtBoxNome;
        private Label lblQnt;
        private TextBox txtBoxQnt;
        private Label lblTotal;
        private Label lblQuantidade;
        private TextBox txtTotal;
        private TextBox txtBoxQuantidadeTotal;
    }
}