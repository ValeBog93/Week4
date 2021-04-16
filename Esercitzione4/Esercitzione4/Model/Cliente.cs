using System;
using System.Collections.Generic;
using System.Text;

namespace Esercitzione4.Model
{
  public  class Cliente
    {
        public int Id { get; set; }
        public string CodiceCliente { get; set; }
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public virtual ICollection<Ordine> Ordini { get; set; }

    }
}
