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
    public class PaymentsController : Controller
    {
        private readonly FMSExpContext _context;

        public PaymentsController(FMSExpContext context)
        {
            _context = context;
        }

        // GET: Payments
        public async Task<IActionResult> Index()
        {
            var fMSExpContext = _context.TblPayment.Include(t => t.PartyNameNavigation);
            return View(await fMSExpContext.ToListAsync());
        }

        // GET: Payments/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tblPayment = await _context.TblPayment
                .Include(t => t.PartyNameNavigation)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tblPayment == null)
            {
                return NotFound();
            }

            return View(tblPayment);
        }

        // GET: Payments/Create
        public IActionResult Create()
        {
            ViewData["PartyName"] = new SelectList(_context.TblVendor, "Id", "Id");
            return View();
        }

        // POST: Payments/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("AutoId,Id,PaymentDate,PartyName,Amount,PaymentMode,Remark,CreatedDatetime")] TblPayment tblPayment)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tblPayment);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["PartyName"] = new SelectList(_context.TblVendor, "Id", "Id", tblPayment.PartyName);
            return View(tblPayment);
        }

        // GET: Payments/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tblPayment = await _context.TblPayment.FindAsync(id);
            if (tblPayment == null)
            {
                return NotFound();
            }
            ViewData["PartyName"] = new SelectList(_context.TblVendor, "Id", "Id", tblPayment.PartyName);
            return View(tblPayment);
        }

        // POST: Payments/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("AutoId,Id,PaymentDate,PartyName,Amount,PaymentMode,Remark,CreatedDatetime")] TblPayment tblPayment)
        {
            if (id != tblPayment.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tblPayment);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TblPaymentExists(tblPayment.Id))
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
            ViewData["PartyName"] = new SelectList(_context.TblVendor, "Id", "Id", tblPayment.PartyName);
            return View(tblPayment);
        }

        // GET: Payments/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tblPayment = await _context.TblPayment
                .Include(t => t.PartyNameNavigation)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tblPayment == null)
            {
                return NotFound();
            }

            return View(tblPayment);
        }

        // POST: Payments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var tblPayment = await _context.TblPayment.FindAsync(id);
            _context.TblPayment.Remove(tblPayment);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TblPaymentExists(string id)
        {
            return _context.TblPayment.Any(e => e.Id == id);
        }
    }
}
