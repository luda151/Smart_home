using Smart_home.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Smart_home.Models
{
    public class TeplotaModel
    {
        public int Id { get; set; }
        public int IdTeplomeru { get; set; }
        public string NazevTeplomeru { get; set; }
        public string MistoTeplomeru { get; set; }
        public int PosledniTeplota { get; set; }
        public DateTime DatumTeploty { get; set; }
        
    }
}

