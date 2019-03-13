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
    public class ItemStocksController : Controller
    {
        private readonly FMSExpContext _context;

        public ItemStocksController(FMSExpContext context)
        {
            _context = context;
        }

        // GET: ItemStocks
        public async Task<IActionResult> Index()
        {
            var fMSExpContext = _context.TblItemStock.Include(t => t.Item).Include(t => t.Purchase).Include(t => t.Sale);
            return View(await fMSExpContext.ToListAsync());
        }

        // GET: ItemStocks/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tblItemStock = await _context.TblItemStock
                .Include(t => t.Item)
                .Include(t => t.Purchase)
                .Include(t => t.Sale)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tblItemStock == null)
            {
                return NotFound();
            }

            return View(tblItemStock);
        }

        // GET: ItemStocks/Create
        public IActionResult Create()
        {
            ViewData["ItemId"] = new SelectList(_context.TblItems, "Id", "Id");
            ViewData["PurchaseId"] = new SelectList(_context.TblPurchase, "Id", "Id");
            ViewData["SaleId"] = new SelectList(_context.TblSale, "SaleId", "SaleId");
            return View();
        }

        // POST: ItemStocks/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("AutoId,Id,StockType,PurchaseId,SaleId,InvoiceNo,ItemId,Qty,PricePerUnit,ItemwiseDiscount,PricePerUnitAfterDiscount,TotalPriceBeforeTax,Sgst,Cgst,Igst,Gst,TotalPriceAfterTax,Mrp,ManufactureDate,Expirydate,BatchNo,CreatedDatetime")] TblItemStock tblItemStock)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tblItemStock);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ItemId"] = new SelectList(_context.TblItems, "Id", "Id", tblItemStock.ItemId);
            ViewData["PurchaseId"] = new SelectList(_context.TblPurchase, "Id", "Id", tblItemStock.PurchaseId);
            ViewData["SaleId"] = new SelectList(_context.TblSale, "SaleId", "SaleId", tblItemStock.SaleId);
            return View(tblItemStock);
        }

        // GET: ItemStocks/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tblItemStock = await _context.TblItemStock.FindAsync(id);
            if (tblItemStock == null)
            {
                return NotFound();
            }
            ViewData["ItemId"] = new SelectList(_context.TblItems, "Id", "Id", tblItemStock.ItemId);
            ViewData["PurchaseId"] = new SelectList(_context.TblPurchase, "Id", "Id", tblItemStock.PurchaseId);
            ViewData["SaleId"] = new SelectList(_context.TblSale, "SaleId", "SaleId", tblItemStock.SaleId);
            return View(tblItemStock);
        }

        // POST: ItemStocks/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("AutoId,Id,StockType,PurchaseId,SaleId,InvoiceNo,ItemId,Qty,PricePerUnit,ItemwiseDiscount,PricePerUnitAfterDiscount,TotalPriceBeforeTax,Sgst,Cgst,Igst,Gst,TotalPriceAfterTax,Mrp,ManufactureDate,Expirydate,BatchNo,CreatedDatetime")] TblItemStock tblItemStock)
        {
            if (id != tblItemStock.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tblItemStock);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TblItemStockExists(tblItemStock.Id))
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
            ViewData["ItemId"] = new SelectList(_context.TblItems, "Id", "Id", tblItemStock.ItemId);
            ViewData["PurchaseId"] = new SelectList(_context.TblPurchase, "Id", "Id", tblItemStock.PurchaseId);
            ViewData["SaleId"] = new SelectList(_context.TblSale, "SaleId", "SaleId", tblItemStock.SaleId);
            return View(tblItemStock);
        }

        // GET: ItemStocks/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tblItemStock = await _context.TblItemStock
                .Include(t => t.Item)
                .Include(t => t.Purchase)
                .Include(t => t.Sale)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tblItemStock == null)
            {
                return NotFound();
            }

            return View(tblItemStock);
        }

        // POST: ItemStocks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var tblItemStock = await _context.TblItemStock.FindAsync(id);
            _context.TblItemStock.Remove(tblItemStock);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TblItemStockExists(string id)
        {
            return _context.TblItemStock.Any(e => e.Id == id);
        }
    }
}
