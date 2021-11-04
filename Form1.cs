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
        private Point _mouse;

        public Form1()
        {
            InitializeComponent();
            label2.Text = "";

            UtilAPI.ConfigureClient(ConfigurationManager.AppSettings["URLAPIMetasis"]);
        }

        private void bProduto_Click(object sender, EventArgs e)
        {
            //OpenFormInPage(new ViewProduto(), ClosableTabC.TabPages[ClosableTabC.SelectedIndex]);
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
            //ClosableTabC.NewPage(this);
        }

        private void ClosableTabC_MouseHover(object sender, EventArgs e)
        {
            label1.Text = $"{DateTime.Now.ToString("ss.fff")} MouseHover {_mouse}";            
        }

        private void ClosableTabC_MouseMove(object sender, MouseEventArgs e)
        {
            _mouse = e.Location;
            //label2.Text = $"{_mouse}";
        }

        private void ClosableTabC_MouseEnter(object sender, EventArgs e)
        {
            label1.Text = $"{DateTime.Now.ToString("ss.fff")} MouseEnter {_mouse}";
        }

        private void ClosableTabC_MouseLeave(object sender, EventArgs e)
        {
            //label1.Text = $"{DateTime.Now.ToString("ss.fff")} MouseLeave {_mouse}";
        }

        private void ClosableTabC_MouseDown(object sender, MouseEventArgs e)
        {

            //label2.Text = $"{label2.Text} \n {ClosableTabC.SelectedIndex} : {DateTime.Now.ToString("ss.fff")} MouseDown";
        }

        private void ClosableTabC_MouseUp(object sender, MouseEventArgs e)
        {

            //label2.Text = $"{label2.Text} \n {ClosableTabC.SelectedIndex} : {DateTime.Now.ToString("ss.fff")} MouseUp";
        }

        private void ClosableTabC_MouseClick(object sender, MouseEventArgs e)
        {
            //label2.Text = $"{label2.Text} \n {ClosableTabC.SelectedIndex} : {DateTime.Now.ToString("ss.fff")} MouseClick";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = "";
        }

        private void closableTabBtn2_AfterCloseClick(object sender, EventArgs e)
        {
            MessageBox.Show($"{closableTabBtn2.TabCount}");
        }
    }
}
