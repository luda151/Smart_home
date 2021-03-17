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
        public int PosledniTeplota { get; set; }
        public int NovaTeplota { get; set; }
        public DateTime Date { get; set; }
        public string Teplot { get; set; }

        //string url = "http://10.0.0.101/temp";
        //public void NastavTeplotu()
        //{
        //    NastavenaTeplota = ZadanaTeplota;
        //}
        //public void NactiTeplotu()
        //{
        //    Task<String> x = GetProductAsync(url);
        //    Teplot = x.Result;
        //    //Console.WriteLine(x.Result);
        //}
        //static async Task<string> GetProductAsync(string url)
        //{
        //    string product = "";
        //    HttpClient httpClient = new HttpClient();
        //    HttpResponseMessage response = await httpClient.GetAsync(url);
        //    if (response.IsSuccessStatusCode)
        //    {
        //        product = await response.Content.ReadAsStringAsync();
        //    }
        //    return product;
        //}

        private IDbService _ulozDbService;

        public Termostat(IDbService ulozDbService)
        {
            _ulozDbService = ulozDbService;
        }

        public Termostat()
        {
        }

        public int vratPosledniTeplotu(Teploty teploty)
        {
            try
            {
                PosledniTeplota = int.Parse(teploty.teplota);
            }
            catch
            {
                PosledniTeplota = 20;
            }
            
            return PosledniTeplota;
        }

        public int vratNastavenouTeplotu(Teploty teploty)
        {
            try
            {

                NastavenaTeplota = int.Parse(teploty.teplota);
            }
            catch
            {
                NastavenaTeplota = 20;
            }
            return NastavenaTeplota;
        }
    }
}
