using System;
using System.Collections.Generic;

namespace CashBash_Sample.Models
{
    public partial class CASH_BASH_EVENT_WINNER
    {
        public int ATNE_ID { get; set; }
        public int EVNT_ID { get; set; }
        public string SEND_CHK_IN { get; set; }
        public System.DateTime LST_UPDT_DT { get; set; }
        public string LST_UPDT_USR_ID { get; set; }
    
        public virtual CASH_BASH_ATTENDEE CASH_BASH_ATTENDEE { get; set; }
        public virtual CASH_BASH_EVENT CASH_BASH_EVENT { get; set; }
    }
}
