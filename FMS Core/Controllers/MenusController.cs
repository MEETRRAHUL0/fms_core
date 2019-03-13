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
    public class MenusController : Controller
    {
        private readonly FMSExpContext _context;

        public MenusController(FMSExpContext context)
        {
            _context = context;
        }

        public IQueryable<TblMenu> GetMenus()
        {
            return _context.TblMenu;
        }
        // GET: Menus
        public async Task<IActionResult> Index()
        {
            return View(await _context.TblMenu.ToListAsync());
        }

        // GET: Menus/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tblMenu = await _context.TblMenu
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tblMenu == null)
            {
                return NotFound();
            }

            return View(tblMenu);
        }

        // GET: Menus/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Menus/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,DisplayName,Icon,Type,Ordinal,Path,ParentId,IsEnable")] TblMenu tblMenu)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tblMenu);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tblMenu);
        }

        // GET: Menus/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tblMenu = await _context.TblMenu.FindAsync(id);
            if (tblMenu == null)
            {
                return NotFound();
            }
            return View(tblMenu);
        }

        // POST: Menus/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,DisplayName,Icon,Type,Ordinal,Path,ParentId,IsEnable")] TblMenu tblMenu)
        {
            if (id != tblMenu.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tblMenu);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TblMenuExists(tblMenu.Id))
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
            return View(tblMenu);
        }

        // GET: Menus/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tblMenu = await _context.TblMenu
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tblMenu == null)
            {
                return NotFound();
            }

            return View(tblMenu);
        }

        // POST: Menus/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tblMenu = await _context.TblMenu.FindAsync(id);
            _context.TblMenu.Remove(tblMenu);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TblMenuExists(int id)
        {
            return _context.TblMenu.Any(e => e.Id == id);
        }
    }
}
