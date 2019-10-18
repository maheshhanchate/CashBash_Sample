using System;
using System.Collections.Generic;

namespace CashBash_Sample.Models
{
    public partial class CASH_BASH_PULL
    {
        public int ATNE_ID { get; set; }
        public string FWS_DLR_ID { get; set; }
        public string PULL_CTRL_ID { get; set; }
        public int EVNT_ID { get; set; }
        public Nullable<int> PULL_AM { get; set; }
        public Nullable<int> MSTR_ID { get; set; }
        public string MSTR_FWS_DLR_NB { get; set; }
        public Nullable<int> PULL_TYPE_CD { get; set; }
    
        public virtual CASH_BASH_DEALER_WINNER CASH_BASH_DEALER_WINNER { get; set; }
        public virtual CASH_BASH_DEALER_WINNER CASH_BASH_DEALER_WINNER1 { get; set; }
        public virtual CASH_BASH_PULL_VALIDATION CASH_BASH_PULL_VALIDATION { get; set; }
    }
}
