
using FMS_Core.Helper;
using FMS_Core.Models.EFModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace FMS_Core.Controllers
{
    public class VendorsController : Controller
    {
        private readonly FMSExpContext _context;

        public VendorsController(FMSExpContext context)
        {
            _context = context;
        }

        // GET: Vendors
        public async Task<IActionResult> Index()
        {
            var fMSExpContext = _context.TblVendor.Include(t => t.TypeNavigation).OrderByDescending(q => q.Id); ;
            return View(await fMSExpContext.ToListAsync());
        }

        // GET: Vendors/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tblVendor = await _context.TblVendor
                .Include(t => t.TypeNavigation)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tblVendor == null)
            {
                return NotFound();
            }
            InilizePageHeader(HeaderTitle.Details, tblVendor.VendorType, id);
            return View(tblVendor);
        }

        // GET: Vendors/Create
        public IActionResult Create()
        {
            ViewData["Type"] = new SelectList(_context.TblVendorType, "Id", "Id");
            return View();
        }

        public void InilizePageHeader(string headerTitle, string PageName, string ID)
        {
            ViewData["HeaderTitle"] = headerTitle;
            ViewData["Name"] = PageName;
            ViewData["ID"] = ID;
            ViewData["CreatedDatetime"] = DateTime.Now;
        }




        public ActionResult CreateSupplier()
        {
            ViewData["VendorType"] = "Supplier";
            ViewData["Type"] = new SelectList(_context.TblVendorType, "Id", "Name");

            InilizePageHeader(HeaderTitle.Add, PageName.Supplier, GenericHelper.GetMaxValue(SequenceTable.tbl_Supplier));

            return View("Create");
        }

        [HttpGet]
        public ActionResult CreateCustomer()
        {
            ViewData["Type"] = new SelectList(_context.TblVendorType, "Id", "Name");

            ViewData["VendorType"] = "Customer";

            InilizePageHeader(HeaderTitle.Add, PageName.Customer, GenericHelper.GetMaxValue(SequenceTable.tbl_Customer));

            return View("Create");
        }


        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> CreateSupplier([Bind( "AutoID,ID,Name,ContactPerson,ContactNo,PhoneNo,VendorType,Type,Place,DOB,GSTNo,TINNo,PANNo,CINNo,AdhaarNo,OpeningBalance,OpeningBalanceType,OpeningBalanceDate,CreditLimit,CreditPeriod,CreditInterestRate,DebitInterestRate,CreatedDatetime,Photo,Remark,SuretyPerson,SuretyPersonContactNo,SuretyPersonAddress")]
        //    TblVendor tbl_vendor)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        var saved = false;
        //        using (var transaction = _context.Database.BeginTransaction())
        //        {
        //            try
        //            {
        //                _context.TblVendor.Add(tbl_vendor);
        //                _context.UpdateNextSequence(SequenceTable.tbl_Supplier);
        //                await _context.SaveChangesAsync();
        //                saved = true;
        //            }
        //            catch (Exception e)
        //            {
        //                throw new InvalidOperationException(e.Message);
        //            }
        //            finally
        //            {
        //                if (saved) transaction.Commit();
        //            }
        //        }
        //        return RedirectToAction("Index");
        //    }
        //    ViewBag.Type = new SelectList(_context.TblVendorType, "ID", "Name", tbl_vendor.Type);
        //    return View("Create", tbl_vendor);
        //}


        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> CreateCustomer([Bind( "AutoID,ID,Name,ContactPerson,ContactNo,PhoneNo,VendorType,Type,Place,DOB,GSTNo,TINNo,PANNo,CINNo,AdhaarNo,OpeningBalance,OpeningBalanceType,OpeningBalanceDate,CreditLimit,CreditPeriod,CreditInterestRate,DebitInterestRate,CreatedDatetime,Photo,Remark,SuretyPerson,SuretyPersonContactNo,SuretyPersonAddress")]
        //    TblVendor tbl_vendor)
        //{
        //    if (ModelState.IsValid)
        //    {

        //        _context.TblVendor.Add(tbl_vendor);
        //        _context.UpdateNextSequence(SequenceTable.tbl_Customer); ;
        //        await _context.SaveChangesAsync();

        //        return RedirectToAction("Index");
        //    }
        //    ViewBag.Type = new SelectList(_context.TblVendorType, "ID", "Name", tbl_vendor.Type);
        //    return View("Create", tbl_vendor);
        //}

        // POST: Vendors/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("AutoId,Id,Name,ContactPerson,ContactNo,PhoneNo,VendorType,Type,Place,Dob,Gstno,Tinno,Panno,Cinno,AdhaarNo,OpeningBalance,OpeningBalanceType,OpeningBalanceDate,CreditLimit,CreditPeriod,CreditInterestRate,DebitInterestRate,CreatedDatetime,Photo,Remark,SuretyPerson,SuretyPersonContactNo,SuretyPersonAddress")] TblVendor tblVendor)
        {
            if (ModelState.IsValid)
            {
                var saved = false;
                using (var transaction = _context.Database.BeginTransaction())
                {
                    try
                    {
                        _context.Add(tblVendor);
                        if (tblVendor.VendorType == "Customer")
                            _context.UpdateNextSequence(SequenceTable.tbl_Customer);
                        else if (tblVendor.VendorType == "Supplier")
                            _context.UpdateNextSequence(SequenceTable.tbl_Supplier);
                        else
                            _context.UpdateNextSequence(SequenceTable.tbl_vendor);

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
                ViewData["Type"] = new SelectList(_context.TblVendorType, "Id", "Id", tblVendor.Type);

                return View(tblVendor);
            }

            // GET: Vendors/Edit/5
            public async Task<IActionResult> Edit(string id)
            {
                if (id == null)
                {
                    return NotFound();
                }

                var tblVendor = await _context.TblVendor.FindAsync(id);
                if (tblVendor == null)
                {
                    return NotFound();
                }
                ViewData["Type"] = new SelectList(_context.TblVendorType, "Id", "Id", tblVendor.Type);
                InilizePageHeader(HeaderTitle.Edit, tblVendor.VendorType, id);
                return View(tblVendor);
            }

        // POST: Vendors/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Id,Name,ContactPerson,ContactNo,PhoneNo,VendorType,Type,Place,Dob,Gstno,Tinno,Panno,Cinno,AdhaarNo,OpeningBalance,OpeningBalanceType,OpeningBalanceDate,CreditLimit,CreditPeriod,CreditInterestRate,DebitInterestRate,CreatedDatetime,Photo,Remark,SuretyPerson,SuretyPersonContactNo,SuretyPersonAddress")] TblVendor tblVendor)
        {
            if (id != tblVendor.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    //_context.Update(tblVendor).Property(x => x.AutoId).IsModified = false;
                    _context.Update(tblVendor);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TblVendorExists(tblVendor.Id))
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
            ViewData["Type"] = new SelectList(_context.TblVendorType, "Id", "Id", tblVendor.Type);
            return View(tblVendor);
        }

        // GET: Vendors/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tblVendor = await _context.TblVendor
                .Include(t => t.TypeNavigation)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tblVendor == null)
            {
                return NotFound();
            }
            InilizePageHeader(HeaderTitle.Delete, tblVendor.VendorType, id);
            return View(tblVendor);
        }

        // POST: Vendors/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var tblVendor = await _context.TblVendor.FindAsync(id);
            _context.TblVendor.Remove(tblVendor);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TblVendorExists(string id)
        {
            return _context.TblVendor.Any(e => e.Id == id);
        }
    }
}