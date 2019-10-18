using System;
using System.Collections.Generic;


namespace CashBash_Sample.Models
{ 
    public partial class CASH_BASH_ATTENDEE_AUDIT
    {
        public int ATNE_ID { get; set; }
        public string ATNE_TYP_CD { get; set; }
        public string FRST_NM { get; set; }
        public string LST_NM { get; set; }
        public Nullable<int> TITL_CD { get; set; }
        public string HM_PHN_NB { get; set; }
        public string EMRY_CNTC_NM { get; set; }
        public string EMRY_PHN_NB { get; set; }
        public string ATNE_SSN_NB { get; set; }
        public Nullable<System.DateTime> INCE_DT { get; set; }
        public string CHK_IN_IN { get; set; }
        public string TXBL_IN { get; set; }
        public int EVNT_ID { get; set; }
        public string ATNE_XREF_ID { get; set; }
        public System.DateTime LST_UPDT_TS { get; set; }
        public string LST_UPDT_USR_ID { get; set; }
        public string MID_INIT { get; set; }
        public string UID_IN { get; set; }
        public string LAWSON_VENDOR_ID { get; set; }
    
        public virtual CASH_BASH_EVENT CASH_BASH_EVENT { get; set; }
    }
}
