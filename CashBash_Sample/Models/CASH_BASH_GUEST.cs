using System;
using System.Collections.Generic;

namespace CashBash_Sample.Models
{
    public partial class CASH_BASH_GUEST
    {
        public int ATNE_ID { get; set; }
        public int EVNT_ID { get; set; }
        public System.DateTime LST_UPDT_DT { get; set; }
        public string LST_UPDT_USR_ID { get; set; }
        public Nullable<int> INVR_ID { get; set; }
        public string INVR_FWS_DLR_NB { get; set; }
    
        public virtual CASH_BASH_ATTENDEE CASH_BASH_ATTENDEE { get; set; }
        public virtual CASH_BASH_ATTENDEE CASH_BASH_ATTENDEE1 { get; set; }
        public virtual CASH_BASH_DEALER CASH_BASH_DEALER { get; set; }
    }
}
