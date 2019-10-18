using System;
using System.Collections.Generic;

namespace CashBash_Sample.Models
{ 
    public partial class ATTENDEE_NOTE
    {
        public int ATNE_ID { get; set; }
        public int EVNT_ID { get; set; }
        public System.DateTime LST_UPDT_TS { get; set; }
        public string LST_UPDT_USR_ID { get; set; }
        public string NT_CMNT_TX { get; set; }
        public string DVTN_IN { get; set; }
        public int NOTE_TYPE_ID { get; set; }
    
        public virtual CASH_BASH_ATTENDEE CASH_BASH_ATTENDEE { get; set; }
        public virtual NOTE_TYPE NOTE_TYPE { get; set; }
        public virtual CASH_BASH_EVENT CASH_BASH_EVENT { get; set; }
    }
}
