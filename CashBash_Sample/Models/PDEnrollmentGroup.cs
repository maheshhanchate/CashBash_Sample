using System;
using System.Collections.Generic;

namespace CashBash_Sample.Models
{
    public partial class PDEnrollmentGroup
    {
        public string GROUP_ID { get; set; }
        public int EVNT_ID { get; set; }
        public string GROUP_NAME { get; set; }
        public int TRPS_WON_QY { get; set; }
        public Nullable<int> TRPS2_WON_QY { get; set; }
        public int TOTL_PNTS_QY { get; set; }
        public int TRPS_PRCH_QY { get; set; }
        public Nullable<int> TRPS2_PRCH_QY { get; set; }
        public int BUY_UP_PERCENTAGE { get; set; }
        public int BUY_UP_QY { get; set; }
        public decimal PRCH_AMT { get; set; }
        public int STATUS_ID { get; set; }
        public string STATUS { get; set; }
        public Nullable<int> PAYMENT_METHOD_ID { get; set; }
        public string PAYMENT_METHOD { get; set; }
        public Nullable<int> DINNER_ONLY_QY { get; set; }
        public Nullable<System.DateTime> LST_UPDT_TS { get; set; }
        public string LST_UPDT_USR_ID { get; set; }
    }
}
