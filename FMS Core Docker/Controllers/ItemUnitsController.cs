using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FMS_Core.Models.EFModels;

namespace FMS_Core.Controllers
{
    public class ItemUnitsController : Controller
    {
        private readonly FMSExpContext _context;

        public ItemUnitsController(FMSExpContext context)
        {
            _context = context;
        }

        // GET: ItemUnits
        public async Task<IActionResult> Index()
        {
            return View(await _context.TblItemUnits.ToListAsync());
        }

        // GET: ItemUnits/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tblItemUnits = await _context.TblItemUnits
                .FirstOrDefaultAsync(m => m.MeasurintUnitId == id);
            if (tblItemUnits == null)
            {
                return NotFound();
            }

            return View(tblItemUnits);
        }

        // GET: ItemUnits/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ItemUnits/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MeasurintUnitId,MeasuringUnits")] TblItemUnits tblItemUnits)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tblItemUnits);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tblItemUnits);
        }

        // GET: ItemUnits/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tblItemUnits = await _context.TblItemUnits.FindAsync(id);
            if (tblItemUnits == null)
            {
                return NotFound();
            }
            return View(tblItemUnits);
        }

        // POST: ItemUnits/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("MeasurintUnitId,MeasuringUnits")] TblItemUnits tblItemUnits)
        {
            if (id != tblItemUnits.MeasurintUnitId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tblItemUnits);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TblItemUnitsExists(tblItemUnits.MeasurintUnitId))
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
            return View(tblItemUnits);
        }

        // GET: ItemUnits/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tblItemUnits = await _context.TblItemUnits
                .FirstOrDefaultAsync(m => m.MeasurintUnitId == id);
            if (tblItemUnits == null)
            {
                return NotFound();
            }

            return View(tblItemUnits);
        }

        // POST: ItemUnits/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tblItemUnits = await _context.TblItemUnits.FindAsync(id);
            _context.TblItemUnits.Remove(tblItemUnits);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TblItemUnitsExists(int id)
        {
            return _context.TblItemUnits.Any(e => e.MeasurintUnitId == id);
        }
    }
}
