using System;
using System.Collections.Generic;


namespace CashBash_Sample.Models
{ 
    public partial class CASH_BASH_ATTENDEE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CASH_BASH_ATTENDEE()
        {
            this.ATTENDEE_NOTE = new HashSet<ATTENDEE_NOTE>();
            this.CASH_BASH_GUEST = new HashSet<CASH_BASH_GUEST>();
            this.CASH_BASH_STAFF = new HashSet<CASH_BASH_STAFF>();
            this.CASH_BASH_EVENT_WINNER = new HashSet<CASH_BASH_EVENT_WINNER>();
            this.CASH_BASH_GUEST1 = new HashSet<CASH_BASH_GUEST>();
            this.TRAVELs = new HashSet<TRAVEL>();
            this.TRAVEL_PREFERENCES = new HashSet<TRAVEL_PREFERENCES>();
        }
    
        public int ATNE_ID { get; set; }
        public string ATNE_TYP_CD { get; set; }
        public string FRST_NM { get; set; }
        public string LST_NM { get; set; }
        public Nullable<int> TITL_CD { get; set; }
        public string HM_PHN_NB { get; set; }
        public string EMRY_CNTC_NM { get; set; }
        public string EMRY_PHN_NB { get; set; }
        public string ATNE_SSN_NB { get; set; }
        public Nullable<System.DateTime> INCE_DT { get; set; }
        public string CHK_IN_IN { get; set; }
        public string TXBL_IN { get; set; }
        public int EVNT_ID { get; set; }
        public string ATNE_XREF_ID { get; set; }
        public System.DateTime LST_UPDT_TS { get; set; }
        public string LST_UPDT_USR_ID { get; set; }
        public string MID_INIT { get; set; }
        public string LAWSON_VENDOR_ID { get; set; }
        public string DISPLAY_DLR_ID { get; set; }
        public string EMAIL { get; set; }
        public Nullable<int> STATUS { get; set; }
        public string DINNER_ONLY_IN { get; set; }
        public string ABSENTEE { get; set; }
        public Nullable<int> TRIP_NB { get; set; }
        public string SWITCHTRIP { get; set; }
    
        public virtual ATTENDEE_ADDRESS ATTENDEE_ADDRESS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ATTENDEE_NOTE> ATTENDEE_NOTE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CASH_BASH_GUEST> CASH_BASH_GUEST { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CASH_BASH_STAFF> CASH_BASH_STAFF { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CASH_BASH_EVENT_WINNER> CASH_BASH_EVENT_WINNER { get; set; }
        public virtual CASH_BASH_EVENT CASH_BASH_EVENT { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CASH_BASH_GUEST> CASH_BASH_GUEST1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TRAVEL> TRAVELs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TRAVEL_PREFERENCES> TRAVEL_PREFERENCES { get; set; }
    }
}
