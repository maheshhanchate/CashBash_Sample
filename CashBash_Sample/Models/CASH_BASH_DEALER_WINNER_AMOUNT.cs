using System;
using System.Collections.Generic;

namespace CashBash_Sample.Models
{

    public partial class CASH_BASH_DEALER_WINNER_AMOUNT
    {
        public int ATNE_ID { get; set; }
        public int EVNT_ID { get; set; }
        public string FWS_DLR_NB { get; set; }
        public int AM_TYPE_ID { get; set; }
        public Nullable<int> DLR_WNR_AM { get; set; }
        public string WNR_PAY_OUT_IN { get; set; }
        public string PULL_CTRL_ID { get; set; }
        public string TAB_USR_ID { get; set; }
        public string CASH_USR_ID { get; set; }
        public Nullable<System.DateTime> TAB_UPDT_DT { get; set; }
        public Nullable<System.DateTime> CASH_UPDT_DT { get; set; }
    }
}
