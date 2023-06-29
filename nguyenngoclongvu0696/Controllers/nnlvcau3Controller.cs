using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using nguyenngoclongvu0696.Models;

namespace nguyenngoclongvu0696.Controllers
{
    public class nnlvcau3Controller : Controller
    {
        private readonly ApplicationDbContext _context;

        public nnlvcau3Controller(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: nnlvcau3
        public async Task<IActionResult> Index()
        {
              return _context.nnlvcau3 != null ? 
                          View(await _context.nnlvcau3.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.nnlvcau3'  is null.");
        }

        // GET: nnlvcau3/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.nnlvcau3 == null)
            {
                return NotFound();
            }

            var nnlvcau3 = await _context.nnlvcau3
                .FirstOrDefaultAsync(m => m.HoTen == id);
            if (nnlvcau3 == null)
            {
                return NotFound();
            }

            return View(nnlvcau3);
        }

        // GET: nnlvcau3/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: nnlvcau3/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("HoTen,LopHoc,SoDienThoai")] nnlvcau3 nnlvcau3)
        {
            if (ModelState.IsValid)
            {
                _context.Add(nnlvcau3);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(nnlvcau3);
        }

        // GET: nnlvcau3/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.nnlvcau3 == null)
            {
                return NotFound();
            }

            var nnlvcau3 = await _context.nnlvcau3.FindAsync(id);
            if (nnlvcau3 == null)
            {
                return NotFound();
            }
            return View(nnlvcau3);
        }

        // POST: nnlvcau3/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("HoTen,LopHoc,SoDienThoai")] nnlvcau3 nnlvcau3)
        {
            if (id != nnlvcau3.HoTen)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(nnlvcau3);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!nnlvcau3Exists(nnlvcau3.HoTen))
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
            return View(nnlvcau3);
        }

        // GET: nnlvcau3/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.nnlvcau3 == null)
            {
                return NotFound();
            }

            var nnlvcau3 = await _context.nnlvcau3
                .FirstOrDefaultAsync(m => m.HoTen == id);
            if (nnlvcau3 == null)
            {
                return NotFound();
            }

            return View(nnlvcau3);
        }

        // POST: nnlvcau3/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.nnlvcau3 == null)
            {
                return Problem("Entity set 'ApplicationDbContext.nnlvcau3'  is null.");
            }
            var nnlvcau3 = await _context.nnlvcau3.FindAsync(id);
            if (nnlvcau3 != null)
            {
                _context.nnlvcau3.Remove(nnlvcau3);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool nnlvcau3Exists(string id)
        {
          return (_context.nnlvcau3?.Any(e => e.HoTen == id)).GetValueOrDefault();
        }
    }
}
