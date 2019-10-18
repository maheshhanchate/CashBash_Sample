using System;
using System.Collections.Generic;

namespace CashBash_Sample.Models
{ 
    public partial class ATTENDEE_TAX_REPORT
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ATTENDEE_TAX_REPORT()
        {
            this.ATTENDEE_TAX_REPORT_DETAILS = new HashSet<ATTENDEE_TAX_REPORT_DETAILS>();
        }
    
        public int ID { get; set; }
        public int EVENT_ID { get; set; }
        public string USER_ID { get; set; }
        public System.DateTime CREATED_AT { get; set; }
        public int BATCH_STATUS_ID { get; set; }
        public System.DateTime BATCH_STATUS_UPDATED_AT { get; set; }
    
        public virtual BATCH_STATUS BATCH_STATUS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ATTENDEE_TAX_REPORT_DETAILS> ATTENDEE_TAX_REPORT_DETAILS { get; set; }
        public virtual CASH_BASH_EVENT CASH_BASH_EVENT { get; set; }
    }
}
