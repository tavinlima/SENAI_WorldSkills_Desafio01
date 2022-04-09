using System;
using System.Collections.Generic;

#nullable disable

namespace WSTowers_webAPI.Domains
{
    public partial class Estoque
    {
        public int Id { get; set; }
        public int? Produto { get; set; }
        public int? Loja { get; set; }
        public int? Quantidade { get; set; }

        public virtual Produto ProdutoNavigation { get; set; }
    }
}
