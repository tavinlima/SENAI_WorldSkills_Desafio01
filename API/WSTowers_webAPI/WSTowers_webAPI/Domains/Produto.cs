﻿using System;
using System.Collections.Generic;

#nullable disable

namespace WSTowers_webAPI.Domains
{
    public partial class Produto
    {
        public Produto()
        {
            Estoques = new HashSet<Estoque>();
            Venda = new HashSet<Venda>();
        }

        public int Id { get; set; }
        public string Produto1 { get; set; }
        public int? Valor { get; set; }
        public int? Categoria { get; set; }

        public virtual Categorium CategoriaNavigation { get; set; }
        public virtual ICollection<Estoque> Estoques { get; set; }
        public virtual ICollection<Venda> Venda { get; set; }
    }
}
