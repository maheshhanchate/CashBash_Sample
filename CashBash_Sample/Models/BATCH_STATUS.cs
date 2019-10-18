using System;
using System.Collections.Generic;

namespace CashBash_Sample.Models
{
   
    public partial class BATCH_STATUS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BATCH_STATUS()
        {
            this.ATTENDEE_TAX_REPORT = new HashSet<ATTENDEE_TAX_REPORT>();
        }
    
        public int ID { get; set; }
        public string NAME { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ATTENDEE_TAX_REPORT> ATTENDEE_TAX_REPORT { get; set; }
    }
}
