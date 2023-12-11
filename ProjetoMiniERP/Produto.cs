using System;
using System.Collections.Generic;

namespace ProjetoMiniERP
{
    public partial class Produto
    {
        public Produto()
        {
            Nota = new HashSet<Nota>();
        }

        public int Id { get; set; }
        public string? Nome { get; set; }
        public int? Preco { get; set; }
        public int? FkFornecedores { get; set; }

        public virtual Fornecedore? FkFornecedoresNavigation { get; set; }
        public virtual ICollection<Nota> Nota { get; set; }
    }
}
