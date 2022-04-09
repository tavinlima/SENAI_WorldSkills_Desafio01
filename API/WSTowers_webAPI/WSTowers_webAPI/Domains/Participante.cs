using System;
using System.Collections.Generic;

#nullable disable

namespace WSTowers_webAPI.Domains
{
    public partial class Participante
    {
        public Participante()
        {
            Venda = new HashSet<Venda>();
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public int? Idade { get; set; }
        public int? Cidade { get; set; }
        public string Genero { get; set; }

        public virtual Cidade CidadeNavigation { get; set; }
        public virtual ICollection<Venda> Venda { get; set; }
    }
}
