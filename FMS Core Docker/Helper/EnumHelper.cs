namespace FMS_Core.Helper
{

    public enum TransactionEntryType { Purchase, Sales, Recipt, Payment }

    public  class SequenceTable
    {
        public const string tbl_Purchase = "tbl_Purchase";
        public const string tbl_ItemStock = "tbl_ItemStock";
        public const string tbl_Supplier = "tbl_Supplier";
        public const string tbl_Items = "tbl_Items";
        public const string tbl_Sale = "tbl_Sale";
        public const string tbl_SalesInvoice = "tbl_SalesInvoice";
        public const string tbl_Customer = "tbl_Customer";
        public const string tbl_Payment = "tbl_Payment";
        public const string tbl_TransactionDebit = "tbl_TransactionDebit";
        public const string tbl_TransactionCredit = "tbl_TransactionCredit";
        public const string tbl_vendor = "tbl_vendor";
    }

    public enum TransactionType { Debit, Credit } //--  For Real: Debit what comes in, credit what goes out.



    public static class PageName
    {
        public const string Supplier = "Supplier";
        public const string Customer = "Customer";
        public const string Items = "Item";
        internal static string Purchase = "Purchase";
        public static string Sales = "Sales";
    }
    public static class HeaderTitle
    {
        public const string Add = "Add New";
        public const string Edit = "Edit";
        public const string Delete = "Delete";
        public const string View = "Index";
        public const string Details = "Details of";
    }

    public static class PaymentMode
    {
        public const int HOLD = 1;
        public const int CREDIT_PURCHASE = 2;
        public const int CASH_PAY = 3;
        public const int MULTI_MODE_PAY = 4;

    }

    public static class TransactionStatus
    {
        public const string Paid = "Paid";
        public const string Unpaid = "Unpaid";
        public const string Pending = "Pending";
        public const string PaidAgainstEntries = "Paid Against Entries :";
        public const string ReciveAgainstEntries = "Recive Against Entries :";
    }
}