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
    public class SalesController : Controller
    {
        private readonly FMSExpContext _context;
        private static List<TblItemStock> SalesItemStock { get; set; }

        public SalesController(FMSExpContext context)
        {
            _context = context;
        }

        public void InitializePageHeader(string headerTitle, string pageName, string id)
        {
            ViewData["HeaderTitle"] = headerTitle;
            ViewData["Name"] = pageName;
            ViewData["Id"] = id;
            ViewData["CreatedDatetime"] = DateTime.Now;
        }

        // GET: Sales
        public async Task<IActionResult> Index()
        {
            var fMSExpContext = _context.TblSale.Include(t => t.Customer);
            return View(await fMSExpContext.ToListAsync());
        }

        // GET: Sales/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            InitializePageHeader(HeaderTitle.Details, PageName.Purchase, id);
            var tblSale = await _context.TblSale
                .Include(t => t.Customer)
                .FirstOrDefaultAsync(m => m.SaleId == id);
            if (tblSale == null)
            {
                return NotFound();
            }

            return View(tblSale);
        }

        // GET: Sales/Create
        public IActionResult Create()
        {
            SalesItemStock = new List<TblItemStock>();
            //ViewData["SaleID"] = GenericHelper.GetMaxValue("tbl_Sale");
            //ViewData["CreatedDatetime"] = DateTime.Now;
            ViewData["InvoiceId"] = GenericHelper.GetMaxValue("tbl_SalesInvoice");
            ViewData["PaymentMode"] = new SelectList(_context.TblPaymentMode, "Id", "Mode");
            InitializePageHeader(HeaderTitle.Add, PageName.Sales,
                GenericHelper.GetMaxValue(SequenceTable.tbl_Sale));


            ViewData["CustomerId"] = new SelectList(_context.TblVendor, "Id", "Name");
            return View();
        }

        // POST: Sales/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(
            [Bind(
                "AutoId,SaleId,InvoiceId,InvoiceDate,CustomerId,DiscountAfterTax,OtherChargeAfterTax,SubTotal,Tax,TotalValueafterTax,RoundOff,GrandTotal,CreatedDatetime,ReverseCharge,Remark")]
            TblSale tblSale)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tblSale);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            ViewData["CustomerId"] = new SelectList(_context.TblVendor, "Id", "Name", tblSale.CustomerId);
            return View(tblSale);
        }

        // GET: Sales/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            InitializePageHeader(HeaderTitle.Edit, PageName.Purchase, id);
            var tblSale = await _context.TblSale.FindAsync(id);
            if (tblSale == null)
            {
                return NotFound();
            }

            ViewData["CustomerId"] = new SelectList(_context.TblVendor, "Id", "Name", tblSale.CustomerId);
            return View(tblSale);
        }

        // POST: Sales/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id,
            [Bind(
                "AutoId,SaleId,InvoiceId,InvoiceDate,CustomerId,DiscountAfterTax,OtherChargeAfterTax,SubTotal,Tax,TotalValueafterTax,RoundOff,GrandTotal,CreatedDatetime,ReverseCharge,Remark")]
            TblSale tblSale)
        {
            if (id != tblSale.SaleId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tblSale);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TblSaleExists(tblSale.SaleId))
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

            ViewData["CustomerId"] = new SelectList(_context.TblVendor, "Id", "Name", tblSale.CustomerId);
            return View(tblSale);
        }

        // GET: Sales/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            InitializePageHeader(HeaderTitle.Delete, PageName.Purchase, id);
            var tblSale = await _context.TblSale
                .Include(t => t.Customer)
                .FirstOrDefaultAsync(m => m.SaleId == id);
            if (tblSale == null)
            {
                return NotFound();
            }

            return View(tblSale);
        }

        // POST: Sales/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var tblSale = await _context.TblSale.FindAsync(id);
            _context.TblSale.Remove(tblSale);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TblSaleExists(string id)
        {
            return _context.TblSale.Any(e => e.SaleId == id);
        }

        #region MyRegion

        public PartialViewResult LoadItems()
        {
            return PartialView(SalesItemStock);
        }

        public PartialViewResult Viewtems()
        {
            return PartialView(SalesItemStock);
        }

        public JsonResult AddItemToSession(string request)
        {
            TblItemStock UIinput = JsonConvert.DeserializeObject<TblItemStock>(request);
            //_context.Configuration.ProxyCreationEnabled = false;
            UIinput.Item = _context.TblItems.FirstOrDefault(q => q.Id == UIinput.Id);
            SalesItemStock.Add(UIinput);
            ViewBag.TblItemStock = SalesItemStock;
            //Session["SalesItemStock"] = SalesItemStock;
            //var TotalAmountBeforeTax = SalesItemStock.Select(q => q.TotalPriceBeforeTax).Sum();
            //var TaxAmount = SalesItemStock.Select(q => q.Gst).Sum();
            //var TotalAmountAfterTax = SalesItemStock.Select(q => q.TotalPriceAfterTax).Sum();

            var total = (from p in SalesItemStock
                         group p by 1
                into g
                         select (
                             new
                             {
                                 TotalAmountBeforeTax = g.Sum(q => q.TotalPriceBeforeTax),
                                 TaxAmount = g.Sum(q => q.Gst),
                                 TotalAmountAfterTax = g.Sum(q => q.TotalPriceAfterTax),
                             }
                         )).FirstOrDefault();


            return Json(new { SalesItemStock, total });
        }

        [HttpGet]
        public PartialViewResult CreateItemList(string SalesID, string InvoiceNo)
        {
            ViewBag.ItemID = new SelectList(_context.TblItems, "Id", "Name");
            ViewBag.SaleID = SalesID;
            ViewBag.ID = SalesID + "-" + GenericHelper.GetMaxValue("tbl_ItemStock") + "-" + (SalesItemStock.Count + 1);
            ViewBag.CreatedDatetime = DateTime.Now;
            ViewBag.InvoiceNo = InvoiceNo;
            ViewBag.StockType = "OUT";

            return PartialView();
        }


        public ActionResult AddSales(string request)
        {
            //using (var transaction = _context.Database.BeginTransaction())
            //{
                TblSale tbl_Sale = JsonConvert.DeserializeObject<TblSale>(request);
                if (SalesItemStock.Count > 0)
                {
                    var saved = false;

                    try
                    {
                        var t = JsonConvert.SerializeObject(tbl_Sale);

                    _context.TblSale.Add(tbl_Sale);
                        _context.SaveChanges();

                        SalesItemStock.ForEach(q => q.Item = null);

                    _context.TblItemStock.AddRange(SalesItemStock);
                        _context.SaveChanges();

                        TblSequence NewSequenceValue = GenericHelper.GetNextUpdatedData("tbl_Sale");
                    _context.Entry(NewSequenceValue).State = EntityState.Modified;
                    //_context.SaveChanges();

                    TblSequence NewSequenceValuetbl_SalesInvoice = GenericHelper.GetNextUpdatedData("tbl_SalesInvoice");
                    _context.Entry(NewSequenceValuetbl_SalesInvoice).State = EntityState.Modified;
                    //_context.SaveChanges();

                    TblSequence NewSequenceValueItemStock = GenericHelper.GetNextUpdatedData("tbl_ItemStock");
                    _context.Entry(NewSequenceValueItemStock).State = EntityState.Modified;
                    //_context.SaveChanges();
                    //_context.SaveChanges();

                    // 1 hold --  only save Sales & Item with status hold

                    // 2  CREDIT PURCHASE --  one transaction entry with Debit (In) with unpaid status

                    // 3  CASH PAY  -- one transaction entry with  Debit (In)/ Paid
                    //             one payment Entry with full amount
                    //             one transaction entry with credit (out) with payment ID

                    // 4 MULTI MODE PAY -- one transaction entry with Debit (In)
                    //             one payment Entry
                    //             one transaction entry with credit (out)

                    if (tbl_Sale.PaymentMode != null && tbl_Sale.PaymentMode.Value != PaymentMode.HOLD
                    ) // not hold
                    {
                        var amount = tbl_Sale.Amount;
                        var creditTID = GenericHelper.GetMaxValue(SequenceTable.tbl_TransactionCredit);
                        var tbl_Transaction_Credit = new TblTransaction
                        {
                            Id = creditTID,

                            CreatedDatetime = tbl_Sale.CreatedDatetime,
                            EntryDate = tbl_Sale.InvoiceDate.ToString(),

                            EntryType = TransactionEntryType.Sales
                                .ToString(), //"Purchase", // Purchase/Sales/Recipt/Payment
                            Status = TransactionStatus
                                .Unpaid, //Paid/Unpaid/Pending/Paid Against entries : // Recive  Against entries
                            TransactionType =
                                TransactionType.Debit
                                    .ToString(), //Debit/ credit --  For Real: Debit what comes in, credit what goes out.
                            //TransactionRef = null,

                            EntryId = tbl_Sale.SaleId,
                            //PurchaseId = tbl_Sale.Id,
                            SalesId = tbl_Sale.SaleId,

                            Amount = tbl_Sale.GrandTotal,

                            VendorId = tbl_Sale.CustomerId
                        };
                        _context.TblTransaction.Add(tbl_Transaction_Credit);
                        //_context.SaveChanges();

                        var NewSequenceValueTbl_Transaction = GenericHelper.GetNextUpdatedData("tbl_TransactionCredit");
                        _context.Entry(NewSequenceValueTbl_Transaction).State = EntityState.Modified;

                        //_context.SaveChanges();
                        if (tbl_Sale.PaymentMode == 2) //CREDIT PURCHASE
                        {
                        }
                        else if (tbl_Sale.PaymentMode == 3) //CASH PAY
                        {
                            var tbl_PaymentID = GenericHelper.GetMaxValue("tbl_Payment");
                            var tbl_Payment = new TblPayment
                            {
                                Id = tbl_PaymentID,
                                Amount = tbl_Sale.GrandTotal,
                                CreatedDatetime = tbl_Sale.CreatedDatetime,

                                PartyName = tbl_Sale.SaleId,
                                PaymentDate = tbl_Sale.InvoiceDate.ToString(),
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

                                CreatedDatetime = tbl_Sale.CreatedDatetime,
                                EntryDate = tbl_Sale.InvoiceDate.ToString(),

                                EntryType = TransactionEntryType.Sales
                                    .ToString(), // "Purchase", // Purchase/Sales/Recipt/Payment
                                Status = TransactionStatus.PaidAgainstEntries +
                                         tbl_Sale
                                             .SaleId, //Paid/Unpaid/Pending/Paid Against entries : // Recive  Against entries
                                TransactionType =
                                    TransactionType.Credit
                                        .ToString(), //Debit/ credit --  For Real: Debit what comes in, credit what goes out.
                                TransactionRef = tbl_Sale.SaleId,

                                EntryId = tbl_PaymentID,
                                //PurchaseID = null,
                                //SalesID = null,
                                PaymentId = tbl_PaymentID,

                                Amount = tbl_Sale.GrandTotal,

                                VendorId = tbl_Sale.CustomerId
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
                        else if (tbl_Sale.PaymentMode == 4) //MULTI MODE PAY
                        {
                            var tbl_PaymentID = GenericHelper.GetMaxValue("tbl_Payment");
                            var tbl_Payment = new TblPayment
                            {
                                Id = tbl_PaymentID,
                                Amount = amount,
                                CreatedDatetime = tbl_Sale.CreatedDatetime,

                                PartyName = tbl_Sale.CustomerId,
                                PaymentDate = tbl_Sale.InvoiceDate.ToString(),
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

                                CreatedDatetime = tbl_Sale.CreatedDatetime,
                                EntryDate = tbl_Sale.InvoiceDate.ToString(),

                                EntryType = TransactionEntryType.Purchase
                                    .ToString(), // "Purchase", // Purchase/Sales/Recipt/Payment
                                Status = TransactionStatus.PaidAgainstEntries +
                                         tbl_Sale
                                             .SaleId, //Paid/Unpaid/Pending/Paid Against entries : // Recive  Against entries
                                TransactionType =
                                    TransactionType.Debit
                                        .ToString(), //Debit/ credit --  For Real: Debit what comes in, credit what goes out.
                                TransactionRef = tbl_Sale.SaleId,

                                EntryId = tbl_PaymentID,
                                //PurchaseID = null,
                                //SalesID = null,
                                PaymentId = tbl_PaymentID,

                                Amount = amount,

                                VendorId = tbl_Sale.CustomerId
                            };
                            _context.TblTransaction.Add(tbl_TransactionDebit);

                            var NewSequenceValueTbl_Transaction2 =
                                GenericHelper.GetNextUpdatedData("tbl_TransactionDebit");
                            _context.Entry(NewSequenceValueTbl_Transaction2).State = EntityState.Modified;
                        }
                    }

                   
                        _context.SaveChanges();
                        saved = true;
                    }
                    catch (Exception e)
                    {
                        throw new InvalidOperationException(e.Message);
                    }
                    finally
                    {
                        //if (saved) transaction.Commit();
                    }

                    //if (tbl_Sale.PaymentMode == 4)  //MULTI MODE PAY
                    //    return JavaScript("window.location = '/Purchases/index'");
                    //else




                    //return RedirectToAction("Index");
                    return Content("window.location = '/Sale/index'");
                }
                else
                {
                    ViewBag.CustomerID = new SelectList(_context.TblVendor, "ID", "Name", tbl_Sale.CustomerId);
                    throw new InvalidOperationException("Please add item to continue!!");

                }

                //return RedirectToAction("Index");
            //}

        }

        #endregion
    }
}

