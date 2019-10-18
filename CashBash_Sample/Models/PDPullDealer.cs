using System;
using System.Collections.Generic;

namespace CashBash_Sample.Models
{
    public partial class PDPullDealer
    {
        public string ENTITY_NAME { get; set; }
        public string FWS_DLR_NB { get; set; }
        public int EVNT_ID { get; set; }
        public string DLR_NM { get; set; }
        public string ENROLLMENT_GROUP_ID { get; set; }
        public int TOTL_PNTS_QY { get; set; }
        public Nullable<int> PLLS_WON_QY { get; set; }
        public int TRPS_WON_QY { get; set; }
        public int TRPS_PRCH_QY { get; set; }
        public int BUY_UP_PERCENTAGE { get; set; }
        public int BUY_UP_QY { get; set; }
        public decimal PRCH_AMT { get; set; }
        public string TERR_NB { get; set; }
        public string AUTHORIZED_SIGNER_ID { get; set; }
        public string AUTHORIZED_SIGNER { get; set; }
        public string AUTHORIZED_SIGNER_EMAIL { get; set; }
        public int STATUS_ID { get; set; }
        public string STATUS { get; set; }
        public Nullable<int> PAYMENT_METHOD_ID { get; set; }
        public string PAYMENT_METHOD { get; set; }
        public string REP_ID { get; set; }
        public string REP_NAME { get; set; }
        public Nullable<int> PULL_GROUP_ID { get; set; }
        public Nullable<int> DINNER_ONLY_QY { get; set; }
        public Nullable<System.DateTime> LST_UPDT_TS { get; set; }
        public string LST_UPDT_USR_ID { get; set; }
        public Nullable<int> NOTE_ID { get; set; }
        public string PAYMENT_METHOD_NOTE { get; set; }
    }
}
