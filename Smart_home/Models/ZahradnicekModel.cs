using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Smart_home.Models
{
    public class ZahradnicekModel
    {
        public int Id { get; set; }
        public string Nazev { get; set; }
        public bool Zapnute { get; set; }
        public bool Aktivni { get; set; }
        public int ZbyvajiciCas { get; set; }
        public int DobaZapnuti { get; set; } 


    }
}
