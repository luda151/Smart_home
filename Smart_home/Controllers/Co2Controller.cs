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
    public class Co2Controller : Controller
    {
        private readonly Smart_homeContext _context;

        public Co2Controller(Smart_homeContext context)
        {
            _context = context;
        }

        // GET: Co2
        public async Task<IActionResult> Index()
        {
            return View(await _context.Co2
                .OrderByDescending(c => c.Id)
                .Take(10)
                .ToListAsync()
                );
        }

        // GET: Co2/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var co2 = await _context.Co2
                .FirstOrDefaultAsync(m => m.Id == id);
            if (co2 == null)
            {
                return NotFound();
            }

            return View(co2);
        }

        // GET: Co2/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Co2/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Cas,Eco2,Etvoc,Raw6,Raw10,Odpor")] Co2 co2)
        {
            if (ModelState.IsValid)
            {
                _context.Add(co2);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(co2);
        }

        // GET: Co2/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var co2 = await _context.Co2.FindAsync(id);
            if (co2 == null)
            {
                return NotFound();
            }
            return View(co2);
        }

        // POST: Co2/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Cas,Eco2,Etvoc,Raw6,Raw10,Odpor")] Co2 co2)
        {
            if (id != co2.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(co2);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Co2Exists(co2.Id))
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
            return View(co2);
        }

        // GET: Co2/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var co2 = await _context.Co2
                .FirstOrDefaultAsync(m => m.Id == id);
            if (co2 == null)
            {
                return NotFound();
            }

            return View(co2);
        }

        // POST: Co2/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var co2 = await _context.Co2.FindAsync(id);
            _context.Co2.Remove(co2);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Co2Exists(int id)
        {
            return _context.Co2.Any(e => e.Id == id);
        }
    }
}
