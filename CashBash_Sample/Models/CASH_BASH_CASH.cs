using System;
using System.Collections.Generic;


namespace CashBash_Sample.Models
{ 
    public partial class CASH_BASH_CASH
    {
        public string CSHR_TYP_CD { get; set; }
        public int EVNT_ID { get; set; }
        public string CHK_IN_USR_ID { get; set; }
        public Nullable<int> INTL_CSH_AM { get; set; }
    
        public virtual USER_IDENTIFIER USER_IDENTIFIER { get; set; }
        public virtual CASH_BASH_EVENT CASH_BASH_EVENT { get; set; }
    }
}
