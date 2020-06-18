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
    public class GstController : Controller
    {
        private readonly FMSExpContext _context;

        public GstController(FMSExpContext context)
        {
            _context = context;
        }

        // GET: Gst
        public   ViewResult Index()
        {
            var t = _context.TblGst.ToList();
            return View(t);
        }

        // GET: Gst/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tblGst = await _context.TblGst
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tblGst == null)
            {
                return NotFound();
            }

            return View(tblGst);
        }

        // GET: Gst/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Gst/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Gst,Sgst,Cgst,Igst,Comment,Name")] TblGst tblGst)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tblGst);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tblGst);
        }

        // GET: Gst/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tblGst = await _context.TblGst.FindAsync(id);
            if (tblGst == null)
            {
                return NotFound();
            }
            return View(tblGst);
        }

        // POST: Gst/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Gst,Sgst,Cgst,Igst,Comment,Name")] TblGst tblGst)
        {
            if (id != tblGst.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tblGst);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TblGstExists(tblGst.Id))
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
            return View(tblGst);
        }

        // GET: Gst/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tblGst = await _context.TblGst
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tblGst == null)
            {
                return NotFound();
            }

            return View(tblGst);
        }

        // POST: Gst/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tblGst = await _context.TblGst.FindAsync(id);
            _context.TblGst.Remove(tblGst);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TblGstExists(int id)
        {
            return _context.TblGst.Any(e => e.Id == id);
        }
    }
}
