
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnTab = new System.Windows.Forms.Panel();
            this.closableTabBtn2 = new AppTesteControlLibrary.ClosableTabBtn();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.closableTabBtn1 = new AppTesteControlLibrary.ClosableTabBtn();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.pnLeft.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.pnTab.SuspendLayout();
            this.closableTabBtn2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.closableTabBtn1.SuspendLayout();
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
            this.pnLeft.Size = new System.Drawing.Size(177, 607);
            this.pnLeft.TabIndex = 5;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.bNovaAba);
            this.flowLayoutPanel1.Controls.Add(this.bProduto);
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(15, 5, 15, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(167, 607);
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(18, 66);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(167, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 607);
            this.panel3.TabIndex = 8;
            // 
            // pnTab
            // 
            this.pnTab.Controls.Add(this.closableTabBtn2);
            this.pnTab.Controls.Add(this.splitter1);
            this.pnTab.Controls.Add(this.panel1);
            this.pnTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnTab.Location = new System.Drawing.Point(177, 0);
            this.pnTab.Name = "pnTab";
            this.pnTab.Size = new System.Drawing.Size(705, 607);
            this.pnTab.TabIndex = 6;
            // 
            // closableTabBtn2
            // 
            this.closableTabBtn2.AllowDrop = true;
            this.closableTabBtn2.Controls.Add(this.tabPage1);
            this.closableTabBtn2.Controls.Add(this.tabPage2);
            this.closableTabBtn2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.closableTabBtn2.Location = new System.Drawing.Point(0, 0);
            this.closableTabBtn2.Name = "closableTabBtn2";
            this.closableTabBtn2.Padding = new System.Drawing.Point(12, 4);
            this.closableTabBtn2.SelectedIndex = 0;
            this.closableTabBtn2.Size = new System.Drawing.Size(705, 349);
            this.closableTabBtn2.TabIndex = 8;
            this.closableTabBtn2.TabPageImage = null;
            this.closableTabBtn2.AfterCloseClick += new System.EventHandler(this.closableTabBtn2_AfterCloseClick);
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(697, 319);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "teste                                ";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(697, 319);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter1.Location = new System.Drawing.Point(0, 349);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(705, 10);
            this.splitter1.TabIndex = 7;
            this.splitter1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.closableTabBtn1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 359);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(705, 248);
            this.panel1.TabIndex = 6;
            // 
            // closableTabBtn1
            // 
            this.closableTabBtn1.AllowDrop = true;
            this.closableTabBtn1.Controls.Add(this.tabPage4);
            this.closableTabBtn1.Controls.Add(this.tabPage8);
            this.closableTabBtn1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.closableTabBtn1.Location = new System.Drawing.Point(0, 0);
            this.closableTabBtn1.Name = "closableTabBtn1";
            this.closableTabBtn1.Padding = new System.Drawing.Point(12, 4);
            this.closableTabBtn1.SelectedIndex = 0;
            this.closableTabBtn1.Size = new System.Drawing.Size(705, 248);
            this.closableTabBtn1.TabIndex = 0;
            this.closableTabBtn1.TabPageImage = null;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 26);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(697, 218);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "tab 4        ";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage8
            // 
            this.tabPage8.Location = new System.Drawing.Point(4, 26);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Size = new System.Drawing.Size(697, 218);
            this.tabPage8.TabIndex = 2;
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 607);
            this.Controls.Add(this.pnTab);
            this.Controls.Add(this.pnLeft);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pnLeft.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.pnTab.ResumeLayout(false);
            this.closableTabBtn2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.closableTabBtn1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnLeft;
        private System.Windows.Forms.Panel pnTab;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button bNovaAba;
        private System.Windows.Forms.Button bProduto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel panel1;
        private AppTesteControlLibrary.ClosableTabBtn closableTabBtn1;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage8;
        private AppTesteControlLibrary.ClosableTabBtn closableTabBtn2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
    }
}

