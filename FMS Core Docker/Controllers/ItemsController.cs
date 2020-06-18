using FMS_Core.Helper;
using FMS_Core.Models.EFModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace FMS_Core.Controllers
{
    public class ItemsController : BaseController
    {
        private readonly FMSExpContext _context;

        public ItemsController(FMSExpContext context)
        {
            _context = context;
        }

        // GET: Item
        public async Task<IActionResult> Index()
        {
            var fMSExpContext = _context.TblItems.Include(t => t.GstNavigation).Include(t => t.MeasuringUnitNavigation)
                .Include(t => t.SupplierNavigation).Include(t => t.TypeNavigation)
                .OrderByDescending(q => q.Id); ;
            return View(await fMSExpContext.ToListAsync());
        }

        // GET: Item/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null) return NotFound();

            var tblItems = await _context.TblItems
                .Include(t => t.GstNavigation)
                .Include(t => t.MeasuringUnitNavigation)
                .Include(t => t.SupplierNavigation)
                .Include(t => t.TypeNavigation)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tblItems == null) return NotFound();

            InitializePageHeader(HeaderTitle.Details, id);
            return View(tblItems);
        }

        public void InitializePageHeader(string headerTitle, string ID)
        {
            ViewData["HeaderTitle"] = headerTitle;
            ViewData["Name"] = PageName.Items;
            ViewData["Id"] = ID;
            ViewData["CreatedDatetime"] = DateTime.Now;
        }

        // GET: Item/Create
        public IActionResult Create()
        {
            ViewData["Gst"] = new SelectList(_context.TblGst, "Id", "Name");
            ViewData["MeasuringUnit"] = new SelectList(_context.TblItemUnits, "MeasurintUnitId", "MeasuringUnits");
            ViewData["Supplier"] = new SelectList(_context.TblVendor, "Id", "Name");
            ViewData["Type"] = new SelectList(_context.TblItemType, "ItemTypeId", "ItemType");

            InitializePageHeader(HeaderTitle.Add, PageName.Items, GenericHelper.GetMaxValue(SequenceTable.tbl_Items));
            return View();
        }

        // POST: Item/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(
            [Bind(
                "Id,Name,HsnSacNo,Type,MeasuringUnit,Manufacture,BarCode,ItemUniqueDescription,Supplier,Photo,UseBatchNo,UseMfgDate,UseExpiryDate,CreatedDatetime,Gst")]
            TblItems items, [Bind("OpeningStock")] int? openingStock)
        {
            if (ModelState.IsValid)
            {
                var saved = false;
                using (var transaction = _context.Database.BeginTransaction())
                {
                    try
                    {

                        _context.Add(items);
                        //await _context.SaveChangesAsync();


                        _context.UpdateNextSequence(SequenceTable.tbl_Items);
                        //TblSequence NewSequenceValue = Helper.GenericHelper.GetNextUpdatedData("tbl_Items");
                        //_context.Entry(NewSequenceValue).State = EntityState.Modified;
                        //await _context.SaveChangesAsync();

                        if (openingStock > 0)
                        {
                            TblItemStock tbl_ItemStock = new TblItemStock()
                            {

                                Id = items.Id + "-" + Helper.GenericHelper.GetMaxValue("tbl_ItemStock") + "-1",
                                StockType = "IN",
                                InvoiceNo = "Opening Stock",
                                ItemId = items.Id,
                                Qty = openingStock,
                                CreatedDatetime = items.CreatedDatetime.ToString() ??
                                                  DateTime.Now.Date.ToString(CultureInfo.InvariantCulture)

                            };
                            _context.TblItemStock.Add(tbl_ItemStock);
                            //await _context.SaveChangesAsync();
                            _context.UpdateNextSequence(SequenceTable.tbl_ItemStock);
                        }


                        await _context.SaveChangesAsync();
                        saved = true;
                    }
                    catch (Exception e)
                    {
                        throw new InvalidOperationException(e.Message);
                    }
                    finally
                    {
                        if (saved) transaction.Commit();
                    }
                }

                return RedirectToAction(nameof(Index));
            }

            ViewData["Gst"] = new SelectList(_context.TblGst, "Id", "Name", items.Gst);
            ViewData["MeasuringUnit"] = new SelectList(_context.TblItemUnits, "MeasurintUnitId", "MeasuringUnits",
                items.MeasuringUnit);
            ViewData["Supplier"] = new SelectList(_context.TblVendor, "Id", "Name", items.Supplier);
            ViewData["Type"] = new SelectList(_context.TblItemType, "ItemTypeId", "ItemType", items.Type);
            return View(items);
        }

        // GET: Item/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null) return NotFound();

            var tblItems = await _context.TblItems.FindAsync(id);
            if (tblItems == null) return NotFound();
            ViewData["Gst"] = new SelectList(_context.TblGst, "Id", "Name", tblItems.Gst);
            ViewData["MeasuringUnit"] = new SelectList(_context.TblItemUnits, "MeasurintUnitId", "MeasuringUnits",
                tblItems.MeasuringUnit);
            ViewData["Supplier"] = new SelectList(_context.TblVendor, "Id", "Name", tblItems.Supplier);
            ViewData["Type"] = new SelectList(_context.TblItemType, "ItemTypeId", "ItemType", tblItems.Type);

            InitializePageHeader(HeaderTitle.Edit, id);

            return View(tblItems);
        }

        // POST: Item/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id,
            [Bind(
                "Id,Name,HsnSacNo,Type,MeasuringUnit,Manufacture,BarCode,ItemUniqueDescription,Supplier,Photo,UseBatchNo,UseMfgDate,UseExpiryDate,CreatedDatetime,Gst")]
            TblItems tblItems)
        {
            if (id != tblItems.Id) return NotFound();

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tblItems);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TblItemsExists(tblItems.Id))
                        return NotFound();
                    throw;
                }

                return RedirectToAction(nameof(Index));
            }

            ViewData["Gst"] = new SelectList(_context.TblGst, "Id", "Name", tblItems.Gst);
            ViewData["MeasuringUnit"] = new SelectList(_context.TblItemUnits, "MeasurintUnitId", "MeasuringUnits",
                tblItems.MeasuringUnit);
            ViewData["Supplier"] = new SelectList(_context.TblVendor, "Id", "Name", tblItems.Supplier);
            ViewData["Type"] = new SelectList(_context.TblItemType, "ItemTypeId", "ItemType", tblItems.Type);
            return View(tblItems);
        }

        // GET: Item/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null) return NotFound();

            var tblItems = await _context.TblItems
                .Include(t => t.GstNavigation)
                .Include(t => t.MeasuringUnitNavigation)
                .Include(t => t.SupplierNavigation)
                .Include(t => t.TypeNavigation)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tblItems == null) return NotFound();
            InitializePageHeader(HeaderTitle.Delete, id);
            return View(tblItems);
        }

        // POST: Item/Delete/5
        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var tblItems = await _context.TblItems.FindAsync(id);
            _context.TblItems.Remove(tblItems);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TblItemsExists(string id)
        {
            return _context.TblItems.Any(e => e.Id == id);
        }
    }
}