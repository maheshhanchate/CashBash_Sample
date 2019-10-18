using System;
using System.Collections.Generic;

namespace CashBash_Sample.Models
{
    public partial class TRAVEL
    {
        public int ATNE_ID { get; set; }
        public int EVNT_ID { get; set; }
        public string ATNE_TYP_CD { get; set; }
        public string PRFD_ARPT_NM { get; set; }
        public Nullable<short> LND_COST_AM { get; set; }
        public Nullable<short> AIR_CST_AM { get; set; }
        public Nullable<System.DateTime> ARVL_DT { get; set; }
        public Nullable<System.DateTime> DPRE_DT { get; set; }
        public Nullable<short> CSH_ALWC_AM { get; set; }
        public string VIP_IN { get; set; }
        public Nullable<short> MISC_CSH_AM { get; set; }
        public Nullable<short> GME_WNGS_AM { get; set; }
        public string CHK_IN_USR_ID { get; set; }
        public string MDCL_RSTS_IN { get; set; }
        public string LST_UPDT_USR_ID { get; set; }
        public Nullable<System.DateTime> LST_UPDT_DT { get; set; }
        public string LAND_BUY_IN_TYP_CD { get; set; }
        public string AIR_BUY_IN_TYPE_CD { get; set; }
        public string CASH_ALWC_TYPE_CD { get; set; }
        public string MISC_BUY_IN_CD { get; set; }
        public Nullable<short> OTHR_COST_AM { get; set; }
        public string OTHR_COST_TYPE_CD { get; set; }
    
        public virtual BUY_IN_TYPE BUY_IN_TYPE { get; set; }
        public virtual BUY_IN_TYPE BUY_IN_TYPE1 { get; set; }
        public virtual BUY_IN_TYPE BUY_IN_TYPE2 { get; set; }
        public virtual BUY_IN_TYPE BUY_IN_TYPE3 { get; set; }
        public virtual CASH_BASH_ATTENDEE CASH_BASH_ATTENDEE { get; set; }
        public virtual CASH_BASH_EVENT CASH_BASH_EVENT { get; set; }
        public virtual USER_IDENTIFIER USER_IDENTIFIER { get; set; }
    }
}
