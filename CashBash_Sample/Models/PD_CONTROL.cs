using System;
using System.Collections.Generic;

namespace CashBash_Sample.Models
{
    public partial class PD_CONTROL
    {
        public int EVNT_ID { get; set; }
        public string FWS_DLR_NB { get; set; }
        public string LOCK_IN { get; set; }
        public System.DateTime LST_UPDT_TS { get; set; }
        public string LST_UPDT_USR_ID { get; set; }
        public string APP_USR_ID { get; set; }
        public string COMPLETE_USR_ID { get; set; }
    
        public virtual CASH_BASH_EVENT CASH_BASH_EVENT { get; set; }
    }
}
