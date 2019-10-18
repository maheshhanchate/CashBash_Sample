using System;
using System.Collections.Generic;

namespace CashBash_Sample.Models
{ 
    public partial class ATTENDEE_TAX_REPORT_DETAILS
    {
        public int ID { get; set; }
        public int EVENT_ID { get; set; }
        public int ATTENDEE_ID { get; set; }
        public string VENDOIR_ID { get; set; }
        public string LAST_NAME { get; set; }
        public string FIRST_NAME { get; set; }
        public string GUEST_NAME { get; set; }
        public string AUDIENCE { get; set; }
        public string DEALER_ID { get; set; }
        public string DEALER_NAME { get; set; }
        public string OTHER_NOTES { get; set; }
        public int AIR_COST { get; set; }
        public int LAND_COST { get; set; }
        public int OTHER_COST { get; set; }
        public decimal PULL_AMMOUNT { get; set; }
        public decimal BONUS_CASH { get; set; }
        public decimal BONUS_NON_CASH { get; set; }
        public string NOTES { get; set; }
        public Nullable<int> AP_COMPANY { get; set; }
        public string PROCESS_LEVEL { get; set; }
        public System.DateTime POST_DATE { get; set; }
        public string REMIT_TO { get; set; }
        public string INVOICE_ID { get; set; }
        public string INVOICE_STATUS { get; set; }
        public System.DateTime INVOICE_DATE { get; set; }
        public System.DateTime DUE_DATE { get; set; }
        public string INVOICE_TYPE { get; set; }
        public string INVOICE_REF { get; set; }
        public string INCOME_CODE { get; set; }
        public string PAYMENT_NUMBER { get; set; }
        public string PAYMENT_CODE { get; set; }
        public System.DateTime PAYMENT_DATE { get; set; }
        public Nullable<int> ATTENDEE_TAX_REPORT_ID { get; set; }
        public int AIR_GUEST_COST { get; set; }
        public Nullable<decimal> TOTAL_COMPUTED { get; set; }
    
        public virtual ATTENDEE_TAX_REPORT ATTENDEE_TAX_REPORT { get; set; }
        public virtual CASH_BASH_EVENT CASH_BASH_EVENT { get; set; }
    }
}
