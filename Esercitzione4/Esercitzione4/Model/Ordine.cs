using System;
using System.Collections.Generic;
using System.Text;

namespace Esercitzione4.Model
{
   public class Ordine
    {
        public int Id { get; set; }
        public DateTime DataOrdine { get; set; }
        public string CodiceOrdine { get; set; }
        public string CodiceProdotto { get; set; }
        public decimal Importo { get; set; }
        public Cliente Cliente { get; set; }
    }
}
