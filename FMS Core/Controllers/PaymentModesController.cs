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
    public class PaymentModesController : Controller
    {
        private readonly FMSExpContext _context;

        public PaymentModesController(FMSExpContext context)
        {
            _context = context;
        }

        // GET: PaymentModes
        public async Task<IActionResult> Index()
        {
            return View(await _context.TblPaymentMode.ToListAsync());
        }

        // GET: PaymentModes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tblPaymentMode = await _context.TblPaymentMode
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tblPaymentMode == null)
            {
                return NotFound();
            }

            return View(tblPaymentMode);
        }

        // GET: PaymentModes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PaymentModes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Mode,Type,IsVisible")] TblPaymentMode tblPaymentMode)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tblPaymentMode);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tblPaymentMode);
        }

        // GET: PaymentModes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tblPaymentMode = await _context.TblPaymentMode.FindAsync(id);
            if (tblPaymentMode == null)
            {
                return NotFound();
            }
            return View(tblPaymentMode);
        }

        // POST: PaymentModes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Mode,Type,IsVisible")] TblPaymentMode tblPaymentMode)
        {
            if (id != tblPaymentMode.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tblPaymentMode);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TblPaymentModeExists(tblPaymentMode.Id))
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
            return View(tblPaymentMode);
        }

        // GET: PaymentModes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tblPaymentMode = await _context.TblPaymentMode
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tblPaymentMode == null)
            {
                return NotFound();
            }

            return View(tblPaymentMode);
        }

        // POST: PaymentModes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tblPaymentMode = await _context.TblPaymentMode.FindAsync(id);
            _context.TblPaymentMode.Remove(tblPaymentMode);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TblPaymentModeExists(int id)
        {
            return _context.TblPaymentMode.Any(e => e.Id == id);
        }
    }
}
