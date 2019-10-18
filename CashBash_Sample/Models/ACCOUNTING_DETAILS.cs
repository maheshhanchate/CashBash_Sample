using System;
using System.Collections.Generic;

namespace CashBash_Sample.Models
{ 
    public partial class ACCOUNTING_DETAILS
    {
        public int EVENT_ID { get; set; }
        public Nullable<int> AP_COMPANY { get; set; }
        public Nullable<int> GL_COMPANY { get; set; }
        public Nullable<int> GL_ACCOUNT { get; set; }
        public Nullable<int> GL_SUB_ACCOUNT { get; set; }
        public Nullable<int> GL_ACCOUNTING_UNIT { get; set; }
        public string GL_USER_FIELD_2 { get; set; }
        public Nullable<System.DateTime> INVOICE_DATE { get; set; }
        public Nullable<System.DateTime> INVOICE_DUE_DATE { get; set; }
        public Nullable<System.DateTime> POSTING_DATE { get; set; }
        public string INVOICE_NUMBER { get; set; }
        public string PROCESS_LEVEL { get; set; }
        public System.DateTime CREATED_AT { get; set; }
        public System.DateTime UPDATED_AT { get; set; }
    
        public virtual CASH_BASH_EVENT CASH_BASH_EVENT { get; set; }
    }
}
