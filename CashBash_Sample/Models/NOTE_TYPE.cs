using System;
using System.Collections.Generic;

namespace CashBash_Sample.Models
{
    public partial class NOTE_TYPE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NOTE_TYPE()
        {
            this.ATTENDEE_NOTE = new HashSet<ATTENDEE_NOTE>();
        }
    
        public int ID { get; set; }
        public string NAME { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ATTENDEE_NOTE> ATTENDEE_NOTE { get; set; }
    }
}
