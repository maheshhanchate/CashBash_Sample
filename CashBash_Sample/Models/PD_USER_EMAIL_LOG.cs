using System;
using System.Collections.Generic;

namespace CashBash_Sample.Models
{
    public partial class PD_USER_EMAIL_LOG
    {
        public int ROW_ID { get; set; }
        public int EVNT_ID { get; set; }
        public string USER_ID { get; set; }
        public string FWS_DLR_NB { get; set; }
        public string LOG_TYPE { get; set; }
        public string FROM { get; set; }
        public string TO { get; set; }
        public string CC { get; set; }
        public string SUBJECT { get; set; }
        public string MESSAGE { get; set; }
        public System.DateTime LOG_DT { get; set; }
    
        public virtual CASH_BASH_DEALER CASH_BASH_DEALER { get; set; }
    }
}
