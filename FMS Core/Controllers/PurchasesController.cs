using FMS_Core.Helper;
using FMS_Core.Models.EFModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FMS_Core.Controllers
{
    public class PurchasesController : Controller
    {
        private readonly FMSExpContext _context;
        private static List<TblItemStock> PurchaseItemStock { get; set; }

        public PurchasesController(FMSExpContext context)
        {
            _context = context;
        }

        // GET: Purchases
        public async Task<IActionResult> Index()
        {
            var fMSExpContext = _context.TblPurchase
                .Include(t => t.PartyNameNavigation)
                .Include(t => t.PaymentModeNavigation)
                .OrderByDescending(q => q.Id);
            return View(await fMSExpContext.ToListAsync());
        }

        // GET: Purchases/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null) return NotFound();
            InitializePageHeader(HeaderTitle.Details, PageName.Purchase, id);
            var tblPurchase = await _context.TblPurchase
                .Include(t => t.PartyNameNavigation)
                .Include(t => t.PaymentModeNavigation)
                .Include(t => t.TblItemStock)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tblPurchase == null) return NotFound();

            return View(tblPurchase);
        }

        // GET: Purchases/Create
        public IActionResult Create()
        {
            InitializePageHeader(HeaderTitle.Add, PageName.Purchase,
                GenericHelper.GetMaxValue(SequenceTable.tbl_Purchase));
            PurchaseItemStock = new List<TblItemStock>();

            ViewData["PartyName"] = new SelectList(_context.TblVendor, "Id", "Name");
            ViewData["PaymentMode"] = new SelectList(_context.TblPaymentMode, "Id", "Mode");
            return View();
        }

        // POST: Purchases/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(
            [Bind(
                "Id,PartyInvoiceDate,PurchaseDate,PartyInvoiceNo,PartyName,PaymentDueAfter,ReverseCharge,Remark,DiscountAmount,OtherCharge,TotalAmountBeforeTax,TaxAmount,TotalAmountAfterTax,RoundOff,GrandTotal,PurchaseBook,PaymentMode,ScanCopy,CreatedDatetime,Amount")]
            TblPurchase tblPurchase)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tblPurchase);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            ViewData["PartyName"] = new SelectList(_context.TblVendor, "Id", "Name", tblPurchase.PartyName);
            ViewData["PaymentMode"] = new SelectList(_context.TblPaymentMode, "Id", "Mode", tblPurchase.PaymentMode);
            return View(tblPurchase);
        }

        // GET: Purchases/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null) return NotFound();

            InitializePageHeader(HeaderTitle.Edit, PageName.Purchase, id);
            //var tblPurchase = await _context.TblPurchase.FindAsync(id);
            var tblPurchase = await _context.TblPurchase
                //.Include(t => t.PartyNameNavigation)
                //.Include(t => t.PaymentModeNavigation)
                .Include(t => t.TblItemStock)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tblPurchase == null) return NotFound();

            ViewData["PartyName"] = new SelectList(_context.TblVendor, "Id", "Name", tblPurchase.PartyName);
            ViewData["PaymentMode"] = new SelectList(_context.TblPaymentMode, "Id", "Mode", tblPurchase.PaymentMode);
            return View(tblPurchase);
        }

        // POST: Purchases/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id,
            [Bind(
                "Id,PartyInvoiceDate,PurchaseDate,PartyInvoiceNo,PartyName,PaymentDueAfter,ReverseCharge,Remark,DiscountAmount,OtherCharge,TotalAmountBeforeTax,TaxAmount,TotalAmountAfterTax,RoundOff,GrandTotal,PurchaseBook,PaymentMode,ScanCopy,CreatedDatetime,Amount")]
            TblPurchase tblPurchase)
        {
            if (id != tblPurchase.Id) return NotFound();

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tblPurchase);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TblPurchaseExists(tblPurchase.Id))
                        return NotFound();
                    throw;
                }

                return RedirectToAction(nameof(Index));
            }

            ViewData["PartyName"] = new SelectList(_context.TblVendor, "Id", "Name", tblPurchase.PartyName);
            ViewData["PaymentMode"] = new SelectList(_context.TblPaymentMode, "Id", "Mode", tblPurchase.PaymentMode);
            return View(tblPurchase);
        }

        // GET: Purchases/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null) return NotFound();
            InitializePageHeader(HeaderTitle.Delete, PageName.Purchase, id);
            var tblPurchase = await _context.TblPurchase
                .Include(t => t.PartyNameNavigation)
                .Include(t => t.PaymentModeNavigation)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tblPurchase == null) return NotFound();

            return View(tblPurchase);
        }

        // POST: Purchases/Delete/5
        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var tblPurchase = await _context.TblPurchase.FindAsync(id);
            _context.TblPurchase.Remove(tblPurchase);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TblPurchaseExists(string id)
        {
            return _context.TblPurchase.Any(e => e.Id == id);
        }

        #region scriptmethod

        public void InitializePageHeader(string headerTitle, string pageName, string id)
        {
            ViewData["HeaderTitle"] = headerTitle;
            ViewData["Name"] = pageName;
            ViewData["Id"] = id;
            ViewData["CreatedDatetime"] = DateTime.Now;
        }

        public PartialViewResult LoadItems()
        {
            return PartialView(PurchaseItemStock);
        }

        public PartialViewResult Viewtems()
        {
            return PartialView(PurchaseItemStock);
        }

        [HttpGet]
        public PartialViewResult CreateItemList(string purchaseId, string partyInvoiceNo)
        {
            ViewBag.ItemID = new SelectList(_context.TblItems, "Id", "Name");
            ViewBag.PurchaseID = purchaseId;
            ViewBag.ID = purchaseId + "-" +
                         GenericHelper.GetMaxValue("tbl_ItemStock") + "-" +
                         (PurchaseItemStock.Count + 1);
            ViewBag.CreatedDatetime = DateTime.Now;
            ViewBag.InvoiceNo = partyInvoiceNo;
            ViewBag.StockType = "IN";
            return PartialView();
        }

        [HttpPost]
        public JsonResult GetItemDetails(string id)
        {
            var StockDtl = _context.vw_StockAvailable.FirstOrDefault(q => q.ItemsID == id);
            var ItemGstDtl = _context.TblItems
                .Include(t => t.GstNavigation)
                .Include(t => t.MeasuringUnitNavigation)
                //.Include(t => t.SupplierNavigation)
                .Include(t => t.TypeNavigation)
                .FirstOrDefault(q => q.Id == id);

            var StockIn = 0;
            var StockOut = 0;
            var StockAvailable = 0;
            var HSNSACNum = "NA";
            if (StockDtl != null)
            {
                StockIn = StockDtl.StockIn;
                StockOut = StockDtl.StockOut;
                StockAvailable = StockDtl.StockAvailable ?? 0;
                HSNSACNum = StockDtl.HSN_SAC_NO ?? "NA";
            }

            var SGST = 0.0m;
            var CGST = 0.0m;
            var GST = 0.0m;
            var Type = "NA";
            var MeasuringUnit = "NA";
            if (ItemGstDtl != null)
            {
                SGST = ItemGstDtl.GstNavigation.Sgst ?? SGST;
                CGST = ItemGstDtl.GstNavigation.Cgst ?? SGST;
                GST = ItemGstDtl.GstNavigation.Gst ?? SGST;
                MeasuringUnit = ItemGstDtl.MeasuringUnitNavigation.MeasuringUnits ?? "NA";
                Type = ItemGstDtl.TypeNavigation.ItemType ?? "NA";
            }

            return Json(new { StockIn, StockOut, StockAvailable, HSNSACNum, SGST, CGST, GST, MeasuringUnit, Type });
        }

        [HttpPost]
        public JsonResult AddItemToSession(string request)
        {
            var UInput = JsonConvert.DeserializeObject<TblItemStock>(request);

            //_context.Configuration.ProxyCreationEnabled = false;
            UInput.Item = _context.TblItems.FirstOrDefault(q => q.Id == UInput.ItemId);
            PurchaseItemStock.Add(UInput);
            ViewBag.TblItemStock = PurchaseItemStock;
            //Session["PurchaseItemStock"] = PurchaseItemStock;
            var TotalAmountBeforeTax = PurchaseItemStock.Select(q => q.TotalPriceBeforeTax).Sum();
            var TaxAmount = PurchaseItemStock.Select(q => q.Gst).Sum();
            var TotalAmountAfterTax = PurchaseItemStock.Select(q => q.TotalPriceAfterTax).Sum();

            var total = (from p in PurchaseItemStock
                         group p by 1
                into g
                         select new
                         {
                             TotalAmountBeforeTax = g.Sum(q => q.TotalPriceBeforeTax),
                             TaxAmount = g.Sum(q => q.Gst),
                             TotalAmountAfterTax = g.Sum(q => q.TotalPriceAfterTax)
                         }).FirstOrDefault();

            return Json(new { PurchaseItemStock, total });
        }

        public JsonResult DeleteItemFromSession(string id)
        {
            PurchaseItemStock.RemoveAll(q => q.Id == id);

            ViewBag.TblItemStock = PurchaseItemStock;
            //Session["PurchaseItemStock"] = PurchaseItemStock;
            var TotalAmountBeforeTax = PurchaseItemStock.Select(q => q.TotalPriceBeforeTax).Sum();
            var TaxAmount = PurchaseItemStock.Select(q => q.Gst).Sum();
            var TotalAmountAfterTax = PurchaseItemStock.Select(q => q.TotalPriceAfterTax).Sum();

            var total = (from p in PurchaseItemStock
                         group p by 1
                into g
                         select new
                         {
                             TotalAmountBeforeTax = g.Sum(q => q.TotalPriceBeforeTax),
                             TaxAmount = g.Sum(q => q.Gst),
                             TotalAmountAfterTax = g.Sum(q => q.TotalPriceAfterTax)
                         }).FirstOrDefault();

            return Json(new { PurchaseItemStock, total });
        }

        public ActionResult AddPurchase(string request)
        {
            using (var transaction = _context.Database.BeginTransaction())
            {
                var TblPurchase = JsonConvert.DeserializeObject<TblPurchase>(request);
                if (PurchaseItemStock.Count > 0)
                {
                    var t = JsonConvert.SerializeObject(TblPurchase);

                    _context.TblPurchase.Add(TblPurchase);

                    PurchaseItemStock.ForEach(q => q.Item = null);
                    _context.TblItemStock.AddRange(PurchaseItemStock);

                    var NewSequenceValue = GenericHelper.GetNextUpdatedData(SequenceTable.tbl_Purchase);
                    _context.Entry(NewSequenceValue).State = EntityState.Modified;

                    var NewSequenceValueItemStock = GenericHelper.GetNextUpdatedData(SequenceTable.tbl_ItemStock);
                    _context.Entry(NewSequenceValueItemStock).State = EntityState.Modified;

                    //_context.SaveChanges();

                    // 1 hold --  only save purchase & Item with status hold

                    // 2  CREDIT PURCHASE --  one transaction entry with credit (out) with unpaid status

                    // 3  CASH PAY  -- one transaction entry with credit (out)/ Paid
                    //             one payment Entry with full amount
                    //             one transaction entry with Debit (in) with payment ID

                    // 4 MULTI MODE PAY -- one transaction entry with credit (out)
                    //             one payment Entry
                    //             one transaction entry with Debit (in)

                    if (TblPurchase.PaymentMode != null && TblPurchase.PaymentMode.Value != PaymentMode.HOLD
                    ) // not hold
                    {
                        var amount = TblPurchase.Amount;
                        var creditTID = GenericHelper.GetMaxValue(SequenceTable.tbl_TransactionCredit);
                        var tbl_Transaction_Credit = new TblTransaction
                        {
                            Id = creditTID,

                            CreatedDatetime = TblPurchase.CreatedDatetime,
                            EntryDate = TblPurchase.PurchaseDate.ToString(),

                            EntryType = TransactionEntryType.Purchase
                                .ToString(), //"Purchase", // Purchase/Sales/Recipt/Payment
                            Status = TransactionStatus
                                .Unpaid, //Paid/Unpaid/Pending/Paid Against entries : // Recive  Against entries
                            TransactionType =
                                TransactionType.Credit
                                    .ToString(), //Debit/ credit --  For Real: Debit what comes in, credit what goes out.
                            //TransactionRef = null,

                            EntryId = TblPurchase.Id,
                            PurchaseId = TblPurchase.Id,
                            //SalesID = null,

                            Amount = TblPurchase.GrandTotal,

                            VendorId = TblPurchase.PartyName
                        };
                        _context.TblTransaction.Add(tbl_Transaction_Credit);
                        //_context.SaveChanges();

                        var NewSequenceValueTbl_Transaction = GenericHelper.GetNextUpdatedData("tbl_TransactionCredit");
                        _context.Entry(NewSequenceValueTbl_Transaction).State = EntityState.Modified;

                        //_context.SaveChanges();
                        if (TblPurchase.PaymentMode == 2) //CREDIT PURCHASE
                        {
                        }
                        else if (TblPurchase.PaymentMode == 3) //CASH PAY
                        {
                            var tbl_PaymentID = GenericHelper.GetMaxValue("tbl_Payment");
                            var tbl_Payment = new TblPayment
                            {
                                Id = tbl_PaymentID,
                                Amount = TblPurchase.GrandTotal,
                                CreatedDatetime = TblPurchase.CreatedDatetime,

                                PartyName = TblPurchase.PartyName,
                                PaymentDate = TblPurchase.PurchaseDate.ToString(),
                                PaymentMode = "CASH"
                                //Remark = "",
                                //TransactionID = creditTID,
                            };
                            _context.TblPayment.Add(tbl_Payment);

                            var NewSequenceValueTbl_Payment = GenericHelper.GetNextUpdatedData("tbl_Payment");
                            _context.Entry(NewSequenceValueTbl_Payment).State = EntityState.Modified;
                            //_context.SaveChanges();

                            var tbl_TransactionDebit = new TblTransaction
                            {
                                Id = GenericHelper.GetMaxValue("tbl_TransactionDebit"),

                                CreatedDatetime = TblPurchase.CreatedDatetime,
                                EntryDate = TblPurchase.PurchaseDate.ToString(),

                                EntryType = TransactionEntryType.Purchase
                                    .ToString(), // "Purchase", // Purchase/Sales/Recipt/Payment
                                Status = TransactionStatus.PaidAgainstEntries +
                                         TblPurchase
                                             .Id, //Paid/Unpaid/Pending/Paid Against entries : // Recive  Against entries
                                TransactionType =
                                    TransactionType.Debit
                                        .ToString(), //Debit/ credit --  For Real: Debit what comes in, credit what goes out.
                                TransactionRef = TblPurchase.Id,

                                EntryId = tbl_PaymentID,
                                //PurchaseID = null,
                                //SalesID = null,
                                PaymentId = tbl_PaymentID,

                                Amount = TblPurchase.GrandTotal,

                                VendorId = TblPurchase.PartyName
                            };
                            _context.TblTransaction.Add(tbl_TransactionDebit);

                            var NewSequenceValuetbl_Transaction2 =
                                GenericHelper.GetNextUpdatedData("tbl_TransactionDebit");
                            _context.Entry(NewSequenceValuetbl_Transaction2).State = EntityState.Modified;

                            //_context.SaveChanges();

                            //var tbl_Transaction result = _context.tbl_Transaction.Where(q => q.ID == creditTID).FirstOrDefault();
                            tbl_Transaction_Credit.Status = TransactionStatus.Paid;
                            //_context.Entry(tbl_Transactionresult).State = EntityState.Modified;
                            //_context.SaveChanges();
                        }
                        else if (TblPurchase.PaymentMode == 4) //MULTI MODE PAY
                        {
                            var tbl_PaymentID = GenericHelper.GetMaxValue("tbl_Payment");
                            var tbl_Payment = new TblPayment
                            {
                                Id = tbl_PaymentID,
                                Amount = amount,
                                CreatedDatetime = TblPurchase.CreatedDatetime,

                                PartyName = TblPurchase.PartyName,
                                PaymentDate = TblPurchase.PurchaseDate.ToString(),
                                PaymentMode = "CASH"
                                //Remark = "",
                                //TransactionID = creditTID,
                            };
                            _context.TblPayment.Add(tbl_Payment);

                            var NewSequenceValueTbl_Payment = GenericHelper.GetNextUpdatedData("tbl_Payment");
                            _context.Entry(NewSequenceValueTbl_Payment).State = EntityState.Modified;
                            //_context.SaveChanges();

                            var tbl_TransactionDebit = new TblTransaction
                            {
                                Id = GenericHelper.GetMaxValue("tbl_TransactionDebit"),

                                CreatedDatetime = TblPurchase.CreatedDatetime,
                                EntryDate = TblPurchase.PurchaseDate.ToString(),

                                EntryType = TransactionEntryType.Purchase
                                    .ToString(), // "Purchase", // Purchase/Sales/Recipt/Payment
                                Status = TransactionStatus.PaidAgainstEntries +
                                         TblPurchase
                                             .Id, //Paid/Unpaid/Pending/Paid Against entries : // Recive  Against entries
                                TransactionType =
                                    TransactionType.Debit
                                        .ToString(), //Debit/ credit --  For Real: Debit what comes in, credit what goes out.
                                TransactionRef = TblPurchase.Id,

                                EntryId = tbl_PaymentID,
                                //PurchaseID = null,
                                //SalesID = null,
                                PaymentId = tbl_PaymentID,

                                Amount = amount,

                                VendorId = TblPurchase.PartyName
                            };
                            _context.TblTransaction.Add(tbl_TransactionDebit);

                            var NewSequenceValueTbl_Transaction2 =
                                GenericHelper.GetNextUpdatedData("tbl_TransactionDebit");
                            _context.Entry(NewSequenceValueTbl_Transaction2).State = EntityState.Modified;
                        }
                    }

                    var saved = false;

                    try
                    {
                        _context.SaveChanges();
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

                    //if (TblPurchase.PaymentMode == 4)  //MULTI MODE PAY
                    //    return JavaScript("window.location = '/Purchases/index'");
                    //else
                    return Content("window.location = '/Purchases/index'");
                    //return RedirectToAction(nameof(Index));
                }

                ViewBag.PaymentMode = new SelectList(_context.TblPaymentMode, "ID", "Mode", TblPurchase.PaymentMode);
                ViewBag.PartyName = new SelectList(_context.TblVendor, "ID", "Name", TblPurchase.PartyName);
                throw new InvalidOperationException("Please add item to continue!!");
            }

            //return RedirectToAction("Index");
        }

        #endregion scriptmethod
    }
}