using Smart_home.Data;
using Smart_home.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Smart_home.Service;

namespace Smart_home.Service
{
    public class ulozDbService : IulozDbService
    {
        private readonly Smart_homeContext _context;

        public ulozDbService(Smart_homeContext context)
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
    }
}
