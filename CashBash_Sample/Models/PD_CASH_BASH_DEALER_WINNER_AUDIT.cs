using System;
using System.Collections.Generic;

namespace CashBash_Sample.Models
{
    public partial class PD_CASH_BASH_DEALER_WINNER_AUDIT
    {
        public int ATNE_ID { get; set; }
        public int EVNT_ID { get; set; }
        public string FWS_DLR_NB { get; set; }
        public Nullable<byte> PULL_QY { get; set; }
        public Nullable<byte> SPLT_PRGE_RT { get; set; }
        public Nullable<int> PULL_AM { get; set; }
        public string ABSE_IN { get; set; }
        public string MSTR_FWS_DLR_NB { get; set; }
        public Nullable<int> MSTR_WNR_ID { get; set; }
        public string PAY_OUT_RECVD_IN { get; set; }
        public string STAGE_CHK_IN { get; set; }
        public string DLR_REP_IN { get; set; }
        public System.DateTime LST_UPDT_TS { get; set; }
        public string LST_UPDT_USR_ID { get; set; }
        public string UID_IN { get; set; }
    
        public virtual CASH_BASH_DEALER CASH_BASH_DEALER { get; set; }
        public virtual CASH_BASH_DEALER CASH_BASH_DEALER1 { get; set; }
    }
}
