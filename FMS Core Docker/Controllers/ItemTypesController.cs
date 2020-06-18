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
    public class ItemTypesController : Controller
    {
        private readonly FMSExpContext _context;

        public ItemTypesController(FMSExpContext context)
        {
            _context = context;
        }

        // GET: ItemTypes
        public async Task<IActionResult> Index()
        {
            return View(await _context.TblItemType.ToListAsync());
        }

        // GET: ItemTypes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tblItemType = await _context.TblItemType
                .FirstOrDefaultAsync(m => m.ItemTypeId == id);
            if (tblItemType == null)
            {
                return NotFound();
            }

            return View(tblItemType);
        }

        // GET: ItemTypes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ItemTypes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ItemTypeId,ItemType")] TblItemType tblItemType)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tblItemType);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tblItemType);
        }

        // GET: ItemTypes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tblItemType = await _context.TblItemType.FindAsync(id);
            if (tblItemType == null)
            {
                return NotFound();
            }
            return View(tblItemType);
        }

        // POST: ItemTypes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ItemTypeId,ItemType")] TblItemType tblItemType)
        {
            if (id != tblItemType.ItemTypeId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tblItemType);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TblItemTypeExists(tblItemType.ItemTypeId))
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
            return View(tblItemType);
        }

        // GET: ItemTypes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tblItemType = await _context.TblItemType
                .FirstOrDefaultAsync(m => m.ItemTypeId == id);
            if (tblItemType == null)
            {
                return NotFound();
            }

            return View(tblItemType);
        }

        // POST: ItemTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tblItemType = await _context.TblItemType.FindAsync(id);
            _context.TblItemType.Remove(tblItemType);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TblItemTypeExists(int id)
        {
            return _context.TblItemType.Any(e => e.ItemTypeId == id);
        }
    }
}
