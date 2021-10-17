using AppTesteMTS.View;
using System;
using System.Configuration;
using System.Drawing;
using System.Runtime.InteropServices;
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
            OpenFormInPage(new ViewProduto(), ClosableTabC.TabPages[ClosableTabC.SelectedIndex]);
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

        //private TabPage NewPage()
        //{
        //    //ClosableTabC.TabPages.Add("Escolha uma tela");
        //    //ClosableTabC.SelectTab(ClosableTabC.TabPages.Count - 1);
        //    //return ClosableTabC.TabPages[ClosableTabC.SelectedIndex];
        //    return ClosableTabC.NewPage(this);
        //}


        private void bNovaAba_Click(object sender, EventArgs e)
        {
            ClosableTabC.NewPage(this);
        }
    }
}
