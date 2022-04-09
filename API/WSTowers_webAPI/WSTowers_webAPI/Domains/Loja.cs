using System;
using System.Collections.Generic;

#nullable disable

namespace WSTowers_webAPI.Domains
{
    public partial class Loja
    {
        public Loja()
        {
            Venda = new HashSet<Venda>();
        }

        public int Id { get; set; }
        public string Loja1 { get; set; }

        public virtual ICollection<Venda> Venda { get; set; }
    }
}
