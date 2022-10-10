using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MappingProva.Entities
{
    public class Porto
    {
        public int Id { get; set; }
        public string Descrizione { get; set; }
        public bool Annullato { get; set; }
        public Insieme IdInsieme = Insieme.Porto;
    }
}