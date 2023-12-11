using System;
using System.Collections.Generic;

namespace ProjetoMiniERP
{
    public partial class Nota
    {
        public int Id { get; set; }

        public int? preco {  get; set; }
        public string? Nome_Cliente { get; set; }
        public string? Nome_Produto { get; set; }
        public int? FkProdutos { get; set; }
        public int? FkClientes { get; set; }

        public virtual Cliente? FkClientesNavigation { get; set; }
        public virtual Produto? FkProdutosNavigation { get; set; }

    }
}
