using AppTesteMTS.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Produto : Entity
{
    public int ProdutoId { get; set; }
    public string Descricao { get; set; }
    public double Preco { get; set; }
}

