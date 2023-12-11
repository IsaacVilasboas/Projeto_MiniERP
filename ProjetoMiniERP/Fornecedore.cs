using System;
using System.Collections.Generic;

namespace ProjetoMiniERP
{
    public partial class Fornecedore
    {
        public Fornecedore()
        {
            Produtos = new HashSet<Produto>();
        }

        public int Id { get; set; }
        public decimal? Cnpj { get; set; }
        public string? Nome { get; set; }

        public virtual ICollection<Produto> Produtos { get; set; }
    }
}
