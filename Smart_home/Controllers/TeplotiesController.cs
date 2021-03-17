using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Smart_home.Data;
using Smart_home.Models;

namespace Smart_home.Controllers
{
    public class TeplotiesController : Controller
    {
        private readonly Smart_homeContext _context;

        
        public TeplotiesController(Smart_homeContext context)
        {
            _context = context;
        }

        // GET: Teploties
        public async Task<IActionResult> Index()
        {
            return View(await _context.Teploty.ToListAsync());
        }

        // GET: Teploties/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var teploty = await _context.Teploty
                .FirstOrDefaultAsync(m => m.id == id);
            if (teploty == null)
            {
                return NotFound();
            }

            return View(teploty);
        }

        // GET: Teploties/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Teploties/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,teplota,vlhkost,cas")] Teploty teploty)
        {
            if (ModelState.IsValid)
            {
                _context.Add(teploty);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(teploty);
        }

        // GET: Teploties/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var teploty = await _context.Teploty.FindAsync(id);
            if (teploty == null)
            {
                return NotFound();
            }
            return View(teploty);
        }

        // POST: Teploties/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,teplota,vlhkost,cas")] Teploty teploty)
        {
            if (id != teploty.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(teploty);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TeplotyExists(teploty.id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(teploty);
        }

        // GET: Teploties/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var teploty = await _context.Teploty
                .FirstOrDefaultAsync(m => m.id == id);
            if (teploty == null)
            {
                return NotFound();
            }

            return View(teploty);
        }

        // POST: Teploties/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var teploty = await _context.Teploty.FindAsync(id);
            _context.Teploty.Remove(teploty);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TeplotyExists(int id)
        {
            return _context.Teploty.Any(e => e.id == id);
        }
    }
}
