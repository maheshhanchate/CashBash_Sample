using System;
using System.Collections.Generic;

namespace CashBash_Sample.Models
{
    public partial class CONTEST_RESULT
    {
        public string ENTITY_NAME { get; set; }
        public string FWS_DLR_NB { get; set; }
        public int EVNT_ID { get; set; }
        public string GROUP_ID { get; set; }
        public int TOTL_PNTS_QY { get; set; }
        public int PLLS_WON_QY { get; set; }
        public int TRPS_WON_QY { get; set; }
        public int BUY_UP_PERCENTAGE { get; set; }
        public string ENTITY_TYPE { get; set; }
        public Nullable<int> TRPS2_WON_QY { get; set; }
    }
}
