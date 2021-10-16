using AppTesteMTS.View;
using System;
using System.Configuration;
using System.Windows.Forms;

namespace AppTesteMTS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            UtilAPI.ConfigureClient(ConfigurationManager.AppSettings["URLAPIMetasis"]);
        }

        private void bProduto_Click(object sender, EventArgs e)
        {
            OpenFormInPage(new ViewProduto(), NewPage());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFormInPage(new ViewProduto(), tabControl1.TabPages[tabControl1.SelectedIndex]);
        }

        private void OpenFormInPage(Form aForm, TabPage aPage)
        {
            //TopLevel for form is set to false
            aForm.TopLevel = false;
            aForm.Dock = DockStyle.Fill;
            aForm.FormBorderStyle = FormBorderStyle.None;                                 
            aPage.Text = aForm.Text;
            aPage.Controls.Add(aForm);
            //Added form to tabpage            
            aForm.Show();
            Refresh();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            NewPage();
        }

        private TabPage NewPage()
        {
            tabControl1.TabPages.Add("Escolha uma tela");
            tabControl1.SelectTab(tabControl1.TabPages.Count - 1);
            return tabControl1.TabPages[tabControl1.SelectedIndex];
        }
    }
}
