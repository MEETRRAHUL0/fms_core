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
    public class TransactionsController : Controller
    {
        private readonly FMSExpContext _context;

        public TransactionsController(FMSExpContext context)
        {
            _context = context;
        }

        // GET: Transactions
        public async Task<IActionResult> Index()
        {
            var fMSExpContext = _context.TblTransaction.Include(t => t.Payment).Include(t => t.Purchase).Include(t => t.Sales).Include(t => t.Vendor);
            return View(await fMSExpContext.ToListAsync());
        }

        // GET: Transactions/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tblTransaction = await _context.TblTransaction
                .Include(t => t.Payment)
                .Include(t => t.Purchase)
                .Include(t => t.Sales)
                .Include(t => t.Vendor)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tblTransaction == null)
            {
                return NotFound();
            }

            return View(tblTransaction);
        }

        // GET: Transactions/Create
        public IActionResult Create()
        {
            ViewData["PaymentId"] = new SelectList(_context.TblPayment, "Id", "Id");
            ViewData["PurchaseId"] = new SelectList(_context.TblPurchase, "Id", "Id");
            ViewData["SalesId"] = new SelectList(_context.TblSale, "SaleId", "SaleId");
            ViewData["VendorId"] = new SelectList(_context.TblVendor, "Id", "Id");
            return View();
        }

        // POST: Transactions/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("AutoId,Id,VendorId,PurchaseId,SalesId,EntryId,EntryDate,EntryType,Amount,Status,CreatedDatetime,TransactionType,TransactionRef,PaymentId")] TblTransaction tblTransaction)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tblTransaction);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["PaymentId"] = new SelectList(_context.TblPayment, "Id", "Id", tblTransaction.PaymentId);
            ViewData["PurchaseId"] = new SelectList(_context.TblPurchase, "Id", "Id", tblTransaction.PurchaseId);
            ViewData["SalesId"] = new SelectList(_context.TblSale, "SaleId", "SaleId", tblTransaction.SalesId);
            ViewData["VendorId"] = new SelectList(_context.TblVendor, "Id", "Id", tblTransaction.VendorId);
            return View(tblTransaction);
        }

        // GET: Transactions/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tblTransaction = await _context.TblTransaction.FindAsync(id);
            if (tblTransaction == null)
            {
                return NotFound();
            }
            ViewData["PaymentId"] = new SelectList(_context.TblPayment, "Id", "Id", tblTransaction.PaymentId);
            ViewData["PurchaseId"] = new SelectList(_context.TblPurchase, "Id", "Id", tblTransaction.PurchaseId);
            ViewData["SalesId"] = new SelectList(_context.TblSale, "SaleId", "SaleId", tblTransaction.SalesId);
            ViewData["VendorId"] = new SelectList(_context.TblVendor, "Id", "Id", tblTransaction.VendorId);
            return View(tblTransaction);
        }

        // POST: Transactions/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("AutoId,Id,VendorId,PurchaseId,SalesId,EntryId,EntryDate,EntryType,Amount,Status,CreatedDatetime,TransactionType,TransactionRef,PaymentId")] TblTransaction tblTransaction)
        {
            if (id != tblTransaction.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tblTransaction);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TblTransactionExists(tblTransaction.Id))
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
            ViewData["PaymentId"] = new SelectList(_context.TblPayment, "Id", "Id", tblTransaction.PaymentId);
            ViewData["PurchaseId"] = new SelectList(_context.TblPurchase, "Id", "Id", tblTransaction.PurchaseId);
            ViewData["SalesId"] = new SelectList(_context.TblSale, "SaleId", "SaleId", tblTransaction.SalesId);
            ViewData["VendorId"] = new SelectList(_context.TblVendor, "Id", "Id", tblTransaction.VendorId);
            return View(tblTransaction);
        }

        // GET: Transactions/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tblTransaction = await _context.TblTransaction
                .Include(t => t.Payment)
                .Include(t => t.Purchase)
                .Include(t => t.Sales)
                .Include(t => t.Vendor)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tblTransaction == null)
            {
                return NotFound();
            }

            return View(tblTransaction);
        }

        // POST: Transactions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var tblTransaction = await _context.TblTransaction.FindAsync(id);
            _context.TblTransaction.Remove(tblTransaction);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TblTransactionExists(string id)
        {
            return _context.TblTransaction.Any(e => e.Id == id);
        }
    }
}
