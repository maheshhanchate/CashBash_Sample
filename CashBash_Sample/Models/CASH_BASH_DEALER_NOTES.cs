using System;
using System.Collections.Generic;

namespace CashBash_Sample.Models
{ 
    public partial class CASH_BASH_DEALER_NOTES
    {
        public int NOTE_ID { get; set; }
        public int EVNT_ID { get; set; }
        public string FWS_DLR_NB { get; set; }
        public System.DateTime LST_UPDT_TS { get; set; }
        public string LST_UPDT_USR_ID { get; set; }
        public string NT_CMNT_TX { get; set; }
    
        public virtual CASH_BASH_EVENT CASH_BASH_EVENT { get; set; }
    }
}
