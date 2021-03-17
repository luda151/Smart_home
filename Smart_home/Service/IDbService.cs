using Smart_home.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Smart_home.Service;

namespace Smart_home.Service
{
    public interface IDbService
    {
        Task<bool> ulozDoDBAsync(Teploty teploty);
        Teploty nactiZDbAsync();

        Termostat nactiTermostat();
    }
}
