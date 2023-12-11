using System;
using System.Collections.Generic;

namespace ProjetoMiniERP
{
    public partial class Cliente
    {
        public Cliente()
        {
            Nota = new HashSet<Nota>();
        }

        public int Id { get; set; }
        public string Nome { get; set; } = null!;
        public decimal Cpf { get; set; }

        public virtual ICollection<Nota> Nota { get; set; }

    }
}
