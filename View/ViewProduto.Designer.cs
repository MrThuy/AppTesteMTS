
namespace AppTesteMTS.View
{
    partial class ViewProduto
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
            this.lbProdutoId = new System.Windows.Forms.Label();
            this.edtProdutoId = new System.Windows.Forms.TextBox();
            this.edtDescricao = new System.Windows.Forms.TextBox();
            this.lbDescricao = new System.Windows.Forms.Label();
            this.lbPreco = new System.Windows.Forms.Label();
            this.edtPreco = new System.Windows.Forms.MaskedTextBox();
            this.bSalvar = new System.Windows.Forms.Button();
            this.bCancelar = new System.Windows.Forms.Button();
            this.bExcluir = new System.Windows.Forms.Button();
            this.GdDados = new System.Windows.Forms.DataGridView();
            this.ColCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPreco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GdDados)).BeginInit();
            this.SuspendLayout();
            // 
            // lbProdutoId
            // 
            this.lbProdutoId.AutoSize = true;
            this.lbProdutoId.Location = new System.Drawing.Point(24, 9);
            this.lbProdutoId.Name = "lbProdutoId";
            this.lbProdutoId.Size = new System.Drawing.Size(49, 15);
            this.lbProdutoId.TabIndex = 0;
            this.lbProdutoId.Text = "Código:";
            // 
            // edtProdutoId
            // 
            this.edtProdutoId.Location = new System.Drawing.Point(79, 6);
            this.edtProdutoId.Name = "edtProdutoId";
            this.edtProdutoId.Size = new System.Drawing.Size(100, 23);
            this.edtProdutoId.TabIndex = 2;
            this.edtProdutoId.Leave += new System.EventHandler(this.ProdutoId_Leave);
            // 
            // edtDescricao
            // 
            this.edtDescricao.Location = new System.Drawing.Point(79, 35);
            this.edtDescricao.Name = "edtDescricao";
            this.edtDescricao.Size = new System.Drawing.Size(371, 23);
            this.edtDescricao.TabIndex = 4;
            // 
            // lbDescricao
            // 
            this.lbDescricao.AutoSize = true;
            this.lbDescricao.Location = new System.Drawing.Point(12, 38);
            this.lbDescricao.Name = "lbDescricao";
            this.lbDescricao.Size = new System.Drawing.Size(61, 15);
            this.lbDescricao.TabIndex = 3;
            this.lbDescricao.Text = "Descrição:";
            // 
            // lbPreco
            // 
            this.lbPreco.AutoSize = true;
            this.lbPreco.Location = new System.Drawing.Point(37, 70);
            this.lbPreco.Name = "lbPreco";
            this.lbPreco.Size = new System.Drawing.Size(40, 15);
            this.lbPreco.TabIndex = 5;
            this.lbPreco.Text = "Preço:";
            // 
            // edtPreco
            // 
            this.edtPreco.Location = new System.Drawing.Point(79, 67);
            this.edtPreco.Name = "edtPreco";
            this.edtPreco.Size = new System.Drawing.Size(100, 23);
            this.edtPreco.TabIndex = 7;
            this.edtPreco.ValidatingType = typeof(int);
            // 
            // bSalvar
            // 
            this.bSalvar.Location = new System.Drawing.Point(118, 105);
            this.bSalvar.Name = "bSalvar";
            this.bSalvar.Size = new System.Drawing.Size(75, 23);
            this.bSalvar.TabIndex = 8;
            this.bSalvar.Text = "Salvar";
            this.bSalvar.UseVisualStyleBackColor = true;
            this.bSalvar.Click += new System.EventHandler(this.bSalvar_ClickAsync);
            // 
            // bCancelar
            // 
            this.bCancelar.Location = new System.Drawing.Point(12, 105);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(75, 23);
            this.bCancelar.TabIndex = 9;
            this.bCancelar.Text = "Cancelar";
            this.bCancelar.UseVisualStyleBackColor = true;
            this.bCancelar.Click += new System.EventHandler(this.bCancelar_Click);
            // 
            // bExcluir
            // 
            this.bExcluir.Location = new System.Drawing.Point(209, 5);
            this.bExcluir.Name = "bExcluir";
            this.bExcluir.Size = new System.Drawing.Size(75, 23);
            this.bExcluir.TabIndex = 10;
            this.bExcluir.Text = "Excluir";
            this.bExcluir.UseVisualStyleBackColor = true;
            this.bExcluir.Click += new System.EventHandler(this.bExcluir_Click);
            // 
            // GdDados
            // 
            this.GdDados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GdDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GdDados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColCodigo,
            this.ColDescricao,
            this.ColPreco});
            this.GdDados.Location = new System.Drawing.Point(1, 145);
            this.GdDados.Name = "GdDados";
            this.GdDados.RowTemplate.Height = 25;
            this.GdDados.Size = new System.Drawing.Size(799, 306);
            this.GdDados.TabIndex = 12;
            // 
            // ColCodigo
            // 
            this.ColCodigo.Frozen = true;
            this.ColCodigo.HeaderText = "Código";
            this.ColCodigo.Name = "ColCodigo";
            // 
            // ColDescricao
            // 
            this.ColDescricao.HeaderText = "Descrição";
            this.ColDescricao.Name = "ColDescricao";
            // 
            // ColPreco
            // 
            this.ColPreco.HeaderText = "Preço";
            this.ColPreco.Name = "ColPreco";
            // 
            // ViewProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GdDados);
            this.Controls.Add(this.bExcluir);
            this.Controls.Add(this.bCancelar);
            this.Controls.Add(this.bSalvar);
            this.Controls.Add(this.edtPreco);
            this.Controls.Add(this.lbPreco);
            this.Controls.Add(this.edtDescricao);
            this.Controls.Add(this.lbDescricao);
            this.Controls.Add(this.edtProdutoId);
            this.Controls.Add(this.lbProdutoId);
            this.Name = "ViewProduto";
            this.Text = "Produto";
            ((System.ComponentModel.ISupportInitialize)(this.GdDados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbProdutoId;
        private System.Windows.Forms.TextBox edtProdutoId;
        private System.Windows.Forms.TextBox edtDescricao;
        private System.Windows.Forms.Label lbDescricao;
        private System.Windows.Forms.Label lbPreco;
        private System.Windows.Forms.MaskedTextBox edtPreco;
        private System.Windows.Forms.Button bSalvar;
        private System.Windows.Forms.Button bCancelar;
        private System.Windows.Forms.Button bExcluir;
        private System.Windows.Forms.DataGridView GdDados;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPreco;
    }
}