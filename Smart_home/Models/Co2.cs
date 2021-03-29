using Smart_home.Service;
using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Smart_home.Models;
using System.Threading.Tasks;

namespace Smart_home.Models
{
    public class Co2
    {
        public int Id { get; set; }
        public string Cas { get; set; }
        public string Eco2 { get; set; }
        public string Etvoc { get; set; }
        public string Raw6 { get; set; }
        public string Raw10 { get; set; }
        public string Odpor { get; set; }

        public Co2()
        {
        }

    }
}
