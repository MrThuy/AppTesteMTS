using AppTesteMTS.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppTesteMTS.View
{
    public partial class ViewProduto : Form
    {
        private Produto _ProdutoModel;

        public ViewProduto()
        {
            InitializeComponent();

            this.SetStyle(ControlStyles.ResizeRedraw, true); // this is to avoid visual artifacts

            CreateModels();
        }

        private void CreateModels()
        {
            _ProdutoModel = new Produto();
        }

        private void Reload()
        {
            _ProdutoModel.ProdutoId = int.TryParse(edtProdutoId.Text, out _) ? Convert.ToInt32(edtProdutoId.Text) : 0;
            _ProdutoModel.Descricao = edtDescricao.Text;
            string _Preco = edtPreco.Text.Replace(CultureInfo.CurrentCulture.NumberFormat.CurrencySymbol, "");
            _ProdutoModel.Preco = double.TryParse(_Preco, out _) ? Convert.ToDouble(_Preco) : 0;
        }
        private void RefreshView()
        {
            edtProdutoId.Text = _ProdutoModel.ProdutoId.ToString();
            edtDescricao.Text = _ProdutoModel.Descricao;
            edtPreco.Text = _ProdutoModel.Preco.ToString("C2", CultureInfo.CurrentCulture);
        }

        private void Clean()
        {
            CreateModels();
            RefreshView();
            edtProdutoId.Focus();
        }

        private void LoadFields()
        {
            Reload();
            try
            {
                if (edtProdutoId.Text.Equals("")) return;

                _ProdutoModel = UtilAPI.Get<Produto>(_ProdutoModel, _ProdutoModel.ProdutoId.ToString());

                if (_ProdutoModel.Options.Status == StatusRecord.Inserting)
                {
                    CreateModels();
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
                Clean();
            }
            finally
            {
                RefreshView();
            }
        }

        private async void bSalvar_ClickAsync(object sender, EventArgs e)
        {
            try
            {
                Produto _produto = new Produto
                {
                    ProdutoId = edtProdutoId.Text.Equals("") ? 0 : Convert.ToInt32(edtProdutoId.Text),
                    Descricao = edtDescricao.Text,
                    Preco = Convert.ToDouble(edtPreco.Text)
                };

                if (_produto.ProdutoId == 0)
                {
                    //var url = await UtilAPI.CreateAsync<Produto>(_produto, "Produto");
                    //_produto = await UtilAPI.GetAsync(_produto, url.PathAndQuery);
                    edtProdutoId.Text = _produto.ProdutoId.ToString();
                }
                else
                    await UtilAPI.UpdateAsync<Produto>(_produto, $"Produto\\{_produto.ProdutoId}");

                MessageBox.Show("Salvo com sucesso!");
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private async void ProdutoId_Leave(object sender, EventArgs e)
        {
            LoadFields();

            /*if (!edtProdutoId.Text.Equals(""))
            {
                try
                {
                    Produto _produto = new Produto
                    {
                        ProdutoId = Convert.ToInt32(edtProdutoId.Text)
                    };

                    _produto = await UtilAPI.GetAsync(_produto, $"/api/Produto/{_produto.ProdutoId}");

                    edtProdutoId.Text = _produto.ProdutoId.ToString();
                    edtDescricao.Text = _produto.Descricao;
                    edtPreco.Text = _produto.Preco.ToString("c2");

                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                    bCancelar.PerformClick();
                }
            }*/
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            edtProdutoId.Clear();
            edtDescricao.Clear();
            edtPreco.Clear();

            edtProdutoId.Focus();
        }

        private async void bExcluir_Click(object sender, EventArgs e)
        {
            Produto _produto = new Produto
            {
                ProdutoId = Convert.ToInt32(edtProdutoId.Text)
            };

            //var statusCode = await UtilAPI.DeleteAsync(_produto.ProdutoId, "Produto");
            MessageBox.Show($"Registro excluído!");

            bCancelar.PerformClick();
        }
    }
}
