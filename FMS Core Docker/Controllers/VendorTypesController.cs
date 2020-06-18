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
    public class VendorTypesController : Controller
    {
        private readonly FMSExpContext _context;

        public VendorTypesController(FMSExpContext context)
        {
            _context = context;
        }

        // GET: VendorTypes
        public async Task<IActionResult> Index()
        {
            return View(await _context.TblVendorType.ToListAsync());
        }

        // GET: VendorTypes/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tblVendorType = await _context.TblVendorType
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tblVendorType == null)
            {
                return NotFound();
            }

            return View(tblVendorType);
        }

        // GET: VendorTypes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: VendorTypes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name")] TblVendorType tblVendorType)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tblVendorType);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tblVendorType);
        }

        // GET: VendorTypes/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tblVendorType = await _context.TblVendorType.FindAsync(id);
            if (tblVendorType == null)
            {
                return NotFound();
            }
            return View(tblVendorType);
        }

        // POST: VendorTypes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Id,Name")] TblVendorType tblVendorType)
        {
            if (id != tblVendorType.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tblVendorType);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TblVendorTypeExists(tblVendorType.Id))
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
            return View(tblVendorType);
        }

        // GET: VendorTypes/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tblVendorType = await _context.TblVendorType
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tblVendorType == null)
            {
                return NotFound();
            }

            return View(tblVendorType);
        }

        // POST: VendorTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var tblVendorType = await _context.TblVendorType.FindAsync(id);
            _context.TblVendorType.Remove(tblVendorType);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TblVendorTypeExists(string id)
        {
            return _context.TblVendorType.Any(e => e.Id == id);
        }
    }
}
