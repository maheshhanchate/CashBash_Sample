using System;
using System.Collections.Generic;

namespace CashBash_Sample.Models
{
    public partial class CONTEST_ENTITY
    {
        public string ENTITY_NAME { get; set; }
        public string FWS_DLR_NB { get; set; }
        public int EVNT_ID { get; set; }
        public string ENROLLMENT_GROUP_ID { get; set; }
        public Nullable<int> PULL_GROUP_ID { get; set; }
        public int TOTL_PNTS_QY { get; set; }
        public int PLLS_WON_QY { get; set; }
        public int TRPS_WON_QY { get; set; }
        public int TRPS_PRCH_QY { get; set; }
        public int BUY_UP_PERCENTAGE { get; set; }
        public int BUY_UP_QY { get; set; }
        public decimal PRCH_AMT { get; set; }
        public string TERR_NB { get; set; }
        public string AUTHORIZED_SIGNER_ID { get; set; }
        public int STATUS_ID { get; set; }
        public Nullable<int> PAYMENT_METHOD_ID { get; set; }
        public Nullable<int> DINNER_ONLY_QY { get; set; }
        public Nullable<System.DateTime> LST_UPDT_TS { get; set; }
        public string LST_UPDT_USR_ID { get; set; }
        public string PAYMENT_METHOD_NOTE { get; set; }
        public int PULL_ASSIGNMENT_TYPE { get; set; }
        public Nullable<int> OWNER_CD { get; set; }
        public string REJECT_NOTE { get; set; }
        public Nullable<System.DateTime> APPROVED_REJECTED_AT { get; set; }
        public Nullable<int> TRPS2_WON_QY { get; set; }
        public Nullable<int> TRPS2_PRCH_QY { get; set; }
    
        public virtual CASH_BASH_DEALER CASH_BASH_DEALER { get; set; }
        public virtual ENROLLMENT_GROUP ENROLLMENT_GROUP { get; set; }
        public virtual ENTITY_STATUS ENTITY_STATUS { get; set; }
        public virtual PAYMENT_METHOD PAYMENT_METHOD { get; set; }
        public virtual PULL_GROUP PULL_GROUP { get; set; }
    }
}
