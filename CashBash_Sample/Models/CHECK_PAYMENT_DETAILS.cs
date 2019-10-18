using System;
using System.Collections.Generic;

namespace CashBash_Sample.Models
{
    public partial class CHECK_PAYMENT_DETAILS
    {
        public int ID { get; set; }
        public Nullable<int> AP_COMPANY { get; set; }
        public string VENDOR_ID { get; set; }
        public string INVOICE_ID { get; set; }
        public string PROCESS_LEVEL { get; set; }
        public Nullable<System.DateTime> INVOICE_DATE { get; set; }
        public Nullable<decimal> INVOICE_AMOUNT { get; set; }
        public Nullable<System.DateTime> INVOICE_DUE_DATE { get; set; }
        public Nullable<System.DateTime> POSTING_DATE { get; set; }
        public Nullable<int> GL_COMPANY { get; set; }
        public Nullable<int> GL_ACCOUNTING_UNIT { get; set; }
        public Nullable<int> GL_ACCOUNT { get; set; }
        public Nullable<int> GL_SUB_ACCOUNT { get; set; }
        public string GL_USER_FIELD_2 { get; set; }
        public int ATTENDEE_ID { get; set; }
        public int EVENT_ID { get; set; }
        public System.DateTime CREATED_AT { get; set; }
        public System.DateTime UPDATED_AT { get; set; }
        public int CHECK_PAYMENTS_ID { get; set; }
    
        public virtual CASH_BASH_EVENT CASH_BASH_EVENT { get; set; }
        public virtual CHECK_PAYMENTS CHECK_PAYMENTS { get; set; }
    }
}
