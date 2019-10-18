using System;
using System.Collections.Generic;

namespace CashBash_Sample.Models
{
    public partial class DEALER_PULL_PURCHASE_ITEM
    {
        public string FWS_ID_NB { get; set; }
        public int EVNT_ID { get; set; }
        public int PULL_PURS_ID { get; set; }
        public Nullable<short> PURS_QY { get; set; }
    
        public virtual PULL_PURCHASE_CODE PULL_PURCHASE_CODE { get; set; }
    }
}
