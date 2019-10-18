using System;
using System.Collections.Generic;

namespace CashBash_Sample.Models
{
    public partial class CASH_BASH_EVENT
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CASH_BASH_EVENT()
        {
            this.ATTENDEE_NOTE = new HashSet<ATTENDEE_NOTE>();
            this.ATTENDEE_TAX_REPORT = new HashSet<ATTENDEE_TAX_REPORT>();
            this.ATTENDEE_TAX_REPORT_DETAILS = new HashSet<ATTENDEE_TAX_REPORT_DETAILS>();
            this.CASH_BASH_ATTENDEE = new HashSet<CASH_BASH_ATTENDEE>();
            this.CASH_BASH_CASH = new HashSet<CASH_BASH_CASH>();
            this.CASH_BASH_DEALER_NOTES = new HashSet<CASH_BASH_DEALER_NOTES>();
            this.CASH_BASH_STAFF = new HashSet<CASH_BASH_STAFF>();
            this.CASH_BASH_ATTENDEE_AUDIT = new HashSet<CASH_BASH_ATTENDEE_AUDIT>();
            this.CASH_BASH_TITLE_CD = new HashSet<CASH_BASH_TITLE_CD>();
            this.PD_CONTROL = new HashSet<PD_CONTROL>();
            this.CHECK_PAYMENT_DETAILS = new HashSet<CHECK_PAYMENT_DETAILS>();
            this.CHECK_PAYMENTS = new HashSet<CHECK_PAYMENTS>();
            this.PULL_GROUP = new HashSet<PULL_GROUP>();
            this.CASH_BASH_EVENT_WINNER = new HashSet<CASH_BASH_EVENT_WINNER>();
            this.TRAVELs = new HashSet<TRAVEL>();
            this.TRAVEL_PREFERENCES = new HashSet<TRAVEL_PREFERENCES>();
            this.USER_SECURITY = new HashSet<USER_SECURITY>();
        }
    
        public int EVNT_ID { get; set; }
        public System.DateTime EVNT_DT { get; set; }
        public string EVNT_NM { get; set; }
        public string END_EVNT_RGSN_IN { get; set; }
        public Nullable<short> CSH_ALWC_DFLT_AM { get; set; }
        public string MAIN_EVNT_BGN_IN { get; set; }
        public string MAIN_EVNT_END_IN { get; set; }
        public Nullable<short> MISC_CSH_DFLT_AM { get; set; }
        public decimal LND_COST_DFLT_AM { get; set; }
        public Nullable<System.DateTime> DFLT_ARVL_DT { get; set; }
        public Nullable<System.DateTime> DFLT_DPRE_DT { get; set; }
        public int TOTL_EVNT_PULL_QTY { get; set; }
        public Nullable<short> MIN_WNR_AM { get; set; }
        public Nullable<short> MIN_PULL_AM { get; set; }
        public bool Active { get; set; }
        public Nullable<int> CONTEST_ENROLLMENT_ID { get; set; }
        public int PERCENTAGE_FOR_BUY_UP { get; set; }
        public Nullable<int> TRIP_POINTS { get; set; }
        public decimal LND_COST_DFLT_AM_DINNER_ONLY { get; set; }
        public string CONTEST_TYPE { get; set; }
        public string DESTINATION1 { get; set; }
        public string DESTINATION2 { get; set; }
        public Nullable<System.DateTime> REGISTRATION_DEADLINE { get; set; }
        public Nullable<bool> ALLOW_TRIP_REQUEST { get; set; }
        public Nullable<bool> ALLOW_BUYUP { get; set; }
        public Nullable<decimal> DESTINATION1_COST { get; set; }
        public Nullable<decimal> DESTINATION2_COST { get; set; }
    
        public virtual ACCOUNTING_DETAILS ACCOUNTING_DETAILS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ATTENDEE_NOTE> ATTENDEE_NOTE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ATTENDEE_TAX_REPORT> ATTENDEE_TAX_REPORT { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ATTENDEE_TAX_REPORT_DETAILS> ATTENDEE_TAX_REPORT_DETAILS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CASH_BASH_ATTENDEE> CASH_BASH_ATTENDEE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CASH_BASH_CASH> CASH_BASH_CASH { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CASH_BASH_DEALER_NOTES> CASH_BASH_DEALER_NOTES { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CASH_BASH_STAFF> CASH_BASH_STAFF { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CASH_BASH_ATTENDEE_AUDIT> CASH_BASH_ATTENDEE_AUDIT { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CASH_BASH_TITLE_CD> CASH_BASH_TITLE_CD { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PD_CONTROL> PD_CONTROL { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHECK_PAYMENT_DETAILS> CHECK_PAYMENT_DETAILS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHECK_PAYMENTS> CHECK_PAYMENTS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PULL_GROUP> PULL_GROUP { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CASH_BASH_EVENT_WINNER> CASH_BASH_EVENT_WINNER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TRAVEL> TRAVELs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TRAVEL_PREFERENCES> TRAVEL_PREFERENCES { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<USER_SECURITY> USER_SECURITY { get; set; }
    }
}
