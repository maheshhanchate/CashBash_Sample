using System;
using System.Collections.Generic;

namespace CashBash_Sample.Models
{ 
    public partial class CASH_BASH_DEALER
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CASH_BASH_DEALER()
        {
            this.CASH_BASH_DEALER_WINNER = new HashSet<CASH_BASH_DEALER_WINNER>();
            this.CASH_BASH_DEALER_WINNER_AUDIT = new HashSet<CASH_BASH_DEALER_WINNER_AUDIT>();
            this.PD_USER_EMAIL_LOG = new HashSet<PD_USER_EMAIL_LOG>();
            this.CASH_BASH_DEALER_WINNER_AUDIT1 = new HashSet<CASH_BASH_DEALER_WINNER_AUDIT>();
            this.PD_CASH_BASH_DEALER_WINNER = new HashSet<PD_CASH_BASH_DEALER_WINNER>();
            this.CASH_BASH_GUEST = new HashSet<CASH_BASH_GUEST>();
            this.PD_CASH_BASH_DEALER_WINNER_AUDIT = new HashSet<PD_CASH_BASH_DEALER_WINNER_AUDIT>();
            this.PD_CASH_BASH_DEALER_WINNER_AUDIT1 = new HashSet<PD_CASH_BASH_DEALER_WINNER_AUDIT>();
            this.CONTEST_ENTITY = new HashSet<CONTEST_ENTITY>();
        }
    
        public string FWS_DLR_NB { get; set; }
        public string DLR_NM { get; set; }
        public string DLR_STR_ADDR_TX { get; set; }
        public string DLR_CITY_NM { get; set; }
        public string DLR_ST_CD { get; set; }
        public string DLR_ZIP_CD { get; set; }
        public string DLR_PHN_NB { get; set; }
        public string DLR_FAX_NB { get; set; }
        public string TERR_ZONE_NB { get; set; }
        public string TERR_DIV_NB { get; set; }
        public string TERR_RGN_NB { get; set; }
        public string TERR_DSTT_NB { get; set; }
        public string FLD_REP_NM { get; set; }
        public string LAWSON_VENDOR_ID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CASH_BASH_DEALER_WINNER> CASH_BASH_DEALER_WINNER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CASH_BASH_DEALER_WINNER_AUDIT> CASH_BASH_DEALER_WINNER_AUDIT { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PD_USER_EMAIL_LOG> PD_USER_EMAIL_LOG { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CASH_BASH_DEALER_WINNER_AUDIT> CASH_BASH_DEALER_WINNER_AUDIT1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PD_CASH_BASH_DEALER_WINNER> PD_CASH_BASH_DEALER_WINNER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CASH_BASH_GUEST> CASH_BASH_GUEST { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PD_CASH_BASH_DEALER_WINNER_AUDIT> PD_CASH_BASH_DEALER_WINNER_AUDIT { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PD_CASH_BASH_DEALER_WINNER_AUDIT> PD_CASH_BASH_DEALER_WINNER_AUDIT1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CONTEST_ENTITY> CONTEST_ENTITY { get; set; }
    }
}
