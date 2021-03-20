using Smart_home.Data;
using Smart_home.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Smart_home.Service;

namespace Smart_home.Service
{
    public class DbService : IDbService
    {
        private readonly Smart_homeContext _context;

        public DbService(Smart_homeContext context)
        {
            _context = context;
        }
        public async Task<bool> ulozDoDBAsync(Teploty teploty)
        {
            try { 
            _context.Teploty.Add(teploty);
            await _context.SaveChangesAsync();
            return true;
            }
            catch
            {
                return false;
            }
        }
        public Teploty nactiZDbAsync()
        {
            try
            {
                Teploty teploty = _context.Teploty
                .LastOrDefault();
                return teploty;
            }
            catch
            {
                Teploty teploty;
                teploty = null;
                return teploty;
            }
        }
        public Termostat nactiTermostat()
        {
            Termostat termostat = _context.Termostat
                .FirstOrDefault();
            return termostat;
        }
        public async Task<bool> ulozCo2DoDBAsync(Co2 co2)
        {
            try
            {
                _context.Co2.Add(co2);
                await _context.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
