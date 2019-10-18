using System;
using System.Collections.Generic;

namespace CashBash_Sample.Models
{
    public partial class TRAVEL_PREFERENCES
    {
        public int ATNE_ID { get; set; }
        public int TRVL_PRFC_ID { get; set; }
        public int EVNT_ID { get; set; }
        public string ATNE_TYP_CD { get; set; }
    
        public virtual CASH_BASH_ATTENDEE CASH_BASH_ATTENDEE { get; set; }
        public virtual CASH_BASH_EVENT CASH_BASH_EVENT { get; set; }
    }
}
