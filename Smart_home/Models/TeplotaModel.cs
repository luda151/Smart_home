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
        public string Mistnost { get; set; }
        public string Umisteni { get; set; }
        public int NastavenaTeplota{ get; set; }
        public int PosledniTeplota { get; set; }
        public int NovaTeplota { get; set; }
        public DateTime Date { get; set; }
        
    }
}



