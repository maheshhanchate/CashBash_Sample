using System;
using System.Collections.Generic;

namespace CashBash_Sample.Models
{
    public partial class CASH_BASH_TITLE_CD
    {
        public int ATNE_TITLE_CD { get; set; }
        public string ATNE_TITLE_DESC { get; set; }
        public int EVNT_ID { get; set; }
    
        public virtual CASH_BASH_EVENT CASH_BASH_EVENT { get; set; }
    }
}
