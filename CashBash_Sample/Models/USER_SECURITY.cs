using System;
using System.Collections.Generic;

namespace CashBash_Sample.Models
{
    public partial class USER_SECURITY
    {
        public string USR_ID { get; set; }
        public int EVNT_ID { get; set; }
        public string ACCS_LVL_CD { get; set; }
        public string ROLE_CD { get; set; }
        public Nullable<System.DateTime> LST_UPDT_DT { get; set; }
        public string LST_UPDT_USR_ID { get; set; }
    
        //public virtual CASH_BASH_EVENT CASH_BASH_EVENT { get; set; }
       // public virtual USER_IDENTIFIER USER_IDENTIFIER { get; set; }
    }
}
