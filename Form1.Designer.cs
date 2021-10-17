
namespace AppTesteMTS
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnLeft = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.bNovaAba = new System.Windows.Forms.Button();
            this.bProduto = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnTab = new System.Windows.Forms.Panel();
            this.ClosableTabC = new AppTesteControlLibrary.ClosableTabControl();
            this.abaPrincipal = new System.Windows.Forms.TabPage();
            this.abaAdd = new System.Windows.Forms.TabPage();
            this.pnLeft.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.pnTab.SuspendLayout();
            this.ClosableTabC.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnLeft
            // 
            this.pnLeft.BackColor = System.Drawing.SystemColors.Control;
            this.pnLeft.Controls.Add(this.flowLayoutPanel1);
            this.pnLeft.Controls.Add(this.panel3);
            this.pnLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnLeft.Location = new System.Drawing.Point(0, 0);
            this.pnLeft.Name = "pnLeft";
            this.pnLeft.Size = new System.Drawing.Size(120, 667);
            this.pnLeft.TabIndex = 5;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.bNovaAba);
            this.flowLayoutPanel1.Controls.Add(this.bProduto);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(15, 5, 15, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(110, 667);
            this.flowLayoutPanel1.TabIndex = 10;
            // 
            // bNovaAba
            // 
            this.bNovaAba.Location = new System.Drawing.Point(18, 8);
            this.bNovaAba.Name = "bNovaAba";
            this.bNovaAba.Size = new System.Drawing.Size(75, 23);
            this.bNovaAba.TabIndex = 1;
            this.bNovaAba.Text = "Nova Aba";
            this.bNovaAba.UseVisualStyleBackColor = true;
            this.bNovaAba.Click += new System.EventHandler(this.bNovaAba_Click);
            // 
            // bProduto
            // 
            this.bProduto.Location = new System.Drawing.Point(18, 37);
            this.bProduto.Name = "bProduto";
            this.bProduto.Size = new System.Drawing.Size(75, 23);
            this.bProduto.TabIndex = 0;
            this.bProduto.Text = "Produto";
            this.bProduto.UseVisualStyleBackColor = true;
            this.bProduto.Click += new System.EventHandler(this.bProduto_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(110, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 667);
            this.panel3.TabIndex = 8;
            // 
            // pnTab
            // 
            this.pnTab.Controls.Add(this.ClosableTabC);
            this.pnTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnTab.Location = new System.Drawing.Point(120, 0);
            this.pnTab.Name = "pnTab";
            this.pnTab.Size = new System.Drawing.Size(739, 667);
            this.pnTab.TabIndex = 6;
            // 
            // ClosableTabC
            // 
            this.ClosableTabC.Controls.Add(this.abaPrincipal);
            this.ClosableTabC.Controls.Add(this.abaAdd);
            this.ClosableTabC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ClosableTabC.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.ClosableTabC.Location = new System.Drawing.Point(0, 0);
            this.ClosableTabC.Name = "ClosableTabC";
            this.ClosableTabC.Padding = new System.Drawing.Point(11, 3);
            this.ClosableTabC.SelectedIndex = 0;
            this.ClosableTabC.Size = new System.Drawing.Size(739, 667);
            this.ClosableTabC.TabIndex = 5;
            // 
            // abaPrincipal
            // 
            this.abaPrincipal.Location = new System.Drawing.Point(4, 24);
            this.abaPrincipal.Name = "abaPrincipal";
            this.abaPrincipal.Padding = new System.Windows.Forms.Padding(3);
            this.abaPrincipal.Size = new System.Drawing.Size(731, 639);
            this.abaPrincipal.TabIndex = 0;
            this.abaPrincipal.Text = "Escolha uma tela";
            this.abaPrincipal.UseVisualStyleBackColor = true;
            // 
            // abaAdd
            // 
            this.abaAdd.Location = new System.Drawing.Point(4, 24);
            this.abaAdd.Name = "abaAdd";
            this.abaAdd.Padding = new System.Windows.Forms.Padding(3);
            this.abaAdd.Size = new System.Drawing.Size(731, 639);
            this.abaAdd.TabIndex = 1;
            this.abaAdd.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 667);
            this.Controls.Add(this.pnTab);
            this.Controls.Add(this.pnLeft);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pnLeft.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.pnTab.ResumeLayout(false);
            this.ClosableTabC.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnLeft;
        private System.Windows.Forms.Panel pnTab;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button bNovaAba;
        private System.Windows.Forms.Button bProduto;
        private AppTesteControlLibrary.ClosableTabControl ClosableTabC;
        private System.Windows.Forms.TabPage abaPrincipal;
        private System.Windows.Forms.TabPage abaAdd;
    }
}

