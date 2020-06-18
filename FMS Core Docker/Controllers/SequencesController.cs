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
    public class SequencesController : Controller
    {
        private readonly FMSExpContext _context;

        public SequencesController(FMSExpContext context)
        {
            _context = context;
        }

        // GET: Sequences
        public async Task<IActionResult> Index()
        {
            return View(await _context.TblSequence.ToListAsync());
        }

        // GET: Sequences/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tblSequence = await _context.TblSequence
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tblSequence == null)
            {
                return NotFound();
            }

            return View(tblSequence);
        }

        // GET: Sequences/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Sequences/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,TableName,PreFix,RecordCount")] TblSequence tblSequence)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tblSequence);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tblSequence);
        }

        // GET: Sequences/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tblSequence = await _context.TblSequence.FindAsync(id);
            if (tblSequence == null)
            {
                return NotFound();
            }
            return View(tblSequence);
        }

        // POST: Sequences/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,TableName,PreFix,RecordCount")] TblSequence tblSequence)
        {
            if (id != tblSequence.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tblSequence);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TblSequenceExists(tblSequence.Id))
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
            return View(tblSequence);
        }

        // GET: Sequences/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tblSequence = await _context.TblSequence
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tblSequence == null)
            {
                return NotFound();
            }

            return View(tblSequence);
        }

        // POST: Sequences/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tblSequence = await _context.TblSequence.FindAsync(id);
            _context.TblSequence.Remove(tblSequence);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TblSequenceExists(int id)
        {
            return _context.TblSequence.Any(e => e.Id == id);
        }
    }
}
