using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SmartiksProje.Models
{
    public class Mapping
    {
        public int id { get; set; }
        public DateTime kazaTarihi { get; set; }
        public DateTime kazasaati { get; set; }
        public string kazaAciklama { get; set; }
        public decimal x { get; set; }
        public decimal y { get; set; }


    }
}