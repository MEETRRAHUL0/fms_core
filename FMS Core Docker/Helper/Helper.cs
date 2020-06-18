using FMS_Core.Models.EFModels;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace FMS_Core.Helper
{
    public static class GenericHelper
    {
        private static readonly FMSExpContext db = new FMSExpContext();

        public static string GetMaxValue(string tableName)
        {
            var result = db.TblSequence.Where(q => q.TableName == tableName).Select(q => new { maxValue = q.PreFix + (q.RecordCount + 1) });
            var c = result.Count();
            return result.FirstOrDefault()?.maxValue;
        }

        public static TblSequence GetNextUpdatedData(string tableName)
        {
            var result = db.TblSequence.FirstOrDefault(q => q.TableName == tableName);
            if (result != null)
            {
                result.RecordCount += 1;

            }
            return result;
        }

        public static void UpdateNextSequence(this FMSExpContext context, string tableName )
        {
            var result = db.TblSequence.FirstOrDefault(q => q.TableName == tableName);
            if (result != null)
            {
                result.RecordCount += 1;
                context.Entry(result).State = EntityState.Modified;
                //context.SaveChangesAsync();
            }

            //return context;
        }

        //public static tbl_ItemStock MapItemStock(ItemStockEntity uIinput)
        //{
        //    tbl_ItemStock res = new tbl_ItemStock
        //            {
        //                AutoID = uIinput.AutoID,
        //                BatchNo = uIinput.BatchNo,
        //                Expirydate = uIinput.Expirydate,
        //                ID = uIinput.ID,
        //                InvoiceNo = uIinput.InvoiceNo,
        //                ItemID = uIinput.ItemID,
        //                ItemwiseDiscount = Convert.ToInt32( uIinput.ItemwiseDiscount),
        //                ManufactureDate =  uIinput.ManufactureDate,
        //                MRP = Convert.ToInt32(uIinput.MRP),
        //                //PricePerUnitAfterTax = Convert.ToInt32(uIinput.PricePerUnitAfterTax),
        //                //PricePerUnitBeforeTax = Convert.ToInt32(uIinput.PricePerUnitBeforeTax),
        //                PurchaseID = uIinput.PurchaseID,
        //                Qty = Convert.ToInt32(uIinput.Qty),
        //                //Tax = Convert.ToInt32(uIinput.Tax),
        //                tbl_Items =  uIinput.tbl_Items,
        //                TotalPriceAfterTax = Convert.ToInt32(uIinput.TotalPriceAfterTax),
        //                TotalPriceBeforeTax = Convert.ToInt32(uIinput.TotalPriceBeforeTax),
        //                //TotalTax = Convert.ToInt32(uIinput.TotalTax)
        //    };

        //    return res;
        //}
    }
}