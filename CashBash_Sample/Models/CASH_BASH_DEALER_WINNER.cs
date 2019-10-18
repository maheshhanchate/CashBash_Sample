using System;
using System.Collections.Generic;

namespace CashBash_Sample.Models
{
   
    public partial class CASH_BASH_DEALER_WINNER
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CASH_BASH_DEALER_WINNER()
        {
            this.CASH_BASH_PULL = new HashSet<CASH_BASH_PULL>();
            this.CASH_BASH_PULL1 = new HashSet<CASH_BASH_PULL>();
        }
    
        public int ATNE_ID { get; set; }
        public int EVNT_ID { get; set; }
        public string FWS_DLR_NB { get; set; }
        public Nullable<short> PULL_QY { get; set; }
        public Nullable<byte> SPLT_PRGE_RT { get; set; }
        public Nullable<int> PULL_AM { get; set; }
        public string ABSE_IN { get; set; }
        public string MSTR_FWS_DLR_NB { get; set; }
        public int MSTR_WNR_ID { get; set; }
        public string PAY_OUT_RECVD_IN { get; set; }
        public string STAGE_CHK_IN { get; set; }
        public string DLR_REP_IN { get; set; }
        public System.DateTime LST_UPDT_TS { get; set; }
        public string LST_UPDT_USR_ID { get; set; }
        public string SEND_CHK_IN { get; set; }
        public string TAB_USR_ID { get; set; }
        public string CASH_USR_ID { get; set; }
        public Nullable<System.DateTime> TAB_UPDT_DT { get; set; }
        public Nullable<System.DateTime> CASH_UPDT_DT { get; set; }
        public string DISPLAY_DLR_NM { get; set; }
        public string PARTIAL_PAYMENT_IN { get; set; }
        public Nullable<int> CASH_AMOUNT { get; set; }
    
        public virtual CASH_BASH_DEALER CASH_BASH_DEALER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CASH_BASH_PULL> CASH_BASH_PULL { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CASH_BASH_PULL> CASH_BASH_PULL1 { get; set; }
    }
}
