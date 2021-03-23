using Smart_home.Service;
using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Smart_home.Models;
using System.Threading.Tasks;

namespace Smart_home.Models
{
    public class Termostat
    {
        public int Id { get; set; }
        public int IdTeplomeru { get; set; }
        public string Mistnost { get; set; }
        public string Umisteni { get; set; }
        [Display(Name = "teplota")] 
        public int ZadanaTeplota { get; set; }
        public int NastavenaTeplota { get; set; } 
        public string PosledniTeplota { get; set; }
        public int NovaTeplota { get; set; }
        public DateTime Date { get; set; }
        public string Teplot { get; set; }

        public Termostat()
        {
            NastavenaTeplota = 22;
        }

    }
}
